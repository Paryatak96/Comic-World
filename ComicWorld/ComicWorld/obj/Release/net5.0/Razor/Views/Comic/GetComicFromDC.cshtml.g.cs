#pragma checksum "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4035be26f69fe62a4c507858bc505fa45412d0e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comic_GetComicFromDC), @"mvc.1.0.view", @"/Views/Comic/GetComicFromDC.cshtml")]
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
#line 1 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\_ViewImports.cshtml"
using ComicWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\_ViewImports.cshtml"
using ComicWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035be26f69fe62a4c507858bc505fa45412d0e3", @"/Views/Comic/GetComicFromDC.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c6b404de7086989ee0373e2c191b93c44246941", @"/Views/_ViewImports.cshtml")]
    public class Views_Comic_GetComicFromDC : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComicWorld.Application.ViewModels.Comic.ListComicForListVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "searchString", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchString"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Type Title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-describedby", new global::Microsoft.AspNetCore.Html.HtmlString("search-addon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"mojaklasa\">\r\n\r\n    <div class=\"text-center\">\r\n        <h1>DC Comics</h1>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4035be26f69fe62a4c507858bc505fa45412d0e37075", async() => {
                WriteLiteral("\r\n\r\n        <div class=\"input-group\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4035be26f69fe62a4c507858bc505fa45412d0e37388", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-outline-primary\">Search</button>\r\n        </div>\r\n\r\n");
                WriteLiteral(@"        <div class=""row"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Cover
                        </th>
                        <th>
                            Issue Number
                        </th>
                        <th>
                            Title
                        </th>
                        <th>
                            Publisher
                        </th>
                        <th>
                            Type
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 47 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                     foreach (var item in Model.Comics)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1748, "\"", 1770, 1);
#nullable restore
#line 51 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
WriteAttributeValue("", 1754, item.ComicPhoto, 1754, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"100\" height=\"152\" />\r\n                            </td>\r\n                            <td style=\"padding-top: 65px;padding-left:40px;\">\r\n                                ");
#nullable restore
#line 54 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Issue));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"padding-top: 65px\">\r\n                                ");
#nullable restore
#line 57 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"padding-top: 65px\">\r\n                                ");
#nullable restore
#line 60 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Publisher));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"padding-top: 65px\">\r\n                                ");
#nullable restore
#line 63 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Type.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"padding-top: 50px;padding-left:80px\">\r\n                                ");
#nullable restore
#line 66 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                           Write(Html.ActionLink("Edit", "EditComic", new { id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 67 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                           Write(Html.ActionLink("Details", "ComicDetails", new { id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 68 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                           Write(Html.ActionLink("Delete", "DeleteComic", new { id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"row\">\r\n            <table>\r\n                <tr>\r\n");
#nullable restore
#line 78 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                      
                        int i = 1;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                     while (i <= Math.Ceiling(Model.Count / (double)Model.PageSize))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>\r\n\r\n");
#nullable restore
#line 85 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                             if (i != Model.CurrentPage)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a class=\"page-link\"");
                BeginWriteAttribute("href", " href=\"", 3607, "\"", 3639, 3);
                WriteAttributeValue("", 3614, "javascript:PagerClick(", 3614, 22, true);
#nullable restore
#line 87 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
WriteAttributeValue("", 3636, i, 3636, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3638, ")", 3638, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 87 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                                                                                 Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 88 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <a class=\"page-link\">");
#nullable restore
#line 91 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                                                Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 92 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n");
#nullable restore
#line 94 "C:\Users\Sebastian\Source\Repos\ComicWorld\ComicWorld\Views\Comic\GetComicFromDC.cshtml"
                        i++;
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tr>\r\n            </table>\r\n            <input type=\"hidden\" name=\"pageNo\" id=\"pageNo\" />\r\n            <input type=\"hidden\" name=\"pageSize\" id=\"pageSize\" value=\"5\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        function PagerClick(index) {\r\n            document.getElementById(\"pageNo\").value = index;\r\n            document.forms[0].submit();\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComicWorld.Application.ViewModels.Comic.ListComicForListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
