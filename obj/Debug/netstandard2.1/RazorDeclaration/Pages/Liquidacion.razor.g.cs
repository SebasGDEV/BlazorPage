#pragma checksum "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d7ae82e713e89706011c9e7370c36b0b12e9ee4"
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
#line 60 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
 
     string DiasdeVacaciones;
     string SalarioMensual;
     DateTime FechaInicio, FechaTerminacion;
     double salarioDiario,  pagoVacaciones, noventaDiasSalario, doceDiasSalario, 
     _salarioMensual, _diasdeVacaciones;

     int Aguinaldo=0;
     

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                           

    public void sumar(){

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                
        _salarioMensual = Convert.ToDouble(SalarioMensual);
        _diasdeVacaciones=Convert.ToDouble(DiasdeVacaciones);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                     
        Console.WriteLine(FechaTerminacion.ToString("MM/dd/yyyy"));

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                                                         
        int currentyear=Convert.ToInt32(FechaTerminacion.ToString("yyyy"));
        System.Console.WriteLine("Año en curso: " + currentyear);
        string FechaAnioEnCursoString=("01/01/"+currentyear);
        DateTime FechaAnioEnCurso=Convert.ToDateTime(FechaAnioEnCursoString);
        System.Console.WriteLine("Fecha concatenada del año en curso: "  + FechaAnioEnCurso);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                              
        var DiasAnioEnCurso1=FechaTerminacion-FechaAnioEnCurso;
        int DiasAnioEnCurso=(int)(DiasAnioEnCurso1.TotalDays);
        System.Console.WriteLine("Dias del Año en curso restadas: " + DiasAnioEnCurso);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                                       

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
#line 99 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                       
        Console.WriteLine("RESULTADO");
        Console.WriteLine(years + " Años");
        Console.WriteLine(months + " Meses");
        Console.WriteLine(dayss + " Dias");

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                            
        Console.WriteLine(_salarioMensual);
        salarioDiario=(_salarioMensual/30);
        Console.WriteLine("El salario diario es: "+ salarioDiario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                        
        pagoVacaciones=salarioDiario*_diasdeVacaciones;
        Console.WriteLine("Pago de vacaciones: "+ pagoVacaciones);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                 
        noventaDiasSalario=salarioDiario*90;
        Console.WriteLine("90 dias de salario: "+ noventaDiasSalario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                 
        doceDiasSalario=salarioDiario*12*years;
        Console.WriteLine("12 dias de salario: "+ doceDiasSalario);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                         
        Aguinaldo=Convert.ToInt32(((salarioDiario*15)/365.25)*DiasAnioEnCurso);
        Console.WriteLine("Aguinaldo es: "+ Aguinaldo);


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\SGARCORO\Documents\GitHub\BlazorPage\Pages\Liquidacion.razor"
                                     



         
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
