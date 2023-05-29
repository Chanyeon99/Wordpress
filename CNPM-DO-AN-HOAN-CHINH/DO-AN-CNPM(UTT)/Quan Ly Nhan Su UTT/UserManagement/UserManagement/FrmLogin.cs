﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class FrmLogin : Form
    {
        public SendLogin send;
        public FrmLogin(SendLogin sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                labelRequiredUserName.Visible = true;
            }
            if (txtPassword.Text.Length == 0)
            {
                labelRequiredPassword.Visible = true;
            }

            if (txtUsername.Text.Length != 0 && txtPassword.Text.Length != 0)
            {
                //var request = new LoginRequest()
                //{
                //    UserName = txtUsername.Text,
                //    Password = Extendsion.Extendsion.GetMD5(txtPassword.Text)
                //};
                //var response = await _userServiceClient.LoginAsync(request);
                //if (!response.Success)
                //{
                //    MessageBox.Show(response.Message);
                //}
                //else
                //{
                //    this.Close();
                //    this.send(response.Data.FullName, response.Data.UserType, response.Data.Id);
                //}
            }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                labelRequiredUserName.Visible = true;
            }
            else
            {
                labelRequiredUserName.Visible = false;
            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

            if (txtPassword.Text.Length == 0)
            {
                labelRequiredPassword.Visible = true;
            }
            else
            {
                labelRequiredPassword.Visible = false;
            }
        }

        private string GetMD5(string txt)
        {
            string str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }


        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                labelRequiredUserName.Visible = true;
            }
            if (txtPassword.Text.Length == 0)
            {
                labelRequiredPassword.Visible = true;
            }

            if (txtUsername.Text.Length != 0 && txtPassword.Text.Length != 0)
            {
                var DtTable = new DataTable();
                SqlConnection con = new SqlConnection(ConnectionString.connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LoginUser";
                cmd.Parameters.Add(new SqlParameter("@UserName", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("@Password", GetMD5(txtPassword.Text)));
                SqlDataReader reader = cmd.ExecuteReader();
                DtTable.Load(reader);
                con.Close();

                if(DtTable.Rows.Count==0)
                {
                    MessageBox.Show("Login Failed . Username or password correct");
                    return;
                }
                else
                {
                    foreach (DataRow row in DtTable.Rows)
                    {
                        string fullName = row["FullName"].ToString();
                        int Id = (int)row["Id"];
                        this.send(fullName, Id);
                        this.Close();
                        break;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkViewPass.Checked ==true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}