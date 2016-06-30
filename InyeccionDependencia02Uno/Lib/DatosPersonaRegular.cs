using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InyeccionDependencia02Uno.Controladores;

namespace InyeccionDependencia02Uno.Lib {
   class DatosPersonaRegular : IDatosPersona {

      public List< string > ObtenerListaNombresCompletos() {
         var listaNombresCompletos = PersonaControlador.ListaNombresCompletos();
         return listaNombresCompletos;
      }

   } //class DatosPersonaRegular : IDatosPersona
} //namespace InyeccionDependencia02Uno.Lib {