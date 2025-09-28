using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;

namespace MvcHelpers_HW.Helpers.Html
{
    public static class HtmlHelpers 
    {
        public static IHtmlContent ColoredText(this IHtmlHelper htmlHelper, string text, Color color)
        {
            TagBuilder span = new TagBuilder("span");
            span.Attributes.Add("style", $"color: rgba({color.R}, {color.G}, {color.B}, {color.A});");

            span.InnerHtml.Append(text);

            return span;
        }
    }
}
