using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcHelpers_HW.Helpers.Tags
{
    [HtmlTargetElement("bootstrap-icon")]
    public class BootstrapSubmitTag : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Add("class", "btn btn-primary");

            output.Attributes.Add("type", "button");
        }
    }
}
