#pragma checksum "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ff60cc7240959f2577dfabc7abd587dcb77fd17"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
 
     string DiasdeVacaciones;
     string SalarioMensual;
     DateTime FechaInicio;
     DateTime FechaHoy;
     double salarioDiario;
    


#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                       

    public void sumar(){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                
        int _salarioMensual = Int32.Parse(SalarioMensual);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                     
        FechaHoy=DateTime.Now;
        Console.WriteLine(FechaHoy.ToString("MM/dd/yyyy"));
        double diferenciaDias= (FechaHoy - FechaInicio).TotalDays;

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                
        Console.WriteLine("Diferencia de puros Dias");
        Console.WriteLine(diferenciaDias);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                
        var diferenciaAnos=Convert.ToInt32(diferenciaDias/365);
        Console.WriteLine("Diferencia de años");
        Console.WriteLine(diferenciaAnos);


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                                               
        var diferenciaMeses =Convert.ToInt32((diferenciaDias - (diferenciaAnos*365))/30);
        Console.WriteLine("Diferencia de Meses");
        Console.WriteLine(diferenciaMeses);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                     
        var diferenciaSoloDias =Convert.ToInt32(diferenciaDias-(diferenciaAnos*365)-(diferenciaMeses*30));
        Console.WriteLine("Diferencia de solo dias");
        Console.WriteLine(diferenciaSoloDias);


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                        
        Console.WriteLine(_salarioMensual);
        salarioDiario=_salarioMensual/30;
        Console.WriteLine("El salario diario es");
        Console.WriteLine(salarioDiario);
         
    }


/*Utilidades*/

        private void LimpiarFormulario()
        {
        DiasdeVacaciones=string.Empty;
        SalarioMensual=string.Empty;
        FechaInicio=DateTime.Now;
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
#pragma warning restore 1591
