using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            LightElementNode article = new LightElementNode("article", DisplayType.Block, ClosingType.WithClosingTag);
            article.AddClass("blog-post");

            LightElementNode header = new LightElementNode("header", DisplayType.Block, ClosingType.WithClosingTag);
            header.AddClass("post-header");

            LightElementNode h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.WithClosingTag);
            h1.AddClass("post-title");
            h1.AddChild(new LightTextNode("Using the Composite Pattern in C#"));
            header.AddChild(h1);

            LightElementNode metaDiv = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
            metaDiv.AddClass("post-meta");

            LightElementNode authorSpan = new LightElementNode("span", DisplayType.Inline, ClosingType.WithClosingTag);
            authorSpan.AddClass("author");
            authorSpan.AddChild(new LightTextNode("Posted by: John Doe"));
            metaDiv.AddChild(authorSpan);

            LightElementNode dateSpan = new LightElementNode("span", DisplayType.Inline, ClosingType.WithClosingTag);
            dateSpan.AddClass("date");
            dateSpan.AddChild(new LightTextNode(" | April 14, 2025"));
            metaDiv.AddChild(dateSpan);

            header.AddChild(metaDiv);
            article.AddChild(header);

            LightElementNode content = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
            content.AddClass("post-content");

            LightElementNode p1 = new LightElementNode("p", DisplayType.Block, ClosingType.WithClosingTag);
            p1.AddChild(new LightTextNode("The Composite pattern is an essential structural design pattern that helps you create hierarchical tree structures where both individual objects and compositions of objects are treated uniformly."));
            content.AddChild(p1);

            LightElementNode p2 = new LightElementNode("p", DisplayType.Block, ClosingType.WithClosingTag);
            p2.AddChild(new LightTextNode("In this blog post, we'll explore how to implement it in C#."));
            content.AddChild(p2);

            LightElementNode h2 = new LightElementNode("h2", DisplayType.Block, ClosingType.WithClosingTag);
            h2.AddChild(new LightTextNode("Key Benefits:"));
            content.AddChild(h2);

            LightElementNode ul = new LightElementNode("ul", DisplayType.Block, ClosingType.WithClosingTag);
            ul.AddClass("benefits-list");

            string[] benefits = {
                "Simplifies client interaction with complex structures",
                "Makes adding new component types easy",
                "Creates structures that follow the principle of recursion",
                "Perfect for representing hierarchies like UI components, file systems, and more"
            };

            foreach (string benefit in benefits)
            {
                LightElementNode li = new LightElementNode("li", DisplayType.Block, ClosingType.WithClosingTag);
                li.AddChild(new LightTextNode(benefit));
                ul.AddChild(li);
            }

            content.AddChild(ul);

            LightElementNode figure = new LightElementNode("figure", DisplayType.Block, ClosingType.WithClosingTag);
            figure.AddClass("post-image");

            LightElementNode img = new LightElementNode("img", DisplayType.Inline, ClosingType.SelfClosing);
            img.AddClass("responsive-img");
            figure.AddChild(img);

            LightElementNode figcaption = new LightElementNode("figcaption", DisplayType.Block, ClosingType.WithClosingTag);
            figcaption.AddChild(new LightTextNode("Composite pattern UML diagram"));
            figure.AddChild(figcaption);

            content.AddChild(figure);

            article.AddChild(content);

            LightElementNode footer = new LightElementNode("footer", DisplayType.Block, ClosingType.WithClosingTag);
            footer.AddClass("post-footer");

            LightElementNode tagsDiv = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
            tagsDiv.AddClass("tags");

            LightElementNode tagSpan1 = new LightElementNode("span", DisplayType.Inline, ClosingType.WithClosingTag);
            tagSpan1.AddClass("tag");
            tagSpan1.AddChild(new LightTextNode("Design Patterns"));
            tagsDiv.AddChild(tagSpan1);

            LightElementNode tagSpan2 = new LightElementNode("span", DisplayType.Inline, ClosingType.WithClosingTag);
            tagSpan2.AddClass("tag");
            tagSpan2.AddChild(new LightTextNode("C#"));
            tagsDiv.AddChild(tagSpan2);

            LightElementNode tagSpan3 = new LightElementNode("span", DisplayType.Inline, ClosingType.WithClosingTag);
            tagSpan3.AddClass("tag");
            tagSpan3.AddChild(new LightTextNode("Programming"));
            tagsDiv.AddChild(tagSpan3);

            footer.AddChild(tagsDiv);
            article.AddChild(footer);

            Console.WriteLine("=== Complete Blog Post (OuterHTML) ===");
            Console.WriteLine(article.OuterHTML);

            Console.WriteLine("\n=== Just the Content Section (InnerHTML) ===");
            Console.WriteLine(content.InnerHTML);

            Console.WriteLine("\n=== Child Count Statistics ===");
            Console.WriteLine($"Article has {article.ChildCount} direct children");
            Console.WriteLine($"Content section has {content.ChildCount} direct children");
            Console.WriteLine($"Benefits list has {ul.ChildCount} direct children");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}