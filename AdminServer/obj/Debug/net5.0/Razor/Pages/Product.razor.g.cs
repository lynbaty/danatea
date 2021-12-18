#pragma checksum "D:\Danatea\danatea\adminserver\Pages\Product.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305dffbbba948dcfaa12074a743f29b8cc8b2f46"
// <auto-generated/>
#pragma warning disable 1591
namespace AdminServer.Pages
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Danatea\danatea\adminserver\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Danatea\danatea\adminserver\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Danatea\danatea\adminserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Danatea\danatea\adminserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Danatea\danatea\adminserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Danatea\danatea\adminserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Danatea\danatea\adminserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Danatea\danatea\adminserver\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Danatea\danatea\adminserver\_Imports.razor"
using AdminServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Danatea\danatea\adminserver\_Imports.razor"
using AdminServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Danatea\danatea\adminserver\_Imports.razor"
using Dtos.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Danatea\danatea\adminserver\_Imports.razor"
using Dtos.Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Danatea\danatea\adminserver\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Danatea\danatea\adminserver\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Danatea\danatea\adminserver\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product")]
    public partial class Product : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
 if (Products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 7 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "bg-white p-8 rounded-md w-full");
            __builder.AddMarkupContent(3, @"<div class="" flex items-center justify-between pb-6""><div><h2 class=""text-gray-600 font-semibold"">Product List</h2>
			<span class=""text-xs"">All product item</span></div>
		<div class=""flex items-center justify-between""><div class=""flex bg-gray-50 items-center p-2 rounded-md""><input class=""bg-gray-50 outline-none ml-1 block "" type=""text"" name id placeholder=""search...""></div>
				<div class=""lg:ml-40 ml-10 space-x-8""><a href=""createproduct"" class=""bg-green-600 px-4 text-white btn"">Create</a></div></div></div>
		");
            __builder.OpenElement(4, "div");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "-mx-4 sm:-mx-8 px-4 sm:px-8 py-4 overflow-x-auto");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "inline-block min-w-full shadow rounded-lg overflow-hidden");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "min-w-full leading-normal");
            __builder.AddMarkupContent(11, @"<thead><tr><th class=""tb-header"">
									Id
								</th>
								<th class=""tb-header"">
									Name
								</th>
								<th class=""tb-header"">
									Description
								</th>
								<th class=""tb-header"">
									DateCreated
								</th>
								<th class=""tb-header"">
									Price
								</th></tr></thead>
						");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 54 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
                              foreach (var product in Products)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "class", "tb-line");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "text-gray-900 whitespace-no-wrap");
            __builder.AddContent(18, 
#nullable restore
#line 58 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
                                                                                         product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                                        ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "class", "tb-line");
            __builder.OpenElement(22, "p");
            __builder.AddAttribute(23, "class", "text-gray-900 whitespace-no-wrap");
            __builder.AddContent(24, 
#nullable restore
#line 61 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
                                                                                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                        ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "class", "tb-line");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "text-gray-900 whitespace-no-wrap");
            __builder.AddContent(30, 
#nullable restore
#line 64 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
                                                                                         product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                        ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "tb-line");
            __builder.OpenElement(34, "p");
            __builder.AddAttribute(35, "class", "text-gray-900 whitespace-no-wrap");
            __builder.AddContent(36, 
#nullable restore
#line 67 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
                                                                                         product.DateCreated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                        ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "class", "tb-line");
            __builder.OpenElement(40, "p");
            __builder.AddAttribute(41, "class", "text-gray-900 whitespace-no-wrap");
            __builder.AddContent(42, 
#nullable restore
#line 70 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
                                                                                         product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "D:\Danatea\danatea\adminserver\Pages\Product.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
