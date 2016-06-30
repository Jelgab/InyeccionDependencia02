using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Uno.Controladores;
using InyeccionDependencia02Uno.Lib;

/*
*/
namespace InyeccionDependencia02Uno {
   class Inicial {
      static void Main( string[] args ) {
         new Inicial().Pruebas();
      }

      private void Pruebas() {
       //Prueba01_MostrarTodosLosNombres();
       //Prueba02_BuscarNombre();
         Prueba03_BuscarNombre_SinObjetoDatosPersona();
      }

      private void Prueba03_BuscarNombre_SinObjetoDatosPersona() {
         Console.Write( "Entre parte del nombre a buscar:" );
         var porcionNombreABuscar = Console.ReadLine();

         var listaNombresHallados = DatosPersonaOperaciones.BuscarNombres( porcionNombreABuscar );

         if ( listaNombresHallados.Count < 1 ) {
            Console.WriteLine( "No se hallaron nombres" );
         } else {
            Console.WriteLine( "Nombres hallados:" );
            listaNombresHallados.ForEach( Console.WriteLine );
         }
      }

      private void Prueba02_BuscarNombre() {
         Console.Write( "Entre parte del nombre a buscar:" );
         var porcionNombreABuscar = Console.ReadLine();

         var listaNombresHallados = DatosPersonaOperaciones.BuscarNombres( porcionNombreABuscar, new DatosPersonaRegular() );

         if ( listaNombresHallados.Count < 1 ) {
            Console.WriteLine( "No se hallaron nombres" );
         }
         else {
            Console.WriteLine( "Nombres hallados:" );
            listaNombresHallados.ForEach( Console.WriteLine );
         }
      }

      private void Prueba01_MostrarTodosLosNombres() {
         var listaNombresCompletos = PersonaControlador.ListaNombresCompletos();
         foreach ( var nombreCompletoActual in listaNombresCompletos ) {
            Console.WriteLine( nombreCompletoActual );
         }
      }
   } //class Inicial

} //namespace InyeccionDependencia02Uno