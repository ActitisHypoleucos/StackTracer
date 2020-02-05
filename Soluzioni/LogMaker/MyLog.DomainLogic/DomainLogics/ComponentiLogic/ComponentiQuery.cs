using System;
using System.Data.SqlClient;
using MyLog.DomainLogic.DomainLogics.ComponenteLogic.Interface;
using MyLog.DomainLogic.Enums;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.ComponentiLogic
{
    public class ComponentiQuery : IComponentiQuery
    {
        public Componenti GetComponenteById(int id, string connectString)
        {
            Componenti componente = new Componenti();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetComponenteById, id);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                componente.id = reader.GetInt32(0);
                                componente.NomeApplicazione = reader.GetString(1);
                                componente.Descrizione = reader.GetString(2);
                                componente.DataInserimento = reader.GetDateTime(3);
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
            return componente;
        }

        public Componenti GetComponenteByAppName(string nome, string connectString)
        {
            Componenti componente = new Componenti();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetComponenteByAppName, nome);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                componente.id = reader.GetInt32(0);
                                componente.NomeApplicazione = reader.GetString(1);
                                componente.Descrizione = reader.GetString(2);
                                componente.DataInserimento = reader.GetDateTime(3);
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
            return componente;
        }
    }
}

//COMPLETED