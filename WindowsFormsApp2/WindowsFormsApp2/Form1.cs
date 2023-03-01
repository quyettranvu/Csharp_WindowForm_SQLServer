using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global variable
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P9B24QG\QUYET_TRAN;Initial Catalog=Demo;Integrated Security=True");

        //Connect DataContext
        DemoDataContext db = new DemoDataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //var cmd = new SqlCommand("PhongBan_SelectAll", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                ///*using Procedure*/
                //var dap = new SqlDataAdapter(cmd);

                ///*using normal*/
                ////var dap = new SqlDataAdapter("SELECT * FROM PhongBan", conn);
                //var table = new DataTable();
                //dap.Fill(table);


                /*using Linq*/
                //visualization
                comboBoxPhongBan.ValueMember = "ID";
                comboBoxPhongBan.DisplayMember = "Department";
                //comboBoxPhongBan.DataSource = table;
                comboBoxPhongBan.DataSource = db.PhongBan_SelectAll();

                //textbox visualization
                textBoxID.DataBindings.Clear();
                textBoxID.DataBindings.Add("Text", comboBoxPhongBan.DataSource, "ID");
                textBoxDepartment.DataBindings.Clear();
                textBoxDepartment.DataBindings.Add("Text", comboBoxPhongBan.DataSource, "Department");
            }
            catch
            {
                MessageBox.Show("Failed in loading data. Please check again your SQL Server :((", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void comboBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //var cmd = new SqlCommand("NhanVien_SelectID", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(comboBoxPhongBan.SelectedValue);
                ///*using procedure*/
                //var dap = new SqlDataAdapter(cmd);

                ///*using normal*/
                ////int id = Convert.ToInt32(comboBoxPhongBan.SelectedValue);
                ////var dap = new SqlDataAdapter("SELECT * FROM SinhVien WHERE ID="+id+"", conn); //2 plus before and after since id type is integer
                //var table = new DataTable();
                //dap.Fill(table);

                /*using Linq*/
                //visualization
                //dataGridViewNhanVien.DataSource = table;
                dataGridViewNhanVien.DataSource = db.NhanVien_SelectID(Convert.ToInt32(comboBoxPhongBan.SelectedValue));

                //textbox visualiztion
                textBoxIDStudent.DataBindings.Clear();
                textBoxIDStudent.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "IDStudent");
                textBoxfullName.DataBindings.Clear();
                textBoxfullName.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "fullName");
                textBoxhomeTown.DataBindings.Clear();
                textBoxhomeTown.DataBindings.Add("Text", dataGridViewNhanVien.DataSource, "homeTown");
            }
            catch
            {
                MessageBox.Show("Failed in loading data. Please check again your SQL Server again :((", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //PhongBan
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            /*Note: case input not English then put N before ''*/
            //Insert
            try
            {
                //conn.Open();
                ///*using procedure*/
                //var cmd = new SqlCommand("PhongBan_Insert", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = textBoxDepartment.Text;

                ///*using normal*/
                ////var cmd = new SqlCommand("INSERT INTO PhongBan(Department) VALUES('" + textBoxDepartment.Text + "')", conn);
                //cmd.ExecuteNonQuery(); //ExecuteNonQuery: a command that does not return any data, such as an INSERT, UPDATE, or DELETE statemen
                //conn.Close();

                /*using Linq*/
                db.PhongBan_Insert(textBoxDepartment.Text);

                textBoxID.Text = "";
                textBoxDepartment.Text = "";
                textBoxDepartment.Focus(); //move cursor here
                MessageBox.Show("Added successfully!","Notification",MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Load form again
                Form1_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Added failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Update
            try
            {
                //conn.Open();
                ///*using procedure*/
                //var cmd = new SqlCommand("PhongBan_Update", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = textBoxDepartment.Text;
                //cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(comboBoxPhongBan.SelectedValue);

                ///*using normal*/
                ////var cmd = new SqlCommand("UPDATE PhongBan SET Department ='"
                ////        + textBoxDepartment.Text + "' WHERE ID = "+ Convert.ToInt32(comboBoxPhongBan.SelectedValue) +"", conn);
                //cmd.ExecuteNonQuery(); //ExecuteNonQuery: a command that does not return any data, such as an INSERT, UPDATE, or DELETE statemen
                //conn.Close();

                /*using Linq*/
                db.PhongBan_Update(textBoxDepartment.Text, Convert.ToInt32(comboBoxPhongBan.SelectedValue));

                MessageBox.Show("Updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Load form again
                Form1_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Updated failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Are you sure want to delete? " + comboBoxPhongBan.Text + "?",
                "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (lenh == DialogResult.Yes)
            {
                try
                {
                    //conn.Open();
                    ///*using procedure*/
                    //var cmd = new SqlCommand("PhongBan_Delete", conn);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(comboBoxPhongBan.SelectedValue);

                    ///*using normal*/
                    ////var cmd = new SqlCommand("DELETE FROM PhongBan WHERE ID = " + Convert.ToInt32(comboBoxPhongBan.SelectedValue) + "", conn);
                    //cmd.ExecuteNonQuery(); //ExecuteNonQuery: a command that does not return any data, such as an INSERT, UPDATE, or DELETE statemen
                    //conn.Close();


                    /*using Linq*/
                    db.PhongBan_Delete(Convert.ToInt32(comboBoxPhongBan.SelectedValue));
                    MessageBox.Show("Deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Load form again
                    Form1_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Deleted failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        //SinhVien
        private void buttonAddSV_Click(object sender, EventArgs e)
        {
            try
            {
                //conn.Open();
                ///*using procedure*/
                //var cmd = new SqlCommand("NhanVien_Insert", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = textBoxfullName.Text;
                //cmd.Parameters.Add("@homeTown", SqlDbType.NVarChar).Value = textBoxhomeTown.Text;
                //cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(comboBoxPhongBan.SelectedValue);

                ///*using normal*/
                ////var cmd = new SqlCommand("INSERT INTO SinhVien(fullName,homeTown,ID) " +
                ////"VALUES('" + textBoxfullName.Text + "','"+textBoxhomeTown.Text+"',"+Convert.ToInt32(comboBoxPhongBan.SelectedValue)+")", conn);
                //cmd.ExecuteNonQuery(); //ExecuteNonQuery: a command that does not return any data, such as an INSERT, UPDATE, or DELETE statemen
                //conn.Close();

                /*using Linq*/
                db.NhanVien_Insert(textBoxfullName.Text, textBoxhomeTown.Text, Convert.ToInt32(comboBoxPhongBan.SelectedValue));

                textBoxIDStudent.Text = "";
                textBoxfullName.Text = "";
                textBoxhomeTown.Text = "";
                textBoxfullName.Focus(); //move cursor here
                MessageBox.Show("Added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Load form again
                comboBoxPhongBan_SelectedIndexChanged(sender, e);
            }
            catch
            {
                MessageBox.Show("Added failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSaveSV_Click(object sender, EventArgs e)
        {
            try
            {
                //conn.Open();
                ///*using procedure*/
                //var cmd = new SqlCommand("NhanVien_Update", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = textBoxfullName.Text;
                //cmd.Parameters.Add("@homeTown", SqlDbType.NVarChar).Value = textBoxhomeTown.Text;
                //cmd.Parameters.Add("@IDStudent", SqlDbType.Int).Value =Convert.ToInt32(textBoxIDStudent.Text);

                ///*using normal*/
                ////var cmd = new SqlCommand("UPDATE SinhVien SET fullName ='"
                ////   + textBoxfullName.Text + "', homeTown='"+textBoxhomeTown.Text+"' WHERE IDStudent="
                ////  + Convert.ToInt32(textBoxIDStudent.Text) +"",conn);
                //cmd.ExecuteNonQuery(); //ExecuteNonQuery: a command that does not return any data, such as an INSERT, UPDATE, or DELETE statemen
                //conn.Close();

                /*using Linq*/
                db.NhanVien_Update(textBoxfullName.Text, textBoxhomeTown.Text, Convert.ToInt32(textBoxIDStudent.Text));

                MessageBox.Show("Updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Load form again
                comboBoxPhongBan_SelectedIndexChanged(sender, e);
            }
            catch
            {
                MessageBox.Show("Added failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteSV_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Are you sure want to delete? " + textBoxfullName.Text + "?",
               "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (lenh == DialogResult.Yes)
            {
                try
                {
                    //conn.Open();
                    ///*using procedure*/
                    //var cmd = new SqlCommand("NhanVien_Delete", conn);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@IDStudent", SqlDbType.Int).Value = Convert.ToInt32(textBoxIDStudent.Text);

                    ///*using normal*/
                    ////var cmd = new SqlCommand("DELETE FROM SinhVien WHERE IDStudent = "
                    ////+ Convert.ToInt32(textBoxIDStudent.Text) + "", conn);
                    //cmd.ExecuteNonQuery(); //ExecuteNonQuery: a command that does not return any data, such as an INSERT, UPDATE, or DELETE statemen
                    //conn.Close();

                    /*using Linq*/
                    db.NhanVien_Delete(Convert.ToInt32(textBoxIDStudent.Text));

                    MessageBox.Show("Deleted successfully!");

                    //Load form again
                    comboBoxPhongBan_SelectedIndexChanged(sender, e);

                }
                catch
                {
                    MessageBox.Show("Deleted failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
