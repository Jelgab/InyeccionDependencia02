using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia02Uno.Lib {
   class DatosPersonaMock01 : IDatosPersona {

      public List<string> ObtenerListaNombresCompletos() {
         return new List< string > { "Test name ABC", "Test name 123", "Test name I II III", "Test name A1", "Test name &", "Test name xyz", "Test name   ", };
      }

   } //class DatosPersonaMock01 : IDatosPersona
} //namespace InyeccionDependencia02Uno.Lib