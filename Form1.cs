using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace BillingSoftware
{
    public partial class Form1 : Form
    {
        
        public string mType;
        public Form1()
        {
            InitializeComponent();            
        }
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["billingFormData"].ConnectionString;
        }
        public static void ConnectToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                // Perform database operations
            }
        }
        private void itemSaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            connection.Open();
            //SqlConnection con = new SqlConnection("Data Source=Adzguru\\SQLEXPRESS;Initial Catalog=billingFormData;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into item_master values(@item_type,@item_name,@item_unit,@item_selling_price,@item_account,@item_description)", connection);
            //bool r1 = item_type_goods.Checked;
            //string type;
            if (item_type_goods.Checked == true)
            {
                mType = "goods";
            }
            if (item_type_service.Checked == true)
            {
                mType = "service";
            }
            cmd.Parameters.AddWithValue("@item_type", mType);
            cmd.Parameters.AddWithValue("@item_name", item_name.Text);
            cmd.Parameters.AddWithValue("@item_unit", item_unit_select.SelectedItem);
            cmd.Parameters.AddWithValue("@item_selling_price", item_selling_price.Text);
            cmd.Parameters.AddWithValue("@item_account", item_account_select.SelectedItem);
            cmd.Parameters.AddWithValue("@item_description", item_description.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("successfully saved");
        }

        private void Item_type_goods_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("successfully Clicked"+sender);
        }

        private void item_type_goods_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
