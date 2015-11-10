using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Lib.Pruebas01;

namespace InyeccionDependencia02Lib.Pruebas01 {

   public class VigilanteAplicacion {
      private INotificador notificadorActual = null;

      public VigilanteAplicacion( INotificador instanciaNotificador ) {
         this.notificadorActual = instanciaNotificador;
      }

      public void Notificar( String elMensaje ) {
         notificadorActual.EjecutarNotificacion( elMensaje );
      }
   } //class VigilanteAplicacion {

} //namespace InyeccionDependencia02Consola.Pruebas01 {