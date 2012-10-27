namespace FacturasCeylan
{
    partial class Impresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impresion));
            this.Imprime = new System.Windows.Forms.Button();
            this.Folio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Imprime
            // 
            this.Imprime.Location = new System.Drawing.Point(54, 124);
            this.Imprime.Name = "Imprime";
            this.Imprime.Size = new System.Drawing.Size(130, 33);
            this.Imprime.TabIndex = 0;
            this.Imprime.Text = "Reimprimir Folio";
            this.Imprime.UseVisualStyleBackColor = true;
            this.Imprime.Click += new System.EventHandler(this.Imprime_Click);
            // 
            // Folio
            // 
            this.Folio.Location = new System.Drawing.Point(67, 62);
            this.Folio.Name = "Folio";
            this.Folio.Size = new System.Drawing.Size(100, 20);
            this.Folio.TabIndex = 1;
            this.Folio.TextChanged += new System.EventHandler(this.Folio_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Folio);
            this.groupBox1.Controls.Add(this.Imprime);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numero de Factura a Imprimir";
            // 
            // Impresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Impresion";
            this.Text = "Impresion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Imprime;
        private System.Windows.Forms.TextBox Folio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}