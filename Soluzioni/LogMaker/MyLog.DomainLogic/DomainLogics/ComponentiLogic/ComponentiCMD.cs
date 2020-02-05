using System;
using System.Data.SqlClient;
using MyLog.DomainLogic.DomainLogics.ComponenteLogic.Interface;
using MyLog.DomainLogic.Enums;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.ComponentiLogic
{
    public class ComponentiCMD : IComponentiCMD
    {
        //INSERT
        public bool insert(Componenti componente, string connectString)
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
                        dbCMD.CommandText = string.Format(Query.insertComponente, componente.NomeApplicazione, componente.Descrizione, componente.DataInserimento);
                        connection.Open();
                        esito = dbCMD.ExecuteNonQuery() > 0; //è andato tutto bene o male
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
        public bool update(Componenti componente, string connectString)
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
                        dbCMD.CommandText = string.Format(Query.updateComponente, componente.NomeApplicazione, componente.Descrizione, componente.DataInserimento, componente.id);
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