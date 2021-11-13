using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
// Connect.cs phục vụ cho formDatabaseConnect.cs
namespace DataLayer
{
	[Serializable] //phương thức đọc ghi đối tượng file dưới dạng mã hóa 
	public class Connect
	{
		public string servername;
		public string Servername
		{
			get { return servername; }
			set { servername = value; }
		}
		public string username;
		public string Username
		{
			get { return username; }
			set { username = value; }
		}
		public string passwd;
		public string Passwd
		{
			get { return passwd; }
			set { passwd = value; }
		}
		public string database;
		public string Database
		{
			get { return database; }
			set { database = value; }
		}

		//Construction
		public Connect(string _servername, string _username, string _passwd, string _database)
		{
			this.servername = _servername;
			this.username = _username;
			this.passwd = _passwd;
			this.database = _database;
		}
		//Method ConnectData using for Form DatabaseConnect's btnSaveData to write file    
		public void ConnectData(string fileName)
		{
			if (File.Exists("connectdb.dba"))
			{
				File.Delete("connectdb.dba");
			}
			//FileStream là cơ chế hỗ trợ đọc ghi file (FileStream is a file write support mode)- Readmore StreamAdapter
			FileStream fs = File.Open("connectdb.dba", FileMode.OpenOrCreate, FileAccess.Write); //method OpenOrCreate nói với hệ điều hảnh nên mở một tập tin nếu nó tồn tại; nếu không, một tập tin mới sẽ được tạo ra.
																								 // FileStream(String, FileMode, FileAccess) đây là định dạng khởi tạo FileStream
			BinaryFormatter bf = new BinaryFormatter(); // tạo đối tượng chuyển đổi 
			bf.Serialize(fs, this); // lưu kết quả chuyển đổi file
			fs.Close();
                
		}
	}
}
