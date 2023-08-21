
namespace MediaTek86.view
{
    partial class AjoutAbsence
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
            this.grpModifAbsence = new System.Windows.Forms.GroupBox();
            this.btnValiderAbsence = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.grpModifAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModifAbsence
            // 
            this.grpModifAbsence.Controls.Add(this.btnValiderAbsence);
            this.grpModifAbsence.Controls.Add(this.comboBox2);
            this.grpModifAbsence.Controls.Add(this.txtFin);
            this.grpModifAbsence.Controls.Add(this.txtDebut);
            this.grpModifAbsence.Controls.Add(this.label4);
            this.grpModifAbsence.Controls.Add(this.label3);
            this.grpModifAbsence.Controls.Add(this.lblDateDebut);
            this.grpModifAbsence.Location = new System.Drawing.Point(12, 12);
            this.grpModifAbsence.Name = "grpModifAbsence";
            this.grpModifAbsence.Size = new System.Drawing.Size(337, 182);
            this.grpModifAbsence.TabIndex = 9;
            this.grpModifAbsence.TabStop = false;
            // 
            // btnValiderAbsence
            // 
            this.btnValiderAbsence.Location = new System.Drawing.Point(175, 153);
            this.btnValiderAbsence.Name = "btnValiderAbsence";
            this.btnValiderAbsence.Size = new System.Drawing.Size(156, 23);
            this.btnValiderAbsence.TabIndex = 9;
            this.btnValiderAbsence.Text = "Valider";
            this.btnValiderAbsence.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(175, 45);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(156, 20);
            this.txtFin.TabIndex = 4;
            // 
            // txtDebut
            // 
            this.txtDebut.Location = new System.Drawing.Point(175, 16);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(156, 20);
            this.txtDebut.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Motif :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date de fin :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(11, 16);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(81, 13);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // AjoutAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 206);
            this.Controls.Add(this.grpModifAbsence);
            this.Name = "AjoutAbsence";
            this.Text = "AjoutAbsence";
            this.grpModifAbsence.ResumeLayout(false);
            this.grpModifAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModifAbsence;
        private System.Windows.Forms.Button btnValiderAbsence;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateDebut;
    }
}