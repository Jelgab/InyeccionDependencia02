using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia02Consola {

   class Inicial {
      static void Main( string[] args ) {
         new Inicial().Pruebas();
      }

      private void Pruebas() {
         Prueba_01();
         Separador();
         Prueba_02();
         Separador();
         Prueba_03();
      }

      private void Separador() {
         Console.WriteLine( $"\r\n\r\n{"".PadLeft( 120, '_' )}\r\n\r\n" );
      }

      private void Prueba_03() {
         //Crear tres tipos distintos de notificadores
         var notificadorPorLog01          = new InyeccionDependencia02Lib.Pruebas01.NotificarALog();
         var notificadorPorCorreo01       = new InyeccionDependencia02Lib.Pruebas01.NotificarACorreo();
         var notificadorPorMensajeTexto01 = new InyeccionDependencia02Lib.Pruebas01.NotificarAMensajeTexto();

         var vigilanteUno = new InyeccionDependencia02Lib.Pruebas03.VigilanteAplicacion03();
         vigilanteUno.NotificadorActual = notificadorPorLog01;
         vigilanteUno.Notificar( "Vigilante Tres" );

         vigilanteUno.NotificadorActual = notificadorPorCorreo01;
         vigilanteUno.Notificar( "Vigilante Tres" );

         vigilanteUno.NotificadorActual = notificadorPorMensajeTexto01;
         vigilanteUno.Notificar( "Vigilante Tres" );
      }

      private void Prueba_02() {
         //Crear tres tipos distintos de notificadores
         var notificadorPorLog01          = new InyeccionDependencia02Lib.Pruebas01.NotificarALog();
         var notificadorPorCorreo01       = new InyeccionDependencia02Lib.Pruebas01.NotificarACorreo();
         var notificadorPorMensajeTexto01 = new InyeccionDependencia02Lib.Pruebas01.NotificarAMensajeTexto();

         var vigilanteUno = new InyeccionDependencia02Lib.Pruebas02.VigilanteAplicacion02();
         vigilanteUno.Notificar( notificadorPorLog01         , "Vigilante Dos" );
         vigilanteUno.Notificar( notificadorPorCorreo01      , "Vigilante Dos" );
         vigilanteUno.Notificar( notificadorPorMensajeTexto01, "Vigilante Dos" );
      }

      private void Prueba_01() {
         //Crear tres tipos distintos de notificadores
         var notificadorPorLog01          = new InyeccionDependencia02Lib.Pruebas01.NotificarALog();
         var notificadorPorCorreo01       = new InyeccionDependencia02Lib.Pruebas01.NotificarACorreo();
         var notificadorPorMensajeTexto01 = new InyeccionDependencia02Lib.Pruebas01.NotificarAMensajeTexto();

         //Crear una nueva instancia de vigilante, inyectarle el Notificador por Log, guardarla en [vigilanteUno]:
         var vigilanteUno = new InyeccionDependencia02Lib.Pruebas01.VigilanteAplicacion( notificadorPorLog01 );
         vigilanteUno.Notificar( "Vigilante Uno" );

         //Crear una nueva instancia de vigilante, inyectarle el Notificador por Correo, guardarla en [vigilanteUno]:
         vigilanteUno = new InyeccionDependencia02Lib.Pruebas01.VigilanteAplicacion( notificadorPorCorreo01 );
         vigilanteUno.Notificar( "Vigilante Uno" );

         //Crear una nueva instancia de vigilante, inyectarle el Notificador por Mensaje Texto, guardarla en [vigilanteUno]:
         vigilanteUno = new InyeccionDependencia02Lib.Pruebas01.VigilanteAplicacion( notificadorPorMensajeTexto01 );
         vigilanteUno.Notificar( "Vigilante Uno" );
      }
   }

} //namespace InyeccionDependencia02Consola {