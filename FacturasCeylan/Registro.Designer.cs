namespace FacturasCeylan
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RNameCliente = new System.Windows.Forms.TextBox();
            this.RRFC = new System.Windows.Forms.TextBox();
            this.RDomici = new System.Windows.Forms.TextBox();
            this.REmail = new System.Windows.Forms.TextBox();
            this.RPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE USUARIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*NOMBRE CLIENTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*R.F.C.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "*DOMICILIO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CORREO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TELEFONO:";
            // 
            // RNameCliente
            // 
            this.RNameCliente.Location = new System.Drawing.Point(137, 70);
            this.RNameCliente.MaxLength = 200;
            this.RNameCliente.Name = "RNameCliente";
            this.RNameCliente.Size = new System.Drawing.Size(273, 20);
            this.RNameCliente.TabIndex = 6;
            // 
            // RRFC
            // 
            this.RRFC.Location = new System.Drawing.Point(137, 110);
            this.RRFC.MaxLength = 13;
            this.RRFC.Name = "RRFC";
            this.RRFC.Size = new System.Drawing.Size(273, 20);
            this.RRFC.TabIndex = 7;
            // 
            // RDomici
            // 
            this.RDomici.Location = new System.Drawing.Point(137, 145);
            this.RDomici.MaxLength = 300;
            this.RDomici.Name = "RDomici";
            this.RDomici.Size = new System.Drawing.Size(273, 20);
            this.RDomici.TabIndex = 8;
            // 
            // REmail
            // 
            this.REmail.Location = new System.Drawing.Point(137, 190);
            this.REmail.MaxLength = 150;
            this.REmail.Name = "REmail";
            this.REmail.Size = new System.Drawing.Size(273, 20);
            this.REmail.TabIndex = 9;
            // 
            // RPhone
            // 
            this.RPhone.Location = new System.Drawing.Point(137, 231);
            this.RPhone.MaxLength = 20;
            this.RPhone.Name = "RPhone";
            this.RPhone.Size = new System.Drawing.Size(273, 20);
            this.RPhone.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "* Datos Obligatorios";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 317);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RPhone);
            this.Controls.Add(this.REmail);
            this.Controls.Add(this.RDomici);
            this.Controls.Add(this.RRFC);
            this.Controls.Add(this.RNameCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RNameCliente;
        private System.Windows.Forms.TextBox RRFC;
        private System.Windows.Forms.TextBox RDomici;
        private System.Windows.Forms.TextBox REmail;
        private System.Windows.Forms.TextBox RPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}