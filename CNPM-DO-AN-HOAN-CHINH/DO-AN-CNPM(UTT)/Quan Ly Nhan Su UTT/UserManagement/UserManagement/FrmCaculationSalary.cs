using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class FrmCaculationSalary : Form
    {
        private static int pageIndex;
        private static double Total_Page;
        private static int pageSize;
        private static string LocationExcel = null;
        private DateTime CurrentStartDate;
        private DateTime CurrentEndDate;
        public FrmCaculationSalary()
        {
            InitializeComponent();
            pageIndex = 1;
            pageSize = 13;
            Total_Page = 0;
        }


        private void PaginationCalculationUserSalary()
        {
            var request = new PaginationUserCaculationSalaryRequest();
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
            request.NameSearch = txtSearch.Text.Length == 0 ? null : txtSearch.Text.Trim();

            request.StartDate = StartDate.Value;
            request.EndDate = EndDate.Value;

            var result = Extendsion.CalculationSalaryUser(request);
            //Fill Data Return to DataGrid , Remove Column Total
            GridCaculationSalary.DataSource = result.Select(c => new {
                IdUser =c.IdUser,
                FullName = c.FullName,
                DepartmentName = c.DepartmentName,
                SalaryValue = c.SalaryValue,
                AllowanceValue = c.AllowanceValue,
                TotalWork = c.TotalWork,
                TotalSalaryBase = c.TotalSalaryBase,
                InsuranceSociety = c.InsuranceSociety,
                BonusValue = c.BonusValue,
                PenaltyValue = c.PenaltyValue,
                AdvanceValue = c.AdvanceValue,
                RealSalary = c.RealSalary
            }).ToList();

            //Get pagination result (Current page & Total page)
            var pagination = Extendsion.Pagination<UserCalculationSalaryVm>(result, request);

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
                    PaginationCalculationUserSalary();
                }
            }
        }

        private void FrmCaculationSalary_Load(object sender, EventArgs e)
        {
            var departments = Extendsion.Departments();

            var dropdown = Extendsion.BuildDropDownlist(departments, 0, 0);

            var departmentsFilter = Extendsion.CollectionToDataTableDefaultSelect<NodeViewModel>(dropdown);
            DataRow DefaultSelectFilter = departmentsFilter.NewRow();
            DefaultSelectFilter[0] = DBNull.Value;
            DefaultSelectFilter[1] = "== Tất cả đơn vị,phòng ban ==";

            departmentsFilter.Rows.InsertAt(DefaultSelectFilter, 0);


            cbboxDepartmentFilter.DataSource = departmentsFilter;
            cbboxDepartmentFilter.DisplayMember = "Name";
            cbboxDepartmentFilter.ValueMember = "Id";
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            PaginationCalculationUserSalary();
            CurrentStartDate = StartDate.Value;
            CurrentEndDate = EndDate.Value;
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
                PaginationCalculationUserSalary();
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
                PaginationCalculationUserSalary();
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
                PaginationCalculationUserSalary();
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
                PaginationCalculationUserSalary();
            }
        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            LocationExcel = Extendsion.GetLocationForExcel();
            lblLocation.Text = "=> " + LocationExcel;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (LocationExcel == null)
            {
                MessageBox.Show("Chưa có đường dẫn để xuất dữ liệu");
                return;
            }

            var request = new PaginationUserCaculationSalaryRequest();
            request.pageIndex = 1;
            request.pageSize = 0;
            if (cbboxDepartmentFilter.SelectedValue == System.DBNull.Value || cbboxDepartmentFilter.SelectedValue == null || cbboxDepartmentFilter.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                request.DepartmentId = null;
            }
            else
            {
                request.DepartmentId = (int)cbboxDepartmentFilter.SelectedValue;
            }
            request.NameSearch = txtSearch.Text.Length == 0 ? null : txtSearch.Text.Trim();

            request.StartDate = StartDate.Value;
            request.EndDate = EndDate.Value;

            var result = Extendsion.ReportCalculationSalary(request, LocationExcel);
            if (result == true)
            {
                MessageBox.Show("Xuất file thành công");
                LocationExcel = null;
                lblLocation.Text = "=> ";
            }
            else
            {
                MessageBox.Show("Xuất file thất bại");
            }
        }

        private void GridCaculationSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var IdUser = (int)GridCaculationSalary.CurrentRow.Cells["Id"].Value;
            FrmUserSalaryDetail frm = new FrmUserSalaryDetail(IdUser, CurrentStartDate,CurrentEndDate);
            frm.Show();
        }
    }
}
