using InyeccionDependencia02Tests.TestAPruebas01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InyeccionDependencia02Tests.Tests01 {
   [TestClass]
   public class LosTests01 {

      [TestMethod]
      public void ProbarNotificacion01() {
         var notificadorSimulado01 = new NotificarSimulado();

         var vigilanteUno = new InyeccionDependencia02Lib.Pruebas01.VigilanteAplicacion( notificadorSimulado01 );
         vigilanteUno.Notificar( "Probando [VigilanteAplicacion] desde [ProbarNotificacion01]" );
      }

      [ TestMethod ]
      public void ProbarNotificacion02() {
         var notificadorSimulado02 = new NotificarSimulado();

         var vigilanteDos = new InyeccionDependencia02Lib.Pruebas02.VigilanteAplicacion02();
         vigilanteDos.Notificar( notificadorSimulado02, "Probando [VigilanteAplicacion02] desde [ProbarNotificacion02]" );
      }

      [ TestMethod ]
      public void ProbarNotificacion03() {
         var notificadorSimulado03 = new NotificarSimulado();
         
         var vigilanteTres = new InyeccionDependencia02Lib.Pruebas03.VigilanteAplicacion03();
         vigilanteTres.NotificadorActual = notificadorSimulado03;
         vigilanteTres.Notificar( "Probando[ VigilanteAplicacion03 ] desde[ ProbarNotificacion03 ]" );
      }

   } //public class LosTests01
} //namespace InyeccionDependencia02Tests.TestAPruebas01 {