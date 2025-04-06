namespace objetos_lineas
{
    partial class frm_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_X1 = new System.Windows.Forms.TextBox();
            this.lbl_X1 = new System.Windows.Forms.Label();
            this.lbl_Y1 = new System.Windows.Forms.Label();
            this.txt_Y1 = new System.Windows.Forms.TextBox();
            this.lbl_X2 = new System.Windows.Forms.Label();
            this.txt_X2 = new System.Windows.Forms.TextBox();
            this.lbl_Y2 = new System.Windows.Forms.Label();
            this.txt_Y2 = new System.Windows.Forms.TextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.gb_grupo1 = new System.Windows.Forms.GroupBox();
            this.bo = new System.Windows.Forms.GroupBox();
            this.btn_dibujar = new System.Windows.Forms.Button();
            this.lbl_CantiadL = new System.Windows.Forms.Label();
            this.gb_grupo1.SuspendLayout();
            this.bo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_X1
            // 
            this.txt_X1.Location = new System.Drawing.Point(47, 67);
            this.txt_X1.Name = "txt_X1";
            this.txt_X1.Size = new System.Drawing.Size(55, 20);
            this.txt_X1.TabIndex = 0;
            // 
            // lbl_X1
            // 
            this.lbl_X1.AutoSize = true;
            this.lbl_X1.Location = new System.Drawing.Point(24, 70);
            this.lbl_X1.Name = "lbl_X1";
            this.lbl_X1.Size = new System.Drawing.Size(17, 13);
            this.lbl_X1.TabIndex = 1;
            this.lbl_X1.Text = "X.";
            // 
            // lbl_Y1
            // 
            this.lbl_Y1.AutoSize = true;
            this.lbl_Y1.Location = new System.Drawing.Point(118, 70);
            this.lbl_Y1.Name = "lbl_Y1";
            this.lbl_Y1.Size = new System.Drawing.Size(17, 13);
            this.lbl_Y1.TabIndex = 3;
            this.lbl_Y1.Text = "Y.";
            // 
            // txt_Y1
            // 
            this.txt_Y1.Location = new System.Drawing.Point(141, 67);
            this.txt_Y1.Name = "txt_Y1";
            this.txt_Y1.Size = new System.Drawing.Size(55, 20);
            this.txt_Y1.TabIndex = 2;
            // 
            // lbl_X2
            // 
            this.lbl_X2.AutoSize = true;
            this.lbl_X2.Location = new System.Drawing.Point(16, 74);
            this.lbl_X2.Name = "lbl_X2";
            this.lbl_X2.Size = new System.Drawing.Size(17, 13);
            this.lbl_X2.TabIndex = 5;
            this.lbl_X2.Text = "X.";
            // 
            // txt_X2
            // 
            this.txt_X2.Location = new System.Drawing.Point(39, 67);
            this.txt_X2.Name = "txt_X2";
            this.txt_X2.Size = new System.Drawing.Size(55, 20);
            this.txt_X2.TabIndex = 4;
            // 
            // lbl_Y2
            // 
            this.lbl_Y2.AutoSize = true;
            this.lbl_Y2.Location = new System.Drawing.Point(117, 73);
            this.lbl_Y2.Name = "lbl_Y2";
            this.lbl_Y2.Size = new System.Drawing.Size(17, 13);
            this.lbl_Y2.TabIndex = 7;
            this.lbl_Y2.Text = "Y.";
            // 
            // txt_Y2
            // 
            this.txt_Y2.Location = new System.Drawing.Point(140, 67);
            this.txt_Y2.Name = "txt_Y2";
            this.txt_Y2.Size = new System.Drawing.Size(55, 20);
            this.txt_Y2.TabIndex = 6;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(6, 16);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(215, 15);
            this.lbl_info.TabIndex = 8;
            this.lbl_info.Text = "ingrese la posiocion inicial (X,Y)\r\n";
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info2.Location = new System.Drawing.Point(13, 16);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(204, 15);
            this.lbl_info2.TabIndex = 9;
            this.lbl_info2.Text = "ingrese la posiocion final (X,Y)\r\n";
            // 
            // gb_grupo1
            // 
            this.gb_grupo1.Controls.Add(this.txt_Y1);
            this.gb_grupo1.Controls.Add(this.txt_X1);
            this.gb_grupo1.Controls.Add(this.lbl_X1);
            this.gb_grupo1.Controls.Add(this.lbl_info);
            this.gb_grupo1.Controls.Add(this.lbl_Y1);
            this.gb_grupo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_grupo1.Location = new System.Drawing.Point(25, 24);
            this.gb_grupo1.Name = "gb_grupo1";
            this.gb_grupo1.Size = new System.Drawing.Size(223, 125);
            this.gb_grupo1.TabIndex = 10;
            this.gb_grupo1.TabStop = false;
            // 
            // bo
            // 
            this.bo.Controls.Add(this.txt_Y2);
            this.bo.Controls.Add(this.txt_X2);
            this.bo.Controls.Add(this.lbl_info2);
            this.bo.Controls.Add(this.lbl_X2);
            this.bo.Controls.Add(this.lbl_Y2);
            this.bo.Location = new System.Drawing.Point(275, 24);
            this.bo.Name = "bo";
            this.bo.Size = new System.Drawing.Size(223, 125);
            this.bo.TabIndex = 11;
            this.bo.TabStop = false;
            // 
            // btn_dibujar
            // 
            this.btn_dibujar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dibujar.Location = new System.Drawing.Point(162, 173);
            this.btn_dibujar.Name = "btn_dibujar";
            this.btn_dibujar.Size = new System.Drawing.Size(92, 33);
            this.btn_dibujar.TabIndex = 12;
            this.btn_dibujar.Text = "Dibujar";
            this.btn_dibujar.UseVisualStyleBackColor = true;
            this.btn_dibujar.Click += new System.EventHandler(this.btn_dibujar_Click);
            // 
            // lbl_CantiadL
            // 
            this.lbl_CantiadL.AutoSize = true;
            this.lbl_CantiadL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CantiadL.Location = new System.Drawing.Point(260, 181);
            this.lbl_CantiadL.Name = "lbl_CantiadL";
            this.lbl_CantiadL.Size = new System.Drawing.Size(109, 16);
            this.lbl_CantiadL.TabIndex = 13;
            this.lbl_CantiadL.Text = "Total Lienas: 0";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 432);
            this.Controls.Add(this.lbl_CantiadL);
            this.Controls.Add(this.btn_dibujar);
            this.Controls.Add(this.gb_grupo1);
            this.Controls.Add(this.bo);
            this.Name = "frm_principal";
            this.Text = "Dubujar liena";
            this.gb_grupo1.ResumeLayout(false);
            this.gb_grupo1.PerformLayout();
            this.bo.ResumeLayout(false);
            this.bo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_X1;
        private System.Windows.Forms.Label lbl_X1;
        private System.Windows.Forms.Label lbl_Y1;
        private System.Windows.Forms.TextBox txt_Y1;
        private System.Windows.Forms.Label lbl_X2;
        private System.Windows.Forms.TextBox txt_X2;
        private System.Windows.Forms.Label lbl_Y2;
        private System.Windows.Forms.TextBox txt_Y2;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_info2;
        private System.Windows.Forms.GroupBox gb_grupo1;
        private System.Windows.Forms.GroupBox bo;
        private System.Windows.Forms.Button btn_dibujar;
        private System.Windows.Forms.Label lbl_CantiadL;
    }
}

