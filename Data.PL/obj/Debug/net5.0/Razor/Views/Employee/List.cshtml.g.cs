#pragma checksum "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56f83ec275436abb0fdd9a9f8434cf030fd809a59e1ebc11c949232300d8c620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_List), @"mvc.1.0.view", @"/Views/Employee/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\C#\RouteDemoAss\Data.PL\Views\_ViewImports.cshtml"
using Data.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C#\RouteDemoAss\Data.PL\Views\_ViewImports.cshtml"
using Data.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C#\RouteDemoAss\Data.PL\Views\_ViewImports.cshtml"
using Data.DL.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"56f83ec275436abb0fdd9a9f8434cf030fd809a59e1ebc11c949232300d8c620", @"/Views/Employee/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"964e971e39dc983e0558caadaa64256478432412206a6f4957eb55bf746c8338", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.bundle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_EmployeeRow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/datatables.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
  
    ViewData["Title"] = "Employee";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56f83ec275436abb0fdd9a9f8434cf030fd809a59e1ebc11c949232300d8c6205450", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div class=""container"">
    <div class=""d-flex justify-content-between p-4 mb-3"">
        <h2>Employee</h2>
        <div>
            <a href=""javascript:;"" data-title=""Add Department"" data-url=""/Employee/Create"" class=""js-render-model btn btn-primary fw-bold px-4 py-2"">
                <i class=""fa-solid fa-plus""></i>
                Add
            </a>
        </div>
    </div>

");
#nullable restore
#line 19 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
     if (Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card shadow border-5 card-flush"">
            <div class=""card-body"">
                <h5 class=""card-title w-25 mb-3 text-center ms-auto"">
                    <input type=""search"" class=""form-control ds-input search-input"" id=""search-input"" placeholder=""Search..."" aria-label=""Search for..."" autocomplete=""off"" spellcheck=""false"" role=""combobox"" aria-autocomplete=""list"" aria-expanded=""false"" aria-owns=""algolia-autocomplete-listbox-0"" dir=""auto"" style=""position: relative; vertical-align: top;"">
                </h5>
                <div class=""table-responsive"">
                    <table class=""table table-row-dashed table-row-gray-300 gy-3 align-middle js-datatabels"">
                        <thead>
                            <tr class=""fw-bold fs-6 text-gray-800"">
                                <th>");
#nullable restore
#line 30 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 31 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 32 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 33 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 34 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 35 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 36 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 37 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.HiaringDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 38 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 39 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                               Write(Html.DisplayNameFor(d => d.LastUpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th class=\"js-no-export text-end\">Action</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 44 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                             foreach (var dep in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56f83ec275436abb0fdd9a9f8434cf030fd809a59e1ebc11c949232300d8c62011507", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 46 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = dep;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 53 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"bg-warning mt-5 text-center\">\r\n            <p class=\"fs-2\">Not Found :(</p>\r\n        </div>\r\n");
#nullable restore
#line 59 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 61 "F:\C#\RouteDemoAss\Data.PL\Views\Employee\List.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Plugins", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56f83ec275436abb0fdd9a9f8434cf030fd809a59e1ebc11c949232300d8c62014199", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56f83ec275436abb0fdd9a9f8434cf030fd809a59e1ebc11c949232300d8c62015444", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
