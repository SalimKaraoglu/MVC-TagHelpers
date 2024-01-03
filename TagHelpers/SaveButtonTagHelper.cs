using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVC_TagHelpers.TagHelpers
{
    [HtmlTargetElement("button-save")]
    //<button-save></button-save>
    public class SaveButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //<button></button>
            output.TagName = "button";
            //<button type="submit"></button>
            output.Attributes.Add("type", "submit");
            //<button type="submit" class="btn btn-success"></button>
            output.Attributes.Add("class", "btn btn-success");
            //<button type="submit" class="btn btn-success"></button>
            output.Content.AppendHtml("<i class='fa-solid fa-floppy-disk'></i> Kaydet");

            base.Process(context, output);
        }
    }
}
