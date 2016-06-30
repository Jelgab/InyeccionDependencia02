using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia02Uno.Controladores {
   public class PersonaControlador {
      public static List<string> ListaNombresCompletos() {
         //Cadena de conexión:
         var conexionAdventureWorks = ConfigurationManager.ConnectionStrings[ "ConexionAdventureWorks" ].ConnectionString;

         //Orden de SQL:
         var scriptListaNombresCompletos = "SELECT TOP 50 FirstName + ' ' + ISNULL( MiddleName, ' ' ) + ' ' + LastName AS NombreCompleto FROM Person.Person";

         //Adapter:
         var PersonaAdaptador = new SqlDataAdapter( scriptListaNombresCompletos, conexionAdventureWorks );

         //Obtener los datos:
         var tablaNombresCompletos = new DataTable();
         PersonaAdaptador.Fill( tablaNombresCompletos );

         //Pasar a List<string>:
         var resultadoListaNombresCompletos = tablaNombresCompletos.AsEnumerable().Select( datoActual => datoActual["NombreCompleto"].ToString() ).ToList();

         return resultadoListaNombresCompletos;
      }

   } //public class PersonaControlador

} //namespace InyeccionDependencia02Uno.Controladores