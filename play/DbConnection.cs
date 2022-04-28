using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace play
{
    static class DbConnection
    {
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shino\Desktop\play\play\resources\resources.mdb";

        private static string StackTrase { get; set; }

        public static List<Player> GetBestPlayers(int n)
        {
            List<Player> items = new List<Player>();
            OleDbConnection con = new OleDbConnection(connectionString);
            try
            {
              
                con.Open();
                string sql = "SELECT name, chore, best_time fROM players ORDER BY best_time DESC";
                OleDbCommand command = new OleDbCommand(sql, con);
                OleDbDataReader reader = command.ExecuteReader();
                int k = 0;
                while (reader.Read() && k<n)
                {
                    
                    string name = reader.GetString(0);
                    int schore = reader.GetInt32(1);
                    int time = reader.GetInt32(2);
                    items.Add(new Player( k+1, name, schore, time));
                    k++;
                }
                reader.Close();   
            }
            catch (OleDbException ex)
            {
                StackTrase += ex.Message;
            }
            catch (Exception ex)
            {
                StackTrase += ex.Message;
            }
            finally
            {
                con.Close();
            }
          
            
            return items;
           
        }
        

        public static bool saveRecord(Player item)
        {
            bool IsSuccess = true;
            if (item != null)
            {
                string query = "select * from players where name=\"" + item.Name + "\"";
                OleDbConnection connection = new OleDbConnection(connectionString);
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    bool flag = reader.HasRows;
                    reader.Close();
                    if (flag)
                    {
                        query = "update players set chore = schore+1, best_time=" + item.BestTime + " where name=\"" + item+"\"" ;
                        command = new OleDbCommand(query, connection);
                        flag = command.ExecuteNonQuery() > 0;
                    }
                    else
                    {
                        query = "insert into players (name, chore, best_time) values (\"" + item.Name + "\",1 ,"+ item.BestTime + ")";
                        command = new OleDbCommand(query, connection);
                        flag = command.ExecuteNonQuery() > 0;
                    }
                }
                catch (OleDbException ex)
                {
                    StackTrase += ex.Message;
                }
                catch (Exception ex)
                {
                    StackTrase += ex.StackTrace;
                }
                finally
                {
                    connection.Close();
                }
            }
            return IsSuccess;
        }
    }

}
