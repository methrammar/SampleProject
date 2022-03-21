using SampleDataAccess.DataAccess;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataAccess.Model
{
    public class Log
    {
        public DateTime TIMESTAMP { get; set; } = DateTime.Now;
        public string OBJECT { get; set; }
        public string METHOD { get; set; }
        public string STATUSCODE { get; set; } = "";       
        public string STATUSDESCRIPTION { get; set; } = "";
        public string EXCEPTION { get; set; } = "";

        public void Post()
        {
            
            IConfiguration appSettingsJson = AppSettingsJson.GetAppSettings();
            string connectionString = appSettingsJson["ConnectionString"];

            IDBManager dbManager = new DBManager(DataProvider.SqlServer);
            dbManager.ConnectionString = connectionString;

            try
            {
                dbManager.Open();
                string checkDbString = @"IF EXISTS(SELECT NAME FROM SYS.TABLES WHERE NAME ='SAMPLE_LOG') 
                                                SELECT 1
                                             ELSE 
                                                SELECT 0";

                bool exists = Convert.ToBoolean(dbManager.ExecuteScalar(CommandType.Text, checkDbString));

                if (!exists)
                {
                    string createTableString = @"CREATE TABLE SAMPLE_LOG(
                                                        LOGICALREF INT PRIMARY KEY IDENTITY(1,1),
                                                        TIMESTAMP_ DATE,
                                                        OBJECT_ VARCHAR(50),
                                                        METHOD_ VARCHAR(10),
                                                        STATUSCODE VARCHAR(30),
                                                        STATUSDESCRIPTION VARCHAR(MAX),
                                                        EXCEPTION VARCHAR(MAX));";

                    dbManager.ExecuteNonQuery(CommandType.Text, createTableString);
                }

                string insertText = $@"INSERT INTO SAMPLE_LOG
                                        (TIMESTAMP_,OBJECT_,METHOD_,STATUSCODE,STATUSDESCRIPTION,EXCEPTION)
                                        VALUES(
                                        @TimeStamp,
                                        @Object,
                                        @Method,
                                        @StatusCode,
                                        @StatusDescription,
                                        @Exception)";

                dbManager.CreateParameters(6);
                dbManager.AddParameters(0, "@TimeStamp", this.TIMESTAMP);
                dbManager.AddParameters(1, "@Object", this.OBJECT);
                dbManager.AddParameters(2, "@Method", this.METHOD);
                dbManager.AddParameters(3, "@StatusCode", this.STATUSCODE);
                dbManager.AddParameters(4, "@StatusDescription", this.STATUSDESCRIPTION);
                dbManager.AddParameters(5, "@Exception", this.EXCEPTION);

                dbManager.ExecuteNonQuery(CommandType.Text, insertText);
            }

            catch (Exception ex)
            {
                string message = DateTime.Now.ToLongDateString() + " Exception thrown: " + ex.Message + ".\n";
                File.AppendAllText("DataAccessLog.txt", message);
            }

            finally
            {
                dbManager.Dispose();
            }
        }
    }
}
