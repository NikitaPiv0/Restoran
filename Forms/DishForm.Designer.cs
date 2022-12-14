namespace Restoran.Forms
{
    partial class DishForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shortNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.authorAddButton = new System.Windows.Forms.Button();
            this.authorRemoveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acceptButton = new System.Windows.Forms.Button();
            this.ingridientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ingredientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishIngredientViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientAddButton = new System.Windows.Forms.Button();
            this.ingredientRemoveButton = new System.Windows.Forms.Button();
            this.ingredientComboBox = new System.Windows.Forms.ComboBox();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingridientUnitTextBox = new System.Windows.Forms.TextBox();
            this.ingredientCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishIngredientViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.shortNameTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.categoryComboBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.authorComboBox, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.authorAddButton, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.authorRemoveButton, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.acceptButton, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.ingridientsDataGridView, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.ingredientAddButton, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.ingredientRemoveButton, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.ingredientComboBox, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.ingridientUnitTextBox, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.ingredientCountNumericUpDown, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 711);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nameTextBox, 3);
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dishBindingSource, "Name", true));
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(6, 33);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(472, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataSource = typeof(Restoran.Models.Dish);
            // 
            // shortNameTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.shortNameTextBox, 3);
            this.shortNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dishBindingSource, "ShortName", true));
            this.shortNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shortNameTextBox.Location = new System.Drawing.Point(6, 95);
            this.shortNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.shortNameTextBox.Name = "shortNameTextBox";
            this.shortNameTextBox.Size = new System.Drawing.Size(472, 23);
            this.shortNameTextBox.TabIndex = 2;
            // 
            // categoryComboBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.categoryComboBox, 3);
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dishBindingSource, "CategoryId", true));
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(6, 157);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(472, 23);
            this.categoryComboBox.TabIndex = 3;
            this.categoryComboBox.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Restoran.Models.Category);
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
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
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
            this.label2.Text = "Короткое название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(6, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Авторы";
            // 
            // authorComboBox
            // 
            this.authorComboBox.DataSource = this.userBindingSource;
            this.authorComboBox.DisplayMember = "FIO";
            this.authorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Location = new System.Drawing.Point(6, 369);
            this.authorComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(149, 23);
            this.authorComboBox.TabIndex = 8;
            this.authorComboBox.ValueMember = "Id";
            // 
            // authorAddButton
            // 
            this.authorAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorAddButton.Location = new System.Drawing.Point(167, 369);
            this.authorAddButton.Margin = new System.Windows.Forms.Padding(6);
            this.authorAddButton.Name = "authorAddButton";
            this.authorAddButton.Size = new System.Drawing.Size(149, 23);
            this.authorAddButton.TabIndex = 9;
            this.authorAddButton.Text = "Добавить";
            this.authorAddButton.UseVisualStyleBackColor = true;
            this.authorAddButton.Click += new System.EventHandler(this.authorAddButton_Click);
            // 
            // authorRemoveButton
            // 
            this.authorRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorRemoveButton.Location = new System.Drawing.Point(328, 369);
            this.authorRemoveButton.Margin = new System.Windows.Forms.Padding(6);
            this.authorRemoveButton.Name = "authorRemoveButton";
            this.authorRemoveButton.Size = new System.Drawing.Size(150, 23);
            this.authorRemoveButton.TabIndex = 10;
            this.authorRemoveButton.Text = "Удалить";
            this.authorRemoveButton.UseVisualStyleBackColor = true;
            this.authorRemoveButton.Click += new System.EventHandler(this.authorRemoveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.DataSource = this.authorsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(478, 144);
            this.dataGridView1.TabIndex = 11;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Имя";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.dishBindingSource;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.acceptButton, 3);
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(6, 624);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(6);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(472, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Добавить";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // ingridientsDataGridView
            // 
            this.ingridientsDataGridView.AllowUserToAddRows = false;
            this.ingridientsDataGridView.AllowUserToDeleteRows = false;
            this.ingridientsDataGridView.AutoGenerateColumns = false;
            this.ingridientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingridientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientNameDataGridViewTextBoxColumn,
            this.quntityDataGridViewTextBoxColumn,
            this.unitNameDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.ingridientsDataGridView, 3);
            this.ingridientsDataGridView.DataSource = this.dishIngredientViewModelBindingSource;
            this.ingridientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingridientsDataGridView.Location = new System.Drawing.Point(3, 401);
            this.ingridientsDataGridView.Name = "ingridientsDataGridView";
            this.ingridientsDataGridView.ReadOnly = true;
            this.ingridientsDataGridView.RowTemplate.Height = 25;
            this.ingridientsDataGridView.Size = new System.Drawing.Size(478, 144);
            this.ingridientsDataGridView.TabIndex = 12;
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            this.ingredientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "IngredientName";
            this.ingredientNameDataGridViewTextBoxColumn.HeaderText = "Ингрединет";
            this.ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            this.ingredientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quntityDataGridViewTextBoxColumn
            // 
            this.quntityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quntityDataGridViewTextBoxColumn.DataPropertyName = "Quntity";
            this.quntityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quntityDataGridViewTextBoxColumn.Name = "quntityDataGridViewTextBoxColumn";
            this.quntityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quntityDataGridViewTextBoxColumn.Width = 97;
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            this.unitNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            this.unitNameDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            this.unitNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitNameDataGridViewTextBoxColumn.Width = 129;
            // 
            // dishIngredientViewModelBindingSource
            // 
            this.dishIngredientViewModelBindingSource.DataSource = typeof(Restoran.ViewModels.DishIngredientViewModel);
            // 
            // ingredientAddButton
            // 
            this.ingredientAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientAddButton.Location = new System.Drawing.Point(167, 589);
            this.ingredientAddButton.Margin = new System.Windows.Forms.Padding(6);
            this.ingredientAddButton.Name = "ingredientAddButton";
            this.ingredientAddButton.Size = new System.Drawing.Size(149, 23);
            this.ingredientAddButton.TabIndex = 13;
            this.ingredientAddButton.Text = "Добавить";
            this.ingredientAddButton.UseVisualStyleBackColor = true;
            this.ingredientAddButton.Click += new System.EventHandler(this.ingredientAddButton_Click);
            // 
            // ingredientRemoveButton
            // 
            this.ingredientRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientRemoveButton.Location = new System.Drawing.Point(328, 589);
            this.ingredientRemoveButton.Margin = new System.Windows.Forms.Padding(6);
            this.ingredientRemoveButton.Name = "ingredientRemoveButton";
            this.ingredientRemoveButton.Size = new System.Drawing.Size(150, 23);
            this.ingredientRemoveButton.TabIndex = 14;
            this.ingredientRemoveButton.Text = "Удалить";
            this.ingredientRemoveButton.UseVisualStyleBackColor = true;
            this.ingredientRemoveButton.Click += new System.EventHandler(this.ingredientRemoveButton_Click);
            // 
            // ingredientComboBox
            // 
            this.ingredientComboBox.DataSource = this.ingredientBindingSource;
            this.ingredientComboBox.DisplayMember = "Name";
            this.ingredientComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientComboBox.FormattingEnabled = true;
            this.ingredientComboBox.Location = new System.Drawing.Point(6, 554);
            this.ingredientComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.ingredientComboBox.Name = "ingredientComboBox";
            this.ingredientComboBox.Size = new System.Drawing.Size(149, 23);
            this.ingredientComboBox.TabIndex = 15;
            this.ingredientComboBox.ValueMember = "Id";
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataSource = typeof(Restoran.Models.Ingredient);
            // 
            // ingridientUnitTextBox
            // 
            this.ingridientUnitTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingridientUnitTextBox.Location = new System.Drawing.Point(328, 554);
            this.ingridientUnitTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ingridientUnitTextBox.Name = "ingridientUnitTextBox";
            this.ingridientUnitTextBox.Size = new System.Drawing.Size(150, 23);
            this.ingridientUnitTextBox.TabIndex = 17;
            this.ingridientUnitTextBox.Text = " ";
            // 
            // ingredientCountNumericUpDown
            // 
            this.ingredientCountNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientCountNumericUpDown.Location = new System.Drawing.Point(167, 554);
            this.ingredientCountNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.ingredientCountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ingredientCountNumericUpDown.Name = "ingredientCountNumericUpDown";
            this.ingredientCountNumericUpDown.Size = new System.Drawing.Size(149, 23);
            this.ingredientCountNumericUpDown.TabIndex = 18;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Restoran.Models.User);
            // 
            // DishForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 750);
            this.MinimizeBox = false;
            this.Name = "DishForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление блюда";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DishForm_FormClosing);
            this.Load += new System.EventHandler(this.DishForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishIngredientViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button acceptButton;
        private TextBox nameTextBox;
        private TextBox shortNameTextBox;
        private ComboBox categoryComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private BindingSource dishBindingSource;
        private BindingSource categoryBindingSource;
        private Label label4;
        private ComboBox authorComboBox;
        private Button authorAddButton;
        private Button authorRemoveButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private BindingSource authorsBindingSource;
        private DataGridView ingridientsDataGridView;
        private Button ingredientAddButton;
        private Button ingredientRemoveButton;
        private ComboBox ingredientComboBox;
        private TextBox ingridientUnitTextBox;
        private NumericUpDown ingredientCountNumericUpDown;
        private BindingSource ingredientBindingSource;
        private DataGridViewTextBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quntityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private BindingSource dishIngredientViewModelBindingSource;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
    }
}