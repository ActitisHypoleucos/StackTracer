using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.DomainLogic.DomainLogics.TracciamentiLogic.Interface;
using MyLog.DomainLogic.Enums;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.TracciamentiLogic
{
    public class TracciamentiCMD : ITracciamentiCMD
    {
        //INSERT
        public bool insert(Tracciamenti tracciamento, string connectString)
        {
            bool esito = false;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.insertTracciamenti,tracciamento.id_Componente_FK,tracciamento.id_Profondita_FK,tracciamento.DataUltimaModifica);
                        connection.Open();
                        esito = dbCMD.ExecuteNonQuery() > 0;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return esito;
        }
    }
}
