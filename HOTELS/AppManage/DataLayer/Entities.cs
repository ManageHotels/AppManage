using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
// Entities.cs phục vụ cho Connect.cs và các class ở tầng Business
namespace DataLayer
{
    [Serializable]
    public partial class Entities
    {
        private Entities(DbConnection connectionString, bool contextOwnsConnection = true) : base(connectionString, contextOwnsConnection)
        {

        }
        public static Entities CreateEntities(bool contextOwnsConnection = true)
        {
            //Đọc file connectdb.dba đã lưu trong bin/Debug - Read the connect file 
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
            Connect cp = (Connect)bf.Deserialize(fs);
            //Giải mã nội dung bên file Encryptor.cs - Decrypt Content
            string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
            string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
            string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
            string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);
            //Tạo chuỗi kết nối - Connection String Builder 
            SqlConnectionStringBuilder sqlConnectBuilder = new SqlConnectionStringBuilder();
            sqlConnectBuilder.DataSource = servername;
            sqlConnectBuilder.InitialCatalog = database;
            sqlConnectBuilder.UserID = username;
            sqlConnectBuilder.Password = pass;

            string sqlConnectionString = sqlConnectBuilder.ConnectionString;

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlConnectionString;

            entityBuilder.Metadata = @"res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl";

            EntityConnection connection = new EntityConnection(entityBuilder.ConnectionString);

            fs.Close();
            return new Entities(connection);
        }
    }
}
