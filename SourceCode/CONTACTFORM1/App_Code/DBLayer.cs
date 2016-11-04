using System;
using System.Data;
using System.Data.SqlClient;
//To get details from web.config
using System.Configuration;
//

public class DBLayer
{
    //Connection
    public static SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings.Get("ConnectionString"));
    public static bool SaveEmailDetails(string Name, string EMAIL, string MESSAGE)
    {
        try
        {
            //Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SAVEFORMDATA";
            cmd.CommandType = CommandType.StoredProcedure;
            //Parameters for command
            SqlParameter prmName = new SqlParameter("@NAME", Name);
            SqlParameter prmEmail = new SqlParameter("@EMAILID", EMAIL);
            SqlParameter prmMessage = new SqlParameter("@MESSAGE", MESSAGE);
            //Add parameters to command
            cmd.Parameters.Add(prmName);
            cmd.Parameters.Add(prmEmail);
            cmd.Parameters.Add(prmMessage);
            conn.Open();
            //Execute the command
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
        finally
        {
            //Close connection here
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }


    public static int ValidateLoginCredentials(string LoginName, string Password)
    {
        try
        {
            //Declare command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ISVALIDUSER";
            cmd.CommandType = CommandType.StoredProcedure;
            //Parameters for command
            SqlParameter prmUserName = new SqlParameter("@USERNAME", LoginName);
            SqlParameter prmPassword = new SqlParameter("@PASSWORD", Password);
            //Add parameters to command
            cmd.Connection = conn;
            cmd.Parameters.Add(prmUserName);
            cmd.Parameters.Add(prmPassword);
            //open connection
            conn.Open();



            //execute the command
            var count = (int)cmd.ExecuteScalar();
            //connection close
            conn.Close();

            return count;
        }
        catch
        {
            return 0;
        }
        finally
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}