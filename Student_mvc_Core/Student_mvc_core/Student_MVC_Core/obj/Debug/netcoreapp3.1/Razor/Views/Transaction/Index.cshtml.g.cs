#pragma checksum "C:\Users\1\Downloads\jQuery-Ajax-with-ASP.NET-Core-MVC-using-Modal-PopUp-main\jQuery Ajax CRUD\jQuery Ajax CRUD\Views\Transaction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ec367b8129181e28ecc1c09ef70a19a59fd919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Index), @"mvc.1.0.view", @"/Views/Transaction/Index.cshtml")]
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
#line 1 "C:\Users\1\Downloads\jQuery-Ajax-with-ASP.NET-Core-MVC-using-Modal-PopUp-main\jQuery Ajax CRUD\jQuery Ajax CRUD\Views\_ViewImports.cshtml"
using jQuery_Ajax_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1\Downloads\jQuery-Ajax-with-ASP.NET-Core-MVC-using-Modal-PopUp-main\jQuery Ajax CRUD\jQuery Ajax CRUD\Views\_ViewImports.cshtml"
using jQuery_Ajax_CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16ec367b8129181e28ecc1c09ef70a19a59fd919", @"/Views/Transaction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8178ab3c2a192ca90360da4713938289d2f3c2fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<jQuery_Ajax_CRUD.Models.TransactionModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\1\Downloads\jQuery-Ajax-with-ASP.NET-Core-MVC-using-Modal-PopUp-main\jQuery Ajax CRUD\jQuery Ajax CRUD\Views\Transaction\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div id=\"view-all\">\n    ");
#nullable restore
#line 9 "C:\Users\1\Downloads\jQuery-Ajax-with-ASP.NET-Core-MVC-using-Modal-PopUp-main\jQuery Ajax CRUD\jQuery Ajax CRUD\Views\Transaction\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""form-modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

            </div>
        </div>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 30 "C:\Users\1\Downloads\jQuery-Ajax-with-ASP.NET-Core-MVC-using-Modal-PopUp-main\jQuery Ajax CRUD\jQuery Ajax CRUD\Views\Transaction\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<jQuery_Ajax_CRUD.Models.TransactionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
