#pragma checksum "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04b10d1da776790fbcc56d249d3665adf8ad955c"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/liquidacion")]
    public partial class Liquidacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.AddMarkupContent(1, "<h1>     Calculadora de Liquidación    </h1>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "width: 20rem;");
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n    <br>  <br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_0(__builder, 5, 6, "txtSalarioMensual", 7, 
#nullable restore
#line 13 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                              true

#line default
#line hidden
#nullable disable
            , 8, "Salario Mensual", 9, 
#nullable restore
#line 13 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
            , 10, "width:-webkit-fill-available;", 11, 
#nullable restore
#line 14 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 12, 
#nullable restore
#line 13 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                       SalarioMensual

#line default
#line hidden
#nullable disable
            , 13, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SalarioMensual = __value, SalarioMensual)), 14, () => SalarioMensual);
            __builder.AddMarkupContent(15, "\r\n    <br><br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatTextField_1(__builder, 16, 17, "txtDiasdeVacaciones", 18, 
#nullable restore
#line 16 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
            , 19, "Dias de Vacaciones", 20, 
#nullable restore
#line 16 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
            , 21, "width:-webkit-fill-available;", 22, 
#nullable restore
#line 17 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 23, 
#nullable restore
#line 16 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                         DiasdeVacaciones

#line default
#line hidden
#nullable disable
            , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DiasdeVacaciones = __value, DiasdeVacaciones)), 25, () => DiasdeVacaciones);
            __builder.AddMarkupContent(26, "\r\n    <br><br>\r\n    ");
            __Blazor.Blazor.Pages.Liquidacion.TypeInference.CreateMatDatePicker_2(__builder, 27, 28, "FechaIniciodeLabores", 29, "Fecha inicio de labores", 30, 
#nullable restore
#line 19 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                       true

#line default
#line hidden
#nullable disable
            , 31, 
#nullable restore
#line 19 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                                                                  true

#line default
#line hidden
#nullable disable
            , 32, "width:-webkit-fill-available;", 33, 
#nullable restore
#line 20 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                             true

#line default
#line hidden
#nullable disable
            , 34, 
#nullable restore
#line 19 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                                           FechaInicio

#line default
#line hidden
#nullable disable
            , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FechaInicio = __value, FechaInicio)), 36, () => FechaInicio);
            __builder.AddMarkupContent(37, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "contenedor");
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatButton>(41);
            __builder.AddAttribute(42, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "style", "width: 6rem;");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                             LimpiarFormulario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(46, "Limpiar");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatButton>(48);
            __builder.AddAttribute(49, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "style", "width: 13rem;");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(52, "Calcular");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
 
     string DiasdeVacaciones;
     string SalarioMensual;
     string FechaInicio;
    


/*Utilidades*/

        private void LimpiarFormulario(){
        DiasdeVacaciones=string.Empty;
        SalarioMensual=string.Empty;
        FechaInicio=string.Empty;
        
        

        }
    
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await js.InvokeVoidAsync("focusById", "txtSalarioMensual");
            }
        }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.Blazor.Pages.Liquidacion
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Required", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Required", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMatDatePicker_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Required", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "EnableWeekNumbers", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
