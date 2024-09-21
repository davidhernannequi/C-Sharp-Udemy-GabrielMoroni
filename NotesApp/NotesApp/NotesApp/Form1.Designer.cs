namespace NotesApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(87, 363);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(56, 66);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(271, 286);
            this.txtNotes.TabIndex = 4;
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.AutoGenerateColumns = false;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8});
            this.dgvNotes.DataSource = this.noteBindingSource;
            this.dgvNotes.Location = new System.Drawing.Point(366, 28);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.Size = new System.Drawing.Size(244, 324);
            this.dgvNotes.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(56, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(271, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(15, 69);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "Notes:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 37);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(490, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 37);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(383, 362);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(101, 37);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn8.HeaderText = "Title";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(NotesApp.Note);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 412);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes App";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource noteBindingSource;
    }
}

