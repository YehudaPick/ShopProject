#pragma checksum "/Users/yehuda.pick/Projects/new/ShopProject/ShopProject/Views/ShoppingCarts/EmptyShoppingCarts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad722545120b9e5a9d9e83f7b35e74c0758c1167"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCarts_EmptyShoppingCarts), @"mvc.1.0.view", @"/Views/ShoppingCarts/EmptyShoppingCarts.cshtml")]
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
#line 1 "/Users/yehuda.pick/Projects/new/ShopProject/ShopProject/Views/_ViewImports.cshtml"
using ShopProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yehuda.pick/Projects/new/ShopProject/ShopProject/Views/_ViewImports.cshtml"
using ShopProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad722545120b9e5a9d9e83f7b35e74c0758c1167", @"/Views/ShoppingCarts/EmptyShoppingCarts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab9dd8f6a7b5e92355807c4f7c958220aa37b51", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCarts_EmptyShoppingCarts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Models.ProductInCart>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/yehuda.pick/Projects/new/ShopProject/ShopProject/Views/ShoppingCarts/EmptyShoppingCarts.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""text-center p-3 mt-3 bg-light opacity rounded-1 text-danger font-weight-bold"">העגלות שלי</h2>


<div class=""container btn-block"" style=""background-color:none !important"">
  <h4 class=""bg-light opacity p-5 m-5 text-center text-danger"" style=""align-items:center; direction:rtl;"">אין עגלות קודמות.</h4>
</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Models.ProductInCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
