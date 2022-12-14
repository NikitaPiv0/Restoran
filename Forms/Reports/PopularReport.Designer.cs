namespace Restoran.Forms.Reports
{
    partial class PopularReport
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stopDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dishDataGridView = new System.Windows.Forms.DataGridView();
            this.dishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDishViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDishViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dishDataGridView, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.SetColumnSpan(this.groupBox3, 4);
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 51);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.startDateTimePicker, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.stopDateTimePicker, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(788, 29);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDateTimePicker.Location = new System.Drawing.Point(3, 3);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(388, 23);
            this.startDateTimePicker.TabIndex = 3;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.stratDateTimePicker_ValueChanged);
            // 
            // stopDateTimePicker
            // 
            this.stopDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopDateTimePicker.Location = new System.Drawing.Point(397, 3);
            this.stopDateTimePicker.Name = "stopDateTimePicker";
            this.stopDateTimePicker.Size = new System.Drawing.Size(388, 23);
            this.stopDateTimePicker.TabIndex = 4;
            this.stopDateTimePicker.ValueChanged += new System.EventHandler(this.stopDateTimePicker_ValueChanged);
            // 
            // dishDataGridView
            // 
            this.dishDataGridView.AllowUserToAddRows = false;
            this.dishDataGridView.AllowUserToDeleteRows = false;
            this.dishDataGridView.AutoGenerateColumns = false;
            this.dishDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishNameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.tableLayoutPanel5.SetColumnSpan(this.dishDataGridView, 4);
            this.dishDataGridView.DataSource = this.orderDishViewModelBindingSource;
            this.dishDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishDataGridView.Location = new System.Drawing.Point(3, 60);
            this.dishDataGridView.Name = "dishDataGridView";
            this.dishDataGridView.ReadOnly = true;
            this.dishDataGridView.RowTemplate.Height = 25;
            this.dishDataGridView.Size = new System.Drawing.Size(794, 387);
            this.dishDataGridView.TabIndex = 4;
            // 
            // dishNameDataGridViewTextBoxColumn
            // 
            this.dishNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dishNameDataGridViewTextBoxColumn.DataPropertyName = "DishName";
            this.dishNameDataGridViewTextBoxColumn.HeaderText = "Блюдо";
            this.dishNameDataGridViewTextBoxColumn.Name = "dishNameDataGridViewTextBoxColumn";
            this.dishNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 97;
            // 
            // orderDishViewModelBindingSource
            // 
            this.orderDishViewModelBindingSource.DataSource = typeof(Restoran.ViewModels.OrderDishViewModel);
            // 
            // PopularReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "PopularReport";
            this.Text = "Популярные блюда";
            this.Load += new System.EventHandler(this.PopularReport_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDishViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private DateTimePicker startDateTimePicker;
        private DateTimePicker stopDateTimePicker;
        private DataGridView dishDataGridView;
        private DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private BindingSource orderDishViewModelBindingSource;
    }
}