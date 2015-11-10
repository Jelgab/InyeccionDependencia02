using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Lib.Pruebas01;

namespace InyeccionDependencia02Lib.Pruebas01 {

   public class NotificarAMensajeTexto : INotificador {
      public void EjecutarNotificacion( string elMensaje ) {
         Console.WriteLine( $"Notificar por Mensaje Texto: {elMensaje}" );
      }
   }

}
