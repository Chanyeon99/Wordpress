
namespace UserManagement
{
    partial class FrmUserPenalty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserPenalty));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DayFilter = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.radioDay = new System.Windows.Forms.RadioButton();
            this.RadioAllDay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbboxFullName = new System.Windows.Forms.ComboBox();
            this.labelRequiredName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.DateBonus = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbboxBonus = new System.Windows.Forms.ComboBox();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbboxDepartmentForm = new System.Windows.Forms.ComboBox();
            this.GridUserPenalty = new System.Windows.Forms.DataGridView();
            this.IdCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentNameCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePenaltyCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenaltyNameCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValuePenaltyCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbboxDepartmentFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblPageIndex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEndPage = new System.Windows.Forms.Button();
            this.BtnNextPage = new System.Windows.Forms.Button();
            this.btnBackpage = new System.Windows.Forms.Button();
            this.btnBeginPage = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUserPenalty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.DayFilter);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.radioDay);
            this.groupBox3.Controls.Add(this.RadioAllDay);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.GridUserPenalty);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.cbboxDepartmentFilter);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(22, 49);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(1016, 535);
            this.groupBox3.TabIndex = 134;
            this.groupBox3.TabStop = false;
            // 
            // DayFilter
            // 
            this.DayFilter.CustomFormat = "dd-MM-yyyy";
            this.DayFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DayFilter.Location = new System.Drawing.Point(471, 51);
            this.DayFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DayFilter.Name = "DayFilter";
            this.DayFilter.Size = new System.Drawing.Size(157, 20);
            this.DayFilter.TabIndex = 133;
            this.DayFilter.ValueChanged += new System.EventHandler(this.DayFilter_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 135;
            this.label6.Text = "Ngày  :";
            // 
            // radioDay
            // 
            this.radioDay.AutoSize = true;
            this.radioDay.Location = new System.Drawing.Point(342, 52);
            this.radioDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioDay.Name = "radioDay";
            this.radioDay.Size = new System.Drawing.Size(96, 17);
            this.radioDay.TabIndex = 134;
            this.radioDay.TabStop = true;
            this.radioDay.Text = "Xem theo ngày";
            this.radioDay.UseVisualStyleBackColor = true;
            this.radioDay.CheckedChanged += new System.EventHandler(this.radioDay_CheckedChanged);
            // 
            // RadioAllDay
            // 
            this.RadioAllDay.AutoSize = true;
            this.RadioAllDay.Location = new System.Drawing.Point(140, 51);
            this.RadioAllDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioAllDay.Name = "RadioAllDay";
            this.RadioAllDay.Size = new System.Drawing.Size(76, 17);
            this.RadioAllDay.TabIndex = 133;
            this.RadioAllDay.TabStop = true;
            this.RadioAllDay.Text = "Xem tất cả";
            this.RadioAllDay.UseVisualStyleBackColor = true;
            this.RadioAllDay.CheckedChanged += new System.EventHandler(this.RadioAllDay_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbboxFullName);
            this.groupBox1.Controls.Add(this.labelRequiredName);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnCreate);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.DateBonus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbboxBonus);
            this.groupBox1.Controls.Add(this.txtIdUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbboxDepartmentForm);
            this.groupBox1.Location = new System.Drawing.Point(640, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(363, 413);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            // 
            // cbboxFullName
            // 
            this.cbboxFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbboxFullName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbboxFullName.FormattingEnabled = true;
            this.cbboxFullName.Location = new System.Drawing.Point(122, 117);
            this.cbboxFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbboxFullName.Name = "cbboxFullName";
            this.cbboxFullName.Size = new System.Drawing.Size(224, 21);
            this.cbboxFullName.TabIndex = 132;
            this.cbboxFullName.SelectedIndexChanged += new System.EventHandler(this.cbboxFullName_SelectedIndexChanged);
            this.cbboxFullName.SelectedValueChanged += new System.EventHandler(this.cbboxFullName_SelectedValueChanged);
            // 
            // labelRequiredName
            // 
            this.labelRequiredName.AutoSize = true;
            this.labelRequiredName.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredName.Location = new System.Drawing.Point(120, 139);
            this.labelRequiredName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequiredName.Name = "labelRequiredName";
            this.labelRequiredName.Size = new System.Drawing.Size(180, 13);
            this.labelRequiredName.TabIndex = 130;
            this.labelRequiredName.Text = "Tên nhân viên không được để trống";
            this.labelRequiredName.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(182, 277);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 128;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(266, 277);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(80, 32);
            this.BtnSave.TabIndex = 129;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Image = ((System.Drawing.Image)(resources.GetObject("BtnCreate.Image")));
            this.BtnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreate.Location = new System.Drawing.Point(21, 277);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(80, 32);
            this.BtnCreate.TabIndex = 127;
            this.BtnCreate.Text = "Tạo mới";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Visible = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 234);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 126;
            this.label16.Text = "Ngày phạt  :";
            // 
            // DateBonus
            // 
            this.DateBonus.CustomFormat = "dd-MM-yyyy";
            this.DateBonus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateBonus.Location = new System.Drawing.Point(122, 234);
            this.DateBonus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateBonus.Name = "DateBonus";
            this.DateBonus.Size = new System.Drawing.Size(224, 20);
            this.DateBonus.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 124;
            this.label5.Text = "Mức phạt  :";
            // 
            // cbboxBonus
            // 
            this.cbboxBonus.FormattingEnabled = true;
            this.cbboxBonus.Location = new System.Drawing.Point(122, 193);
            this.cbboxBonus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbboxBonus.Name = "cbboxBonus";
            this.cbboxBonus.Size = new System.Drawing.Size(224, 21);
            this.cbboxBonus.TabIndex = 123;
            // 
            // txtIdUser
            // 
            this.txtIdUser.Enabled = false;
            this.txtIdUser.Location = new System.Drawing.Point(122, 154);
            this.txtIdUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.ReadOnly = true;
            this.txtIdUser.Size = new System.Drawing.Size(224, 20);
            this.txtIdUser.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 121;
            this.label3.Text = "Mã nhân viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "Họ và tên  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Đơn vị ,phòng ban  :";
            // 
            // cbboxDepartmentForm
            // 
            this.cbboxDepartmentForm.FormattingEnabled = true;
            this.cbboxDepartmentForm.Location = new System.Drawing.Point(122, 80);
            this.cbboxDepartmentForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbboxDepartmentForm.Name = "cbboxDepartmentForm";
            this.cbboxDepartmentForm.Size = new System.Drawing.Size(224, 21);
            this.cbboxDepartmentForm.TabIndex = 117;
            this.cbboxDepartmentForm.SelectedIndexChanged += new System.EventHandler(this.cbboxDepartmentForm_SelectedIndexChanged);
            this.cbboxDepartmentForm.SelectedValueChanged += new System.EventHandler(this.cbboxDepartmentForm_SelectedValueChanged);
            // 
            // GridUserPenalty
            // 
            this.GridUserPenalty.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridUserPenalty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUserPenalty.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUserPenalty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridUserPenalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUserPenalty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCL,
            this.UserId,
            this.FullNameCL,
            this.DepartmentNameCL,
            this.DatePenaltyCL,
            this.PenaltyNameCL,
            this.ValuePenaltyCL});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUserPenalty.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridUserPenalty.EnableHeadersVisualStyles = false;
            this.GridUserPenalty.Location = new System.Drawing.Point(22, 106);
            this.GridUserPenalty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridUserPenalty.Name = "GridUserPenalty";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUserPenalty.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridUserPenalty.RowHeadersVisible = false;
            this.GridUserPenalty.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridUserPenalty.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.GridUserPenalty.RowTemplate.Height = 24;
            this.GridUserPenalty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridUserPenalty.Size = new System.Drawing.Size(605, 351);
            this.GridUserPenalty.TabIndex = 116;
            this.GridUserPenalty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUserPenalty_CellContentClick);
            // 
            // IdCL
            // 
            this.IdCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdCL.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdCL.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdCL.FillWeight = 30F;
            this.IdCL.HeaderText = "Id";
            this.IdCL.MinimumWidth = 6;
            this.IdCL.Name = "IdCL";
            this.IdCL.ReadOnly = true;
            this.IdCL.Width = 41;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "MNV";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 56;
            // 
            // FullNameCL
            // 
            this.FullNameCL.DataPropertyName = "FullName";
            this.FullNameCL.HeaderText = "Họ và tên";
            this.FullNameCL.MinimumWidth = 6;
            this.FullNameCL.Name = "FullNameCL";
            this.FullNameCL.ReadOnly = true;
            this.FullNameCL.Width = 138;
            // 
            // DepartmentNameCL
            // 
            this.DepartmentNameCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DepartmentNameCL.DataPropertyName = "DepartmentName";
            this.DepartmentNameCL.HeaderText = "Đơn vị,Phòng ban";
            this.DepartmentNameCL.MinimumWidth = 6;
            this.DepartmentNameCL.Name = "DepartmentNameCL";
            this.DepartmentNameCL.ReadOnly = true;
            this.DepartmentNameCL.Width = 108;
            // 
            // DatePenaltyCL
            // 
            this.DatePenaltyCL.DataPropertyName = "DatePenalty";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.DatePenaltyCL.DefaultCellStyle = dataGridViewCellStyle4;
            this.DatePenaltyCL.HeaderText = "Ngày phạt";
            this.DatePenaltyCL.MinimumWidth = 6;
            this.DatePenaltyCL.Name = "DatePenaltyCL";
            this.DatePenaltyCL.ReadOnly = true;
            this.DatePenaltyCL.Width = 125;
            // 
            // PenaltyNameCL
            // 
            this.PenaltyNameCL.DataPropertyName = "PenaltyName";
            this.PenaltyNameCL.HeaderText = "Mức phạt";
            this.PenaltyNameCL.MinimumWidth = 6;
            this.PenaltyNameCL.Name = "PenaltyNameCL";
            this.PenaltyNameCL.ReadOnly = true;
            this.PenaltyNameCL.Width = 138;
            // 
            // ValuePenaltyCL
            // 
            this.ValuePenaltyCL.DataPropertyName = "ValuePenalty";
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = null;
            this.ValuePenaltyCL.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValuePenaltyCL.HeaderText = "Tiền phạt";
            this.ValuePenaltyCL.MinimumWidth = 6;
            this.ValuePenaltyCL.Name = "ValuePenaltyCL";
            this.ValuePenaltyCL.ReadOnly = true;
            this.ValuePenaltyCL.Width = 138;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 80);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 20);
            this.txtSearch.TabIndex = 109;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 24);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 115;
            this.label18.Text = "Đơn vị ,phòng ban  :";
            // 
            // cbboxDepartmentFilter
            // 
            this.cbboxDepartmentFilter.FormattingEnabled = true;
            this.cbboxDepartmentFilter.Location = new System.Drawing.Point(140, 21);
            this.cbboxDepartmentFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbboxDepartmentFilter.Name = "cbboxDepartmentFilter";
            this.cbboxDepartmentFilter.Size = new System.Drawing.Size(488, 21);
            this.cbboxDepartmentFilter.TabIndex = 114;
            this.cbboxDepartmentFilter.SelectedIndexChanged += new System.EventHandler(this.cbboxDepartmentFilter_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(471, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 24);
            this.btnSearch.TabIndex = 112;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 83);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 113;
            this.label17.Text = "Họ và tên  :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblPageIndex);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnEndPage);
            this.groupBox2.Controls.Add(this.BtnNextPage);
            this.groupBox2.Controls.Add(this.btnBackpage);
            this.groupBox2.Controls.Add(this.btnBeginPage);
            this.groupBox2.Location = new System.Drawing.Point(22, 462);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(605, 51);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            // 
            // LblPageIndex
            // 
            this.LblPageIndex.AutoSize = true;
            this.LblPageIndex.Location = new System.Drawing.Point(295, 23);
            this.LblPageIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPageIndex.Name = "LblPageIndex";
            this.LblPageIndex.Size = new System.Drawing.Size(0, 13);
            this.LblPageIndex.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Trang :";
            // 
            // BtnEndPage
            // 
            this.BtnEndPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEndPage.Location = new System.Drawing.Point(497, 17);
            this.BtnEndPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEndPage.Name = "BtnEndPage";
            this.BtnEndPage.Size = new System.Drawing.Size(94, 25);
            this.BtnEndPage.TabIndex = 19;
            this.BtnEndPage.Text = "Trang cuối";
            this.BtnEndPage.UseVisualStyleBackColor = true;
            this.BtnEndPage.Click += new System.EventHandler(this.BtnEndPage_Click);
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextPage.Location = new System.Drawing.Point(378, 17);
            this.BtnNextPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(98, 25);
            this.BtnNextPage.TabIndex = 18;
            this.BtnNextPage.Text = "Trang sau";
            this.BtnNextPage.UseVisualStyleBackColor = true;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // btnBackpage
            // 
            this.btnBackpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackpage.Location = new System.Drawing.Point(131, 17);
            this.btnBackpage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackpage.Name = "btnBackpage";
            this.btnBackpage.Size = new System.Drawing.Size(94, 25);
            this.btnBackpage.TabIndex = 17;
            this.btnBackpage.Text = "Trang trước";
            this.btnBackpage.UseVisualStyleBackColor = true;
            this.btnBackpage.Click += new System.EventHandler(this.btnBackpage_Click);
            // 
            // btnBeginPage
            // 
            this.btnBeginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginPage.Location = new System.Drawing.Point(12, 17);
            this.btnBeginPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBeginPage.Name = "btnBeginPage";
            this.btnBeginPage.Size = new System.Drawing.Size(98, 25);
            this.btnBeginPage.TabIndex = 16;
            this.btnBeginPage.Text = "Trang đầu";
            this.btnBeginPage.UseVisualStyleBackColor = true;
            this.btnBeginPage.Click += new System.EventHandler(this.btnBeginPage_Click);
            // 
            // FrmUserPenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1061, 633);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUserPenalty";
            this.Text = "Quản lý phạt nhân sự";
            this.Load += new System.EventHandler(this.FrmUserPenalty_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUserPenalty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker DayFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioDay;
        private System.Windows.Forms.RadioButton RadioAllDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbboxFullName;
        private System.Windows.Forms.Label labelRequiredName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker DateBonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbboxBonus;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbboxDepartmentForm;
        private System.Windows.Forms.DataGridView GridUserPenalty;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbboxDepartmentFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblPageIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEndPage;
        private System.Windows.Forms.Button BtnNextPage;
        private System.Windows.Forms.Button btnBackpage;
        private System.Windows.Forms.Button btnBeginPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentNameCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePenaltyCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyNameCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValuePenaltyCL;
    }
}