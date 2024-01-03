using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVC_TagHelpers.TagHelpers
{
    [HtmlTargetElement("box-create", Attributes = "width")]
    [HtmlTargetElement("box-create", Attributes = "height")]
    [HtmlTargetElement("box-create", Attributes = "color")]
    [HtmlTargetElement("box-create", Attributes = "text")]
    [HtmlTargetElement("box-create", Attributes = "radius")]

    public class BoxCreateTagHelper : TagHelper
    {
        public string Width { get; set; }
        public string Height { get; set; }
        public string Color { get; set; }
        public string Text { get; set; }
        public string Radius { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("style", $"width:{Width}px; height:{Height}px; background-color:{Color}; border-radius:{Radius};");
            output.Content.AppendHtml(Text);
            output.Attributes.Add("class", "d-flex justify-content-center align-items-center text-white mx-2");

            base.Process(context, output);
        }
    }
}
