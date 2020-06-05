using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Toolkit.TagHelpers
{
    [HtmlTargetElement(Attributes = nameof(Inversion))]
    public class InversionTagHelper : TagHelper
    {
        public bool Inversion { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Inversion)
            {
                output.SuppressOutput();
            }
        }
    }
}
