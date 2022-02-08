using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;

public class Util
{
    public static string connectionstring = @"Data Source =.; Initial Catalog = MyProject; Integrated Security = True";
    public static DataTable f_GetServerNameSQL()
    {
        SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
        DataTable table = instance.GetDataSources();
        string ServerName = Environment.MachineName;
        return table;
    }
    public static int RunSql(string query)
    {
        using (SqlConnection conn = new SqlConnection(connectionstring))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    int a = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return a;

                }
                catch (Exception ex) { return -1; }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
    public static DataTable GetData(string sql)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                    cmd.Dispose();
                    return dt;
                }
            }
        }
        catch (Exception ex) { return null; }
    }

    public static DataSet GetDataSet(string sql)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    DataSet dt = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                    cmd.Dispose();
                    return dt;
                }
            }
        }
        catch (Exception ex) { return null; }


    }
    public static DataTable GetData(string sql, SqlParameter[] param)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(dt);
                    cmd.Dispose();
                    return dt;
                }
            }
        }
        catch (Exception ex) { return null; }

    }
    public static DataTable GetStoredData(string sql)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    cmd.Dispose();
                    return dt;
                }
            }

        }
        catch (Exception ex) { return null; }

    }
    public static DataTable GetStoredData(string sql, params SqlParameter[] sp)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    foreach (SqlParameter p in sp)
                        cmd.Parameters.Add(p);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    cmd.Dispose();
                    da.Dispose();
                    return dt;
                }
            }

        }
        catch (Exception ex) { return null; }
    }

}
