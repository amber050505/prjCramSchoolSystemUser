#pragma checksum "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fc390dfc8b7f33901a86f690f0166708a3296d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Create), @"mvc.1.0.view", @"/Views/Order/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fc390dfc8b7f33901a86f690f0166708a3296d6", @"/Views/Order/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d32ed70855580ea7ceb2069ad0d7dfa76919d5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prjCramSchoolSystemUser.ViewModel.COrderCreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("_txtReceiver"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
  
    ViewData["Title"] = "建立訂單";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .divider {
            padding-bottom: 25px;
            margin-bottom: 30px;
        }
        /*被彈出的div*/
        .eject {
            border: 3px #000000 solid;
            border-radius: 10px;
            width: 300px;
            height: 300px;
            background-color: #ECF5FF;
            position: fixed;
            left: 50%;
            top: 50%;
            transform: translate(-50%,-50%);
            z-index: 99;
            /*讓其浮在最上面*/
            /*position: absolute;*/
            display: none;
            /*設置彈出的div窗口位置*/
            /*left: 40%;
            top: 30%;*/
        }
        /*彈出窗口後，背部不可點擊操作*/
        /*#background_div {
            background-color: rgba(220,220,220,0.5);
            position: absolute;
        }*/
    </style>
");
            }
            );
            WriteLiteral("\r\n<!-- Checkout Section Begin -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fc390dfc8b7f33901a86f690f0166708a3296d66011", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fc390dfc8b7f33901a86f690f0166708a3296d66273", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 41 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
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
    <!-- Breadcrumb Begin -->
    <div class=""breadcrumb-option"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""breadcrumb__text"">
                            <h2>建立訂單</h2>
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""breadcrumb__links"">
                            <a");
                BeginWriteAttribute("href", " href=\"", 1595, "\"", 1620, 1);
#nullable restore
#line 53 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
WriteAttributeValue("", 1602, Url.Content("~/"), 1602, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">首頁</a>
                            <span>建立訂單</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    <!-- Breadcrumb End -->
    <!-- Shopping Cart Section Begin -->
    <section id=""divOrderCreate"" class=""shopping-cart spad"" style=""padding-top:25px;"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
");
                WriteLiteral("                        <h6 style=\"color: #111111; font-weight: 600; text-transform: uppercase; margin-top: 25px; margin-bottom: 35px; \">\r\n                            <span style=\"margin-right:90px;\">訂購人帳號:<span style=\"margin-left:10px;\">");
#nullable restore
#line 68 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                                                                                              Write(Model.oder.FUserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></span>\r\n                            <span>訂購人姓名:<span style=\"margin-left:10px;\">");
#nullable restore
#line 69 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                                                                   Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></span>\r\n                        </h6>\r\n");
                WriteLiteral(@"
                    <div class=""shopping__cart__table"">
                        <table>
                            <thead>
                                <tr>
                                    <th style=""display:none""></th>
                                    <th>序號</th>
                                    <th style=""padding-right:20px;"">課程</th>
                                    <th>使用課程學生</th>
                                    <th></th>
                                    <th>金額</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 86 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                                  
                                    if (Model.coursedata.ShoppingCart_List != null && Model.coursedata.ShoppingCart_List.Count != 0)
                                    {
                                        int x = 0;
                                        int num = 1;
                                        foreach (var item in Model.coursedata.ShoppingCart_List)
                                        {
                                            for (int i = 0; i < item.Count; i++)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td style=\"display:none\">");
#nullable restore
#line 96 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                                                                        Write(item.EchelonId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td class=\"cart__close\">");
#nullable restore
#line 97 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                                                                       Write(num);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                                    <td class=""product__cart__item"">
                                                        <div class=""product__cart__item__pic"" style=""margin-right:10px;"">
                                                            <img");
                BeginWriteAttribute("src", " src=\"", 4237, "\"", 4258, 1);
#nullable restore
#line 100 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
WriteAttributeValue("", 4243, item.PhotoName, 4243, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""width:200px;"">
                                                        </div>
                                                        <div class=""product__cart__item__text"">
                                                            <h5 style=""margin-top:23px;"">");
#nullable restore
#line 103 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                                                        </div>
                                                    </td>
                                                    <td class=""quantity__item"" colspan=""2"">
                                                        <div class=""showData d-flex"">
                                                            <label class=""labReceiver"">請輸入使用課程學生資訊</label>
                                                            <button class=""btn btn-outline-primary btnCheckReceiver d-flex justify-content-center align-items-center"" type=""button"" style=""width: 25px; height: 25px;margin-left:10px;""><i class=""fa-solid fa-plus""></i></button>
                                                        </div>
                                                        <div class=""eject"">
                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fc390dfc8b7f33901a86f690f0166708a3296d614554", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 112 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.order_detail[x].FReceiverId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                            <!--做一個點擊關閉的按鈕-->
                                                            <div class=""close"" style=""width: 20px;height: 25px; margin-left: 275px;"">
                                                                <span class=""span_close"" style=""font-size: 25px; color:red;"">X</span>
                                                            </div>
                                                            <!--彈出div的內容-->
                                                            <div class=""divReceiver"" style=""height: 300px; width: 300px;"">
                                                                <h5 style=""padding-top: 30px; padding-bottom: 15px; color: #111111; font-weight: 600;"">請輸入使用課程學生的帳號或Email</h5>
                                                                <input type=""text"" class=""txtReceiver"" style=""width:280px; margin-right: 5px; margin-left: 5px; border: 1px #000000 solid;"" />
                                    ");
                WriteLiteral("                            <button type=\"button\" class=\"btn btn-outline-primary checkReceiver\" style=\"margin-top:10px; margin-left: 225px;\">\r\n");
                WriteLiteral(@"                                                                    確定
                                                                </button>
                                                                <h5 style=""padding-top: 10px; padding-bottom: 15px; color: #111111; font-weight: 600;"">查詢結果</h5>
                                                                <div class=""result_caption""></div>
");
                WriteLiteral(@"                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td class=""cart__price"">$");
#nullable restore
#line 131 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                                                                        Write(item.Price.ToString("###,###,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 133 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                                                x++;
                                                num++;
                                            }

                                        }
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 143 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                      
                        if (Model.coursedata.ShoppingCart_List != null && Model.coursedata.ShoppingCart_List.Count != 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div style=""margin-bottom: 30px;text-align:right;"">
                                <span style=""margin-right: 50px; color: #111111; font-size: 16px; font-weight: 600; width: 140px;"">總金額</span>
                                <span style="" color: #111111; font-size: 16px; font-weight: 600; width: 140px;"">$</span>
                                <span id=""course_Price"" style=""margin-right: 20px; color: #111111; font-size: 16px; font-weight: 600; width: 140px;"">
                                    ");
#nullable restore
#line 150 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                               Write(Model.coursedata.TotalPrice.ToString("###,###,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </span>\r\n                            </div>\r\n");
#nullable restore
#line 153 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                            <div class=\"continue__btn\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 9199, "\"", 9245, 1);
#nullable restore
#line 160 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
WriteAttributeValue("", 9206, Url.Content("~/Shopping/Shoppingcart"), 9206, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">回購物車</a>
                            </div>
                        </div>
                        <div class=""col-lg-6 col-md-6 col-sm-6"">
                            <div class=""continue__btn update__btn"">
                                <input type=""submit"" value=""建立訂單""");
                BeginWriteAttribute("class", " class=\"", 9525, "\"", 9533, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""color: #007bff; font-size: 14px; font-weight: 600; letter-spacing: 2px; text-transform: uppercase; border: 1px solid #007bff; padding: 14px 35px; display: inline-block; background-color: #FFFFFF  "" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Shopping Cart Section End -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Checkout Section End -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 178 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        //這個判斷重新寫
        //顯示:學生姓名 or 重新輸入
        //回傳 FirstName + LastName
        $(""#divOrderCreate"").on(""click"", "".checkReceiver"", async function (e) {
            //let btnTarget = $(this);
            let btnTarget = $(e.target);
            //取輸入textbox值
            //let receiver = $(e.target).closest("".divReceiver"").children("".txtReceiver"").val();
            let receiver = btnTarget.closest("".divReceiver"").children("".txtReceiver"").val();
            console.log(receiver);
            //查詢結果顯示標籤
            //let receiverMsg = $(e.target).closest("".divReceiver"").children("".result_caption"");
            let receiverMsg = btnTarget.closest("".divReceiver"").children("".result_caption"");
            let response = await fetch(""");
#nullable restore
#line 193 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\Create.cshtml"
                                   Write(Url.Content("~/order/checkReceiverId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" + `?account=${receiver}`);
            if (response.status == 200) {
                let arr = await response.json();
                //帳號存在
                if (arr.userState == 1) {
                    //顯示學生姓名
                    let name = "" 學生 : "";
                    if (arr.lastName != """") {
                        name += arr.lastName;
                    }
                    if (arr.firstName != """") {
                        name += arr.firstName;
                    }
                    //放進彈跳div
                    receiverMsg.html(`<h5>${name}</h5>`);
                    //放進textbox裡
                    //$(e.target).closest("".divReceiver"").closest("".eject"").children(""._txtReceiver"").val(arr.userName);
                    btnTarget.closest("".divReceiver"").closest("".eject"").children(""._txtReceiver"").val(arr.userName);
                    //顯示lab裡
                    //$(e.target).closest("".divReceiver"").closest("".eject"").closest("".quantity__item"").closest("".showData"").children");
                WriteLiteral(@"("".labReceiver"").html(name);
                    btnTarget.closest("".quantity__item"").children("".showData"").children("".labReceiver"").html(name);
                    //顯示存檔按鈕
                    //??
                } else {
                    //帳號不存在
                    receiverMsg.html(""帳號或信箱不存在，請重新輸入"");
                }                
            } else {
                let message = ""錯誤發生，無法驗證"";
                receiverMsg.html(message);
            }
        })


        //點擊彈出一個div框
        $(""#divOrderCreate"").on(""click"", "".btnCheckReceiver"", function (e) { //給按鈕綁定點擊事件
            let showdiv = $(e.target).closest("".quantity__item"").children("".eject"");
            showdiv.show();
        })

        //點擊關閉這個div框
        $(""#divOrderCreate"").on(""click"", "".close"", function (e) {
            let showdiv = $(e.target).closest("".quantity__item"").children("".eject"");
            showdiv.hide();
        })

        //鼠標移動到關閉按鈕，按鈕變紅色,移除變黑色
        $(""#divOrderCreate"").on(""mouseove");
                WriteLiteral(@"r"", "".close"", function (e) {
            $(e.target).children("".span_close"").css(""color"", ""red"");
            $(e.target).children(""span"").css(""cursor"", ""default"");
            //$(e.target).children(""span"").css(""color"", ""red"");

        })
        //$(""#divOrderCreate"").on(""mouseout"", "".close"", function (e) {
            //$(e.target).children(""span"").css(""color"", ""black"");
        //})



        //點擊彈出一個div框
        //$(""#btnCheckReceiver"").click(function () { //給按鈕綁定點擊事件
        //    var hei = $(document).height();
        //    var wid = $(document).width();
        //    $(""#background_div"").css(""width"", wid);
        //    $(""#background_div"").css(""height"", hei);
        //    $(""#eject"").show();
        //});

        //點擊關閉這個div框
        //$(""#close"").click(function () {
        //    $(""#background_div"").css(""width"", 0);
        //    $(""#background_div"").css(""height"", 0);
        //    $(""#eject"").hide();
        //});

        //鼠標移動到關閉按鈕，按鈕變紅色,移除變黑色
        //$(""#clo");
                WriteLiteral(@"se"").mouseover(function () {
        //    $(""#close span"").css(""color"", ""red"");
        //    $(""#close span"").css(""cursor"", ""default"");
        //});
        //$(""#close"").mouseout(function () {
        //    $(""#close span"").css(""color"", ""black"");
        //});
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prjCramSchoolSystemUser.ViewModel.COrderCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
