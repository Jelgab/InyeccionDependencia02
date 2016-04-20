using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Lib.Pruebas01;
using Microsoft.Practices.Unity;

namespace InyeccionDependencia02Consola {

   class Inicial {
      #region Principal
      static void Main( string[] args ) {
         new Inicial().Pruebas();
      }

      private void Pruebas() {
         Prueba_01();
         Separador();
         Prueba_02();
         Separador();
         Prueba_03();
         Separador();
         Prueba_04();
      }
      #endregion Principal

      #region Pruebas
      private void Prueba_04() {
         Console.WriteLine("Prueba 04 \r\n");
         var elContenedor = new UnityContainer();

         //Indicar qué tipo de Notificador se va a inyectar:
         elContenedor.RegisterType< INotificador, NotificarALog >();

         //Reemplaza a var vigilanteUno = new InyeccionDependencia02Lib.Pruebas04.VigilanteAplicacion04( new NotificarALog() ):
         var vigilanteUno = elContenedor.Resolve< InyeccionDependencia02Lib.Pruebas04.VigilanteAplicacion04 >(); //[Resolve()] crea una nueva instancia del tipo [VigilanteAplicacion04], toma el constructor,  mira de qué
                                                                                                                 //tipo es el parámetro del constructor (Interface [INotificador] en este caso), busca si esta instancia de
                                                                                                                 //[elContenedor] tiene un tipo registrado que se adhiera a esa interface y si lo halla le entrega una nueva
                                                                                                                 //instancia de este tipo al constructor de [VigilanteAplicacion04]. O sea que en este caso [Resolve()] 
                                                                                                                 //creará una instancia VigilanteAplicacion04(New NotificarALog()) y el resultado tipo VigilanteAplicacion04
                                                                                                                 //será entregado a [vigilanteUno]. [vigilanteUno] es entonces del tipo VigilanteAplicacion04.

         //Llamar la rutina de Notificar con vigilanteUno:
         vigilanteUno.Notificar( "vigilanteUno notificando. Se creó usando UnityContainer" );

         Separador( '.' );

         //Registrar otro tipo de notificador:
         elContenedor.RegisterType< INotificador, NotificarACorreo >(); //Después de esto, cuando se use Resolve, no se asignará una instancia del tipo [NotificarALog] sino del tipo [NotificarACorreo].

         //Reemplaza a var vigilanteDos = new InyeccionDependencia02Lib.Pruebas04.VigilanteAplicacion04( new NotificarACorreo() ):
         var vigilanteDos = elContenedor.Resolve< InyeccionDependencia02Lib.Pruebas04.VigilanteAplicacion04 >(); //Crea nueva instancia [VigilanteAplicacion04], inyecta instancia tipo [NotificarACorreo]

         //Llamar la rutina de Notificar con vigilanteDos:
         vigilanteDos.Notificar("También se creó con UnityContainer, después de registrar tipo NotificarACorreo ");

         Separador( '.' );

         //Solo para mostrar que [vigilanteUno] no es afectado por los cambios posteriores a [elContenedor]:
         vigilanteUno.Notificar( "vigilanteUno notificando. Después de haber registrado y usado otro tipo de Notificador (NotificarACorreo)." );

         Separador( '.' );

         //Registrar otro tipo de notificador:
         elContenedor.RegisterType< INotificador, NotificarAMensajeTexto >(); //Después de esto, cuando se use Resolve, inyectará new NotificarAMensajeTexto()

         //Reemplaza a var vigilanteTres = new InyeccionDependencia02Lib.Pruebas04.VigilanteAplicacion04( new NotificarAMensajeTexto() ):
         var vigilanteTres = elContenedor.Resolve< InyeccionDependencia02Lib.Pruebas04.VigilanteAplicacion04 >();

         //Notificar:
         vigilanteTres.Notificar( "vigilanteTres notificando. vigilanteTres se creó después de registrar el tipo de Notificador NotificarAMensajeTexto" );
      } //private void Prueba_04()

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

         //Mostrar forma simplificada:
         var vigilanteSimpleUno = new VigilanteAplicacion( new NotificarALog() );
         vigilanteSimpleUno.Notificar( "Vigilante Simple #1" );

         new VigilanteAplicacion( new NotificarACorreo() ).Notificar( "Vigilante Simple #2" );
      }
      #endregion Pruebas

      #region Común
      private void Separador( Char caracterSeparador = '_' ) { //No usar default si se pasa a una librería. Usar overload.
         Console.WriteLine( $"\r\n\r\n{"".PadLeft( 120, caracterSeparador )}\r\n\r\n" );
      }
      #endregion Común

   } //class Inicial

} //namespace InyeccionDependencia02Consola {