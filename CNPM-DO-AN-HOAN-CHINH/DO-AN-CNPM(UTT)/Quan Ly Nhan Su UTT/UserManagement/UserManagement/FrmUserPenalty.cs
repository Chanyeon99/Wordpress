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
    public partial class FrmUserPenalty : Form
    {
        private static int? IdUserPenalty = null;
        private static int pageIndex;
        private static double Total_Page;
        private static int pageSize;
        public FrmUserPenalty()
        {
            InitializeComponent();
            pageIndex = 1;
            pageSize = 13;
            Total_Page = 0;
        }

        private void PaginationUserPenalty()
        {
            var request = new PaginationUserPenaltyRequest();
            request.pageIndex = pageIndex;
            request.pageSize = pageSize;
            if (cbboxDepartmentFilter.SelectedValue == System.DBNull.Value || cbboxDepartmentFilter.SelectedValue == null || cbboxDepartmentFilter.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                request.DepartmentId = null;
            }
            else
            {
                request.DepartmentId = (int)cbboxDepartmentFilter.SelectedValue;
            }
            if (RadioAllDay.Checked == true)
            {
                request.DatePenalty = null;
            }
            else
            {
                request.DatePenalty = DayFilter.Value;
            }
            request.NameSearch = txtSearch.Text.Length == 0 ? null : txtSearch.Text.Trim();



            var result = Extendsion.UserPenaltyAll(request);
            //Fill Data Return to DataGrid , Remove Column Total
            GridUserPenalty.DataSource = result.Select(c => new {
                Id = c.Id,
                UserId = c.UserId,
                FullName = c.FullName,
                DepartmentName = c.DepartmentName,
                DatePenalty = c.DatePenalty,
                PenaltyName = c.PenaltyName,
                ValuePenalty = c.ValuePenalty
            }).ToList();

            //Get pagination result (Current page & Total page)
            var pagination = Extendsion.Pagination<UserPenaltyViewModel>(result, request);

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
                    PaginationUserPenalty();
                }
            }
        }

        private bool ValidateUserPenalty()
        {
            if (txtIdUser.Text.Length == 0 || cbboxFullName.DataSource == null)
            {
                labelRequiredName.Visible = true;
                return false;
            }
            else
            {
                labelRequiredName.Visible = false;
                return true;
            }
        }

        private void FrmUserPenalty_Load(object sender, EventArgs e)
        {
            RadioAllDay.Checked = true;
            DayFilter.Enabled = false;

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

            var Bonus = Extendsion.AllPenalty();
            cbboxBonus.DataSource = Bonus;
            cbboxBonus.DisplayMember = "Name";
            cbboxBonus.ValueMember = "Id";
            PaginationUserPenalty();
            CreateModel();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PaginationUserPenalty();
        }

        private void RadioAllDay_CheckedChanged(object sender, EventArgs e)
        {
            DayFilter.Enabled = false;
            PaginationUserPenalty();
        }

        private void radioDay_CheckedChanged(object sender, EventArgs e)
        {
            DayFilter.Enabled = true;
            PaginationUserPenalty();
        }

        private void cbboxDepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaginationUserPenalty();
        }

        private void CreateModel()
        {
            IdUserPenalty = null;
            txtIdUser.Text = null;
            cbboxFullName.DataSource = null;
            BtnCreate.Visible = false;
            btnDelete.Visible = false;
            cbboxFullName.Enabled = true;
        }


        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateModel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (IdUserPenalty == null)
            {
                MessageBox.Show("Không có đối tượng cần xóa");
            }
            else
            {
                DialogResult Notification;
                Notification = MessageBox.Show("Delete", "Bạn thực sự muốn xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Notification == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "UserPenaltyDelete";
                        cmd.Parameters.Add(new SqlParameter("@Id", IdUserPenalty));
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
                    PaginationUserPenalty();
                }

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserPenalty() == false)
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
                    cmd.CommandText = "UserPenaltySave";
                    if (IdUserPenalty == null)
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", DBNull.Value));
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@Id", IdUserPenalty));
                    }
                    cmd.Parameters.Add(new SqlParameter("@IdUser", int.Parse(txtIdUser.Text)));
                    cmd.Parameters.Add(new SqlParameter("@IdPenalty", (int)cbboxBonus.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@DatePenalty", DateBonus.Value));
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
                PaginationUserPenalty();
                CreateModel();
                BtnCreate.Visible = false;
                btnDelete.Visible = false;
            }
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
                PaginationUserPenalty();
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
                PaginationUserPenalty();
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
                PaginationUserPenalty();
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
                PaginationUserPenalty();
            }
        }

        private void GridUserPenalty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Entity = GridUserPenalty.CurrentRow.Cells["IdCL"].Value.ToString();

            var result = Extendsion.GetUserPenaltyById(int.Parse(Entity));

            if (result.Rows.Count != 0)
            {
                cbboxDepartmentForm_SelectedIndexChanged(sender, e);
                foreach (DataRow data in result.Rows)
                {
                    IdUserPenalty = (int)data["Id"];
                    txtIdUser.Text = data["UserId"].ToString();
                    cbboxDepartmentForm.SelectedValue = (int)data["DepartmentId"];
                    cbboxBonus.SelectedValue = (int)data["PenaltyId"];
                    cbboxFullName.SelectedValue = (int)data["UserId"];
                    DateBonus.Value = (DateTime)data["DatePenalty"];
                }
                cbboxFullName.Enabled = false;
                BtnCreate.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                MessageBox.Show("Get User Failed");
            }
        }

        private void cbboxDepartmentForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = cbboxDepartmentForm.SelectedValue.ToString();
            if (t == "System.Data.DataRowView" || t == "UserManagement.NodeViewModel")
            {
                return;
            }
            var request = new PaginationUserRequest()
            {
                pageIndex = 1,
                pageSize = 0,
                DepartmentId = int.Parse(t),
                NameSearch = null
            };
            var UserByDepartment = Extendsion.Users(request);
            if (UserByDepartment.Count == 0)
            {
                cbboxFullName.DataSource = null;
            }
            else
            {
                cbboxFullName.DataSource = UserByDepartment;
                cbboxFullName.DisplayMember = "FullName";
                cbboxFullName.ValueMember = "Id";
            }
        }

        private void cbboxFullName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbboxFullName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbboxFullName.DataSource != null && cbboxFullName.SelectedValue != null)
            {
                var t = cbboxFullName.SelectedValue.ToString();
                if (t == "System.Data.DataRowView" || t == "UserManagement.UserViewModel")
                {
                    return;
                }
                txtIdUser.Text = t;
                ValidateUserPenalty();
            }
        }

        private void DayFilter_ValueChanged(object sender, EventArgs e)
        {
            PaginationUserPenalty();
        }

        private void cbboxDepartmentForm_SelectedValueChanged(object sender, EventArgs e)
        {
            var t = cbboxDepartmentForm.SelectedValue.ToString();
            if (t == "System.Data.DataRowView" || t == "UserManagement.NodeViewModel")
            {
                return;
            }
            var request = new PaginationUserRequest()
            {
                pageIndex = 1,
                pageSize = 0,
                DepartmentId = int.Parse(t),
                NameSearch = null
            };
            var UserByDepartment = Extendsion.Users(request);
            if (UserByDepartment.Count == 0)
            {
                cbboxFullName.DataSource = null;
            }
            else
            {
                cbboxFullName.DataSource = UserByDepartment;
                cbboxFullName.DisplayMember = "FullName";
                cbboxFullName.ValueMember = "Id";
            }
        }
    }
}
