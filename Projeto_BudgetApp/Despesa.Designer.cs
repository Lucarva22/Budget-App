namespace Projeto_BudgetApp
{
    partial class Despesa
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.despesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialAppDataSet = new Projeto_BudgetApp.FinancialAppDataSet();
            this.despesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.despesaTableAdapter = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.DespesaTableAdapter();
            this.tableAdapterManager1 = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.TableAdapterManager();
            this.pagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentosTableAdapter = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.PagamentosTableAdapter();
            this.despesasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.despesasTableAdapter = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.DespesasTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new Projeto_BudgetApp.FinancialAppDataSetTableAdapters.CategoriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(151, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 39);
            this.button2.TabIndex = 21;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 380);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 35);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(18, 224);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(231, 35);
            this.txtNome.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(17, 76);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(231, 35);
            this.txtValor.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, -8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 49);
            this.label5.TabIndex = 22;
            this.label5.Text = "Despesas";
            // 
            // despesasBindingSource
            // 
            this.despesasBindingSource.DataMember = "Despesas";
            // 
            // financialAppDataSet
            // 
            this.financialAppDataSet.DataSetName = "FinancialAppDataSet";
            this.financialAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // despesaBindingSource
            // 
            this.despesaBindingSource.DataMember = "Despesa";
            this.despesaBindingSource.DataSource = this.financialAppDataSet;
            // 
            // despesaTableAdapter
            // 
            this.despesaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoriasTableAdapter = null;
            this.tableAdapterManager1.DespesasTableAdapter = null;
            this.tableAdapterManager1.DespesaTableAdapter = this.despesaTableAdapter;
            this.tableAdapterManager1.LoginTableAdapter = null;
            this.tableAdapterManager1.PagamentosTableAdapter = null;
            this.tableAdapterManager1.ReceitasTableAdapter = null;
            this.tableAdapterManager1.ReceitaTableAdapter = null;
            this.tableAdapterManager1.TransferenciasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Projeto_BudgetApp.FinancialAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pagamentosBindingSource
            // 
            this.pagamentosBindingSource.DataMember = "Pagamentos";
            this.pagamentosBindingSource.DataSource = this.financialAppDataSet;
            // 
            // pagamentosTableAdapter
            // 
            this.pagamentosTableAdapter.ClearBeforeFill = true;
            // 
            // despesasBindingSource1
            // 
            this.despesasBindingSource1.DataMember = "Despesas";
            this.despesasBindingSource1.DataSource = this.financialAppDataSet;
            // 
            // despesasTableAdapter
            // 
            this.despesasTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pagamento";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pagamentosBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 35);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "CodPagamento";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.categoriasBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 151);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 35);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.ValueMember = "CodCategorias";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.financialAppDataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // Despesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(349, 505);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Despesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesa";
            this.Load += new System.EventHandler(this.Despesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource despesasBindingSource;
        private FinancialAppDataSet financialAppDataSet;
        private System.Windows.Forms.BindingSource despesaBindingSource;
        private FinancialAppDataSetTableAdapters.DespesaTableAdapter despesaTableAdapter;
        private FinancialAppDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource pagamentosBindingSource;
        private FinancialAppDataSetTableAdapters.PagamentosTableAdapter pagamentosTableAdapter;
        private System.Windows.Forms.BindingSource despesasBindingSource1;
        private FinancialAppDataSetTableAdapters.DespesasTableAdapter despesasTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private FinancialAppDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
    }
}