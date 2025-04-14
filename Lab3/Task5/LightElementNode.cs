using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private DisplayType _displayType;
        private ClosingType _closingType;
        private List<string> _cssClasses;
        private List<LightNode> _children;

        public LightElementNode(string tagName, DisplayType displayType, ClosingType closingType)
        {
            _tagName = tagName;
            _displayType = displayType;
            _closingType = closingType;
            _cssClasses = new List<string>();
            _children = new List<LightNode>();
        }

        public string TagName
        {
            get { return _tagName; }
        }

        public DisplayType DisplayType
        {
            get { return _displayType; }
        }

        public ClosingType ClosingType
        {
            get { return _closingType; }
        }

        public int ChildCount
        {
            get { return _children.Count; }
        }

        public void AddClass(string cssClass)
        {
            if (!_cssClasses.Contains(cssClass))
            {
                _cssClasses.Add(cssClass);
            }
        }

        public void RemoveClass(string cssClass)
        {
            _cssClasses.Remove(cssClass);
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
        }

        public void RemoveChild(LightNode child)
        {
            _children.Remove(child);
        }

        public string InnerHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (LightNode child in _children)
                {
                    sb.Append(child.Render());
                }
                return sb.ToString();
            }
        }

        public string OuterHTML
        {
            get { return Render(); }
        }

        public override string Render()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<");
            sb.Append(_tagName);

            if (_cssClasses.Count > 0)
            {
                sb.Append(" class=\"");
                sb.Append(string.Join(" ", _cssClasses));
                sb.Append("\"");
            }

            if (_closingType == ClosingType.SelfClosing)
            {
                sb.Append(" />");
                return sb.ToString();
            }
            else
            {
                sb.Append(">");

                foreach (LightNode child in _children)
                {
                    sb.Append(child.Render());
                }

                sb.Append("</");
                sb.Append(_tagName);
                sb.Append(">");

                return sb.ToString();
            }
        }
    }

}
