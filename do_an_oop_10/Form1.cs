using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace do_an_oop_10
{
    public partial class Form1 : Form
    {

        string strcon = Properties.Settings.Default.stringconn;
        SqlConnection sqlcon;

        private void openConn()
        {
            if(sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }

        private void closeConn()
        {
            if (sqlcon.State == ConnectionState.Open&&sqlcon!=null)
            {
                sqlcon.Close();
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void showInfomatinonLogin()
        {
            openConn();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from tblLogin";
            sqlCmd.Connection = sqlcon;

            SqlDataReader reader = sqlCmd.ExecuteReader();  
            listLogin.Items.Clear();    
            listLogin.Groups.Clear();

            ListViewGroup g1 = new ListViewGroup("admin");
            listLogin.Groups.Add(g1);

            ListViewGroup g2 = new ListViewGroup("nhanVien");
            listLogin.Groups.Add(g2);

            while (reader.Read())
            {
                string nameLogin = reader.GetString(0);
                string passWord = reader.GetString(1);
                string chucVu = reader.GetString(2);
                
                ListViewItem lvi = new ListViewItem(nameLogin);  
                // lvi.SubItems.Add(nameLogin);
                lvi.SubItems.Add(passWord);
                lvi.SubItems.Add(chucVu);

                listLogin.Items.Add(lvi);

                if (string.Compare(chucVu, "admin", true) == 0)
                {
                    lvi.Group = g1;
                }

                else
                {
                    lvi.Group = g2;
                }
                lvi.Tag = chucVu;

            }
            reader.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            showInfomatinonLogin();

        }
    }
}