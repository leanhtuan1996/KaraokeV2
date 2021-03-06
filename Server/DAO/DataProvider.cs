﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Server.DAO
{
    public class DataProvider
    {

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { return instance ?? (instance = new DataProvider()); }
        }

        readonly string _connectionString = ConfigurationManager.ConnectionStrings["StringConnect"].ConnectionString;

        DataProvider()
        {
        }

        public SqlDataReader ExcuteReader(string sql, SqlParameter[] parameter = null)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            connection.Open();

            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader rd = cmd.ExecuteReader();

            //SqlDataReader dr;

            //using(SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    SqlCommand cmd = new SqlCommand(sql, connection);

            //    if (parameter != null)
            //    {
            //        cmd.Parameters.AddRange(parameter);
            //    }

            //    dr = cmd.ExecuteReader();
            //}           

            //connection.Close();      
            //return dr;

            return rd;
        }

        public SqlDataReader Excutereader(string sql, SqlParameter[] parameter = null)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(sql, connection);

            if (parameter != null)
            {
                cmd.Parameters.AddRange(parameter);
            }
            var dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader EXCUTEREADER_SP(string SP_Name, SqlParameter[] parameter = null)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(SP_Name, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (parameter != null)
            {
                cmd.Parameters.AddRange(parameter);
            }
            var dr = cmd.ExecuteReader();
            return dr;
        }

        public void ConnectionClose()
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            connection.Close();
        }

        public DataTable ExecuteQuery(string _query, SqlParameter[] sqlParameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_query, connection);
                if (sqlParameter != null)
                {
                    command.Parameters.AddRange(sqlParameter);
                }
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(data);

                connection.Close();
            }

            return data;
        }

        public DataTable ExecuteQuery_SP(string SP_Name, SqlParameter[] sqlParameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(SP_Name, connection) { CommandType = CommandType.StoredProcedure };

                if (sqlParameter != null)
                {
                    command.Parameters.AddRange(sqlParameter);
                }

                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string _query, SqlParameter[] sqlParameter = null)
        {

            int accpectedRows = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(_query, connection);

                if (sqlParameter != null)
                {
                    command.Parameters.AddRange(sqlParameter);
                }

                accpectedRows = command.ExecuteNonQuery();

                connection.Close();

            }
            return accpectedRows;
        }

        public int ExecuteNonQuery_SP(string SP_Name, SqlParameter[] sqlParameter = null)
        {
            int accpectedRows = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(SP_Name, connection) { CommandType = CommandType.StoredProcedure };

                if (sqlParameter != null)
                {
                    command.Parameters.AddRange(sqlParameter);
                }

                accpectedRows = command.ExecuteNonQuery();

                connection.Close();

            }
            return accpectedRows;
        }

        public object ExecuteScalar(string _query, SqlParameter[] sqlParameter = null)
        {
            object accpectedRows;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(_query, connection);

                if (sqlParameter != null)
                {
                    command.Parameters.AddRange(sqlParameter);
                }

                accpectedRows = command.ExecuteScalar();

                connection.Close();
            }

            return accpectedRows;
        }
        public object ExecuteScalar_SP(string SP_Name, SqlParameter[] sqlParameter = null)
        {
            object accpectedRows;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(SP_Name, connection) { CommandType = CommandType.StoredProcedure };

                if (sqlParameter != null)
                {
                    command.Parameters.AddRange(sqlParameter);
                }

                accpectedRows = command.ExecuteScalar();

                connection.Close();
            }

            return accpectedRows;
        }

    }
}