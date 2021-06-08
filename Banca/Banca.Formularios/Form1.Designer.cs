
namespace Banca.Formularios
{
    partial class Form1
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
            this.LstTipos = new System.Windows.Forms.ListBox();
            this.LstPrestamos = new System.Windows.Forms.ListBox();
            this.TxtLinea = new System.Windows.Forms.TextBox();
            this.TxtTNA = new System.Windows.Forms.TextBox();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.TxtPlazo = new System.Windows.Forms.TextBox();
            this.BtnSimular = new System.Windows.Forms.Button();
            this.TxtCapital = new System.Windows.Forms.TextBox();
            this.TxtInteres = new System.Windows.Forms.TextBox();
            this.TxtCuotaTotal = new System.Windows.Forms.TextBox();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.TxtComisionTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblComisionTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstTipos
            // 
            this.LstTipos.FormattingEnabled = true;
            this.LstTipos.Location = new System.Drawing.Point(6, 59);
            this.LstTipos.Name = "LstTipos";
            this.LstTipos.Size = new System.Drawing.Size(207, 277);
            this.LstTipos.TabIndex = 0;
            this.LstTipos.SelectedIndexChanged += new System.EventHandler(this.LstTipos_SelectedIndexChanged);
            // 
            // LstPrestamos
            // 
            this.LstPrestamos.FormattingEnabled = true;
            this.LstPrestamos.Location = new System.Drawing.Point(40, 60);
            this.LstPrestamos.Name = "LstPrestamos";
            this.LstPrestamos.Size = new System.Drawing.Size(308, 277);
            this.LstPrestamos.TabIndex = 1;
            // 
            // TxtLinea
            // 
            this.TxtLinea.Enabled = false;
            this.TxtLinea.Location = new System.Drawing.Point(305, 22);
            this.TxtLinea.Name = "TxtLinea";
            this.TxtLinea.Size = new System.Drawing.Size(122, 20);
            this.TxtLinea.TabIndex = 2;
            // 
            // TxtTNA
            // 
            this.TxtTNA.Enabled = false;
            this.TxtTNA.Location = new System.Drawing.Point(305, 67);
            this.TxtTNA.Name = "TxtTNA";
            this.TxtTNA.Size = new System.Drawing.Size(122, 20);
            this.TxtTNA.TabIndex = 3;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(305, 112);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(122, 20);
            this.TxtMonto.TabIndex = 4;
            // 
            // TxtPlazo
            // 
            this.TxtPlazo.Location = new System.Drawing.Point(305, 159);
            this.TxtPlazo.Name = "TxtPlazo";
            this.TxtPlazo.Size = new System.Drawing.Size(122, 20);
            this.TxtPlazo.TabIndex = 5;
            // 
            // BtnSimular
            // 
            this.BtnSimular.Location = new System.Drawing.Point(339, 208);
            this.BtnSimular.Name = "BtnSimular";
            this.BtnSimular.Size = new System.Drawing.Size(75, 23);
            this.BtnSimular.TabIndex = 6;
            this.BtnSimular.Text = "Simular";
            this.BtnSimular.UseVisualStyleBackColor = true;
            this.BtnSimular.Click += new System.EventHandler(this.BtnSimular_Click);
            // 
            // TxtCapital
            // 
            this.TxtCapital.Enabled = false;
            this.TxtCapital.Location = new System.Drawing.Point(327, 250);
            this.TxtCapital.Name = "TxtCapital";
            this.TxtCapital.Size = new System.Drawing.Size(100, 20);
            this.TxtCapital.TabIndex = 7;
            // 
            // TxtInteres
            // 
            this.TxtInteres.Enabled = false;
            this.TxtInteres.Location = new System.Drawing.Point(327, 291);
            this.TxtInteres.Name = "TxtInteres";
            this.TxtInteres.Size = new System.Drawing.Size(100, 20);
            this.TxtInteres.TabIndex = 8;
            // 
            // TxtCuotaTotal
            // 
            this.TxtCuotaTotal.Enabled = false;
            this.TxtCuotaTotal.Location = new System.Drawing.Point(327, 328);
            this.TxtCuotaTotal.Name = "TxtCuotaTotal";
            this.TxtCuotaTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtCuotaTotal.TabIndex = 9;
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(339, 369);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(75, 23);
            this.BtnAlta.TabIndex = 10;
            this.BtnAlta.Text = "ALTA";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // TxtComisionTotal
            // 
            this.TxtComisionTotal.Location = new System.Drawing.Point(181, 373);
            this.TxtComisionTotal.Name = "TxtComisionTotal";
            this.TxtComisionTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtComisionTotal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Línea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "TNA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Plazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cuota (INterés)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cuota(Capital)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "CUOTA TOTAL";
            // 
            // LblComisionTotal
            // 
            this.LblComisionTotal.AutoSize = true;
            this.LblComisionTotal.Location = new System.Drawing.Point(68, 375);
            this.LblComisionTotal.Name = "LblComisionTotal";
            this.LblComisionTotal.Size = new System.Drawing.Size(76, 13);
            this.LblComisionTotal.TabIndex = 19;
            this.LblComisionTotal.Text = "Comisión Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "TIPOS PRESTAMO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnAlta);
            this.groupBox1.Controls.Add(this.TxtCuotaTotal);
            this.groupBox1.Controls.Add(this.TxtInteres);
            this.groupBox1.Controls.Add(this.TxtCapital);
            this.groupBox1.Controls.Add(this.BtnSimular);
            this.groupBox1.Controls.Add(this.TxtPlazo);
            this.groupBox1.Controls.Add(this.TxtMonto);
            this.groupBox1.Controls.Add(this.TxtTNA);
            this.groupBox1.Controls.Add(this.TxtLinea);
            this.groupBox1.Controls.Add(this.LstTipos);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 405);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.LblComisionTotal);
            this.groupBox2.Controls.Add(this.TxtComisionTotal);
            this.groupBox2.Controls.Add(this.LstPrestamos);
            this.groupBox2.Location = new System.Drawing.Point(481, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 405);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstTipos;
        private System.Windows.Forms.ListBox LstPrestamos;
        private System.Windows.Forms.TextBox TxtLinea;
        private System.Windows.Forms.TextBox TxtTNA;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.TextBox TxtPlazo;
        private System.Windows.Forms.Button BtnSimular;
        private System.Windows.Forms.TextBox TxtCapital;
        private System.Windows.Forms.TextBox TxtInteres;
        private System.Windows.Forms.TextBox TxtCuotaTotal;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.TextBox TxtComisionTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblComisionTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

