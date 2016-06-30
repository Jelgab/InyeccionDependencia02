using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Uno.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InyeccionDependencia02Uno.Tests {
   [TestClass]
   public class DatosPersonaOperacionesTests {

      #region Común
      private static void MostrarResultados( List<string> listaNombresHallados ) {
         if ( listaNombresHallados.Count < 1 ) {
            Console.WriteLine( "No se hallaron nombres" );
         } else {
            Console.WriteLine( "Nombres hallados:" );
            listaNombresHallados.ForEach( Console.WriteLine );
         }
      }
      #endregion Común

      #region Tests

      [ TestMethod ]
      public void BuscarNombresTest03_DatoQueNoExiste() {
         var porcionNombreABuscar = "---NO EXISTE---";

         var listaNombresHallados = DatosPersonaOperaciones.BuscarNombres( porcionNombreABuscar, new DatosPersonaMock01() );

         MostrarResultados( listaNombresHallados );
      }

      [TestMethod ]
      public void BuscarNombresTest02_EspacioEnBlanco() {
         var porcionNombreABuscar = " ";

         var listaNombresHallados = DatosPersonaOperaciones.BuscarNombres( porcionNombreABuscar, new DatosPersonaMock01() );

         MostrarResultados( listaNombresHallados );
      }

      [TestMethod ]
      public void BuscarNombresTest01_Letras() {
         var porcionNombreABuscar = "ab";

         var listaNombresHallados = DatosPersonaOperaciones.BuscarNombres( porcionNombreABuscar, new DatosPersonaMock01() );

         MostrarResultados( listaNombresHallados );
      }
      #endregion Tests

      //public void BuscarNombresTest01()

   } //class DatosPersonaOperacionesTests
} //namespace InyeccionDependencia02Uno.Tests