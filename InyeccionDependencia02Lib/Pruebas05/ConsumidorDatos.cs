using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia02Lib.Pruebas05 {
   public class ConsumidorDatos {
      private IDatosVarios _DatosServicioActual;

      //Constructor:
      public ConsumidorDatos( IDatosVarios instanciaParaDatos ) {
         _DatosServicioActual = instanciaParaDatos;
      }

      //Métodos, etc:
      public void MostrarDatos( String lasOpciones ) {
         var resultadoObtenidoDeInstanciaParaDatosInyectada = _DatosServicioActual.ObtenerFrase( lasOpciones );

         Console.WriteLine( $"Datos obtenidos: \r\n {resultadoObtenidoDeInstanciaParaDatosInyectada}" );
      }

   } //class ConsumidorDatos
} //namespace InyeccionDependencia02Lib.Pruebas05