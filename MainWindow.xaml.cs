using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=ASHIK\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True";
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txt_userid.Text == "" || txt_pass.Password == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from tb_user where userid=@userid and pass=@pass", con);
                cmd.Parameters.AddWithValue("@userid", txt_userid.Text);
                cmd.Parameters.AddWithValue("@pass", txt_pass.Password);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    //MessageBox.Show("Login Successful!");
                    this.Hide();
                    mainInterface mi = new mainInterface();
                    mi.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExitHome_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
