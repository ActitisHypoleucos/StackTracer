using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.DomainLogic.DomainLogics.ProfonditaLogic.Interface;
using MyLog.DomainLogic.Enums;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.ProfonditaLogic
{
    public class ProfonditaCMD : IProfonditaCMD
    {
        //INSERT
        public bool insert(Profondita profondita, string connectString)
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
                        dbCMD.CommandText = string.Format(Query.insertProfondita,profondita.Livello_Tracciamento);
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

        //UPDATE
        public bool update(Profondita profondita, string connectString)
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
                        dbCMD.CommandText = string.Format(Query.updateProfondita, profondita.Livello_Tracciamento,profondita.id);
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

//COMPLETED