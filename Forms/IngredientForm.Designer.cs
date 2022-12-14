namespace Restoran.Forms
{
    partial class IngredientForm
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shortNameTextBox = new System.Windows.Forms.TextBox();
            this.caloriesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.proteinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.carbohydrateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbohydrateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.acceptButton, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.shortNameTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.caloriesNumericUpDown, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.proteinNumericUpDown, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.carbohydrateNumericUpDown, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point(253, 416);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(6);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Добавить";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "Name", true));
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(6, 47);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(322, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataSource = typeof(Restoran.Models.Ingredient);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Короткое название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(6, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Каллории (на 100 гр)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(6, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Белки (на 100 гр)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(6, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Углеводы (на 100 гр)";
            // 
            // shortNameTextBox
            // 
            this.shortNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "ShortName", true));
            this.shortNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shortNameTextBox.Location = new System.Drawing.Point(6, 129);
            this.shortNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.shortNameTextBox.Name = "shortNameTextBox";
            this.shortNameTextBox.Size = new System.Drawing.Size(322, 23);
            this.shortNameTextBox.TabIndex = 7;
            // 
            // caloriesNumericUpDown
            // 
            this.caloriesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ingredientBindingSource, "Сalories", true));
            this.caloriesNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caloriesNumericUpDown.Location = new System.Drawing.Point(6, 211);
            this.caloriesNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.caloriesNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.caloriesNumericUpDown.Name = "caloriesNumericUpDown";
            this.caloriesNumericUpDown.Size = new System.Drawing.Size(322, 23);
            this.caloriesNumericUpDown.TabIndex = 8;
            // 
            // proteinNumericUpDown
            // 
            this.proteinNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ingredientBindingSource, "Protein", true));
            this.proteinNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proteinNumericUpDown.Location = new System.Drawing.Point(6, 293);
            this.proteinNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.proteinNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.proteinNumericUpDown.Name = "proteinNumericUpDown";
            this.proteinNumericUpDown.Size = new System.Drawing.Size(322, 23);
            this.proteinNumericUpDown.TabIndex = 9;
            // 
            // carbohydrateNumericUpDown
            // 
            this.carbohydrateNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ingredientBindingSource, "Carbohydrate", true));
            this.carbohydrateNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carbohydrateNumericUpDown.Location = new System.Drawing.Point(6, 375);
            this.carbohydrateNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.carbohydrateNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.carbohydrateNumericUpDown.Name = "carbohydrateNumericUpDown";
            this.carbohydrateNumericUpDown.Size = new System.Drawing.Size(322, 23);
            this.carbohydrateNumericUpDown.TabIndex = 10;
            // 
            // IngredientForm
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
            this.Name = "IngredientForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление ингредиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngredientForm_FormClosing);
            this.Load += new System.EventHandler(this.IngredientForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbohydrateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button acceptButton;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox shortNameTextBox;
        private NumericUpDown caloriesNumericUpDown;
        private NumericUpDown proteinNumericUpDown;
        private NumericUpDown carbohydrateNumericUpDown;
        private BindingSource ingredientBindingSource;
    }
}