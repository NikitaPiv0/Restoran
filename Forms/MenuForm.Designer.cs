namespace Restoran.Forms
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.dishAddButton = new System.Windows.Forms.Button();
            this.dishRemoveButton = new System.Windows.Forms.Button();
            this.dishDataGridView = new System.Windows.Forms.DataGridView();
            this.dishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDishViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compabyNameTextBox = new System.Windows.Forms.TextBox();
            this.dishComboBox = new System.Windows.Forms.ComboBox();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDishViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.acceptButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dishAddButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dishRemoveButton, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.dishDataGridView, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.compabyNameTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dishComboBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.countNumericUpDown, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата";
            // 
            // dateTimePicker
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimePicker, 3);
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.menuBindingSource, "Date", true));
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker.Location = new System.Drawing.Point(6, 33);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(472, 23);
            this.dateTimePicker.TabIndex = 4;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(Restoran.Models.Menu);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название компанни";
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.acceptButton, 3);
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(6, 350);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(6);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(472, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Добавить";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // dishAddButton
            // 
            this.dishAddButton.Location = new System.Drawing.Point(316, 315);
            this.dishAddButton.Margin = new System.Windows.Forms.Padding(6);
            this.dishAddButton.Name = "dishAddButton";
            this.dishAddButton.Size = new System.Drawing.Size(75, 23);
            this.dishAddButton.TabIndex = 1;
            this.dishAddButton.Text = "Добавить";
            this.dishAddButton.UseVisualStyleBackColor = true;
            this.dishAddButton.Click += new System.EventHandler(this.dishAddButton_Click);
            // 
            // dishRemoveButton
            // 
            this.dishRemoveButton.Location = new System.Drawing.Point(403, 315);
            this.dishRemoveButton.Margin = new System.Windows.Forms.Padding(6);
            this.dishRemoveButton.Name = "dishRemoveButton";
            this.dishRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.dishRemoveButton.TabIndex = 2;
            this.dishRemoveButton.Text = "Удалить";
            this.dishRemoveButton.UseVisualStyleBackColor = true;
            this.dishRemoveButton.Click += new System.EventHandler(this.dishRemoveButton_Click);
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
            this.tableLayoutPanel1.SetColumnSpan(this.dishDataGridView, 3);
            this.dishDataGridView.DataSource = this.menuDishViewModelBindingSource;
            this.dishDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishDataGridView.Location = new System.Drawing.Point(3, 127);
            this.dishDataGridView.Name = "dishDataGridView";
            this.dishDataGridView.ReadOnly = true;
            this.dishDataGridView.RowTemplate.Height = 25;
            this.dishDataGridView.Size = new System.Drawing.Size(478, 144);
            this.dishDataGridView.TabIndex = 6;
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
            // menuDishViewModelBindingSource
            // 
            this.menuDishViewModelBindingSource.DataSource = typeof(Restoran.ViewModels.MenuDishViewModel);
            // 
            // compabyNameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.compabyNameTextBox, 3);
            this.compabyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuBindingSource, "CopmanyName", true));
            this.compabyNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compabyNameTextBox.Location = new System.Drawing.Point(6, 95);
            this.compabyNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.compabyNameTextBox.Name = "compabyNameTextBox";
            this.compabyNameTextBox.Size = new System.Drawing.Size(472, 23);
            this.compabyNameTextBox.TabIndex = 7;
            // 
            // dishComboBox
            // 
            this.dishComboBox.DataSource = this.dishBindingSource;
            this.dishComboBox.DisplayMember = "Name";
            this.dishComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishComboBox.FormattingEnabled = true;
            this.dishComboBox.Location = new System.Drawing.Point(6, 280);
            this.dishComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.dishComboBox.Name = "dishComboBox";
            this.dishComboBox.Size = new System.Drawing.Size(298, 23);
            this.dishComboBox.TabIndex = 8;
            this.dishComboBox.ValueMember = "Id";
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataSource = typeof(Restoran.Models.Dish);
            // 
            // countNumericUpDown
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.countNumericUpDown, 2);
            this.countNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countNumericUpDown.Location = new System.Drawing.Point(316, 280);
            this.countNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(162, 23);
            this.countNumericUpDown.TabIndex = 9;
            // 
            // MenuForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 650);
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDishViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private Button acceptButton;
        private Button dishAddButton;
        private Button dishRemoveButton;
        private DataGridView dishDataGridView;
        private TextBox compabyNameTextBox;
        private ComboBox dishComboBox;
        private BindingSource dishBindingSource;
        private NumericUpDown countNumericUpDown;
        private BindingSource menuBindingSource;
        private DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private BindingSource menuDishViewModelBindingSource;
    }
}