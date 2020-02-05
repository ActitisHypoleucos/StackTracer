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
    public class ProfonditaQuery : IProfonditaQuery
    {
        public Profondita GetProfonditaById(int id, string connectString)
        {
            Profondita livello = new Profondita();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetProfonditaById, id);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                livello.id = reader.GetInt32(0);
                                livello.Livello_Tracciamento = reader.GetString(1);
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
            return livello;
        }

        public Profondita GetProfonditaByLevel(string nome, string connectString)
        {
            Profondita livello = new Profondita();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                using (SqlCommand dbCMD = new SqlCommand())
                {
                    try
                    {
                        dbCMD.CommandType = System.Data.CommandType.Text;
                        dbCMD.Connection = connection;
                        dbCMD.CommandText = string.Format(Query.GetProfonditaByLivello, nome);
                        connection.Open();
                        using (var reader = dbCMD.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                livello.id = reader.GetInt32(0);
                                livello.Livello_Tracciamento = reader.GetString(1);
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
            return livello;
        }
    }
}
