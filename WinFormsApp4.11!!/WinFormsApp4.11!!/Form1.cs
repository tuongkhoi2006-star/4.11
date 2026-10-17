using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp4._11__.Models;

namespace WinFormsApp4._11__
{
    public partial class Form1 : Form
    {
        private BindingList<RepairOrder> masterList = new BindingList<RepairOrder>();
        private BindingSource bs = new BindingSource();
        private string currentImagePath;

        private readonly string[] statuses = new[] { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" };
        private readonly string[] deviceTypes = new[] { "Điện thoại", "Laptop", "Máy tính bảng", "Tivi", "Khác" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDeviceType.Items.AddRange(deviceTypes);
            cmbStatus.Items.AddRange(statuses);
            cmbFilterStatus.Items.Add("All");
            cmbFilterStatus.Items.AddRange(statuses);
            cmbFilterStatus.SelectedIndex = 0;

            bs.DataSource = masterList;
            dgvOrders.DataSource = bs;

            // define columns
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Mã đơn" });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Tên khách" });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "SĐT" });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DeviceType", HeaderText = "Loại" });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Mô tả" });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReceivedDate", HeaderText = "Ngày", DefaultCellStyle = { Format = "d" } });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EstimatedCost", HeaderText = "Chi phí", DefaultCellStyle = { Format = "N0" } });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng thái" });

            RefreshView();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var path = openFileDialog.FileName;
                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxDevice.Image = Image.FromStream(fs);
                    }
                    currentImagePath = path;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở ảnh: " + ex.Message);
                }
            }
        }

        private bool ValidateInput(bool isNew)
        {
            errorProvider.Clear();
            bool ok = true;

            string id = txtId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                errorProvider.SetError(txtId, "Mã đơn không được để trống");
                ok = false;
            }
            else if (isNew && masterList.Any(x => x.Id.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(txtId, "Mã đơn đã tồn tại");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Tên khách hàng bắt buộc");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại bắt buộc");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Mô tả lỗi bắt buộc");
                ok = false;
            }

            if (!decimal.TryParse(txtCost.Text.Trim(), out var cost) || cost < 0)
            {
                errorProvider.SetError(txtCost, "Chi phí phải là số không âm");
                ok = false;
            }

            return ok;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(true)) return;

            var order = new RepairOrder
            {
                Id = txtId.Text.Trim(),
                CustomerName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                DeviceType = cmbDeviceType.SelectedItem?.ToString() ?? string.Empty,
                Description = txtDescription.Text.Trim(),
                ReceivedDate = dtpReceived.Value.Date,
                EstimatedCost = decimal.Parse(txtCost.Text.Trim()),
                Status = cmbStatus.SelectedItem?.ToString() ?? statuses[0],
                ImagePath = currentImagePath
            };

            masterList.Add(order);
            RefreshView();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;
            var id = dgvOrders.CurrentRow.Cells[0].Value?.ToString();
            var existing = masterList.FirstOrDefault(x => x.Id == id);
            if (existing == null) return;

            if (!ValidateInput(false)) return;

            existing.CustomerName = txtName.Text.Trim();
            existing.Phone = txtPhone.Text.Trim();
            existing.DeviceType = cmbDeviceType.SelectedItem?.ToString() ?? string.Empty;
            existing.Description = txtDescription.Text.Trim();
            existing.ReceivedDate = dtpReceived.Value.Date;
            existing.EstimatedCost = decimal.Parse(txtCost.Text.Trim());
            existing.Status = cmbStatus.SelectedItem?.ToString() ?? existing.Status;
            existing.ImagePath = currentImagePath;

            // force refresh
            bs.ResetBindings(false);
            RefreshView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;
            var id = dgvOrders.CurrentRow.Cells[0].Value?.ToString();
            var existing = masterList.FirstOrDefault(x => x.Id == id);
            if (existing == null) return;

            var r = MessageBox.Show("Xác nhận xóa đơn " + id + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;
            masterList.Remove(existing);
            RefreshView();
            ClearForm();
        }

        private void ClearForm()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtCost.Text = "0";
            cmbDeviceType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtpReceived.Value = DateTime.Today;
            pictureBoxDevice.Image = null;
            currentImagePath = null;
            errorProvider.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvOrders.Rows[e.RowIndex];
            var id = row.Cells[0].Value?.ToString();
            var order = masterList.FirstOrDefault(x => x.Id == id);
            if (order == null) return;

            txtId.Text = order.Id;
            txtName.Text = order.CustomerName;
            txtPhone.Text = order.Phone;
            txtDescription.Text = order.Description;
            txtCost.Text = order.EstimatedCost.ToString();
            cmbDeviceType.SelectedItem = order.DeviceType;
            cmbStatus.SelectedItem = order.Status;
            dtpReceived.Value = order.ReceivedDate == DateTime.MinValue ? DateTime.Today : order.ReceivedDate;
            currentImagePath = order.ImagePath;
            if (!string.IsNullOrEmpty(order.ImagePath) && File.Exists(order.ImagePath))
            {
                try
                {
                    using (var fs = new FileStream(order.ImagePath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxDevice.Image = Image.FromStream(fs);
                    }
                }
                catch { pictureBoxDevice.Image = null; }
            }
            else pictureBoxDevice.Image = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void RefreshView()
        {
            var q = txtSearch.Text.Trim().ToLower();
            var selectedStatus = cmbFilterStatus.SelectedItem?.ToString();

            IEnumerable<RepairOrder> filtered = masterList;
            if (!string.IsNullOrEmpty(q))
            {
                filtered = filtered.Where(x => (x.Id ?? "").ToLower().Contains(q)
                    || (x.CustomerName ?? "").ToLower().Contains(q)
                    || (x.Phone ?? "").ToLower().Contains(q));
            }
            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "All")
            {
                filtered = filtered.Where(x => x.Status == selectedStatus);
            }

            bs.DataSource = new BindingList<RepairOrder>(filtered.ToList());
            dgvOrders.DataSource = bs;

            toolStripStatusLabelCount.Text = $"Số đơn: {bs.Count}";

            var total = masterList.Where(x => x.Status != "Hoàn tất").Sum(x => x.EstimatedCost);
            toolStripStatusLabelTotal.Text = $"Tổng chi phí (chưa hoàn tất): {total:N0}";
        }

        private void exportCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CSV files|*.csv|All files|*.*";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("Id,CustomerName,Phone,DeviceType,Description,ReceivedDate,EstimatedCost,Status,ImagePath");
                foreach (RepairOrder o in bs.List)
                {
                    sb.AppendLine($"\"{o.Id}\",\"{o.CustomerName}\",\"{o.Phone}\",\"{o.DeviceType}\",\"{o.Description}\",{o.ReceivedDate:d},{o.EstimatedCost},{o.Status},\"{o.ImagePath}\"");
                }
                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất CSV: " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBoxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void lblCost_Click(object sender, EventArgs e)
        {

        }
    }
}
