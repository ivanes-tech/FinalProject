#pragma checksum "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "043c4ba345ed6d768c21b6cac76f445a85bf208a"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalProject.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/brahiam/ProgIII/FinalProject/_Imports.razor"
using FinalProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editarcliente")]
    public partial class EditarCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Clientes</h3>\n<hr>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<label>Ingrese la cédula del cliente:</label>\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "Cedula");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                                                                cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                       Cargar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "btn btn-outline-success");
            __builder.AddContent(18, "Cargar Cliente");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n<hr>\n");
#nullable restore
#line 18 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
 if (activated == true && enable == true)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "container");
            __builder.AddMarkupContent(24, "\n    ");
            __builder.OpenElement(25, "form");
            __builder.AddAttribute(26, "class", "form");
            __builder.AddMarkupContent(27, "\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "\n            ");
            __builder.AddMarkupContent(31, "<label>Nombre</label>\n            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "placeholder", "Nombre");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                                                                          nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nombre = __value, nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "\n            ");
            __builder.AddMarkupContent(42, "<label>Apellido</label>\n            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "placeholder", "Apellido");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                                                                            apellido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => apellido = __value, apellido));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.AddMarkupContent(52, "\n            ");
            __builder.AddMarkupContent(53, "<label>Correo</label>\n            ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "placeholder", "Correo");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                                                                          correo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => correo = __value, correo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n\n        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group");
            __builder.AddMarkupContent(63, "\n            ");
            __builder.AddMarkupContent(64, "<label>Licencia</label>\n            ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "placeholder", "Licencia ");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                                                                             licencia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => licencia = __value, licencia));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n\n        ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group");
            __builder.AddMarkupContent(74, "\n            ");
            __builder.AddMarkupContent(75, "<label>Nacionalidad</label>\n            ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "class", "form-control");
            __builder.AddAttribute(78, "placeholder", "Nacionalidad");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                                                                                nacionalidad

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nacionalidad = __value, nacionalidad));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n\n        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-group");
            __builder.AddMarkupContent(85, "\n            ");
            __builder.AddMarkupContent(86, "<label>Tipo de sangre</label>\n            ");
            __builder.OpenElement(87, "select");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                                                tipodesangre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tipodesangre = __value, tipodesangre));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(91, "\n");
#nullable restore
#line 51 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                 foreach (var bld in Blood())
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                    ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", 
#nullable restore
#line 53 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                                    bld.IdSangre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, 
#nullable restore
#line 53 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                                                   bld.Sangre1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n");
#nullable restore
#line 54 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n        <hr>\n        ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
                           Editar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "class", "btn btn-outline-success");
            __builder.AddContent(103, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\n    <hr>\n    ");
            __builder.OpenElement(107, "h3");
            __builder.AddContent(108, 
#nullable restore
#line 62 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
         notification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n");
#nullable restore
#line 63 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
}
else if (activated == true && enable == false){


#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "    ");
            __builder.AddMarkupContent(111, "<h2>No hay un ciudadano registrado con esa cédula.</h2>\n");
#nullable restore
#line 67 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "/home/brahiam/ProgIII/FinalProject/Pages/EditarCliente.razor"
      

    string cedula;
    string nombre;
    string apellido;
    string correo;
    string licencia;
    string nacionalidad;
    int tipodesangre;

    string notification = "";

    bool enable = true;
    bool activated = false;

    Clientes cliente = null;
    rentcarContext db;


    protected override void OnInitialized()
    {
        db = new rentcarContext(rentar);
    }

    List<Sangre> Blood() => db.Sangre.ToList();
    void Cargar()
    {

        cliente = db.Clientes.Where(C => C.Cedula == cedula).SingleOrDefault();

        if (cliente == null)
        {

            enable = false;
        }
        else
        {

            nombre = cliente.Nombre;
            apellido = cliente.Apellido;
            correo = cliente.Correo;
            licencia = cliente.Licencia;
            nacionalidad = cliente.Nacionalidad;
            tipodesangre = cliente.SangreIdSangre;
        }

        activated = true;

    }
    void Editar()
    {

        try
        {
            cliente.Cedula = cedula;
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Correo = correo;
            cliente.Licencia = licencia;
            cliente.Nacionalidad = nacionalidad;
            cliente.SangreIdSangre = tipodesangre;


            db.SaveChanges();
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
            notification = "La edición no se pudo realizar";

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DbContextOptions<rentcarContext> rentar { get; set; }
    }
}
#pragma warning restore 1591
