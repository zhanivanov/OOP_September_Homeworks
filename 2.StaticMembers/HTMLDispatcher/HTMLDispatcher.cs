using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class HTMLDispatcher
{
    public static ElementBuilder CreateImage(string imgSource, string imageAlt, string title)
    {
        ElementBuilder image = new ElementBuilder("img");
        image.AddAttribute("src", imgSource);
        image.AddAttribute("title", title);
        image.AddAttribute("alt", imageAlt);
        return image;
    }

    public static ElementBuilder CreateURL(string url, string title, string text)
    {
        ElementBuilder aTag = new ElementBuilder("a");
        aTag.AddAttribute("href", url);
        aTag.AddAttribute("title", title);
        aTag.AddContent(text);
        return aTag;
    }

    public static ElementBuilder CreateInput(string inputType,string inputName,string inputValue)
    {
        ElementBuilder inputField = new ElementBuilder("input");
        inputField.AddAttribute("type", inputType);
        inputField.AddAttribute("name", inputName);
        inputField.AddAttribute("value", inputValue);
        return inputField;
    }
}