﻿
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
            this.components = new System.ComponentModel.Container();
            this.lslPersonnel = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.suppPersonnel = new System.Windows.Forms.Button();
            this.modifPersonnel = new System.Windows.Forms.Button();
            this.ajoutPersonnel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.De = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.à = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.mediatek86DataSet = new MediaTek86.mediatek86DataSet();
            this.absenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.absenceTableAdapter = new MediaTek86.mediatek86DataSetTableAdapters.absenceTableAdapter();
            this.mediatek86DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediatek86DataSet1 = new MediaTek86.mediatek86DataSet1();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelTableAdapter = new MediaTek86.mediatek86DataSet1TableAdapters.personnelTableAdapter();
            this.mediatek86DataSet2 = new MediaTek86.mediatek86DataSet2();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new MediaTek86.mediatek86DataSet2TableAdapters.serviceTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatek86DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatek86DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatek86DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatek86DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lslPersonnel
            // 
            this.lslPersonnel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personnelBindingSource, "NOM", true));
            this.lslPersonnel.DataSource = this.personnelBindingSource;
            this.lslPersonnel.DisplayMember = "NOM";
            this.lslPersonnel.FormattingEnabled = true;
            this.lslPersonnel.Location = new System.Drawing.Point(6, 83);
            this.lslPersonnel.Name = "lslPersonnel";
            this.lslPersonnel.Size = new System.Drawing.Size(240, 277);
            this.lslPersonnel.TabIndex = 0;
            this.lslPersonnel.ValueMember = "NOM";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.serviceBindingSource, "NOM", true));
            this.comboBox1.DataSource = this.serviceBindingSource;
            this.comboBox1.DisplayMember = "NOM";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "NOM";
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
            this.groupBox1.Controls.Add(this.lslPersonnel);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 373);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnels";
            // 
            // suppPersonnel
            // 
            this.suppPersonnel.Location = new System.Drawing.Point(323, 391);
            this.suppPersonnel.Name = "suppPersonnel";
            this.suppPersonnel.Size = new System.Drawing.Size(147, 32);
            this.suppPersonnel.TabIndex = 6;
            this.suppPersonnel.Text = "Supprimer";
            this.suppPersonnel.UseVisualStyleBackColor = true;
            // 
            // modifPersonnel
            // 
            this.modifPersonnel.Location = new System.Drawing.Point(170, 391);
            this.modifPersonnel.Name = "modifPersonnel";
            this.modifPersonnel.Size = new System.Drawing.Size(147, 32);
            this.modifPersonnel.TabIndex = 5;
            this.modifPersonnel.Text = "Modifier";
            this.modifPersonnel.UseVisualStyleBackColor = true;
            // 
            // ajoutPersonnel
            // 
            this.ajoutPersonnel.Location = new System.Drawing.Point(14, 391);
            this.ajoutPersonnel.Name = "ajoutPersonnel";
            this.ajoutPersonnel.Size = new System.Drawing.Size(150, 32);
            this.ajoutPersonnel.TabIndex = 1;
            this.ajoutPersonnel.Text = "Ajouter";
            this.ajoutPersonnel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(277, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 373);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Absences";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.De,
            this.à,
            this.Motif});
            this.dataGridView1.DataSource = this.mediatek86DataSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 354);
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
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(476, 391);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(147, 32);
            this.btnDeconnexion.TabIndex = 9;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // mediatek86DataSet
            // 
            this.mediatek86DataSet.DataSetName = "mediatek86DataSet";
            this.mediatek86DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // absenceBindingSource
            // 
            this.absenceBindingSource.DataMember = "absence";
            this.absenceBindingSource.DataSource = this.mediatek86DataSet;
            // 
            // absenceTableAdapter
            // 
            this.absenceTableAdapter.ClearBeforeFill = true;
            // 
            // mediatek86DataSetBindingSource
            // 
            this.mediatek86DataSetBindingSource.DataSource = this.mediatek86DataSet;
            this.mediatek86DataSetBindingSource.Position = 0;
            // 
            // mediatek86DataSet1
            // 
            this.mediatek86DataSet1.DataSetName = "mediatek86DataSet1";
            this.mediatek86DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "personnel";
            this.personnelBindingSource.DataSource = this.mediatek86DataSet1;
            // 
            // personnelTableAdapter
            // 
            this.personnelTableAdapter.ClearBeforeFill = true;
            // 
            // mediatek86DataSet2
            // 
            this.mediatek86DataSet2.DataSetName = "mediatek86DataSet2";
            this.mediatek86DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "service";
            this.serviceBindingSource.DataSource = this.mediatek86DataSet2;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 431);
            this.Controls.Add(this.suppPersonnel);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.modifPersonnel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ajoutPersonnel);
            this.Controls.Add(this.groupBox1);
            this.Name = "absence";
            this.Text = "Gérer les absences";
            this.Load += new System.EventHandler(this.absence_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatek86DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatek86DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatek86DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatek86DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn De;
        private System.Windows.Forms.DataGridViewTextBoxColumn à;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motif;
        private System.Windows.Forms.Button btnDeconnexion;
        private mediatek86DataSet mediatek86DataSet;
        private System.Windows.Forms.BindingSource absenceBindingSource;
        private mediatek86DataSetTableAdapters.absenceTableAdapter absenceTableAdapter;
        private System.Windows.Forms.BindingSource mediatek86DataSetBindingSource;
        private mediatek86DataSet1 mediatek86DataSet1;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private mediatek86DataSet1TableAdapters.personnelTableAdapter personnelTableAdapter;
        private mediatek86DataSet2 mediatek86DataSet2;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private mediatek86DataSet2TableAdapters.serviceTableAdapter serviceTableAdapter;
    }
}