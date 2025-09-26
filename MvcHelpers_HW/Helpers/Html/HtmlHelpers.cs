using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcHelpers_HW.Helpers.Html
{
    public static class HtmlHelpers 
    {
        public static IHtmlContent ColoredText(this IHtmlHelper htmlHelper, string text, string color)
        {
            TagBuilder span = new TagBuilder("span");
            span.Attributes.Add("style", $"color: {color};");

            span.InnerHtml.Append(text);

            return span;
        }
    }
}
