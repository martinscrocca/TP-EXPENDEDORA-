namespace Expendedora.PresentacionGUI
{
    partial class ListaLatas
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
            this.listBoxLatas2 = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCantidadLatas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxLatas2
            // 
            this.listBoxLatas2.Font = new System.Drawing.Font("Roland", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLatas2.FormattingEnabled = true;
            this.listBoxLatas2.ItemHeight = 25;
            this.listBoxLatas2.Location = new System.Drawing.Point(6, 148);
            this.listBoxLatas2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxLatas2.Name = "listBoxLatas2";
            this.listBoxLatas2.Size = new System.Drawing.Size(1163, 479);
            this.listBoxLatas2.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(153, 638);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 35);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblCantidadLatas
            // 
            this.lblCantidadLatas.AutoSize = true;
            this.lblCantidadLatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadLatas.Location = new System.Drawing.Point(940, 34);
            this.lblCantidadLatas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadLatas.Name = "lblCantidadLatas";
            this.lblCantidadLatas.Size = new System.Drawing.Size(99, 33);
            this.lblCantidadLatas.TabIndex = 2;
            this.lblCantidadLatas.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Woodcut", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(410, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad Total de Latas";
            // 
            // ListaLatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantidadLatas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listBoxLatas2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListaLatas";
            this.Text = "ListaLatas";
            this.Load += new System.EventHandler(this.ListaLatas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLatas2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCantidadLatas;
        private System.Windows.Forms.Label label2;
    }
}