#pragma checksum "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97a017964162f2fc2d32ed830a24132afbc77993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_List), @"mvc.1.0.view", @"/Views/Course/List.cshtml")]
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
#line 1 "D:\prjuser\prjCramSchoolSystemUser\Views\_ViewImports.cshtml"
using prjCramSchoolSystemUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\prjuser\prjCramSchoolSystemUser\Views\_ViewImports.cshtml"
using prjCramSchoolSystemUser.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97a017964162f2fc2d32ed830a24132afbc77993", @"/Views/Course/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d32ed70855580ea7ceb2069ad0d7dfa76919d5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prjCramSchoolSystemUser.ViewModel.CCourseListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_CourseList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "??????", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-color: #5599FF"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
  
    ViewData["Title"] = "????????????";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97a017964162f2fc2d32ed830a24132afbc779936642", async() => {
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
                WriteLiteral(@"
    <style>
        .product__item__text_ {
            padding-top: 0px;
            margin-top: 10px;
            text-align: center;
            position: relative;
        }

            .product__item__text_ h5 {
                margin-bottom: 16px;
            }

                .product__item__text_ h5 a {
                    color: #111111;
                    font-weight: 600;
                    text-transform: uppercase;
                }

            .product__item__text_ .product__item__price_ {
                color: #111111;
                font-weight: 600;
                font-size: 16px;
                -webkit-transition: all, 0.3s;
                -o-transition: all, 0.3s;
                transition: all, 0.3s;
            }

            .product__item__text_ .cart_add_ {
                position: absolute;
                left: 0;
                bottom: -20px;
                width: 100%;
                -webkit-transition: all, 0.5s;
                -o");
                WriteLiteral(@"-transition: all, 0.5s;
                transition: all, 0.5s;
                opacity: 0;
                visibility: hidden;
            }

                .product__item__text_ .cart_add_ a {
                    color: #111111;
                    font-size: 16px;
                    font-weight: 600;
                    display: inline-block;
                    border-bottom: 2px solid #f08632;
                    padding-bottom: 4px;
                }

        .overflow-hidden:hover .product__item__text_ .cart_add_ {
            opacity: 1;
            visibility: visible;
            bottom: -4px;
        }

        .product__item__text_ .cart_add_ {
            position: absolute;
            left: 0;
            bottom: -20px;
            width: 100%;
            -webkit-transition: all, 0.5s;
            -o-transition: all, 0.5s;
            transition: all, 0.5s;
            opacity: 0;
            visibility: hidden;
        }

        .overflow-hidden:hover .produ");
                WriteLiteral(@"ct__item__text_ .product__item__price_ {
            opacity: 0;
            visibility: hidden;
        }

        .product__item__text_ .product__item__price_ {
            color: #111111;
            font-weight: 600;
            font-size: 16px;
            -webkit-transition: all, 0.3s;
            -o-transition: all, 0.3s;
            transition: all, 0.3s;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<!-- Breadcrumb Begin -->
<div class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""breadcrumb__text"">
                    <h2>????????????</h2>
                </div>
            </div>
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""breadcrumb__links"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 3220, "\"", 3245, 1);
#nullable restore
#line 107 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
WriteAttributeValue("", 3227, Url.Content("~/"), 3227, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">??????</a>
                    <span>????????????</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Shop Section Begin -->
<section class=""shop spad"" style=""margin-top:0px; padding-top:0px;"">

    <div class=""container-xxl py-5"">
        <div class=""container"">
            <div class=""row"" style=""padding-bottom:60px;"">
                <div class=""col-lg-7 col-md-7"">
                    <div class=""shop__option__search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a017964162f2fc2d32ed830a24132afbc7799311783", async() => {
                WriteLiteral("\r\n                            <select id=\"CategoryDDL\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a017964162f2fc2d32ed830a24132afbc7799312133", async() => {
                    WriteLiteral("??????");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 126 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                  
                                    if (Model.CategoryDDL.Length > 0)
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                         foreach (var item in Model.CategoryDDL)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a017964162f2fc2d32ed830a24132afbc7799314031", async() => {
#nullable restore
#line 132 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                                             Write(item);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                               WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 133 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                         

                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </select>\r\n                            <input id=\"txtSearch\" type=\"text\" placeholder=\"??????\">\r\n                            <button id=\"btnSearch\" type=\"button\"><i class=\"fa fa-search\"></i></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <small style=\"margin-left: 170px; color: #666666\">???????????????????????????????????????</small>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row g-4\" id=\"divCourse\">\r\n");
#nullable restore
#line 146 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                  
                    foreach (var item in Model.course)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-4 wow fadeInUp\" data-wow-delay=\"0.1s\" style=\"padding-bottom:20px;\">\r\n                            <div class=\"service-item rounded overflow-hidden\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 5228, "\"", 5249, 1);
#nullable restore
#line 151 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
WriteAttributeValue("", 5234, item.PhotoName, 5234, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100%; height: 100%; object-fit: cover; \">\r\n                                <div class=\"position-relative p-4 pt-0\">\r\n                                    <div class=\"service-icon\">\r\n                                        <span>");
#nullable restore
#line 154 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                         Write(item.CourseState);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                    <div class=""product__details__text product__item__text_"">
                                        <h5 class=""mb-3"" style=""border-bottom: none; padding-bottom: 0px; margin-bottom: 5px; "">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a017964162f2fc2d32ed830a24132afbc7799319669", async() => {
#nullable restore
#line 157 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                                                                                                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                                                                                                                                         WriteLiteral(item.FEchelonId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                                        <div class=\"product__item__price_\"><h5 class=\"mb-3\" style=\"border-bottom: none; padding-bottom: 0px; margin-bottom: 5px;\">$");
#nullable restore
#line 158 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                                                                                                                                              Write(item.Price.ToString("###,###,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></div>\r\n                                        <div class=\"cart_add_\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a017964162f2fc2d32ed830a24132afbc7799322849", async() => {
                WriteLiteral("??????????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                                                                                                      WriteLiteral(item.FEchelonId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 164 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <!--<div class=\"shop__last__option\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                <div class=\"shop__pagination\">\r\n");
#nullable restore
#line 174 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                      
                        //int p = 1;
                        //for (int i = 0; i < Model.page; i++)
                        //{
                            //<a href="#">@p</a>
                            //p++;
                        //}
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral("    <!--</div>\r\n    </div>\r\n    <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n        <div class=\"shop__last__text\">-->\r\n");
            WriteLiteral("    <!--</div>\r\n            </div>\r\n        </div>\r\n    </div>-->\r\n</section>\r\n<!-- Shop Section End -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#CategoryDDL"").change(function () {
        //let b = $(""#CategoryDDL"").find(""option: selected"").text();
        //console.log(b);
            Search();
        })
        $(""#btnSearch"").click(function () {
            Search();
        })
        let Search = async function () {
            let formData = new FormData();
            formData.append(""txtCategory"", $(""#CategoryDDL"").val());
            formData.append(""txtSearch"", $(""#txtSearch"").val());
            let response = await fetch(""");
#nullable restore
#line 208 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\List.cshtml"
                                   Write(Url.Content("~/Course/searchList"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", { method: ""POST"", body: formData })
            let data_arr = await response.json();
            console.log(data_arr);
            let docFrag = $(document.createDocumentFragment());
            $.each(data_arr.course, function (idx, data) {
                let { fEchelonId, name, classState, courseState, originalPrice, specialOffer, discountDate, price, photoName, price_Format } = data;
                let row = `<div class=""col-md-6 col-lg-4 wow fadeInUp"" data-wow-delay=""0.1s"" style=""padding-bottom:20px;"">`
                row +=`<div class=""service-item rounded overflow-hidden"">`;
                row += `<img class=""img-fluid"" src=""${photoName}"" style=""width: 100%; height: 100%; object-fit: cover; "">`;
                row += `<div class=""position-relative p-4 pt-0""><div class=""service-icon""><span>${courseState}</span></div>`;
                row += `<div class=""product__details__text product__item__text_"">`
                row += `<h5 class=""mb-3"" style=""border-bottom: none; padding-bottom:");
                WriteLiteral(@" 0px; margin-bottom: 5px; ""><a asp-action=""Detail"" asp-route-id=""${fEchelonId}"">${name}</a></h5>`
                row += `<div class=""product__item__price_""><h5 class=""mb-3"" style=""border-bottom: none; padding-bottom: 0px; margin-bottom: 5px;"">$${price_Format}</h5></div>`
                row += `<div class=""cart_add_""><a style=""border-color: #5599FF"" asp-action=""Detail"" asp-route-id=""${fEchelonId}"" target=""_blank"">??????????????????</a></div></div></div>`
                row += `</div></div>`
                docFrag.append(row);
            })
            $(""#divCourse"").html(docFrag);
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prjCramSchoolSystemUser.ViewModel.CCourseListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
