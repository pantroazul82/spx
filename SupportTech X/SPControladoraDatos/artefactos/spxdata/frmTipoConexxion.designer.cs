namespace SPX2019.artefactos.SPXdata.frm.cnn
{
    partial class frmTipoConexxion
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rdMysql = new System.Windows.Forms.RadioButton();
            this.rdSqlServer = new System.Windows.Forms.RadioButton();
            this.rdOracle = new System.Windows.Forms.RadioButton();
            this.rdPostgress = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(201, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(120, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rdMysql
            // 
            this.rdMysql.AutoSize = true;
            this.rdMysql.Location = new System.Drawing.Point(64, 69);
            this.rdMysql.Name = "rdMysql";
            this.rdMysql.Size = new System.Drawing.Size(54, 17);
            this.rdMysql.TabIndex = 2;
            this.rdMysql.Text = "MySql";
            this.rdMysql.UseVisualStyleBackColor = true;
            // 
            // rdSqlServer
            // 
            this.rdSqlServer.AutoSize = true;
            this.rdSqlServer.Checked = true;
            this.rdSqlServer.Location = new System.Drawing.Point(64, 94);
            this.rdSqlServer.Name = "rdSqlServer";
            this.rdSqlServer.Size = new System.Drawing.Size(74, 17);
            this.rdSqlServer.TabIndex = 3;
            this.rdSqlServer.TabStop = true;
            this.rdSqlServer.Text = "Sql Server";
            this.rdSqlServer.UseVisualStyleBackColor = true;
            // 
            // rdOracle
            // 
            this.rdOracle.AutoSize = true;
            this.rdOracle.Location = new System.Drawing.Point(64, 119);
            this.rdOracle.Name = "rdOracle";
            this.rdOracle.Size = new System.Drawing.Size(56, 17);
            this.rdOracle.TabIndex = 4;
            this.rdOracle.Text = "Oracle";
            this.rdOracle.UseVisualStyleBackColor = true;
            // 
            // rdPostgress
            // 
            this.rdPostgress.AutoSize = true;
            this.rdPostgress.Location = new System.Drawing.Point(64, 144);
            this.rdPostgress.Name = "rdPostgress";
            this.rdPostgress.Size = new System.Drawing.Size(71, 17);
            this.rdPostgress.TabIndex = 5;
            this.rdPostgress.Text = "Postgress";
            this.rdPostgress.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 50);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione el tipo de motor al que desea conectarse";
            // 
            // frmTipoConexxion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdPostgress);
            this.Controls.Add(this.rdOracle);
            this.Controls.Add(this.rdSqlServer);
            this.Controls.Add(this.rdMysql);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTipoConexxion";
            this.Text = "Tipo de Conexxion";
            this.Load += new System.EventHandler(this.frmTipoConexxion_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rdMysql;
        private System.Windows.Forms.RadioButton rdSqlServer;
        private System.Windows.Forms.RadioButton rdOracle;
        private System.Windows.Forms.RadioButton rdPostgress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}