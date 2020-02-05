using System;
using System.Data.SqlClient;
using MyLog.DomainLogic.DomainLogics.EventiLogic.Interface;
using MyLog.DomainLogic.Enums;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.EventiLogic
{
    public class EventiCMD : IEventiCMD
    {
        //INSERT
        public bool insert(Eventi evento, string connectString)
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
                        dbCMD.CommandText = string.Format(Query.insertEvento, evento.id_Componente_FK, evento.id_Profondita_FK, evento.Messaggio, evento.StackTrace, evento.MetodoEvocatore);
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
        public bool update(Eventi evento, string connectString)
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
                        dbCMD.CommandText = string.Format(Query.updateEvento, evento.id_Componente_FK, evento.id_Profondita_FK, evento.DataEvento, evento.Messaggio, evento.StackTrace, evento.MetodoEvocatore, evento.id);
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

    }//CLASS
}

//COMPLETED