#pragma checksum "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a97541e4cbed2fc6400ef63606219066318413ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Detail), @"mvc.1.0.view", @"/Views/Course/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97541e4cbed2fc6400ef63606219066318413ac", @"/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d32ed70855580ea7ceb2069ad0d7dfa76919d5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prjCramSchoolSystemUser.ViewModel.CCourseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fEchelonId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-details spad form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-top:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
  
    if (!string.IsNullOrEmpty(Model.course.FEchelonId))
    {
        ViewData["Title"] = Model.course.FCourse.FName;
    }
    else
    {
        ViewData["Title"] = "Detail";
    }

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .coverimg {
            border: 2px green dashed;
        }

        #table_title {
            color: #111111;
            font-weight: 600;
            text-transform: uppercase;
            /*border-bottom: 1px solid #e1e1e1;*/
            padding-top: 15px;
            padding-bottom: 10px;
            margin-bottom: 10px;
        }
    </style>
");
            }
            );
            WriteLiteral(@"<!-- Breadcrumb Begin -->
<div class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""breadcrumb__text"">
                    <h2>課程詳情</h2>
                </div>
            </div>
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""breadcrumb__links"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 1089, "\"", 1114, 1);
#nullable restore
#line 41 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
WriteAttributeValue("", 1096, Url.Content("~/"), 1096, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">首頁</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1146, "\"", 1182, 1);
#nullable restore
#line 42 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
WriteAttributeValue("", 1153, Url.Content("~/Course/List"), 1153, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">開課資訊</a>\r\n                    <span>課程詳情</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Breadcrumb End -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a97541e4cbed2fc6400ef63606219066318413ac8478", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a97541e4cbed2fc6400ef63606219066318413ac8740", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 52 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <div class=""container"" id=""product_imgs"">
        <div class=""row"">
            <div class=""container"">
                <!-- Blog Section Begin -->
                <div class=""row"">
                    <div class=""col-lg-8"">
                        <div");
                BeginWriteAttribute("class", " class=\"", 1798, "\"", 1806, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 61 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                              
                                string imgPath = Model.courseimg;
                                if (imgPath == "NullImg.jpg")
                                {
                                    imgPath = Url.Content("~/images/NullImg.jpg");
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"blog__item__pic set-bg\">\r\n                                    <img class=\"blog__item__pic set-bg uploadImg\"");
                BeginWriteAttribute("src", " src=\"", 2321, "\"", 2335, 1);
#nullable restore
#line 68 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
WriteAttributeValue("", 2327, imgPath, 2327, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 100%; height: 100%; object-fit: cover; \" />\r\n                                </div>\r\n");
                WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-4\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a97541e4cbed2fc6400ef63606219066318413ac12100", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 74 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.course.FEchelonId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a97541e4cbed2fc6400ef63606219066318413ac13904", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 75 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.course.FName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"product__details__text\">\r\n                            <div class=\"product__label\" style=\"border-width: 1px; border-style: solid; border-color: #5599FF; padding: 5px; background-color: #FFFFFF; color: #5599FF; \">");
#nullable restore
#line 77 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                                                                                                                                    Write(Html.DisplayFor(model => model.ClassState));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <h4 style=\"margin-bottom: 10px; margin-top: 10px;\">");
#nullable restore
#line 78 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                          Write(Html.DisplayFor(model => model.course.FCourse.FName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 79 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                              
                                string originalprice = "";
                                if (Model.course.FCourse.FOriginalPrice != null)
                                {
                                    originalprice = String.Format("{0:0,0}", (decimal)Model.course.FCourse.FOriginalPrice);
                                }
                                DateTime _starttime = Convert.ToDateTime(Model.course.FStartTime);
                                string StartTime = _starttime.ToString("yyyy") + "年" + _starttime.ToString("MM") + "月" + _starttime.ToString("dd") + "日";
                                DateTime _endtime = Convert.ToDateTime(Model.course.FEndTime);
                                string EndTime = _endtime.ToString("yyyy") + "年" + _endtime.ToString("MM") + "月" + _endtime.ToString("dd") + "日";
                                //特價
                                if (Model.course.FDiscountDate >= DateTime.Now)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <h5 style=\"text-decoration: line-through; border-bottom:none; padding-bottom:0px; margin-bottom:5px;\">$");
#nullable restore
#line 92 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                                                                                      Write(originalprice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                    <h5 style=\"border-bottom: none; padding-bottom: 0px; margin-bottom: 5px; \">$");
#nullable restore
#line 93 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                                                           Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 96 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                               
                                }
                                //原價
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <h5 style=\"border-bottom: none; padding-bottom: 0px; margin-bottom: 5px;\">$");
#nullable restore
#line 101 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 102 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <ul style=\"padding-bottom: 0px; margin-bottom: 5px;padding-top:0px;margin-top:5px;\">\r\n");
#nullable restore
#line 105 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                  
                                    if (Model.course.FDiscountDate >= DateTime.Now)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>優惠價錢至<span>");
#nullable restore
#line 108 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                  Write(Model.DiscountDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n");
#nullable restore
#line 109 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li>授課年級:<span style=\"padding-left:6px;\">");
#nullable restore
#line 111 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                    Write(Html.DisplayFor(model => model.course.FCourse.FGrade));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span><span style=\"padding-left:6px;\">");
#nullable restore
#line 111 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                                                                                                                 Write(Model.SchoolYear);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span><span>學期</span></li>\r\n");
                WriteLiteral("                                <li>課程堂數:<span style=\"padding-left:6px;\">");
#nullable restore
#line 113 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                    Write(Html.DisplayFor(model => model.course.FCourse.FTotalNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n                                <li>課程總時數:<span style=\"padding-left:6px;\">");
#nullable restore
#line 114 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                     Write(Html.DisplayFor(model => model.course.FCourse.FTotalHours));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n                                <li>開班日期:<span style=\"padding-left:6px;\">");
#nullable restore
#line 115 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                    Write(StartTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>&nbsp;~&nbsp;<span>");
#nullable restore
#line 115 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                                                        Write(EndTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n                                <li>上課時間:<span style=\"padding-left:6px;\">");
#nullable restore
#line 116 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                    Write(Html.DisplayFor(model => model.course.FTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></li>\r\n                                <li>授課老師:<span style=\"padding-left:6px;\">");
#nullable restore
#line 117 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                                    Write(Html.DisplayFor(model => model.course.FTeacher));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></li>
                            </ul>
                            <button id=""addCart"" type=""button"" class=""btn"" style=""text-align: center; border-width: 1px; border-style: solid; border-color: #5599FF; background-color: #FFFFFF; color: #5599FF; ""><h5 style=""border-bottom: none; padding-bottom: 0px; margin-bottom: 5px; color: #5599FF;""><i class=""fa-solid fa-cart-shopping""></i>&nbsp;&nbsp;加入購物車</h5></button>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Blog Section End -->
            <div class=""col-lg-12"" style=""padding-top:20px;"">
                <h5 id=""table_title"">課程大綱</h5>
                <div class=""product__details__text"">
                    <p>
                        ");
#nullable restore
#line 129 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                   Write(Html.DisplayFor(model => model.course.FCourse.FSummary));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 133 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
              
                if (Model.Detail_List != null && Model.Detail_List.Count > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""col-lg-12"" style=""padding-bottom: 20px;"">
                        <h5 id=""table_title"">課程細項</h5>
                        <table class=""table table-hover"" style=""border-style: none;"">
                            <thead>
                                <tr>
                                    <th scope=""col"">課堂數</th>
                                    <th scope=""col"">課堂進度(頁數)</th>
                                    <th scope=""col"">課程進度說明</th>
                                    <th scope=""col"">授課方式</th>
                                    <th scope=""col"">說明</th>
                                </tr>
                            </thead>
                            <tbody id=""tbody_Detail"">
");
#nullable restore
#line 149 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                 foreach (var item in Model.Detail_List)
                                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 153 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                                   Write(item.FCourseNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 154 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                       Write(item.FSchedule);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 155 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                       Write(item.FScheduleDetail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 156 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                       Write(item.FTeachingMethod);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 157 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                       Write(item.FRemark);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 159 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 163 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <link href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.1.4/toastr.min.css"" rel=""stylesheet"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.1.4/toastr.min.js""></script>
    <script>
        $(""#addCart"").click(async function () {
            //let EchelonId = document.getElementById(""fEchelonId"");
            let EchelonId = $(""#fEchelonId"").val();
            console.log(EchelonId);
            let response = await fetch(""");
#nullable restore
#line 182 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                   Write(Url.Content("~/Course/AddShoppinCat"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" + `?fEchelonId=${EchelonId}`);\r\n            //toastr[\"success\"](\"商品已加入購物車！\");\r\n            toastr.options = {\r\n                onclick: function () {\r\n                    window.location.href = \"");
#nullable restore
#line 186 "D:\prjuser\prjCramSchoolSystemUser\Views\Course\Detail.cshtml"
                                       Write(Url.Content("~/Shopping/Shoppingcart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                }\r\n            }\r\n            //toastr.success(\"success\");\r\n            toastr.success(\"課程已加入購物車！\");\r\n            //toastr.options = { onclick: function () { alert(\"You clicked Me!\"); } }\r\n\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prjCramSchoolSystemUser.ViewModel.CCourseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
