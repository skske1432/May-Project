#pragma checksum "D:\back up - 20220428\Nait courses\done spring term - 2021\CPSC1517\Assignment\git repos\2021-may-project-skske1432\src\May-Project-YoungjaeLee\May-Project-YoungjaeLee\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dc5ecf0ee6ced6b8942033ce89caf6598ec0df8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(May_Project_YoungjaeLee.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace May_Project_YoungjaeLee.Pages
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
#line 1 "D:\back up - 20220428\Nait courses\done spring term - 2021\CPSC1517\Assignment\git repos\2021-may-project-skske1432\src\May-Project-YoungjaeLee\May-Project-YoungjaeLee\Pages\_ViewImports.cshtml"
using May_Project_YoungjaeLee;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dc5ecf0ee6ced6b8942033ce89caf6598ec0df8", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfdbb8edd1aff00d214511e924643b032823b2b6", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\back up - 20220428\Nait courses\done spring term - 2021\CPSC1517\Assignment\git repos\2021-may-project-skske1432\src\May-Project-YoungjaeLee\May-Project-YoungjaeLee\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Query page description</h1>
    <p>Query page will basically list all the ProgramCourses in the database. In addition to that, it also has a filter option that filters the result by a selected program. 
    It also has a link to edit/add a program course.</p>
    <h1 class=""display-4"">CRUD page description</h1>
    <p>CRUD page will have an option to create, update, and deactivate the program course. It also has a drop-down list to select a program and course.
     It also has a filter option to filter the drop-down menus for course input. In addition, it also has a button to cancel the page and direct the user to the Query page.</p>
    <h1 class=""display-4"">ERD</h1> 
    <img src=""img/ERD.png"" alt=""ERD"">
    <p>Site Styling Decision: awsm.css</p>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
