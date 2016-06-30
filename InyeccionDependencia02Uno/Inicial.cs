using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Uno.Controladores;

/*
*/
namespace InyeccionDependencia02Uno {
   class Inicial {
      static void Main( string[] args ) {
         new Inicial().Pruebas();
      }

      private void Pruebas() {
         //Prueba01();
         Prueba02_BuscarNombre();
      }

      private void Prueba02_BuscarNombre() {
         Console.Write( "Entre parte del nombre a buscar:" );
         var porcionNombreABuscar = Console.ReadLine();
         var listaNombresHallados = BuscarNombres( porcionNombreABuscar );

         if ( listaNombresHallados.Count < 1 ) {
            Console.WriteLine( "No se hallaron nombres" );
         }
         else {
            Console.WriteLine( "Nombres hallados:" );
            listaNombresHallados.ForEach( Console.WriteLine );
         }
      }

      private List<string> BuscarNombres( string porcionNombreABuscar ) {
         //Lista de nombres completos:
         var listaNombresCompletos = PersonaControlador.ListaNombresCompletos();

         //Obtener los que contengan [porcionNombreABuscar]:
         var listaNombresHallados = listaNombresCompletos.Where( nombreCompletoActual => nombreCompletoActual.ToUpper().Contains( porcionNombreABuscar.ToUpper() ) ).ToList();

         return listaNombresHallados;
      }

      private void Prueba01() {
         var listaNombresCompletos = PersonaControlador.ListaNombresCompletos();
         foreach ( var nombreCompletoActual in listaNombresCompletos ) {
            Console.WriteLine( nombreCompletoActual );
         }
      }
   } //class Inicial

} //namespace InyeccionDependencia02Uno