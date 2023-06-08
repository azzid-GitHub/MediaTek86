
namespace MediaTek86.view
{
    partial class absence
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
            this.lslPersonnel = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.suppPersonnel = new System.Windows.Forms.Button();
            this.modifPersonnel = new System.Windows.Forms.Button();
            this.ajoutPersonnel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuppAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.De = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.à = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAjouModifPersonnel = new System.Windows.Forms.GroupBox();
            this.btnValiderPersonnel = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpModifAbsence = new System.Windows.Forms.GroupBox();
            this.btnValiderAbsence = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAjouModifPersonnel.SuspendLayout();
            this.grpModifAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // lslPersonnel
            // 
            this.lslPersonnel.FormattingEnabled = true;
            this.lslPersonnel.Location = new System.Drawing.Point(6, 83);
            this.lslPersonnel.Name = "lslPersonnel";
            this.lslPersonnel.Size = new System.Drawing.Size(240, 277);
            this.lslPersonnel.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Services :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.suppPersonnel);
            this.groupBox1.Controls.Add(this.modifPersonnel);
            this.groupBox1.Controls.Add(this.ajoutPersonnel);
            this.groupBox1.Controls.Add(this.lslPersonnel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 396);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnels";
            // 
            // suppPersonnel
            // 
            this.suppPersonnel.Location = new System.Drawing.Point(171, 366);
            this.suppPersonnel.Name = "suppPersonnel";
            this.suppPersonnel.Size = new System.Drawing.Size(75, 23);
            this.suppPersonnel.TabIndex = 6;
            this.suppPersonnel.Text = "Supprimer";
            this.suppPersonnel.UseVisualStyleBackColor = true;
            // 
            // modifPersonnel
            // 
            this.modifPersonnel.Location = new System.Drawing.Point(90, 365);
            this.modifPersonnel.Name = "modifPersonnel";
            this.modifPersonnel.Size = new System.Drawing.Size(75, 23);
            this.modifPersonnel.TabIndex = 5;
            this.modifPersonnel.Text = "Modifier";
            this.modifPersonnel.UseVisualStyleBackColor = true;
            // 
            // ajoutPersonnel
            // 
            this.ajoutPersonnel.Location = new System.Drawing.Point(6, 366);
            this.ajoutPersonnel.Name = "ajoutPersonnel";
            this.ajoutPersonnel.Size = new System.Drawing.Size(78, 22);
            this.ajoutPersonnel.TabIndex = 1;
            this.ajoutPersonnel.Text = "Ajouter";
            this.ajoutPersonnel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSuppAbsence);
            this.groupBox2.Controls.Add(this.btnModifAbsence);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(277, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 396);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Absences";
            // 
            // btnSuppAbsence
            // 
            this.btnSuppAbsence.Location = new System.Drawing.Point(256, 366);
            this.btnSuppAbsence.Name = "btnSuppAbsence";
            this.btnSuppAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnSuppAbsence.TabIndex = 7;
            this.btnSuppAbsence.Text = "Supprimer";
            this.btnSuppAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModifAbsence.Location = new System.Drawing.Point(175, 365);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnModifAbsence.TabIndex = 8;
            this.btnModifAbsence.Text = "Modifier";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.De,
            this.à,
            this.Motif});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // De
            // 
            this.De.HeaderText = "de";
            this.De.Name = "De";
            // 
            // à
            // 
            this.à.HeaderText = "a";
            this.à.Name = "à";
            this.à.ReadOnly = true;
            // 
            // Motif
            // 
            this.Motif.HeaderText = "motif";
            this.Motif.Name = "Motif";
            // 
            // grpAjouModifPersonnel
            // 
            this.grpAjouModifPersonnel.Controls.Add(this.btnValiderPersonnel);
            this.grpAjouModifPersonnel.Controls.Add(this.textBox4);
            this.grpAjouModifPersonnel.Controls.Add(this.textBox3);
            this.grpAjouModifPersonnel.Controls.Add(this.textBox2);
            this.grpAjouModifPersonnel.Controls.Add(this.textBox1);
            this.grpAjouModifPersonnel.Controls.Add(this.lblMail);
            this.grpAjouModifPersonnel.Controls.Add(this.lblTel);
            this.grpAjouModifPersonnel.Controls.Add(this.lblPrenom);
            this.grpAjouModifPersonnel.Controls.Add(this.lblNom);
            this.grpAjouModifPersonnel.Location = new System.Drawing.Point(8, 414);
            this.grpAjouModifPersonnel.Name = "grpAjouModifPersonnel";
            this.grpAjouModifPersonnel.Size = new System.Drawing.Size(252, 188);
            this.grpAjouModifPersonnel.TabIndex = 7;
            this.grpAjouModifPersonnel.TabStop = false;
            // 
            // btnValiderPersonnel
            // 
            this.btnValiderPersonnel.Location = new System.Drawing.Point(90, 156);
            this.btnValiderPersonnel.Name = "btnValiderPersonnel";
            this.btnValiderPersonnel.Size = new System.Drawing.Size(156, 23);
            this.btnValiderPersonnel.TabIndex = 8;
            this.btnValiderPersonnel.Text = "Valider";
            this.btnValiderPersonnel.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(3, 123);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(3, 89);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Tél :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(3, 54);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(3, 22);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
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
            this.grpModifAbsence.Location = new System.Drawing.Point(277, 420);
            this.grpModifAbsence.Name = "grpModifAbsence";
            this.grpModifAbsence.Size = new System.Drawing.Size(337, 182);
            this.grpModifAbsence.TabIndex = 8;
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
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(452, 630);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(156, 23);
            this.btnDeconnexion.TabIndex = 9;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 664);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.grpModifAbsence);
            this.Controls.Add(this.grpAjouModifPersonnel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "absence";
            this.Text = "Gérer les absences";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAjouModifPersonnel.ResumeLayout(false);
            this.grpAjouModifPersonnel.PerformLayout();
            this.grpModifAbsence.ResumeLayout(false);
            this.grpModifAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lslPersonnel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button suppPersonnel;
        private System.Windows.Forms.Button modifPersonnel;
        private System.Windows.Forms.Button ajoutPersonnel;
        private System.Windows.Forms.Button btnSuppAbsence;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn De;
        private System.Windows.Forms.DataGridViewTextBoxColumn à;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motif;
        private System.Windows.Forms.GroupBox grpAjouModifPersonnel;
        private System.Windows.Forms.Button btnValiderPersonnel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grpModifAbsence;
        private System.Windows.Forms.Button btnValiderAbsence;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}