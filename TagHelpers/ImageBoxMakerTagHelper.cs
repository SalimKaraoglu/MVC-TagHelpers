using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVC_TagHelpers.TagHelpers
{
    [HtmlTargetElement("image-box-maker" , Attributes ="width")]
    [HtmlTargetElement("image-box-maker" , Attributes ="height")]
    [HtmlTargetElement("image-box-maker" , Attributes ="color")]
    [HtmlTargetElement("image-box-maker" , Attributes ="image")]
    public class ImageBoxMakerTagHelper : TagHelper
    {
        public string Witdh { get; set; }
        public string Height { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("style", $"height:{Height}px; witdh:{Witdh}px; background-color: {Color}; border-radius:5px;");
            output.Content.AppendHtml($"<img style='border-radius:100%;' src='{Image}' width='{int.Parse(Witdh) - 20};' height='{int.Parse(Height) - 20};'  />");
            output.Attributes.Add("class", "d-flex justify-content-center align-items-center text-white mx-2");

            base.Process(context, output);
        }

    }
}
