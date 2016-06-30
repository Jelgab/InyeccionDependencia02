using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia02Uno.Lib {
   public class DatosPersonaOperaciones {

      public static List<string> BuscarNombres( string porcionNombreABuscar, IDatosPersona objetoDatosPersona ) {
         //Lista de nombres completos:
         var listaNombresCompletos = objetoDatosPersona.ObtenerListaNombresCompletos();

         //Obtener los que contengan [porcionNombreABuscar]:
         var listaNombresHallados = listaNombresCompletos.Where( nombreCompletoActual => nombreCompletoActual.ToUpper().Contains( porcionNombreABuscar.ToUpper() ) ).ToList();

         return listaNombresHallados;
      }

   } //public class DatosPersonaOperaciones
} //namespace InyeccionDependencia02Uno.Lib