#pragma checksum "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1be3039b8e785a19d6a4475b378bb1746bbcddbf"
// <auto-generated/>
#pragma warning disable 1591
namespace RhinoWebUI.Client.Pages.Configurations
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using RhinoWebUI.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using RhinoWebUI.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
using RhinoWebUI.Shared.Models.Configurations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/configurations")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/configurations/{id:int}")]
    public partial class Configurations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.RhinoWebUI.Client.Pages.Configurations.Configurations.TypeInference.CreateMudTable_0(__builder, 0, 1, 
#nullable restore
#line 5 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                  configurationList

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 5 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                            true

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 5 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                              Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 5 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                                                       _loading

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 5 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                                                                                       Color.Dark

#line default
#line hidden
#nullable disable
            , 6, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(7);
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(9, "ID");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "# of Elements");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(15);
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(17, "# of Test");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(19);
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(21, "Actions");
                }
                ));
                __builder2.CloseComponent();
            }
            , 22, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(23);
                __builder2.AddAttribute(24, "DataLabel", "ID");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 13 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
__builder3.AddContent(26, context.Id);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(28);
                __builder2.AddAttribute(29, "DataLabel", "Elements");
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 14 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
__builder3.AddContent(31, context.NumberOfElements);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(33);
                __builder2.AddAttribute(34, "DataLabel", "Tests");
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 15 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
__builder3.AddContent(36, context.NumberOfTests);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(38);
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(40);
                    __builder3.AddAttribute(41, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 17 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                       Color.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 17 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                                         Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                                                                () =>
           ShowEditConfiguration(context)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(46, "Edit");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(48);
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(50);
                    __builder3.AddAttribute(51, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 22 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 22 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                       Color.Warning

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 22 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                                            Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                                                                   () =>
           DeleteConfiguration(context)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(56, "Delete");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 57, (__value) => {
#nullable restore
#line 5 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                                                                                                                         mudTable = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 28 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
  if (configurationList==null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudText>(58);
            __builder.AddAttribute(59, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 30 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                Typo.h6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "Align", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 30 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
                                Align.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "Class", "my-8 alert-info");
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(63, "\r\n                No matching configuration records found.\r\n            ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 33 "C:\Users\user\Desktop\Clone\source\repos\Rhino Work\RhinoWebClient\RhinoWebUI\Client\Pages\Configurations\Configurations.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RhinoWebUI.Client.Pages.Configurations.Configurations
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::MudBlazor.Color __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6, int __seq7, global::System.Action<global::MudBlazor.MudTable<T>> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "Loading", __arg3);
        __builder.AddAttribute(__seq4, "LoadingProgressColor", __arg4);
        __builder.AddAttribute(__seq5, "HeaderContent", __arg5);
        __builder.AddAttribute(__seq6, "RowTemplate", __arg6);
        __builder.AddComponentReferenceCapture(__seq7, (__value) => { __arg7((global::MudBlazor.MudTable<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
