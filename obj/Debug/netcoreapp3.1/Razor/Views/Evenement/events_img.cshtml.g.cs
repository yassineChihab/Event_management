#pragma checksum "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55112b1b04e9b539ae0bce7df5c013009968062b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Evenement_events_img), @"mvc.1.0.view", @"/Views/Evenement/events_img.cshtml")]
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
#line 1 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
using CoreMigration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55112b1b04e9b539ae0bce7df5c013009968062b", @"/Views/Evenement/events_img.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58b485b224f619325a8e163dff52b7b41e1a101", @"/Views/_ViewImports.cshtml")]
    public class Views_Evenement_events_img : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreMigration.Models.Activite>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
  
    ViewBag.Title = "events_img";
    Layout = "~/Views/Shared/_EvenementLayoutPage.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
  
    var i = 0;
    IEnumerable<Activite> Act = ViewData["activitie"] as IEnumerable<Activite>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55112b1b04e9b539ae0bce7df5c013009968062b3941", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
    <link href=""https://fonts.googleapis.com/css?family=Droid+Sans:400,700"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://rawgit.com/LeshikJanz/libraries/master/Bootstrap/baguetteBox.min.css"">
    <title>Gallerie des photos ENSA'S</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55112b1b04e9b539ae0bce7df5c013009968062b5440", async() => {
                WriteLiteral(@"
    <div id=""carousel-example-generic"" class=""carousel slide"" data-ride=""carousel"">
        <!-- Indicators -->
        <ol class=""carousel-indicators hidden"">
            <li data-target=""#carousel-example-generic"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carousel-example-generic"" data-slide-to=""1""></li>
            <li data-target=""#carousel-example-generic"" data-slide-to=""2""></li>
            <li data-target=""#carousel-example-generic"" data-slide-to=""3""></li>
        </ol>
        <!-- Wrapper for slides -->
        <div class=""carousel-inner"" role=""listbox"">
");
#nullable restore
#line 34 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
             foreach (Activite e in Act)
            {
                if (i == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"item active\">\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1595, "\"", 1615, 1);
#nullable restore
#line 39 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
WriteAttributeValue("", 1601, e.piece_joint, 1601, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-responsive"" alt=""..."">
                        <div>
                            <div class=""carousel-caption"">
                                <h2 class=""h1"">ENSA <span>SAFI</span></h2>
                                <p class=""h1"">
                                    ");
#nullable restore
#line 44 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
                               Write(e.titre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </p>\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1978, "\"", 2011, 2);
                WriteAttributeValue("", 1985, "/Evenement/activitie/", 1985, 21, true);
#nullable restore
#line 46 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
WriteAttributeValue("", 2006, e.id, 2006, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-default\">voir plus</a>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 50 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
                    i = 1;
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"item\">\n                        <img");
                BeginWriteAttribute("src", " src=\"", 2295, "\"", 2315, 1);
#nullable restore
#line 55 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
WriteAttributeValue("", 2301, e.piece_joint, 2301, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-responsive"" alt=""..."">
                        <div>
                            <div class=""carousel-caption"">
                                <h2 class=""h1"">ENSA <span>SAFI</span></h2>
                                <p class=""h1"">
                                    ");
#nullable restore
#line 60 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
                               Write(e.titre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </p>\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2678, "\"", 2711, 2);
                WriteAttributeValue("", 2685, "/Evenement/activitie/", 2685, 21, true);
#nullable restore
#line 62 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
WriteAttributeValue("", 2706, e.id, 2706, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-default\">Voir plus</a>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 66 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>
        <!-- -->
        <!-- Controls -->
        <a class=""left carousel-control"" href=""#carousel-example-generic"" role=""button"" data-slide=""prev"">
            <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""right carousel-control"" href=""#carousel-example-generic"" role=""button"" data-slide=""next"">
            <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
    <section class=""about text-center wow animate__bounceInUp"" style=""background-color: white;"" data-wow-duration="".8s"">
        <div class=""container"">
            <div class=""container gallery-container"">
                <h1>Découvrez notre galerie</h1>
                <div class=""tz-gallery"">
                    <div class=""row border border-primary"">
");
#nullable restore
#line 87 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
                         foreach (Activite e in Act)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-12 col-md-4\">\n                                <a class=\"lightbox\"");
                BeginWriteAttribute("href", " href=\"", 4004, "\"", 4036, 2);
                WriteAttributeValue("", 4011, "/Evenement/gallerie/", 4011, 20, true);
#nullable restore
#line 90 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
WriteAttributeValue("", 4031, e.id, 4031, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 4079, "\"", 4099, 1);
#nullable restore
#line 91 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
WriteAttributeValue("", 4085, e.piece_joint, 4085, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Bridge\">\n                                </a>\n                                <h3 style=\"text-align:center\">");
#nullable restore
#line 93 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
                                                         Write(e.titre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                            </div>\n");
#nullable restore
#line 95 "C:\Users\abc\Downloads\event-management-main\event-management-main\Views\Evenement\events_img.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </section>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<style>


    body {
        background-color: #434c50;
        min-height: 100vh;
        font: normal 16px sans-serif;
        padding: 40px 0;
    }

    .container.gallery-container {
        background-color: #fff;
        color: #35373a;
        min-height: 100vh;
        padding: 30px 50px;
    }

    .gallery-container h1 {
        text-align: center;
        margin-top: 50px;
        font-family: 'Droid Sans', sans-serif;
        font-weight: bold;
    }

    .gallery-container p.page-description {
        text-align: center;
        margin: 25px auto;
        font-size: 18px;
        color: #999;
    }

    .tz-gallery {
        padding: 40px;
    }

        /* Override bootstrap column paddings */
        .tz-gallery .row > div {
            padding: 2px;
        }

        .tz-gallery .lightbox img {
            width: 100%;
            border-radius: 0;
            position: relative;
        }

        .tz-gallery .lightbox:before {
            position: absolute;
            top: 50%;
");
            WriteLiteral(@"            left: 50%;
            margin-top: -13px;
            margin-left: -13px;
            opacity: 0;
            color: #fff;
            font-size: 26px;
            font-family: 'Glyphicons Halflings';
            content: '\e003';
            pointer-events: none;
            z-index: 9000;
            transition: 0.4s;
        }


        .tz-gallery .lightbox:after {
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            opacity: 0;
            background-color: rgba(46, 132, 206, 0.7);
            content: '';
            transition: 0.4s;
        }

        .tz-gallery .lightbox:hover:after,
        .tz-gallery .lightbox:hover:before {
            opacity: 1;
        }

    .baguetteBox-button {
        background-color: transparent !important;
    }

    ");
            WriteLiteral("@media(max-width: 768px) {\n        body {\n            padding: 0;\n        }\n    }\n\n    ");
            WriteLiteral("@media (min-width: 992px) {\n        .col-md-4 {\n            width: 100%;\n        }\n    }\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreMigration.Models.Activite>> Html { get; private set; }
    }
}
#pragma warning restore 1591
