#pragma checksum "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "123886e157fefd3b65f75774b24bac215ce08b31"
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
#line 33 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
 
     string DiasdeVacaciones;
     string SalarioMensual;
     DateTime FechaInicio, FechaTerminacion;
     double salarioDiario=0,  pagoVacaciones=0, noventaDiasSalario=0, doceDiasSalario=0, aguinaldo=0,
     _salarioMensual, _diasdeVacaciones;
     

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                           

    public void sumar(){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                
        _salarioMensual = Convert.ToDouble(SalarioMensual);
        _diasdeVacaciones=Convert.ToDouble(DiasdeVacaciones);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                     
        Console.WriteLine(FechaTerminacion.ToString("MM/dd/yyyy"));

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                         
        int anio=Convert.ToInt32(FechaTerminacion.ToString("yyyy"));
        System.Console.WriteLine("aniiio " + anio);
        

        string FechaAnioConcatenada=("01/01/"+anio);
        System.Console.WriteLine("Fecha concatenada del año en curso pero con 011" + FechaAnioConcatenada);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                       

        Console.WriteLine("Proceamiento de las fechas");
        var yearsOld = FechaTerminacion - FechaInicio;
        Console.WriteLine("Dias del test: "+ yearsOld);
        int years = (int)(yearsOld.TotalDays / 365.25);
        int months = (int)(((yearsOld.TotalDays / 365.25) - years) * 12);
        int dayss= (int)(( ( ( ( yearsOld.TotalDays / 365.25) - years) * 12)-months)*30.5);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                       
        Console.WriteLine("RESULTADO");
        Console.WriteLine(years + " Años");
        Console.WriteLine(months + " Meses");
        Console.WriteLine(dayss + " Dias");

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                            
        Console.WriteLine(_salarioMensual);
        salarioDiario=(_salarioMensual/30);
        Console.WriteLine("El salario diario es: "+ salarioDiario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                        
        pagoVacaciones=salarioDiario*_diasdeVacaciones;
        Console.WriteLine("Pago de vacaciones: "+ pagoVacaciones);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                 
        noventaDiasSalario=salarioDiario*90;
        Console.WriteLine("90 dias de salario: "+ noventaDiasSalario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                 
        doceDiasSalario=salarioDiario*12*years;
        Console.WriteLine("12 dias de salario: "+ doceDiasSalario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                       

        aguinaldo=salarioDiario*15;
        Console.WriteLine("Aguinaldo es: "+aguinaldo);


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                     



         
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
