#pragma checksum "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfdb270c792949e2359363e30a80a07e888b0755"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Details), @"mvc.1.0.view", @"/Views/Contacts/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\_ViewImports.cshtml"
using Siakad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\_ViewImports.cshtml"
using Siakad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfdb270c792949e2359363e30a80a07e888b0755", @"/Views/Contacts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e93e65e77b3a805e9b245828193a126af33dafb", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Siakad.Models.ContactDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Details</h1>\n\n<div>    \n    <hr />\n   <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 13 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 16 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 19 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 22 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 25 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Jurusan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 28 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Jurusan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 31 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fakultas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 34 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fakultas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 37 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DosenPembimbing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 40 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DosenPembimbing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
#nullable restore
#line 45 "C:\Users\Republic of Gamers\Documents\Computer Science\Visual Studio\ASP.NET Core\Siakad\Views\Contacts\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfdb270c792949e2359363e30a80a07e888b07557454", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Siakad.Models.ContactDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
