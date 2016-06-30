using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Uno.Controladores;

namespace InyeccionDependencia02Uno {
   class Inicial {
      static void Main( string[] args ) {
         new Inicial().Prueba01();
      }

      private void Prueba01() {
         var listaNombresCompletos = PersonaControlador.ListaNombresCompletos();
      }
   } //class Inicial

} //namespace InyeccionDependencia02Uno