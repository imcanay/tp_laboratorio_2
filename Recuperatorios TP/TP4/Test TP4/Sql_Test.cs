using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace Test_TP4
{
    [TestClass]
    public class Sql_Test
    {
        [TestMethod]
        [DataRow("Data Source = localhost; Database = FabricaMuebles; Trusted_Connection = True;")]
        public void SqlConexionTest(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            try
            {
                connection.Open();
                Assert.IsTrue(connection.State == System.Data.ConnectionState.Open);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }finally
            {
                connection.Close();
            }

        }

        [TestMethod]
        [DataRow("Data Source = localhost123; Database = FabricaMuebles; Trusted_Connection = True;")]
        [DataRow("Data Source = localhost; Database = FabricaDeOtraCosa; Trusted_Connection = True;")]
        public void SqlConexionTestFails(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {

                Assert.IsFalse(connection.State == System.Data.ConnectionState.Open);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
