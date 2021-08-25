using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace OVERTIME_PROJECT_01
{
    public class Utils
    {
        #region variables
        public static int personelUnvanId;
        public static int personelId;
        public static string personelKullaniciAdi;
        public static int personelTabloIndex;
        public static int mesaiId;
        public static int mesaiDurumId;
        public static int onayId;
        public static bool isSelected;
        #endregion variables

        #region sql_baglanti
        private static string connStr = "Data Source=.;Initial Catalog=OVERTIME_SYSTEM;Integrated Security=True";
        private static SqlConnection sqlConnection;

        private static string ConnectionString()
        {
            return connStr;
        }

        private static void ConnectionSupply()
        {
            sqlConnection = new SqlConnection(ConnectionString());

            try
            {
                OpenConnection();
            }
            catch(Exception)
            {                
            }
        }

        private static void OpenConnection()
        {
            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        private static void CloseConnection()
        {
            if(sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public static DataTable CreateTable(string command)
        {
            ConnectionSupply();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            CloseConnection();
            return dataTable;
        }

        public static bool ExecuteCommand(string command)
        {
            ConnectionSupply();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                CloseConnection();
                throw e;
                return false;
            }
        }
        public static bool ExecuteCommandByParameter(string command,byte[] img_binary_data_array,int shift_id)
        {
            ConnectionSupply();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@arr", img_binary_data_array);
            sqlCommand.Parameters.AddWithValue("@shift_id", shift_id);

            try
            {
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
                sqlCommand.Dispose();
                CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                CloseConnection();
                throw e;
                return false;
            }
        }
        
        public static int ReturnIntegerSingleValue(string command)
        {
            int value=0;
            ConnectionSupply();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                value =  Convert.ToInt32(sqlCommand.ExecuteScalar(),null);
                CloseConnection();
                return value;
                
            }
            catch
            {
                CloseConnection();
                return value;
            }
        }
        public static string ReturnStringSingleValue(string command)
        {
            string value = "";
            ConnectionSupply();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                value = sqlCommand.ExecuteScalar().ToString() ;
                CloseConnection();
                return value;

            }
            catch
            {
                CloseConnection();
                return value;
            }
        }        
        public static byte[] ReturnByteArraySingleValue(string command)
        {
            byte[] value = null;
            ConnectionSupply();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            try
            {
                value = (byte[])sqlCommand.ExecuteScalar();
                CloseConnection();
                return value;

            }
            catch
            {
                CloseConnection();
                return value;
            }
        }
        #endregion sql_baglanti

        #region hour_calculate
        public static string Calculate_Hours(DateTime firstDate,DateTime secondDate)
        {
            double difference=0;
            double fraction = 0;
            string hour = "";
            TimeSpan hour_difference = secondDate - firstDate;
            difference = hour_difference.TotalHours;
            fraction = difference - Math.Truncate(difference);
            fraction = fraction * 60;
            fraction = Math.Round(fraction);
            difference = Math.Truncate(difference);

            if (fraction == 60)
            {
                difference = ++difference;
                if (difference >= 10)
                {
                    hour = difference.ToString() + ":" + "00";
                }
                else
                {
                    hour = "0"+difference.ToString() + ":" + "00";
                }
            }
            else
            {
                if (difference >= 10)
                {
                    if (fraction >= 10)
                    {
                        hour =  difference.ToString() + ":" + fraction;
                    }
                    else
                    {
                        hour = difference.ToString() + ":" +"0"+ fraction;
                    }
                }
                else
                {
                    if (fraction >= 10)
                    {
                        hour = "0"+difference.ToString() + ":" + fraction;
                    }
                    else
                    {
                        hour = "0"+difference.ToString() + ":" + "0" + fraction;
                    }
                }             
                
            }
            return hour;
        }
        #endregion hour_calculate

    }
}
