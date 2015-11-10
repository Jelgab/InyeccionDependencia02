using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Lib.Pruebas01;

namespace InyeccionDependencia02Lib.Pruebas02 {

   public class VigilanteAplicacion02 {

      public void Notificar( INotificador notificadorActual, String elMensaje ) {
         notificadorActual.EjecutarNotificacion( elMensaje );
      }

   } //class VigilanteAplicacion02

}
