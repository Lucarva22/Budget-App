namespace Projeto_BudgetApp
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.txtNewLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialAppDataSet = new Projeto_BudgetApp.FinancialAppDataSet();
            this.loginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter1 = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager1 = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(35, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Registar>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ainda não possui uma conta?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 65);
            this.button1.TabIndex = 14;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(35, 155);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(216, 28);
            this.txtPass.TabIndex = 13;
            this.txtPass.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(35, 94);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(216, 28);
            this.txtLogin.TabIndex = 11;
            this.txtLogin.Text = "Carvalho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.txtNewEmail);
            this.panel1.Controls.Add(this.txtNewLogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(298, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 261);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Login";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(70, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(90, 117);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(177, 28);
            this.txtNewPass.TabIndex = 4;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewEmail.Location = new System.Drawing.Point(90, 78);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(177, 28);
            this.txtNewEmail.TabIndex = 3;
            // 
            // txtNewLogin
            // 
            this.txtNewLogin.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewLogin.Location = new System.Drawing.Point(90, 31);
            this.txtNewLogin.Name = "txtNewLogin";
            this.txtNewLogin.Size = new System.Drawing.Size(177, 28);
            this.txtNewLogin.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Registar novo Formando";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_BudgetApp.Properties.Resources._2931151_close_delete_exit_remove_x_icon;
            this.pictureBox1.Location = new System.Drawing.Point(579, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            // 
            // financialAppDataSet
            // 
            this.financialAppDataSet.DataSetName = "FinancialAppDataSet";
            this.financialAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource1
            // 
            this.loginBindingSource1.DataMember = "Login";
            this.loginBindingSource1.DataSource = this.financialAppDataSet;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoriasTableAdapter = null;
            this.tableAdapterManager1.DespesasTableAdapter = null;
            this.tableAdapterManager1.DespesaTableAdapter = null;
            this.tableAdapterManager1.LoginTableAdapter = this.loginTableAdapter1;
            this.tableAdapterManager1.PagamentosTableAdapter = null;
            this.tableAdapterManager1.ReceitasTableAdapter = null;
            this.tableAdapterManager1.ReceitaTableAdapter = null;
            this.tableAdapterManager1.TransferenciasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Projeto_BudgetApp.FinancialAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(282, 396);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.TextBox txtNewLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private FinancialAppDataSet financialAppDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource1;
        private FinancialAppDataSetTableAdapters.LoginTableAdapter loginTableAdapter1;
        private FinancialAppDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}