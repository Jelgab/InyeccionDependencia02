using System;
using InyeccionDependencia02Lib.Pruebas01;

namespace InyeccionDependencia02Tests.TestAPruebas01 {

   public class NotificarSimulado : INotificador {
      public void EjecutarNotificacion( String elMensaje ) {
         Console.WriteLine( $"Este es un mock. No notifica a ninguna parte. Mensaje a notificar: {elMensaje}" );
      }
   }

}
