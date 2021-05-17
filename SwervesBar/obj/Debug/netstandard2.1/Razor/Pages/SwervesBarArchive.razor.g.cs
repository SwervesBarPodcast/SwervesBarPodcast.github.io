#pragma checksum "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3468a540a3b445e8be4198d21942c1b02a6db148"
// <auto-generated/>
#pragma warning disable 1591
namespace SwervesBar.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using SwervesBar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\_Imports.razor"
using SwervesBar.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/swervesArchive")]
    public partial class SwervesBarArchive : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Swerve\'s Bar Archive</h1>\r\n");
#nullable restore
#line 5 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"
 if (comics == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 8 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-hover");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead>
            <tr>
                <th scope=""col"">Episode</th>
                <th scope=""col"">Comic Description</th>
                <th scope=""col"">Broadcaster</th>
                <th scope=""col"">Link</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 21 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"
             foreach (var comic in comics)
            {


#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"
                         comic.Episode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"
                         comic.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"
                         comic.Broadcasters

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", 
#nullable restore
#line 28 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"
                                 comic.Link

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, "Click Here");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 30 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "  \r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 34 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\austi\OneDrive\Desktop\Podcast_Site\SwervesBarPodcast.github.io\SwervesBar\Pages\SwervesBarArchive.razor"
       

    //Added Comic object. Didn't want to flood the page with a lot of table rows for each individual episode.
    // Now all details about the comics are stored in comics.json file so that we only need to edit the json file
    // comics.json is in wwwroot folder
    private Comic[] comics;

    protected override async Task OnInitializedAsync()
    {
        comics = await Http.GetFromJsonAsync<Comic[]>("comic-episodes/comics.json");
    }

    public class Comic
    {
        public int Episode { get; set; }
        public string Description { get; set; }
        public string Broadcasters { get; set; }
        public string Link { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
