// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AdminServer.Pages
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using AdminServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using AdminServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using Dtos.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using Dtos.Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "d:\Danatea\danatea\AdminServer\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "d:\Danatea\danatea\AdminServer\_Imports.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "d:\Danatea\danatea\AdminServer\Pages\Category.razor"
       
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
#pragma warning restore 1591
