﻿#region License
/*
 **************************************************************
 *  Author: Rick Strahl 
 *          © West Wind Technologies, 2009
 *          http://www.west-wind.com/
 * 
 * Created: 09/12/2009
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 **************************************************************  
*/
#endregion

using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Configuration;
using System.Data.Common;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace Westwind.Utilities.Data
{
    /// <summary>
    /// Basic low level Data Access Layer
    /// </summary>
    [DebuggerDisplay("{ErrorMessage}")]
    internal abstract class DataAccessBase : IDisposable
    {
        /// <summary>
        /// The internally used dbProvider
        /// </summary>
        public DbProviderFactory dbProvider = null;
        

        /// <summary>
        /// An error message if a method fails
        /// </summary>
        public virtual string ErrorMessage
        {
            get { return _ErrorMessage; }
            set { _ErrorMessage = value; }
        }
        private string _ErrorMessage = string.Empty;

        /// <summary>
        /// Optional error number returned by failed SQL commands
        /// </summary>
        public int ErrorNumber
        {
            get { return _ErrorNumber; }
            set { _ErrorNumber = value; }
        }
        private int _ErrorNumber = 0;


        /// <summary>
        /// ConnectionString for the data access component
        /// </summary>
        public virtual string ConnectionString
        {
            get { return _ConnectionString; }
            set { 


                _ConnectionString = value; 
            }
        }
        private string _ConnectionString = string.Empty;


        /// <summary>
        /// A SQL Transaction object that may be active. You can 
        /// also set this object explcitly
        /// </summary>
        public virtual DbTransaction Transaction
        {
            get { return _Transaction; }
            set { _Transaction = value; }
        }
        private DbTransaction _Transaction = null;


        /// <summary>
        /// The SQL Connection object used for connections
        /// </summary>
        public virtual DbConnection Connection
        {
            get { return _Connection; }
            set { _Connection = value; }
        }
        protected DbConnection _Connection = null;

        /// <summary>
        /// Determines whether extended schema information is returned for 
        /// queries from the server. Useful if schema needs to be returned
        /// as part of DataSet XML creation 
        /// </summary>
        public virtual bool ExecuteWithSchema
        {
            get { return _ExecuteWithSchema; }
            set { _ExecuteWithSchema = value; }
        }
        private bool _ExecuteWithSchema = false;


        /// <summary>
        /// Opens a Sql Connection based on the connection string.
        /// Called internally but externally accessible. Sets the internal
        /// _Connection property.
        /// </summary>
        /// <returns></returns>
        public abstract bool OpenConnection();

        /// <summary>
        /// Creates a Command object and opens a connection
        /// </summary>
        /// <param name="ConnectionString"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public abstract DbCommand CreateCommand(string sql, CommandType commandType, params DbParameter[] parameters);

        /// <summary>
        /// Creates a Command object and opens a connection
        /// </summary>
        /// <param name="ConnectionString"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public virtual DbCommand CreateCommand(string sql, params DbParameter[] parameters)
        {
            return CreateCommand(sql, CommandType.Text, parameters);
        }


        /// <summary>
        /// Used to create named parameters to pass to commands or the various
        /// methods of this class.
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public abstract DbParameter CreateParameter(string parameterName, object value);


        /// <summary>
        /// Used to create named parameters to pass to commands or the various
        /// methods of this class.
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public virtual DbParameter CreateParameter(string parameterName, object value, ParameterDirection parameterDirection)
        {
            DbParameter parm = CreateParameter(parameterName, value);
            parm.Direction = parameterDirection;
            return parm;
        }

        /// <summary>
        /// Used to create named parameters to pass to commands or the various
        /// methods of this class.
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public virtual DbParameter CreateParameter(string parameterName, object value, int size)
        {
            DbParameter parm = CreateParameter(parameterName, value);
            parm.Size = size;
            return parm;
        }

        /// <summary>
        /// Used to create named parameters to pass to commands or the various
        /// methods of this class.
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public virtual DbParameter CreateParameter(string parameterName, object value, DbType type)
        {
            DbParameter parm = CreateParameter(parameterName, value);
            parm.DbType = type;
            return parm;
        }

        /// <summary>
        /// Used to create named parameters to pass to commands or the various
        /// methods of this class.
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public virtual DbParameter CreateParameter(string parameterName, object value, DbType type, int size)
        {
            DbParameter parm = CreateParameter(parameterName, value);
            parm.DbType = type;
            parm.Size = size;
            return parm;
        }

        /// <summary>
        /// Executes a non-query command and returns the affected records
        /// </summary>
        /// <param name="Command">Command should be created with GetSqlCommand to have open connection</param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public abstract int ExecuteNonQuery(DbCommand Command, params DbParameter[] Parameters);

        /// <summary>
        /// Executes a command that doesn't return any data. The result
        /// returns the number of records affected or -1 on error.
        /// </summary>
        /// <param name="sql">SQL statement as a string</param>
        /// <param name="parameters">Any number of SQL named parameters</param>
        /// <returns></returns>
        /// <summary>
        /// Executes a command that doesn't return a data result. You can return
        /// output parameters and you do receive an AffectedRecords counter.
        /// </summary>        
        public virtual int ExecuteNonQuery(string sql, params DbParameter[] parameters)
        {
            DbCommand command = CreateCommand(sql);
            if (command == null)
                return -1;

            return ExecuteNonQuery(command, parameters);
        }


        /// <summary>
        /// Executes a SQL Command object and returns a SqlDataReader object
        /// </summary>
        /// <param name="Command">Command should be created with GetSqlCommand and open connection</param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        /// <returns>A SqlDataReader. Make sure to call Close() to close the underlying connection.</returns>
        public abstract DbDataReader ExecuteReader(DbCommand Command, params DbParameter[] Parameters);


        /// <summary>
        /// Executes a SQL command against the server and returns a DbDataReader
        /// </summary>
        /// <param name="sql">Sql String</param>
        /// <param name="parameters">Any SQL parameters </param>
        /// <returns></returns>
        public virtual DbDataReader ExecuteReader(string sql, params DbParameter[] parameters)
        {
            DbCommand command = CreateCommand(sql, parameters);
            if (command == null)
                return null;

            return ExecuteReader(command);
        }


        /// <summary>
        /// Executes a SQL statement and creates an object list using
        /// Reflection.
        /// 
        /// Not very efficient but provides an easy way to retrieve
        /// </summary>
        /// <typeparam name="T">Entity type to create from DataReader data</typeparam>
        /// <param name="sql">Sql string to execute</param>        
        /// <param name="parameters">DbParameters to fill the SQL statement</param>
        /// <returns>List of objects</returns>
        public virtual List<T> ExecuteReader<T>(string sql, params DbParameter[] parameters)
            where T : class, new()
        {
            var reader = ExecuteReader(sql, parameters);
            if (reader == null)
                return null;

            var result = DataUtils.DataReaderToObjectList<T>(reader,null);
            reader.Close();
            return result;
        }

        /// <summary>
        /// Executes a SQL statement and creates an object list using
        /// Reflection.
        /// 
        /// Not very efficient but provides an easy way to retrieve
        /// </summary>
        /// <typeparam name="T">Entity type to create from DataReader data</typeparam>
        /// <param name="sql">Sql string to execute</param>        
        /// <param name="propertiesToExclude">Comma delimited list of properties that are not to be updated</param>
        /// <param name="parameters">DbParameters to fill the SQL statement</param>
        /// <returns>List of objects</returns>
        public virtual List<T> ExecuteReader<T>(string sql, string propertiesToExclude, params DbParameter[] parameters)
            where T : class, new()
        {
            var reader = ExecuteReader(sql, parameters);
            if (reader == null)
                return null;

            var result = DataUtils.DataReaderToObjectList<T>(reader, propertiesToExclude);
            reader.Close();
            return result;
        }

  

        /// <summary>
        /// Executes a SQL statement and creates an object list using
        /// Reflection.
        /// 
        /// Not very efficient but provides an easy way to retrieve
        /// </summary>
        /// <typeparam name="T">Entity type to create from DataReader data</typeparam>
        /// <param name="sql">Sql string to execute</param>        
        /// <param name="parameters">DbParameters to fill the SQL statement</param>
        /// <returns>List of objects</returns>
        public virtual List<T> ExecuteReader<T>(DbCommand sqlCommand, params DbParameter[] parameters)
            where T : class, new()
        {
            var reader = ExecuteReader(sqlCommand, parameters);
            return DataUtils.DataReaderToObjectList<T>(reader, null);
        }


        /// <summary>
        /// Returns a DataTable from a Sql Command string passed in.
        /// </summary>
        /// <param name="Tablename"></param>
        /// <param name="Command"></param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public abstract DataTable ExecuteTable(string Tablename, DbCommand Command, params DbParameter[] Parameters);

        /// <summary>
        /// Returns a DataTable from a Sql Command string passed in.
        /// </summary>
        /// <param name="Tablename"></param>
        /// <param name="ConnectionString"></param>
        /// <param name="Sql"></param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public virtual DataTable ExecuteTable(string Tablename, string Sql, params DbParameter[] Parameters)
        {
            SetError();

            DbCommand Command = CreateCommand(Sql, Parameters);
            if (Command == null)
                return null;

            return ExecuteTable(Tablename, Command);
        }


        /// <summary>
        /// Returns a DataSet/DataTable from a Sql Command string passed in. 
        /// </summary>
        /// <param name="Tablename">The name for the table generated or the base names</param>
        /// <param name="Command"></param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public abstract DataSet ExecuteDataSet(string tablename, DbCommand command, params DbParameter[] parameters);


        /// <summary>
        /// Executes a SQL command against the server and returns a DataSet of the result
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual DataSet ExecuteDataSet(string tablename, string sql, params DbParameter[] parameters)
        {
            return ExecuteDataSet(tablename, CreateCommand(sql), parameters);
        }


        /// <summary>
        /// Returns a DataSet from a Sql Command string passed in.
        /// </summary>
        /// <param name="Tablename"></param>
        /// <param name="Command"></param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public abstract DataSet ExecuteDataSet(DataSet dataSet, string Tablename, DbCommand Command, params DbParameter[] Parameters);

        /// <summary>
        /// Returns a DataTable from a Sql Command string passed in.
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="Command"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual DataSet ExecuteDataSet(DataSet dataSet, string tablename, string sql, params DbParameter[] parameters)
        {
            DbCommand Command = CreateCommand(sql, parameters);
            if (Command == null)
                return null;

            return ExecuteDataSet(dataSet, tablename, Command);
        }


        /// <summary>
        /// Executes a command and returns a scalar value from it
        /// </summary>
        /// <param name="SqlCommand">A SQL Command object</param>
        /// <returns>value or null on failure</returns>
        public abstract object ExecuteScalar(DbCommand Command, params DbParameter[] Parameters);

        /// <summary>
        /// Executes a Sql command and returns a single value from it.
        /// </summary>
        /// <param name="Sql">Sql string to execute</param>
        /// <param name="Parameters">Any named SQL parameters</param>
        /// <returns>Result value or null. Check ErrorMessage on Null if unexpected</returns>
        public virtual object ExecuteScalar(string sql, params DbParameter[] parameters)
        {
            DbCommand command = CreateCommand(sql, parameters);
            if (command == null)
                return null;

            return ExecuteScalar(command, null);
        }

        /// <summary>
        /// Closes a connection
        /// </summary>
        /// <param name="Command"></param>
        public abstract void CloseConnection(DbCommand Command);


        /// <summary>
        /// Closes an active connection. If a transaction is pending the 
        /// connection is held open.
        /// </summary>
        public abstract void CloseConnection();


        /// <summary>
        /// Sql 2005 specific semi-generic paging routine
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="sortOrderFields"></param>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public virtual DbCommand CreatePagingCommand(string sql, int pageSize, int page, string sortOrderFields, params DbParameter[] Parameters)
        {
            int pos = sql.IndexOf("select ", 0, StringComparison.OrdinalIgnoreCase);
            if (pos == -1)
            {
                SetError("Invalid Command for paging. Must start with select and followed by field list");
                return null;
            }
            sql = StringUtils.ReplaceStringInstance(sql, "select", string.Empty, 1, true);

            string NewSql = string.Format(
            @"
select * FROM 
   (SELECT ROW_NUMBER() OVER (ORDER BY @OrderByFields) as __No,{0}) __TQuery
where __No > (@Page-1) * @PageSize and __No < (@Page * @PageSize + 1)
", sql);

            return CreateCommand(NewSql,
                            CreateParameter("@PageSize", pageSize),
                            CreateParameter("@Page", page),
                            CreateParameter("@OrderByFields", sortOrderFields));

        }

        /// <summary>
        /// Executes a long SQL script that contains batches (GO commands). This code
        /// breaks the script into individual commands and captures all execution errors.
        /// 
        /// If ContinueOnError is false, operations are run inside of a transaction and
        /// changes are rolled back. If true commands are accepted even if failures occur
        /// and are not rolled back.
        /// </summary>
        /// <param name="Script"></param>
        /// <param name="ScriptIsFile"></param>
        /// <returns></returns>
        public bool RunSqlScript(string Script, bool ContinueOnError, bool ScriptIsFile)
        {
            SetError();

            if (ScriptIsFile)
            {
                try
                {
                    Script = File.ReadAllText(Script);
                }
                catch (Exception ex)
                {
                    SetError(ex.Message);
                    return false;
                }
            }

            string[] ScriptBlocks = System.Text.RegularExpressions.Regex.Split(Script + "\r\n", "GO\r\n");
            string Errors = "";

            if (!ContinueOnError)
                BeginTransaction();

            foreach (string Block in ScriptBlocks)
            {
                if (string.IsNullOrEmpty(Block.TrimEnd()))
                    continue;

                if (ExecuteNonQuery(Block) == -1)
                {
                    Errors = ErrorMessage + "\r\n";
                    if (!ContinueOnError)
                    {
                        RollbackTransaction();
                        return false;
                    }
                }
            }

            if (!ContinueOnError)
                CommitTransaction();

            if (string.IsNullOrEmpty(Errors))
                return true;

            ErrorMessage = Errors;
            return false;
        }

        #region Generic Entity features
        /// <summary>
        /// Generic routine to retrieve an object from a database record
        /// The object properties must match the database fields.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="Table"></param>
        /// <param name="KeyField"></param>
        /// <param name="fieldsToSkip"></param>
        /// <returns></returns>
        public virtual bool GetEntity(object entity, DbCommand command, string fieldsToSkip)
        {
            SetError();

            if (string.IsNullOrEmpty(fieldsToSkip))
                fieldsToSkip = string.Empty;

            DbDataReader Reader = ExecuteReader(command);
            if (Reader == null)
                return false;

            if (!Reader.Read())
            {
                Reader.Close();
                CloseConnection(command);
                return false;
            }

            Type ObjType = entity.GetType();
            
            PropertyInfo[] Properties = ObjType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo Property in Properties)
            {
                if (!Property.CanRead || !Property.CanWrite)
                    continue;

                string Name = Property.Name;

                if (fieldsToSkip.IndexOf("," + Name.ToLower() + ",") > -1)
                    continue;

                object Value = null;
                try
                {
                    Value = Reader[Name];
                    if (Value is DBNull)
                        Value = null;
                }
                catch
                {
                    continue;
                }

                Property.SetValue(entity, Value, null);
            }

            Reader.Close();
            CloseConnection();

            return true;
        }



        /// <summary>
        /// Generic routine to return an Entity that matches the field names of a 
        /// table exactly.
        /// </summary>
        /// <param name="Entity"></param>
        /// <param name="Table"></param>
        /// <param name="KeyField"></param>
        /// <param name="KeyValue"></param>
        /// <param name="FieldsToSkip"></param>
        /// <returns></returns>
        public virtual bool GetEntity(object Entity, string Table, string KeyField, object KeyValue, string FieldsToSkip)
        {
            SetError();

            DbCommand Command = CreateCommand("select * from " + Table + " where [" + KeyField + "]=@Key",
                                                    CreateParameter("@Key", KeyValue));
            if (Command == null)
                return false;

            return GetEntity(Entity, Command, FieldsToSkip);
        }

        /// <summary>
        /// Updates an entity object that has matching fields in the database for each
        /// public property. Kind of a poor man's quick entity update mechanism.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="table"></param>
        /// <param name="keyField"></param>
        /// <param name="fieldsToSkip"></param>
        /// <returns></returns>
        public virtual bool UpdateEntity(object entity, string table, string keyField, string fieldsToSkip = null)
        {
            this.SetError();

            if (string.IsNullOrEmpty(fieldsToSkip))
                fieldsToSkip = string.Empty;
            else
                fieldsToSkip = "," + fieldsToSkip.ToLower() + ",";

            DbCommand Command = CreateCommand(string.Empty);

            Type ObjType = entity.GetType();

            StringBuilder sb = new StringBuilder();
            sb.Append("update " + table + " set ");

            PropertyInfo[] Properties = ObjType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo Property in Properties)
            {
                if (!Property.CanRead)
                    continue;

                string Name = Property.Name;

                if (fieldsToSkip.IndexOf("," + Name.ToLower() + ",") > -1)
                    continue;

                object Value = Property.GetValue(entity, null);

                sb.Append(" [" + Name + "]=@" + Name + ",");

                Command.Parameters.Add(CreateParameter("@" + Name, Value));
            }

            object pkValue = ReflectionUtils.GetProperty(entity, keyField);

            String CommandText = sb.ToString().TrimEnd(',') + " where " + keyField + "=@__PK";

            Command.Parameters.Add(CreateParameter("@__PK", pkValue));
            Command.CommandText = CommandText;

            bool Result = ExecuteNonQuery(Command) > -1;
            CloseConnection(Command);

            return Result;
        }
        
        /// <summary>
        /// This version of UpdateEntity allows you to specify which fields to update and
        /// so is a bit more efficient as it only checks for specific fields in the database
        /// and the underlying table.
        /// </summary>
        /// <seealso cref="SaveEntity">
        /// <seealso cref="InsertEntity"/>
        /// <param name="Entity"></param>
        /// <param name="Table"></param>
        /// <param name="KeyField"></param>
        /// <param name="FieldsToSkip"></param>
        /// <param name="FieldsToUpdate"></param>
        /// <returns></returns>
        public virtual bool UpdateEntity(object Entity, string Table, string KeyField, string FieldsToSkip, string FieldsToUpdate)
        {
            this.SetError();

            if (FieldsToSkip == null)
                FieldsToSkip = string.Empty;
            else
                FieldsToSkip = "," + FieldsToSkip.ToLower() + ",";

            DbCommand Command = CreateCommand(string.Empty);

            Type ObjType = Entity.GetType();

            StringBuilder sb = new StringBuilder();
            sb.Append("update " + Table + " set ");

            string[] Fields = FieldsToUpdate.Split(',');
            foreach (string Name in Fields)
            {
                if (FieldsToSkip.IndexOf("," + Name.ToLower() + ",") > -1)
                    continue;

                PropertyInfo Property = ObjType.GetProperty(Name);
                if (Property == null)
                    continue;

                object Value = Property.GetValue(Entity, null);

                sb.Append(" [" + Name + "]=@" + Name + ",");

                Command.Parameters.Add(CreateParameter("@" + Name, Value));
            }
            object pkValue = ReflectionUtils.GetProperty(Entity, KeyField);

            String CommandText = sb.ToString().TrimEnd(',') + " where " + KeyField + "=@__PK";

            Command.Parameters.Add(CreateParameter("@__PK", pkValue));
            Command.CommandText = CommandText;

            bool Result = ExecuteNonQuery(Command) > -1;
            CloseConnection(Command);

            return Result;
        }

        /// <summary>
        /// Inserts an object into the database based on its type information.
        /// The properties must match the database structure and you can skip
        /// over fields in the FieldsToSkip list.        
        /// </summary>        
        /// <seealso cref="SaveEntity">
        /// <seealso cref="UpdateEntity"/>
        /// <param name="entity"></param>
        /// <param name="table"></param>
        /// <param name="KeyField"></param>
        /// <param name="fieldsToSkip"></param>
        /// <returns>Scope Identity or Null</returns>
        public object InsertEntity(object entity, string table, string fieldsToSkip = null)
        {
            this.SetError();

            if (string.IsNullOrEmpty(fieldsToSkip))
                fieldsToSkip = string.Empty;
            else
                fieldsToSkip = "," + fieldsToSkip.ToLower() + ",";

            DbCommand Command = CreateCommand(string.Empty);

            Type ObjType = entity.GetType();

            StringBuilder FieldList = new StringBuilder();
            StringBuilder DataList = new StringBuilder();
            FieldList.Append("insert " + table + " (");
            DataList.Append(" values (");

            PropertyInfo[] Properties = ObjType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (PropertyInfo Property in Properties)
            {
                if (!Property.CanRead)
                    continue;

                string Name = Property.Name;

                if (fieldsToSkip.IndexOf("," + Name.ToLower() + ",") > -1)
                    continue;

                object Value = Property.GetValue(entity, null);

                FieldList.Append("[" + Name + "],");
                DataList.Append("@" + Name + ",");

                Command.Parameters.Add(CreateParameter("@" + Name, Value == null ? DBNull.Value : Value));
            }

            Command.CommandText = FieldList.ToString().TrimEnd(',') + ") " +
                                 DataList.ToString().TrimEnd(',') + ");select SCOPE_IDENTITY()";

            object Result = ExecuteScalar(Command);
                     

            CloseConnection();

            return Result;
        }


        /// <summary>
        /// Saves an enity into the database using insert or update as required.
        /// Requires a keyfield that exists on both the entity and the database.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="table"></param>
        /// <param name="keyField"></param>
        /// <param name="fieldsToSkip"></param>
        /// <returns></returns>
        public virtual bool SaveEntity(object entity, string table, string keyField, string fieldsToSkip = null)
        {
            object pkValue = ReflectionUtils.GetProperty(entity, keyField);
            object res = null;
            if (pkValue != null)
                res = this.ExecuteScalar("select [" + keyField + "] from [" + table + "] where [" + keyField + "]=@id",
                                         this.CreateParameter("@id", pkValue));


            if (res == null)
            {
                this.InsertEntity(entity, table, fieldsToSkip);
                if (!string.IsNullOrEmpty(ErrorMessage))
                    return false;
            }
            else
                return this.UpdateEntity(entity, table, keyField, fieldsToSkip);

            return true;
        }


        #endregion



        /// <summary>
        /// Starts a new transaction on this connection/instance
        /// </summary>
        /// <returns></returns>
        public virtual bool BeginTransaction()
        {
            if (_Connection == null)
            {
                if (!this.OpenConnection())
                    return false;
            }            

            Transaction = _Connection.BeginTransaction();
            if (Transaction == null)
                return false;

            return true;
        }

        /// <summary>
        /// Commits all changes to the database and ends the transaction
        /// </summary>
        /// <returns></returns>
        public virtual bool CommitTransaction()
        {
            if (Transaction == null)
            {
                SetError("No active Transaction to commit.");
                return false;
            }

            Transaction.Commit();
            Transaction = null;

            CloseConnection();

            return true;
        }

        /// <summary>
        /// Rolls back a transaction
        /// </summary>
        /// <returns></returns>
        public virtual bool RollbackTransaction()
        {
            if (Transaction == null)
                return true;

            Transaction.Rollback();
            Transaction = null;

            CloseConnection();

            return true;
        }



        /// <summary>
        /// Sets the error message for the failure operations
        /// </summary>
        /// <param name="Message"></param>
        protected virtual void SetError(string Message, int errorNumber)
        {
            if (string.IsNullOrEmpty(Message))
            {
                ErrorMessage = string.Empty;
                ErrorNumber = 0;
                return;
            }

            ErrorMessage = Message;
            ErrorNumber = errorNumber;
        }        

        /// <summary>
        /// Sets the error message and error number.
        /// </summary>
        /// <param name="message"></param>
        protected virtual void SetError(string message)
        {
            SetError(message,0);
        }

        protected virtual void SetError(DbException ex)
        {
            SetError(ex.Message, ex.ErrorCode);
        }

        protected virtual void SetError(Exception ex)
        {
            SetError(ex.Message,0);
        }

        /// <summary>
        /// Sets the error message for failure operations.
        /// </summary>
        protected virtual void SetError()
        {
            SetError(null,0);
        }


        #region IDisposable Members

        public void Dispose()
        {
            if (_Connection != null)
                CloseConnection();
        }


        #endregion
    }
}