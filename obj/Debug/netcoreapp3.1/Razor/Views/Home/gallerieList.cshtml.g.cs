#pragma checksum "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Home\gallerieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ded0998d93712ee076ae858a7b13debe86142d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_gallerieList), @"mvc.1.0.view", @"/Views/Home/gallerieList.cshtml")]
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
#line 1 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\_ViewImports.cshtml"
using CoreMigration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Home\gallerieList.cshtml"
using CoreMigration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ded0998d93712ee076ae858a7b13debe86142d", @"/Views/Home/gallerieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58b485b224f619325a8e163dff52b7b41e1a101", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_gallerieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Home\gallerieList.cshtml"
  
    ViewBag.Title = "gallerieList";
    Layout = "~/Views/Shared/_Layout.cshtml";
    IEnumerable<Activite> Act = ViewData["listgallerie"] as IEnumerable<Activite>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div>
        <div class=""card card-danger"">
            <div class=""card-header"">
                <h3 class=""card-title"">Events</h3>

            </div>
            <div class=""card-body p-0"">
                <table class=""table table-striped projects"">
                    <thead>
                        <tr>
                            <th style=""width: 1%"">
                                ID
                            </th>
                            <th style=""width: 20%"">
                                Event Title
                            </th>

                            <th style=""width: 20%"">
                                Event Date
                            </th>


                            <th style=""width: 8%"" class=""text-center"">

                            </th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 38 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Home\gallerieList.cshtml"
                         foreach (var e in Act)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>\n                                    ");
#nullable restore
#line 42 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Home\gallerieList.cshtml"
                               Write(e.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    <a>\n                                        ");
#nullable restore
#line 46 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Home\gallerieList.cshtml"
                                   Write(e.titre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </a>\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 50 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Home\gallerieList.cshtml"
                               Write(e.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n\n                                <td class=\"project-actions text-right\">\n                                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1842, 2);
            WriteAttributeValue("", 1812, "/Home/gallerieListImages/", 1812, 25, true);
#nullable restore
#line 54 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Home\gallerieList.cshtml"
WriteAttributeValue("", 1837, e.id, 1837, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-list"">
                                        </i>
                                        Voir Les images
                                    </a>
                                </td>
                            </tr>
");
#nullable restore
#line 61 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Home\gallerieList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n            <!-- /.card-body -->\n        </div>\n    </div>\n\n\n\n\n\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
