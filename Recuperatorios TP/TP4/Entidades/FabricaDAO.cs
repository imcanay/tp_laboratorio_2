using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FabricaDAO
    {
        public SqlConnection connection;
        public string connectionString = "Data Source = localhost; Database = FabricaMuebles; Trusted_Connection = True;";
        public SqlCommand command;
        public SqlDataReader reader;

        public FabricaDAO()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
           
        }

        public List<Mueble> GetListaDeMuebles()
        {
            List<Mueble> listaMuebles = new List<Mueble>();
            command.CommandText = "SELECT * FROM ListaDeMuebles";
            command.Connection = connection;
            Sillon auxSillon = new Sillon();
            Ropero auxRopero = new Ropero();
            try
            {

                connection.Open();
            reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Tipo"].ToString() == "Sillon")
                    {
                        auxSillon.Nombre = reader["Nombre"].ToString();
                        auxSillon.MaterialBase = (Material)reader["MaterialBase"].ToString();
                        auxSillon.MaterialTapizado = (Material)reader["MaterialTapizado"].ToString();
                        auxSillon.ColorBase =(ConsoleColor)reader["ColorBase"];
                        auxSillon.ColorTapizado = (ConsoleColor)reader["ColorTapizado"];
                        listaMuebles.Add(auxSillon);
                    }
                    else if (reader["Tipo"].ToString() == "Ropero")
                    {
                        auxRopero.Nombre = reader["Nombre"].ToString();
                        auxRopero.MaterialBase = (Material)reader["MaterialBase"].ToString();
                        auxRopero.MaterialEstantes = (Material)reader["MaterialEstantes"].ToString();
                        auxRopero.ColorBase = (ConsoleColor)reader["ColorBase"];
                        auxRopero.ColorEstantes = (ConsoleColor)reader["ColorEstantes"];
                        auxRopero.ColorBarniz = (EColorBarniz)reader["ColorBarniz"];
                        listaMuebles.Add(auxRopero);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaMuebles;
        }
    public bool InsertListaDeMuebles(List<Mueble> listaDeMuebles)
        {
            bool retorno = false;
            
            connection.ConnectionString = connectionString;
    
            Sillon auxSillon = new Sillon();
            Ropero auxRopero = new Ropero();
            command.CommandText = "INSERT INTO ListaDeMuebles values(@Nombre,@MaterialBase,@MaterialEstantes,@MaterialTapizado,@ColorBase,@ColorEstantes,@ColorTapizado,@ColorBarniz,@Tipo)";
            command.Connection = connection;
            try
            {
                connection.Open();
                foreach (var item in listaDeMuebles)
                {
                    if (item.GetType() == typeof(Sillon))
                    {
                        auxSillon = (Sillon)item;
                        command.Parameters.Add(new SqlParameter("Nombre", auxSillon.Nombre));
                        command.Parameters.Add(new SqlParameter("MaterialBase", auxSillon.MaterialBase.ToString()));
                        command.Parameters.Add(new SqlParameter("MaterialEstantes", ""));//materialestantes
                        command.Parameters.Add(new SqlParameter("MaterialTapizado", auxSillon.MaterialTapizado.ToString()));
                        command.Parameters.Add(new SqlParameter("ColorBase", (int)auxSillon.ColorBase));
                        command.Parameters.Add(new SqlParameter("ColorEstantes", 1));//colorestantes
                        command.Parameters.Add(new SqlParameter("ColorTapizado", (int)auxSillon.ColorTapizado));
                        command.Parameters.Add(new SqlParameter("ColorBarniz", 1));//color barniz
                        command.Parameters.Add(new SqlParameter("Tipo", "Sillon"));
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();

                    }
                    else if (item.GetType() == typeof(Ropero))
                    {
                        auxRopero = (Ropero)item;
                        command.Parameters.Add(new SqlParameter("Nombre", auxRopero.Nombre));
                        command.Parameters.Add(new SqlParameter("MaterialBase", auxRopero.MaterialBase.ToString()));
                        command.Parameters.Add(new SqlParameter("MaterialEstantes", auxRopero.MaterialEstantes.ToString()));
                        command.Parameters.Add(new SqlParameter("MaterialTapizado", ""));//materialtapizado
                        command.Parameters.Add(new SqlParameter("ColorBase", (int)auxRopero.ColorBase));
                        command.Parameters.Add(new SqlParameter("ColorEstantes", (int)auxRopero.ColorEstantes));
                        command.Parameters.Add(new SqlParameter("ColorTapizado", 1));//colortapizado
                        command.Parameters.Add(new SqlParameter("ColorBarniz", (int)auxRopero.ColorBarniz));
                        command.Parameters.Add(new SqlParameter("Tipo", "Ropero"));
                        
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();

                    }
                    else
                    {
                        throw new Exception("Esta ingresando algo que no es un mueble");
                    }
                }
                retorno = true;
            }

            catch (Exception)
            {

                throw;
            }finally
            {
                connection.Close();

            }
                
           



            return retorno;        
        }

    }
}
