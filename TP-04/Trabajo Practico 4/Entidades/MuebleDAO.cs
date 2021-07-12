using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class MuebleDAO
    {
        private SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
        public int id;
        public string nombre;
        public Material materialBase;
        public Material materialEstantes;
        public Material materialTapizado;
        public ConsoleColor colorBase;
        public ConsoleColor colorEstantes;
        public ConsoleColor colorTapizado;
        public EColorBarniz colorBarniz;

        public MuebleDAO()
        {
          //  this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
           // this.comando = new SqlCommand();
            //this.comando.CommandType = System.Data.CommandType.Text; es text por defecto
           // this.comando.Connection = conexion;
        }
        public MuebleDAO(string nombre)
        {
         this.nombre = nombre;

        }
        //public List<Mueble> GetEntidadSQLs()
        //{
        //    this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
        //    this.comando = new SqlCommand();
        //    //this.comando.CommandType = System.Data.CommandType.Text; es text por defecto
        //    this.comando.Connection = conexion;
        //    List<Mueble> listaEntidadesSQL = new List<Mueble>();
        //    comando.CommandText = "SELECT id, nombre," +
        //                            " Material Base, Material Estantes, " +
        //                            "Material Tapizado, Color Base, Color Estantes, " +
        //                            "Color Tapizado, Color Barniz FROM ListaDemuebles";


        //    try
        //    {
        //        conexion.Open();
        //        SqlDataReader oDr = comando.ExecuteReader();

        //        while (oDr.Read())
        //        {

        //            string auxNombre = oDr["Nombre"].ToString();
        //            Material auxMaterialBase = (Material)oDr["Material Base"];

        //            ConsoleColor auxColorBase = (ConsoleColor)oDr["Color Base"];
        //            if (oDr["Material Estantes"] != null) //si tiene material estantes es ropero
        //            {
        //                Material auxMaterialEstantes = (Material)oDr["Material Estantes"];
        //                ConsoleColor auxColorEstantes = (ConsoleColor)oDr["Color Estantes"];
        //                EColorBarniz auxColorBarniz = (EColorBarniz)oDr["Color Barniz"];

        //                Ropero roperoAx = new Ropero(auxNombre, auxMaterialBase, auxMaterialEstantes);
        //                roperoAx.ColorBarniz = auxColorBarniz;
        //                roperoAx.ColorBase = auxColorBase;
        //                listaEntidadesSQL.Add(roperoAx);
        //            }
        //            else //sino es sillon
        //            {
        //                Material auxMaterialTapizado = (Material)oDr["Material Tapizado"];
        //                ConsoleColor auxColorTapizado = (ConsoleColor)oDr["Color Tapizado"];
        //                Sillon sillonAx = new Sillon(auxNombre, auxMaterialBase, auxMaterialTapizado);
        //                sillonAx.ColorBase = auxColorBase;
        //                sillonAx.ColorTapizado = auxColorTapizado;
        //                listaEntidadesSQL.Add(sillonAx);

        //            }





        //        }
        //        return listaEntidadesSQL;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;

        //    }
        //    finally
        //    {
        //        if (this.conexion.State != System.Data.ConnectionState.Closed)
        //        {
        //            this.conexion.Close();
        //        }
        //    }
        //}

        public bool Guardar(List<Mueble> ListaDemuebles)
        {
            Sillon sillonAx = new Sillon("SillonDB", Fabrica.listaDeMateriales[0],Fabrica.listaDeMateriales[2]);
            Ropero roperoAx;
            bool retorno = false;

            string query = "INSERT INTO ListaDeMuebles (Nombre, MaterialBase, MaterialEstantes,MaterialTapizado, ColorBase, ColorEstantes, ColorTapizado, ColorBarniz) VALUES (@Nombre,@Material Base,@Material Estantes,@Material Tapizado,@Color Base,@Color Estantes,@Color Tapizado,@Color Barniz)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            
            comando.Parameters.AddWithValue("@Nombre", sillonAx.Nombre);
            comando.Parameters.AddWithValue("@MaterialBase", sillonAx.MaterialBase.ToString());
            comando.Parameters.AddWithValue("@MaterialEstantes", DBNull.Value);
            comando.Parameters.AddWithValue("@MaterialTapizado", sillonAx.MaterialTapizado.ToString());
            comando.Parameters.AddWithValue("@ColorBase", (int)sillonAx.ColorBase);
            comando.Parameters.AddWithValue("@ColorEstantes", DBNull.Value);
            comando.Parameters.AddWithValue("@ColorTapizado", (int)sillonAx.ColorTapizado);
            comando.Parameters.AddWithValue("@ColorBarniz", DBNull.Value);
            comando.ExecuteNonQuery();
            retorno = true;
            conexion.Close();



            return retorno;
        }

    }
}
