#pragma checksum "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b1a837a42e9da5b89ff39c719f335d20a7e1bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderList), @"mvc.1.0.view", @"/Views/Order/OrderList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b1a837a42e9da5b89ff39c719f335d20a7e1bc", @"/Views/Order/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d32ed70855580ea7ceb2069ad0d7dfa76919d5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjCramSchoolSystemUser.ViewModel.COrderListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
  
    ViewData["Title"] = "我的訂單";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""breadcrumb__text"">
                    <h2>我的訂單</h2>
                </div>
            </div>
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""breadcrumb__links"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 514, "\"", 539, 1);
#nullable restore
#line 17 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
WriteAttributeValue("", 521, Url.Content("~/"), 521, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">首頁</a>
                    <span>我的訂單</span>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Shopping Cart Section Begin -->
<section id=""divOrderCreate"" class=""shopping-cart spad"" style=""padding-top:50px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

");
#nullable restore
#line 31 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                  if (Model != null && Model.Count()!=0)
                    {
                        foreach (var item in Model)
                        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <table class=\"table\" style=\"border: 2px solid #dee2e6;\">\r\n                                <thead>\r\n                                    <tr>\r\n                                        <th scope=\"col\">訂單編號  ");
#nullable restore
#line 38 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                                         Write(item.order.FOrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                        <th scope=""col"">訂單日期</th>
                                        <th scope=""col"">訂單金額</th>
                                        <th scope=""col"">訂購人</th>
                                        <th scope=""col"">付款狀態</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th scope=""row"">
");
#nullable restore
#line 49 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                             if (item.order_detail_count != null && item.order_detail_count.Count != 0)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                                 foreach (var detail in item.order_detail_count)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <h6><span>");
#nullable restore
#line 53 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                                         Write(detail.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span style=\"margin-left:5px;\">×");
#nullable restore
#line 53 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                                                                                            Write(detail.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n");
#nullable restore
#line 54 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </th>\r\n                                        <td>");
#nullable restore
#line 57 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                       Write(item.order.FCreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>$");
#nullable restore
#line 58 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                        Write(item.Price.ToString("###,###,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                        <td>");
#nullable restore
#line 68 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                       Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 69 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                                       Write(item.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><button type=\"button\" class=\"btn btn-primary\" style=\"background-color: #FFFFFF; color: #AAAAAA; border: 1px solid #AAAAAA; \"");
            BeginWriteAttribute("onclick", " onclick=\"", 3473, "\"", 3555, 4);
            WriteAttributeValue("", 3483, "location.href=\'", 3483, 15, true);
#nullable restore
#line 70 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
WriteAttributeValue("", 3498, Url.Content("~/Order/ReviewOrder/"), 3498, 36, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
WriteAttributeValue("", 3534, item.order.FOrderId, 3534, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3554, "\'", 3554, 1, true);
            EndWriteAttribute();
            WriteLiteral(">查看訂單詳情</button></td>\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n");
#nullable restore
#line 74 "D:\prjuser\prjCramSchoolSystemUser\Views\Order\OrderList.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjCramSchoolSystemUser.ViewModel.COrderListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
