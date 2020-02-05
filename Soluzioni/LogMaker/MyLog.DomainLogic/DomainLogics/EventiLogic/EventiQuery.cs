using System;
using System.Data.SqlClient;
using MyLog.DomainLogic.DomainLogics.EventiLogic.Interface;
using MyLog.DomainLogic.Enums;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.EventiLogic
{
    public class EventiQuery : IEventiQuery
    {
        public Eventi GetEventoById(int id, string connectString)
        {
            Eventi evento = new Eventi();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetEventoById, id);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                evento.id = reader.GetInt32(0);
                                evento.id_Componente_FK = reader.GetInt32(1);
                                evento.id_Profondita_FK = reader.GetInt32(2);
                                evento.DataEvento = reader.GetDateTime(3);
                                evento.Messaggio = reader.GetString(4);
                                evento.StackTrace = reader.GetString(5);
                                evento.MetodoEvocatore = reader.GetString(6);
                            }
                        }
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
            return evento;
        }
        public Eventi GetEventoByCaller(string nome, string connectString)
        {
            Eventi evento = new Eventi();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetEventoByCaller, nome);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                evento.id = reader.GetInt32(0);
                                evento.id_Componente_FK = reader.GetInt32(1);
                                evento.id_Profondita_FK = reader.GetInt32(2);
                                evento.DataEvento = reader.GetDateTime(3);
                                evento.Messaggio = reader.GetString(4);
                                evento.StackTrace = reader.GetString(5);
                                evento.MetodoEvocatore = reader.GetString(6);
                            }
                        }
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
            return evento;
        }
        public Eventi GetEventoByDateEvent(DateTime dataEvento, string connectString)
        {
            Eventi evento = new Eventi();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetEventoByDateEvent, dataEvento);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                evento.id = reader.GetInt32(0);
                                evento.id_Componente_FK = reader.GetInt32(1);
                                evento.id_Profondita_FK = reader.GetInt32(2);
                                evento.DataEvento = reader.GetDateTime(3);
                                evento.Messaggio = reader.GetString(4);
                                evento.StackTrace = reader.GetString(5);
                                evento.MetodoEvocatore = reader.GetString(6);
                            }
                        }
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
            return evento;
        }
    }
}
