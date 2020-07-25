using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace CSTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load_information_Click(object sender, EventArgs e)
        {
            string source = "Server=(서버IP);Port=3306;Database=test_database;Uid=root;password=(패스워드)";
            reload(source);
        }

        private void input_information_Click(object sender, EventArgs e)
        {
            string source = "Server=(서버IP);Port=3306;Database=test_database;Uid=root;password=(패스워드)";
            reload(source);
        }

        private void input_delete_Click(object sender, EventArgs e)
        {
            string source = "Server=(서버IP);Port=3306;Database=test_database;Uid=root;password=(패스워드)";
            delete_information(source);
            reload(source);
        }

        public void reload(string source)
        {
            MySqlConnection con = new MySqlConnection(source);
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT * FROM infromation";
            try
            {
                con.Open();
                MySqlDataReader reader = query.ExecuteReader();
                dataGridView1.Rows.Clear();
                for (int i = 0; reader.Read(); i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["num"].Value = reader["information_num"].ToString();
                    dataGridView1.Rows[i].Cells["name"].Value = reader["information_name"].ToString();
                    dataGridView1.Rows[i].Cells["year"].Value = reader["information_year"].ToString();
                    dataGridView1.Rows[i].Cells["work"].Value = reader["information_work"].ToString();
                }
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                con.Close();
            }
        }

        public void server_information(string source)
        {
            MySqlConnection con = new MySqlConnection(source);
            string insertQuery = "INSERT INTO infromation(information_num, information_name, information_year, information_work) VALUES(" + Int32.Parse(input_num.Text) + ",'" + input_name.Text + "'," + Int32.Parse(input_year.Text) + ",'" + input_work.Text + "')";
            con.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, con);
            try
            {
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("잘 전달이 되었습니다");
                }
                else
                {
                    MessageBox.Show("비상적인 접근입니다");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void delete_information(string source)
        {
            MySqlConnection con = new MySqlConnection(source);
            //MySqlCommand query = con.CreateCommand();
            con.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool isChecked = Convert.ToBoolean(dataGridView1.Rows[i].Cells["chk"].Value);
                if (isChecked)
                {
                    string deleteData = Convert.ToString(dataGridView1.Rows[i].Cells["name"].Value);
                    string deleteQuery = "DELETE FROM infromation WHERE information_name='" + deleteData + "';";
                    MySqlCommand command = new MySqlCommand(deleteQuery, con);
                    try
                    {
                        if(command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("삭제 완료!");
                        }
                        else
                        {
                            MessageBox.Show("오류 발생!");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            con.Close();
        }
    }
}
