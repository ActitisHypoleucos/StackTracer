using System;
using System.Data.SqlClient;
using MyLog.DomainLogic.DomainLogics.TracciamentiLogic.Interface;
using MyLog.DomainLogic.Enums;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.TracciamentiLogic
{
    public class TracciamentiQuery : ITracciamentiQuery
    {
        public Tracciamenti GetTracciamentoByComponent(int id, string connectString)
        {
            Tracciamenti tracciamento = new Tracciamenti();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetTracciamentoByComponent, id, connectString);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //tracciamento.id = reader.GetInt32(0);
                                tracciamento.id_Componente_FK = reader.GetInt32(0);
                                tracciamento.id_Profondita_FK = reader.GetInt32(1);
                                tracciamento.DataUltimaModifica = reader.GetDateTime(2);
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
            return tracciamento;
        }

        public Tracciamenti GetTracciamentoByDepth(int id, string connectString)
        {
            Tracciamenti tracciamento = new Tracciamenti();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetTracciamentoByDepth, id, connectString);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //tracciamento.id = reader.GetInt32(0);
                                tracciamento.id_Componente_FK = reader.GetInt32(1);
                                tracciamento.id_Profondita_FK = reader.GetInt32(2);
                                tracciamento.DataUltimaModifica = reader.GetDateTime(3);
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
            return tracciamento;
        }

        public Tracciamenti GetTracciamentoByDate(DateTime date, string connectString)
        {
            Tracciamenti tracciamento = new Tracciamenti();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetTracciamentoByDate, date, connectString);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //tracciamento.id = reader.GetInt32(0);
                                tracciamento.id_Componente_FK = reader.GetInt32(1);
                                tracciamento.id_Profondita_FK = reader.GetInt32(2);
                                tracciamento.DataUltimaModifica = reader.GetDateTime(3);
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
            return tracciamento;
        }


        public Tracciamenti GetTracciamentoByComponentAndDepth(int id_C, int id_P, string connectString)
        {
            Tracciamenti tracciamento = new Tracciamenti();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetTracciamentoByDepth, id_C, id_P, connectString);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //tracciamento.id = reader.GetInt32(0);
                                tracciamento.id_Componente_FK = reader.GetInt32(1);
                                tracciamento.id_Profondita_FK = reader.GetInt32(2);
                                tracciamento.DataUltimaModifica = reader.GetDateTime(3);
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
            return tracciamento;
        }
    }
}

//COMPLETED