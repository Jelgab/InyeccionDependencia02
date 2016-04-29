using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia02Lib.Pruebas05 {
   public class DatosServicio : IDatosVarios {
      public String ObtenerFrase( String lasOpciones ) {
         var elResultado = "";

         using ( var clienteRequest = new WebClient() ) {
            var datosGet = $"http://baconipsum.com/api/?{lasOpciones}"; //Servicio que devuelve palabras (como lorem ipsum)

            try {
               elResultado = clienteRequest.DownloadString( datosGet );
            }
            catch ( Exception errorHaciendoRequest ) {
               elResultado = $"Hubo un error: {errorHaciendoRequest.Message}";
            }
         }

         return elResultado;
      } //public String ObtenerFrase( String lasOpciones )

   } //class DatosServicio : IDatosVarios

} //namespace InyeccionDependencia02Lib.Pruebas05