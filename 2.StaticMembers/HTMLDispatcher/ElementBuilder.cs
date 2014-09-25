using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ElementBuilder
{
    private string elementName;
    private string content = "";
    private string finalAttribute = "";
    private string createdElement;
    private string[] tags = {"a", "abbr", "acronym", "address", "applet", "area", "b", "base", "basefont",
                    "bdo", "bgsound", "big", "blockquote", "blink", "body", "br", "button,", "caption", "center", "cite", "code",
                    "col", "colgroup", "dd", "dfn", "del", "dir", "dl", "div", "dt", "embed", "em", "fieldset", "font", "form",
                    "frame", "frameset", "h1", "h2", "h3", "h4", "h5", "h6", "head", "hr", "html", "iframe", "img", "input",
                    "ins", "isindex", "i", "kbd", "label", "legend", "li", "link", "marquee", "menu", "meta", "noframe",
                    "noscript", "optgroup", "option", "ol", "p", "pre", "q", "s", "samp", "script", "select", "small", "span", "strike",
                    "strong", "style", "sub", "sup", "table", "td", "th", "tr", "tbody", "textarea", "tfoot", "thead", "title",
                    "tt", "u", "ul", "var"};
    private string[] selfClosingTags = {"area", "base", "br", "col", "command", "embed", "hr", "img", "input", "keygen", "link", "meta", "param", "source", "track", "wbr"};

    public ElementBuilder(string element)
    {
        this.ElementName = element;
        createElement();
    }


    public string ElementName
    {
        get { return this.elementName; } 
        set
        {
            if(this.tags.Contains(value))
            {
                this.elementName = value;
            }
            else
            {
                throw new ArgumentException("The tag you are trying to create is not a valid one!!!");
            }
        }
    }

    public static ElementBuilder operator *(ElementBuilder element, int times)
    {
        string result = "";
        for (int i = 0; i < times; i++)
        {
            result += element.createdElement;
        }
        element.createdElement = result;
        return element;
    }

    private void createElement()
    {
        if (this.selfClosingTags.Contains(this.elementName))
        {
            this.createdElement = "<" + this.elementName + finalAttribute + "/>";
        }
        else
        {
            this.createdElement = "<" + this.elementName + finalAttribute + ">" + this.content + "</" + this.elementName + ">";
        }
    }

    public void AddAttribute(string attribute, string value)
    {
        this.finalAttribute += " " + attribute + "=\"" + value + "\"";
        createElement();
    }

    public void AddContent(string content)
    {
        this.content = content;
        createElement();
    }

    public override string ToString()
    {
        return this.createdElement.ToString();
    }


}