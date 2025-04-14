import sys 
import re
import gc
from abc import ABC, abstractmethod

class HTMLElement(ABC):
    @abstractmethod
    def render(self) -> str:
        pass

class H1Element(HTMLElement):
    def __init__(self, content):
        self.content = content
    
    def render(self) -> str:
        return f"<h1>{self.content}</h1>"

class H2Element(HTMLElement):
    def __init__(self, content):
        self.content = content
    
    def render(self) -> str:
        return f"<h2>{self.content}</h2>"

class ParagraphElement(HTMLElement):
    def __init__(self, content):
        self.content = content
    
    def render(self) -> str:
        return f"<p>{self.content}</p>"

class BlockquoteElement(HTMLElement):
    def __init__(self, content):
        self.content = content
    
    def render(self) -> str:
        return f"<blockquote>{self.content}</blockquote>"

class HTMLDocument:
    def __init__(self):
        self.elements = []
    
    def add_element(self, element):
        self.elements.append(element)
    
    def render(self) -> str:
        return "\n".join([element.render() for element in self.elements])

def process_file_without_flyweight(file_path):
    document = HTMLDocument()
    is_first_line = True
    
    with open(file_path, 'r', encoding='utf-8') as file:
        for line in file:
            line = line.rstrip('\n')
            if not line:
                continue
                
            if is_first_line:
                document.add_element(H1Element(line))
                is_first_line = False
            elif len(line) < 20:
                document.add_element(H2Element(line))
            elif line.startswith(' ') or line.startswith('\t'):
                document.add_element(BlockquoteElement(line.lstrip()))
            else:
                document.add_element(ParagraphElement(line))
    
    return document

class HTMLElementFlyweightFactory:
    def __init__(self):
        self._element_types = {}
    
    def get_element_type(self, element_type):
        if element_type not in self._element_types:
            if element_type == "h1":
                self._element_types[element_type] = FlyweightH1Element()
            elif element_type == "h2":
                self._element_types[element_type] = FlyweightH2Element()
            elif element_type == "p":
                self._element_types[element_type] = FlyweightPElement()
            elif element_type == "blockquote":
                self._element_types[element_type] = FlyweightBlockquoteElement()
                
        return self._element_types[element_type]

class FlyweightHTMLElement(ABC):
    @abstractmethod
    def render(self, content) -> str:
        pass

class FlyweightH1Element(FlyweightHTMLElement):
    def render(self, content) -> str:
        return f"<h1>{content}</h1>"

class FlyweightH2Element(FlyweightHTMLElement):
    def render(self, content) -> str:
        return f"<h2>{content}</h2>"

class FlyweightPElement(FlyweightHTMLElement):
    def render(self, content) -> str:
        return f"<p>{content}</p>"

class FlyweightBlockquoteElement(FlyweightHTMLElement):
    def render(self, content) -> str:
        return f"<blockquote>{content}</blockquote>"

class FlyweightHTMLDocument:
    def __init__(self, factory):
        self.factory = factory
        self.elements = []
    
    def add_element(self, element_type, content):
        self.elements.append((element_type, content))
    
    def render(self) -> str:
        result = []
        for element_type, content in self.elements:
            element = self.factory.get_element_type(element_type)
            result.append(element.render(content))
        return "\n".join(result)

def process_file_with_flyweight(file_path):
    factory = HTMLElementFlyweightFactory()
    document = FlyweightHTMLDocument(factory)
    is_first_line = True
    
    with open(file_path, 'r', encoding='utf-8') as file:
        for line in file:
            line = line.rstrip('\n')
            if not line:
                continue
                
            if is_first_line:
                document.add_element("h1", line)
                is_first_line = False
            elif len(line) < 20:
                document.add_element("h2", line)
            elif line.startswith(' ') or line.startswith('\t'):
                document.add_element("blockquote", line.lstrip())
            else:
                document.add_element("p", line)
    
    return document

def get_size(obj, seen=None):
    size = sys.getsizeof(obj)
    if seen is None:
        seen = set()
    obj_id = id(obj)
    if obj_id in seen:
        return 0
    seen.add(obj_id)
    if isinstance(obj, dict):
        size += sum([get_size(k, seen) + get_size(v, seen) for k, v in obj.items()])
    elif hasattr(obj, '__dict__'):
        size += get_size(obj.__dict__, seen)
    elif hasattr(obj, '__iter__') and not isinstance(obj, (str, bytes, bytearray)):
        size += sum([get_size(i, seen) for i in obj])
    return size

def main():
    file_path = "pg1513.txt"
    print("Processing without Flyweight pattern...")
    gc.collect()
    document = process_file_without_flyweight(file_path)
    regular_size = get_size(document)
    print(f"Memory used by regular implementation: {regular_size} bytes")
    rendered = document.render()
    print(f"Sample of rendered HTML (first 100 chars):\n{rendered[:100]}...")
    print("\nProcessing with Flyweight pattern...")
    gc.collect()
    flyweight_document = process_file_with_flyweight(file_path)
    flyweight_size = get_size(flyweight_document)
    print(f"Memory used by flyweight implementation: {flyweight_size} bytes")
    flyweight_rendered = flyweight_document.render()
    print(f"Sample of rendered HTML (first 100 chars):\n{flyweight_rendered[:100]}...")
    memory_saved = regular_size - flyweight_size
    percent_saved = (memory_saved / regular_size) * 100 if regular_size > 0 else 0
    print(f"\nMemory saved: {memory_saved} bytes ({percent_saved:.2f}%)")
    print(f"\nBoth implementations produce identical output: {rendered == flyweight_rendered}")
    element_counts = {"h1": 0, "h2": 0, "p": 0, "blockquote": 0}
    for element_type, _ in flyweight_document.elements:
        element_counts[element_type] += 1
    print("\nElement counts:")
    for element_type, count in element_counts.items():
        print(f"  {element_type}: {count}")

if __name__ == "__main__":
    main()
