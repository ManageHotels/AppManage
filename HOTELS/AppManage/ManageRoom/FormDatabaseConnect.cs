using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRoom
{
    public partial class FormDatabaseConnect : DevExpress.XtraEditors.XtraForm
    {
        public FormDatabaseConnect()
        {
            InitializeComponent();
        }
        SqlConnection GetCon(string server, string username, string pass, string database)
        {
            return new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + pass + ";"); // return chuỗi kết nối
        }
        private void btnCheckData_Click(object sender, EventArgs e)//check database
        {
            SqlConnection con = GetCon(txtServer.Text, txtUsername.Text, txtPassword.Text, cbbDatabase.Text);
            try
            {
                con.Open();
                MessageBox.Show("Successful Connection");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed Connection");
            }
        }

        private void cbbDatabase_MouseClick(object sender, MouseEventArgs e)
        {
            cbbDatabase.Items.Clear();
            string conn = "Server=" + txtServer.Text + "; User ID=" + txtUsername.Text + "; Password=" + txtPassword.Text + ";"; //chuỗi kết nối kiểu string
            SqlConnection con = new SqlConnection(conn); //tạo đối tượng kết nối đưa tham số kết nối kiểu string vào
            con.Open(); //mở kết nối
            string qr = " SELECT NAME FROM SYS.DATABASES";
            SqlCommand cmd = new SqlCommand(qr, con); //khởi tạo đối tượng datacommand để truy vấn dữ liệu
            IDataReader dr = cmd.ExecuteReader(); // khởi tạo đối tượng datareader để thi hành truy vấn
            while (dr.Read())
            {
                cbbDatabase.Items.Add(dr[0].ToString()); //đọc các dữ liệu trả về từ các item dòng đầu tiên cho đến cuối
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            string svEncrypt = Encryptor.Encrypt(txtServer.Text, "qwertyuiop", true);
            string usEncrypt = Encryptor.Encrypt(txtUsername.Text, "qwertyuiop", true);
            string passEncrypt = Encryptor.Encrypt(txtPassword.Text, "qwertyuiop", true);
            string dbEncrypt = Encryptor.Encrypt(cbbDatabase.Text, "qwertyuiop", true);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Choose where to save";
            sf.Filter = "Text File (*.dba|*.dba| AllFiles(*.*)|*.*"; // Structer Default để lưu trữ đuôi tệp
            if (sf.ShowDialog() == DialogResult.OK) //Submit
            {
                Connect cn = new Connect(svEncrypt, usEncrypt, passEncrypt, dbEncrypt); // khởi tạo class Connect.s
                cn.ConnectData(sf.FileName);                                            // gọi method's Connect.cs                
                MessageBox.Show("File saved successfully", "Notification");
            }
        }
    }
}