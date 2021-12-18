#pragma checksum "D:\Danatea\danatea\adminserver\Pages\Category.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d4685df6f361cedfbf6e7ddc0b2fcac64985469"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/category")]
    public partial class Category : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
 if (Categories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "bg-white p-8 rounded-md w-full");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                          Request

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                                   HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "class", "grid grid-cols-3 space-x-5 align-middle");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\t\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\t\t\t");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "flex justify-between align-middle space-x-5");
                __builder2.AddMarkupContent(14, "<h1>Danh mục cấp 1</h1>\r\n\t\t\t\t");
                __Blazor.AdminServer.Pages.Category.TypeInference.CreateInputSelect_0(__builder2, 15, 16, "bg-gray-300 rounded-md border-1 border-gray-800 px-3 py-2 pr-2", 17, 
#nullable restore
#line 17 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                           Request.ParentId

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Request.ParentId = __value, Request.ParentId)), 19, () => Request.ParentId, 20, (__builder3) => {
#nullable restore
#line 18 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                 foreach (var cate in Categories)
					{

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(21, "option");
                    __builder3.AddAttribute(22, "value", 
#nullable restore
#line 20 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                        cate.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(23, 
#nullable restore
#line 20 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                                  cate.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 21 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
					}

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\t\t\t");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "w-auto");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-bl w-full");
                __builder2.AddAttribute(29, "placeholder", "Search...");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                         Request.Search

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Request.Search = __value, Request.Search))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Request.Search));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\t\t\t");
                __builder2.AddMarkupContent(34, "<div><button type=\"submit\" class=\"btn bg-gray-300 text-gray-800 hover:bg-gray-800 hover:text-white\">Submit</button>\r\n\t\t\t\t<a href=\"createcategory\" class=\"btn bg-green-200 text-green-800 hover:bg-green-800 hover:text-white\">Create</a></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 33 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
         if(ChildCategories != null)
		{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "div");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "-mx-4 sm:-mx-8 px-4 sm:px-8 py-4 overflow-x-auto");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "inline-block min-w-full shadow rounded-lg overflow-hidden");
            __builder.OpenElement(40, "table");
            __builder.AddAttribute(41, "class", "min-w-full leading-normal");
            __builder.AddMarkupContent(42, @"<thead><tr><th class=""tb-header"">
										Id
									</th>
									<th class=""tb-header"">
										Name
									</th>
									<th class=""tb-header"">
										SortOrder
									</th>
									<th class=""tb-header"">
										IsHome
									</th>
									<th class=""tb-header"">
										Action
									</th></tr></thead>
							");
            __builder.OpenElement(43, "tbody");
#nullable restore
#line 64 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                 foreach (var category in ChildCategories)
									{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "tr");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "class", "tb-line");
            __builder.OpenElement(47, "p");
            __builder.AddAttribute(48, "class", "text-gray-900 whitespace-no-wrap");
            __builder.AddContent(49, 
#nullable restore
#line 68 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                                                                             category.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "class", "tb-line");
            __builder.OpenElement(53, "p");
            __builder.AddAttribute(54, "class", "text-gray-900 whitespace-no-wrap");
            __builder.AddContent(55, 
#nullable restore
#line 71 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                                                                             category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "class", "tb-line");
            __builder.OpenElement(59, "p");
            __builder.AddAttribute(60, "class", "text-gray-900 whitespace-no-wrap");
            __builder.AddContent(61, 
#nullable restore
#line 74 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                                                                             category.SortOrder

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "class", "tb-line");
            __builder.OpenElement(65, "p");
            __builder.AddAttribute(66, "class", "text-gray-900 whitespace-no-wrap");
            __builder.AddContent(67, 
#nullable restore
#line 77 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                                                                             category.IsHome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(69, "td");
            __builder.AddAttribute(70, "class", "tb-line");
            __builder.AddMarkupContent(71, "<a href=\"EditCategory\" class=\"text-blue-800 font-semibold whitespace-no-wrap\">Edit</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
                                                                  () =>Delete(category.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
									}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 91 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 93 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "D:\Danatea\danatea\adminserver\Pages\Category.razor"
       
    private IReadOnlyList<CategoryDto> Categories { get; set; }


	public CategoryRequestDto Request {set; get;}
	public IReadOnlyList<CategoryDto> ChildCategories { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Categories = await httpClient.GetFromJsonAsync<IReadOnlyList<CategoryDto>>("category");
		Request = new CategoryRequestDto();
		await LoadCate();
	}
	
	private async Task HandleValidSubmit(EditContext context){
		await LoadCate();
	}

	public async Task Delete(int id){
		await httpClient.DeleteAsync("category/" + id);
		await LoadCate();
	}
	public async Task LoadCate (){
		ChildCategories = await httpClient.GetFromJsonAsync<IReadOnlyList<CategoryDto>>($"category?parentid={Request.ParentId}&search={Request.Search}");
		StateHasChanged();
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.AdminServer.Pages.Category
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
