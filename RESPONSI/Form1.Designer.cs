namespace RESPONSI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            label1 = new Label();
            txtName = new TextBox();
            deptCombo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            Test = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(89, 189);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(302, 189);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(496, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(77, 244);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(488, 177);
            dgvData.TabIndex = 3;
            dgvData.CellClick += dgvData_CellContentClick;
            dgvData.CellContentClick += dgvData_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 28);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "Logo";
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(144, 23);
            txtName.TabIndex = 5;
            // 
            // deptCombo
            // 
            deptCombo.FormattingEnabled = true;
            deptCombo.Items.AddRange(new object[] { "HR", "Engineer", "Developer", "Product_M", "Finance" });
            deptCombo.Location = new Point(192, 114);
            deptCombo.Name = "deptCombo";
            deptCombo.Size = new Size(121, 23);
            deptCombo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 64);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 8;
            label2.Text = "Nama Karyawan : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 122);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 9;
            label3.Text = "Departemen";
            // 
            // Test
            // 
            Test.Location = new Point(719, 421);
            Test.Name = "Test";
            Test.Size = new Size(69, 19);
            Test.TabIndex = 10;
            Test.Text = "button1";
            Test.UseVisualStyleBackColor = true;
            Test.Click += Test_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 49);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 28);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 12;
            label4.Text = "ID Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 61);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "1 : HR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 76);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 15;
            label5.Text = "2 : Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 91);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 16;
            label7.Text = "3 : Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(407, 106);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 17;
            label8.Text = "4 : Product Manager";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(407, 122);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 18;
            label9.Text = "5 : Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(Test);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deptCombo);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private Label label1;
        private TextBox txtName;
        private ComboBox deptCombo;
        private Label label2;
        private Label label3;
        private Button Test;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}