namespace WinFormsApp4._11__
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer = new SplitContainer();
            groupBoxInfo = new GroupBox();
            btnChooseImage = new Button();
            pictureBoxDevice = new PictureBox();
            lblImage = new Label();
            cmbStatus = new ComboBox();
            cmbDeviceType = new ComboBox();
            dtpReceived = new DateTimePicker();
            txtCost = new TextBox();
            txtDescription = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblStatus = new Label();
            lblCost = new Label();
            lblReceived = new Label();
            lblDescription = new Label();
            lblDeviceType = new Label();
            lblPhone = new Label();
            lblName = new Label();
            lblId = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            groupBoxList = new GroupBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cmbFilterStatus = new ComboBox();
            lblFilter = new Label();
            dgvOrders = new DataGridView();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCsvToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabelCount = new ToolStripStatusLabel();
            toolStripStatusLabelTotal = new ToolStripStatusLabel();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDevice).BeginInit();
            groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 28);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(groupBoxInfo);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(groupBoxList);
            splitContainer.Size = new Size(800, 396);
            splitContainer.SplitterDistance = 320;
            splitContainer.TabIndex = 0;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(btnChooseImage);
            groupBoxInfo.Controls.Add(pictureBoxDevice);
            groupBoxInfo.Controls.Add(lblImage);
            groupBoxInfo.Controls.Add(cmbStatus);
            groupBoxInfo.Controls.Add(cmbDeviceType);
            groupBoxInfo.Controls.Add(dtpReceived);
            groupBoxInfo.Controls.Add(txtCost);
            groupBoxInfo.Controls.Add(txtDescription);
            groupBoxInfo.Controls.Add(txtPhone);
            groupBoxInfo.Controls.Add(txtName);
            groupBoxInfo.Controls.Add(txtId);
            groupBoxInfo.Controls.Add(lblStatus);
            groupBoxInfo.Controls.Add(lblCost);
            groupBoxInfo.Controls.Add(lblReceived);
            groupBoxInfo.Controls.Add(lblDescription);
            groupBoxInfo.Controls.Add(lblDeviceType);
            groupBoxInfo.Controls.Add(lblPhone);
            groupBoxInfo.Controls.Add(lblName);
            groupBoxInfo.Controls.Add(lblId);
            groupBoxInfo.Controls.Add(btnAdd);
            groupBoxInfo.Controls.Add(btnUpdate);
            groupBoxInfo.Controls.Add(btnDelete);
            groupBoxInfo.Controls.Add(btnClear);
            groupBoxInfo.Dock = DockStyle.Fill;
            groupBoxInfo.Location = new Point(0, 0);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(320, 396);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin đơn";
            groupBoxInfo.Enter += groupBoxInfo_Enter;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(11, 258);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(100, 23);
            btnChooseImage.TabIndex = 19;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // pictureBoxDevice
            // 
            pictureBoxDevice.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxDevice.Location = new Point(122, 247);
            pictureBoxDevice.Name = "pictureBoxDevice";
            pictureBoxDevice.Size = new Size(180, 120);
            pictureBoxDevice.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDevice.TabIndex = 18;
            pictureBoxDevice.TabStop = false;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(12, 235);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(86, 20);
            lblImage.TabIndex = 17;
            lblImage.Text = "Ảnh thiết bị";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(122, 210);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(180, 28);
            cmbStatus.TabIndex = 16;
            // 
            // cmbDeviceType
            // 
            cmbDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeviceType.FormattingEnabled = true;
            cmbDeviceType.Location = new Point(122, 110);
            cmbDeviceType.Name = "cmbDeviceType";
            cmbDeviceType.Size = new Size(180, 28);
            cmbDeviceType.TabIndex = 15;
            // 
            // dtpReceived
            // 
            dtpReceived.Format = DateTimePickerFormat.Short;
            dtpReceived.Location = new Point(122, 144);
            dtpReceived.Name = "dtpReceived";
            dtpReceived.Size = new Size(180, 27);
            dtpReceived.TabIndex = 14;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(122, 177);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(180, 27);
            txtCost.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(122, 80);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(180, 24);
            txtDescription.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(122, 50);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(180, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 27);
            txtName.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(122, -7);
            txtId.Name = "txtId";
            txtId.Size = new Size(180, 27);
            txtId.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 210);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Trạng thái";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(3, 180);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(108, 20);
            lblCost.TabIndex = 7;
            lblCost.Text = "Chi phí dự kiến";
            lblCost.Click += lblCost_Click;
            // 
            // lblReceived
            // 
            lblReceived.AutoSize = true;
            lblReceived.Location = new Point(6, 149);
            lblReceived.Name = "lblReceived";
            lblReceived.Size = new Size(110, 20);
            lblReceived.TabIndex = 6;
            lblReceived.Text = "Ngày tiếp nhận";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(6, 84);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(69, 20);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Mô tả lỗi";
            // 
            // lblDeviceType
            // 
            lblDeviceType.AutoSize = true;
            lblDeviceType.Location = new Point(6, 113);
            lblDeviceType.Name = "lblDeviceType";
            lblDeviceType.Size = new Size(88, 20);
            lblDeviceType.TabIndex = 4;
            lblDeviceType.Text = "Loại thiết bị";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(7, 57);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(97, 20);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Số điện thoại";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 22);
            lblName.Name = "lblName";
            lblName.Size = new Size(111, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Tên khách hàng";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, -19);
            lblId.Name = "lblId";
            lblId.Size = new Size(60, 20);
            lblId.TabIndex = 1;
            lblId.Text = "Mã đơn";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 373);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(84, 373);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(165, 373);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(242, 373);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 23;
            btnClear.Text = "Mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(txtSearch);
            groupBoxList.Controls.Add(lblSearch);
            groupBoxList.Controls.Add(cmbFilterStatus);
            groupBoxList.Controls.Add(lblFilter);
            groupBoxList.Controls.Add(dgvOrders);
            groupBoxList.Dock = DockStyle.Fill;
            groupBoxList.Location = new Point(0, 0);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(476, 396);
            groupBoxList.TabIndex = 0;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Danh sách đơn";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(70, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 25);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 20);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Tìm kiếm";
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Location = new Point(350, 22);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(120, 28);
            cmbFilterStatus.TabIndex = 2;
            cmbFilterStatus.SelectedIndexChanged += cmbFilterStatus_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(300, 25);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(75, 20);
            lblFilter.TabIndex = 1;
            lblFilter.Text = "Trạng thái";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(10, 52);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(456, 332);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCsvToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportCsvToolStripMenuItem
            // 
            exportCsvToolStripMenuItem.Name = "exportCsvToolStripMenuItem";
            exportCsvToolStripMenuItem.Size = new Size(165, 26);
            exportCsvToolStripMenuItem.Text = "Export CSV";
            exportCsvToolStripMenuItem.Click += exportCsvToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCount, toolStripStatusLabelTotal });
            statusStrip.Location = new Point(0, 424);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelCount
            // 
            toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            toolStripStatusLabelCount.Size = new Size(71, 20);
            toolStripStatusLabelCount.Text = "Số đơn: 0";
            // 
            // toolStripStatusLabelTotal
            // 
            toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            toolStripStatusLabelTotal.Size = new Size(211, 20);
            toolStripStatusLabelTotal.Text = "Tổng chi phí (chưa hoàn tất): 0";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer);
            Controls.Add(menuStrip);
            Controls.Add(statusStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Repair Service Tracker";
            Load += Form1_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDevice).EndInit();
            groupBoxList.ResumeLayout(false);
            groupBoxList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox pictureBoxDevice;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbDeviceType;
        private System.Windows.Forms.DateTimePicker dtpReceived;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotal;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;

        #endregion
    }
}
