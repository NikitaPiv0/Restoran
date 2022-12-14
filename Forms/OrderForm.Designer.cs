namespace Restoran.Forms
{
    partial class OrderForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conpanyComboBox = new System.Windows.Forms.ComboBox();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishDataGridView = new System.Windows.Forms.DataGridView();
            this.dishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDishViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDishComboBox = new System.Windows.Forms.ComboBox();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addDishButton = new System.Windows.Forms.Button();
            this.removeDishButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.countDishNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDishViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countDishNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.conpanyComboBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dishDataGridView, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.allDishComboBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.addDishButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.removeDishButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.acceptButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.countDishNumericUpDown, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimePicker, 2);
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "CreateAt", true));
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(6, 33);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(322, 23);
            this.dateTimePicker.TabIndex = 0;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Restoran.Models.Order);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Компания";
            // 
            // conpanyComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.conpanyComboBox, 2);
            this.conpanyComboBox.DataSource = this.menuBindingSource;
            this.conpanyComboBox.DisplayMember = "CopmanyName";
            this.conpanyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conpanyComboBox.FormattingEnabled = true;
            this.conpanyComboBox.Location = new System.Drawing.Point(6, 95);
            this.conpanyComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.conpanyComboBox.Name = "conpanyComboBox";
            this.conpanyComboBox.Size = new System.Drawing.Size(322, 23);
            this.conpanyComboBox.TabIndex = 3;
            this.conpanyComboBox.ValueMember = "Id";
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(Restoran.Models.Menu);
            this.menuBindingSource.CurrentChanged += new System.EventHandler(this.menuBindingSource_CurrentChanged);
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
            this.tableLayoutPanel1.SetColumnSpan(this.dishDataGridView, 2);
            this.dishDataGridView.DataSource = this.orderDishViewModelBindingSource;
            this.dishDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishDataGridView.Location = new System.Drawing.Point(3, 127);
            this.dishDataGridView.Name = "dishDataGridView";
            this.dishDataGridView.ReadOnly = true;
            this.dishDataGridView.RowTemplate.Height = 25;
            this.dishDataGridView.Size = new System.Drawing.Size(328, 194);
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
            // allDishComboBox
            // 
            this.allDishComboBox.DataSource = this.dishBindingSource;
            this.allDishComboBox.DisplayMember = "Name";
            this.allDishComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allDishComboBox.FormattingEnabled = true;
            this.allDishComboBox.Location = new System.Drawing.Point(6, 330);
            this.allDishComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.allDishComboBox.Name = "allDishComboBox";
            this.allDishComboBox.Size = new System.Drawing.Size(155, 23);
            this.allDishComboBox.TabIndex = 5;
            this.allDishComboBox.ValueMember = "Id";
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataSource = typeof(Restoran.Models.Dish);
            // 
            // addDishButton
            // 
            this.addDishButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDishButton.Location = new System.Drawing.Point(6, 365);
            this.addDishButton.Margin = new System.Windows.Forms.Padding(6);
            this.addDishButton.Name = "addDishButton";
            this.addDishButton.Size = new System.Drawing.Size(155, 23);
            this.addDishButton.TabIndex = 6;
            this.addDishButton.Text = "Добавить";
            this.addDishButton.UseVisualStyleBackColor = true;
            this.addDishButton.Click += new System.EventHandler(this.addDishButton_Click);
            // 
            // removeDishButton
            // 
            this.removeDishButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeDishButton.Location = new System.Drawing.Point(173, 365);
            this.removeDishButton.Margin = new System.Windows.Forms.Padding(6);
            this.removeDishButton.Name = "removeDishButton";
            this.removeDishButton.Size = new System.Drawing.Size(155, 23);
            this.removeDishButton.TabIndex = 7;
            this.removeDishButton.Text = "Удалить";
            this.removeDishButton.UseVisualStyleBackColor = true;
            this.removeDishButton.Click += new System.EventHandler(this.removeDishButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.acceptButton, 2);
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(6, 400);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(6);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(322, 23);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Добавить";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // countDishNumericUpDown
            // 
            this.countDishNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countDishNumericUpDown.Location = new System.Drawing.Point(173, 330);
            this.countDishNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.countDishNumericUpDown.Name = "countDishNumericUpDown";
            this.countDishNumericUpDown.Size = new System.Drawing.Size(155, 23);
            this.countDishNumericUpDown.TabIndex = 10;
            // 
            // OrderForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заказа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDishViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countDishNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePicker;
        private Label label1;
        private Label label2;
        private ComboBox conpanyComboBox;
        private DataGridView dishDataGridView;
        private ComboBox allDishComboBox;
        private Button addDishButton;
        private Button removeDishButton;
        private Button acceptButton;
        private DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private BindingSource orderDishViewModelBindingSource;
        private BindingSource orderBindingSource;
        private BindingSource menuBindingSource;
        private BindingSource dishBindingSource;
        private NumericUpDown countDishNumericUpDown;
    }
}