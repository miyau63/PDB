#pragma checksum "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\Home\EditIns.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfff8d65e848e15f74a6a3d87471323b90c03be6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditIns), @"mvc.1.0.view", @"/Views/Home/EditIns.cshtml")]
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
#line 1 "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfff8d65e848e15f74a6a3d87471323b90c03be6", @"/Views/Home/EditIns.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditIns : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Instrument>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\Home\EditIns.cshtml"
  
    ViewBag.Title = "Редактирование инструментов";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\Home\EditIns.cshtml"
 using (Html.BeginForm("EditIns", "Home"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\Home\EditIns.cshtml"
Write(Html.HiddenFor(m => m.InstrumentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dataBox\">\r\n        <label>Название</label><br />\r\n        ");
#nullable restore
#line 10 "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\Home\EditIns.cshtml"
   Write(Html.TextBoxFor(m => m.Name, new { @class = "text-box" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\Home\EditIns.cshtml"
   Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"dataBox\">\r\n        <label>Категория</label><br />\r\n        ");
#nullable restore
#line 15 "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\Home\EditIns.cshtml"
   Write(Html.DropDownListFor(m => m.Categ, new SelectList(new string[] { "духовые", "струнные", "клавишные", "ударные" })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div class=\"dataBox\">\r\n        <input type=\"submit\" value=\"Сохранить\" />\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\5\source\repos\WebApplication4\WebApplication4\Views\Home\EditIns.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Instrument> Html { get; private set; }
    }
}
#pragma warning restore 1591