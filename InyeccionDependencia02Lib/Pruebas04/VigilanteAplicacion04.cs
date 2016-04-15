using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Lib.Pruebas01;

namespace InyeccionDependencia02Lib.Pruebas04 {
   /// <summary>
   /// [VigilanteAplicacion04] es como [VigilanteAplicacion] pero va a ser utilizado en
   /// otro ejemplo entonces se escribe aparte para dejar más separados los ejemplos.
   /// </summary>
   class VigilanteAplicacion04 {
      private INotificador _NotificadorActual = null;

      public VigilanteAplicacion04( INotificador instanciaNotificador ) {
         this._NotificadorActual = instanciaNotificador;
      }

      public void Notificar( String elMensaje ) {
         _NotificadorActual.EjecutarNotificacion( elMensaje );
      }
   } //class VigilanteAplicacion04
} //namespace InyeccionDependencia02Lib.Pruebas04