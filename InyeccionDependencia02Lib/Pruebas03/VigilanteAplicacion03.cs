using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Lib.Pruebas01;

namespace InyeccionDependencia02Lib.Pruebas03 {

   public class VigilanteAplicacion03 {

      public INotificador NotificadorActual { get; set; }

      public void Notificar( String elMensaje ) {
         NotificadorActual.EjecutarNotificacion( elMensaje );
      }

   } //class VigilanteAplicacion02

}
