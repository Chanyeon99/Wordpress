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

namespace UserManagement
{
    public partial class FrmUser : Form
    {
        private static int? IdUser = null;
        private static int pageIndex;
        private static double Total_Page;
        private static int pageSize;
        private static string ImageLocation;
        private static byte[] ByteAvatar;
        public FrmUser()
        {
            InitializeComponent();
            pageIndex = 1;
            pageSize = 13;
            Total_Page = 0;
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            cbboxGender.Text = "Nam";

            var departments = Extendsion.Departments();

            var dropdown = Extendsion.BuildDropDownlist(departments, 0, 0);
            var departmentsForm = dropdown;
            cbboxDepartmentForm.DataSource = departmentsForm;
            cbboxDepartmentForm.DisplayMember = "Name";
            cbboxDepartmentForm.ValueMember = "Id";


            var departmentsFilter = Extendsion.CollectionToDataTableDefaultSelect<NodeViewModel>(dropdown);
            DataRow DefaultSelectFilter = departmentsFilter.NewRow();
            DefaultSelectFilter[0] = DBNull.Value;
            DefaultSelectFilter[1] = "== Tất cả đơn vị,phòng ban ==";

            departmentsFilter.Rows.InsertAt(DefaultSelectFilter, 0);

            cbboxDepartmentFilter.DataSource = departmentsFilter;
            cbboxDepartmentFilter.DisplayMember = "Name";
            cbboxDepartmentFilter.ValueMember = "Id";
            radioAll.Checked = true;
            CreateModel();
            PaginationUser();
        }

        private bool ValidateUser()
        {
            if (txtName.Text.Length == 0 || cbboxSalary.DataSource == null || txtInsuranceSociety.Text.Length == 0)
            {
                if (txtName.Text.Length == 0)
                {
                    labelRequiredName.Visible = true;
                }
                else
                {
                    labelRequiredName.Visible = false;
                }
                if (txtInsuranceSociety.Text.Length == 0)
                {
                    lblRequiredInsuranceSociety.Visible = true;
                }
                else
                {
                    try
                    {
                        var check = double.Parse(txtInsuranceSociety.Text);
                        lblRequiredInsuranceSociety.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        lblRequiredInsuranceSociety.Visible = true;
                    }
                }
                if (cbboxSalary.DataSource == null)
                {
                    lblreuiqredsalary.Visible = true;
                }
                else
                {
                    lblreuiqredsalary.Visible = false;
                }
                return false;
            }
            else
            {
                try
                {
                    var check = double.Parse(txtInsuranceSociety.Text);
                    lblRequiredInsuranceSociety.Visible = false;
                }
                catch(Exception ex)
                {
                    lblRequiredInsuranceSociety.Visible = true;
                    return false;
                }
                labelRequiredName.Visible = false;
                lblreuiqredsalary.Visible = false;
                return true;
            }
        }

        private void CreateModel()
        {
            IdUser = null;
            txtName.Text = null;
            txtIdCard.Text = null;
            txtEmail.Text = null;
            txtAddress.Text = null;
            BtnCreate.Visible = false;
            checkWorking.Checked = false;
            btnDelete.Visible = false;
            txtInsuranceSociety.Text = null;
            ImageLocation = null;
            Avatar.Image = null;
            ByteAvatar = null;
            txtPhone.Text = null;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateModel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Extendsion.ImageLocation(ref ImageLocation, ref Avatar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PaginationUser()
        {
            var request = new PaginationUserRequest();
            request.pageIndex = pageIndex;
            request.pageSize = pageSize;
            if (cbboxDepartmentFilter.SelectedValue == System.DBNull.Value || cbboxDepartmentFilter.SelectedValue == null || cbboxDepartmentFilter.SelectedValue.ToString()== "System.Data.DataRowView")
            {
                request.DepartmentId = null;
            }
            else
            {
                request.DepartmentId = (int)cbboxDepartmentFilter.SelectedValue;
            }
            if (radioAll.Checked == true)
            {
                request.IsWorking = null;
            }
            else if (radioWorking.Checked == true)
            {
                request.IsWorking = true;
            }
            else
            {
                request.IsWorking = false;
            }
            request.NameSearch = txtSearch.Text.Length == 0 ? null : txtSearch.Text.Trim();



            var result = Extendsion.Users(request);
            //Fill Data Return to DataGrid , Remove Column Total
            GridUser.DataSource = result.Select(c => new {
                Id = c.Id,
                FullName = c.FullName,
                Gender = c.Gender,
                Phone = c.Phone,
                DayOfBirth = c.DayOfBirth
            }).ToList();

            //Get pagination result (Current page & Total page)
            var pagination = Extendsion.Pagination<UserViewModel>(result, request);

            //Set globals Total page
            Total_Page = pagination.TotalPage;

            //Set Display pagination UI
            LblPageIndex.Text = pageIndex + " / " + Total_Page;

            //if else ..
            if (pageIndex == 1) // you are stay top page
            {
                btnBackpage.Enabled = false;
                btnBeginPage.Enabled = false;
            }
            else
            {
                btnBackpage.Enabled = true;
                btnBeginPage.Enabled = true;
            }

            if (pageIndex == Total_Page) // you are stay last page
            {
                BtnNextPage.Enabled = false;
                BtnEndPage.Enabled = false;
            }
            else
            {
                BtnNextPage.Enabled = true;
                BtnEndPage.Enabled = true;
            }

            if (Total_Page == 0 && pageIndex > 0)
            {
                if (pageIndex == 1)
                {
                    return;
                }
                else
                {
                    pageIndex--;
                    PaginationUser();
                }
            }
        }

        private void cbboxDepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PaginationUser();
        }

        private void btnBeginPage_Click(object sender, EventArgs e)
        {
            if (Total_Page == 0)
            {
                return;
            };
            if (pageIndex == 1)
            {
                MessageBox.Show("Bạn đang ở trang đầu tiên");
            }
            else
            {
                pageIndex = 1;
                PaginationUser();
            }
        }

        private void btnBackpage_Click(object sender, EventArgs e)
        {
            if (Total_Page == 0)
            {
                return;
            };
            if (pageIndex == 1)
            {
                MessageBox.Show("Bạn đang ở trang đầu tiên");
            }
            else
            {
                pageIndex--;
                PaginationUser();
            }
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (Total_Page == 0)
            {
                return;
            };
            if (pageIndex == Total_Page)
            {
                MessageBox.Show("Bạn đang ở trang cuối cùng");
            }
            else
            {
                pageIndex++;
                PaginationUser();
            }
        }

        private void BtnEndPage_Click(object sender, EventArgs e)
        {
            if (Total_Page == 0)
            {
                return;
            };
            if (pageIndex == Total_Page)
            {
                MessageBox.Show("Bạn đang ở trang cuối cùng");
            }
            else
            {
                pageIndex = (int)Total_Page;
                PaginationUser();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IdUser == null)
            {
                MessageBox.Show("Không xác định được giảng viên cần xóa");
                return;
            }
            else
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Xóa nhân viên này", "Delete ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (thongbao == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "UserDelete";
                        cmd.Parameters.Add(new SqlParameter("@Id", IdUser));
                        var x = cmd.ExecuteNonQuery();
                        if (x == 1)
                        {
                            MessageBox.Show("Delete Success");
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed");
                        }
                        con.Close();
                    }
                    CreateModel();
                    PaginationUser();
                }
            }
        }

        private void cbboxDepartmentForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbboxSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbboxSalary.DataSource != null)
            {
                var t = cbboxSalary.SelectedValue.ToString();
                if (t == "System.Data.DataRowView")
                {
                    return;
                }
                var IdDepartment = Extendsion.GetIdDepartmentBySalaryId(int.Parse(t));
                cbboxDepartmentForm.SelectedValue = IdDepartment;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUser() == false)
            {
                return;
            }
            else
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UserSave";
                    if (IdUser == null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", IdUser));
                    }
                    cmd.Parameters.Add(new SqlParameter("@FullName", txtName.Text));
                    cmd.Parameters.Add(new SqlParameter("@Gender", cbboxGender.Text));
                    cmd.Parameters.Add(new SqlParameter("@IdCard",txtIdCard.Text));
                    cmd.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@Address", txtAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("@Phone", txtPhone.Text));
                    cmd.Parameters.Add(new SqlParameter("@DayOfBirth", dateTimeDayofBirth.Value));
                    cmd.Parameters.Add(new SqlParameter("@SalaryId", (int)cbboxSalary.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@DepartmentId", (int)cbboxDepartmentForm.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@InsuranceSociety", double.Parse(txtInsuranceSociety.Text)));
                    cmd.Parameters.Add(new SqlParameter("@IsWorking", checkWorking.Checked));
                    var avatar = ImageLocation == null ? ByteAvatar : Extendsion.ByteForImage(ImageLocation);
                    if(avatar == null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@Avatar", DBNull.Value)).SqlDbType = SqlDbType.Image;
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("Avatar", avatar));
                    }
                    var x = cmd.ExecuteNonQuery();
                    if (x == 1)
                    {
                        MessageBox.Show("Saved Success");
                    }
                    else
                    {
                        MessageBox.Show("Saved Failed");
                    }
                    con.Close();
                }
                PaginationUser();
                CreateModel();
                BtnCreate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateUser();
        }

        private void GridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Entity = GridUser.CurrentRow.Cells["Id"].Value.ToString();

            var result = Extendsion.GetUserById(int.Parse(Entity));

            if (result.Rows.Count != 0)
            {
                cbboxDepartmentForm_SelectedIndexChanged(sender, e);
                foreach (DataRow data in result.Rows)
                {
                    IdUser = (int)data["Id"];
                    txtName.Text = data["FullName"].ToString();
                    txtAddress.Text = data["Address"].ToString();
                    txtEmail.Text = data["Email"].ToString();
                    txtIdCard.Text = data["IdCard"].ToString();
                    cbboxGender.Text = data["Gender"].ToString();
                    dateTimeDayofBirth.Value = (DateTime)data["DayOfBirth"];
                    cbboxDepartmentForm.SelectedValue = (int)data["DepartmentId"];
                    cbboxSalary.SelectedValue = (int)data["SalaryId"];
                    checkWorking.Checked = data["IsWorking"] == DBNull.Value ? false : (bool)data["IsWorking"];
                    txtInsuranceSociety.Text = data["InsuranceSociety"].ToString();
                    txtPhone.Text = data["Phone"].ToString();
                    if (data["Avatar"] != null && data["Avatar"] != System.DBNull.Value)
                    {
                        Extendsion.SetImage((byte[])data["Avatar"], ref Avatar);
                        ByteAvatar = (byte[])data["Avatar"];
                    }
                    else
                    {
                        Avatar.Image = null;
                        ByteAvatar = null;
                    }
                }
                BtnCreate.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                MessageBox.Show("Get User Failed");
            }
        }

        private void cbboxDepartmentForm_SelectedValueChanged(object sender, EventArgs e)
        {
            var t = cbboxDepartmentForm.SelectedValue.ToString();
            if (t == "System.Data.DataRowView" || t == "UserManagement.NodeViewModel")
            {
                return;
            }
            var SalaryByDepartment = Extendsion.AllSalaryBase((int)cbboxDepartmentForm.SelectedValue);
            if (SalaryByDepartment.Rows.Count == 0)
            {
                cbboxSalary.DataSource = null;
            }
            else
            {

                cbboxSalary.DataSource = SalaryByDepartment;
                cbboxSalary.DisplayMember = "Name";
                cbboxSalary.ValueMember = "Id";
                ValidateUser();
            }
        }

        private void cbboxDepartmentFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            var t = cbboxDepartmentFilter.SelectedValue.ToString();
            if (t == "System.Data.DataRowView")
            {
                return;
            }
            pageIndex = 1;
            PaginationUser();
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            PaginationUser();
        }

        private void radioWorking_CheckedChanged(object sender, EventArgs e)
        {
            PaginationUser();
        }

        private void radioNotWork_CheckedChanged(object sender, EventArgs e)
        {
            PaginationUser();
        }

        private void txtInsuranceSociety_TextChanged(object sender, EventArgs e)
        {
            ValidateUser();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimeDayofBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAutoCreateUser_Click(object sender, EventArgs e)
        {
            using (var form = new FrmAutoCreate())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "AutoCreateUser";
                        cmd.Parameters.Add(new SqlParameter("@QuanitytyUser", form.Quantity));
                        var x = cmd.ExecuteNonQuery();
                        if (x <= 0)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại. Hãy đảm bảo răng bạn có ít nhất 1 đơn vị,phòng ban và mức lương trực thuộc đơn vị phòng ban đó");
                        }
                        else
                        {
                            MessageBox.Show("Đã tự động tạo mới " + form.Quantity +" Nhân viên");
                        }
                        con.Close();
                    }
                    this.PaginationUser();
                }
            }
        }
    }
}
