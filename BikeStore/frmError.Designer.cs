namespace BikeStore
{
    partial class frmError
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
            this.dgvError = new System.Windows.Forms.DataGridView();
            this.errorLogIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorSeverityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProcedureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorMessageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bikeStoreDataSet = new BikeStore.BikeStoreDataSet();
            this.errorLogTableAdapter = new BikeStore.BikeStoreDataSetTableAdapters.ErrorLogTableAdapter();
            this.lblError = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvError
            // 
            this.dgvError.AllowUserToAddRows = false;
            this.dgvError.AllowUserToDeleteRows = false;
            this.dgvError.AutoGenerateColumns = false;
            this.dgvError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.errorLogIDDataGridViewTextBoxColumn,
            this.errorTimeDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.errorNumberDataGridViewTextBoxColumn,
            this.errorSeverityDataGridViewTextBoxColumn,
            this.errorStateDataGridViewTextBoxColumn,
            this.errorProcedureDataGridViewTextBoxColumn,
            this.errorLineDataGridViewTextBoxColumn,
            this.errorMessageDataGridViewTextBoxColumn});
            this.dgvError.DataSource = this.errorLogBindingSource;
            this.dgvError.Location = new System.Drawing.Point(12, 178);
            this.dgvError.Name = "dgvError";
            this.dgvError.ReadOnly = true;
            this.dgvError.RowHeadersVisible = false;
            this.dgvError.RowHeadersWidth = 51;
            this.dgvError.RowTemplate.Height = 24;
            this.dgvError.Size = new System.Drawing.Size(776, 347);
            this.dgvError.TabIndex = 0;
            // 
            // errorLogIDDataGridViewTextBoxColumn
            // 
            this.errorLogIDDataGridViewTextBoxColumn.DataPropertyName = "ErrorLogID";
            this.errorLogIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.errorLogIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorLogIDDataGridViewTextBoxColumn.Name = "errorLogIDDataGridViewTextBoxColumn";
            this.errorLogIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorTimeDataGridViewTextBoxColumn
            // 
            this.errorTimeDataGridViewTextBoxColumn.DataPropertyName = "ErrorTime";
            this.errorTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.errorTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorTimeDataGridViewTextBoxColumn.Name = "errorTimeDataGridViewTextBoxColumn";
            this.errorTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorNumberDataGridViewTextBoxColumn
            // 
            this.errorNumberDataGridViewTextBoxColumn.DataPropertyName = "ErrorNumber";
            this.errorNumberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.errorNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorNumberDataGridViewTextBoxColumn.Name = "errorNumberDataGridViewTextBoxColumn";
            this.errorNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorSeverityDataGridViewTextBoxColumn
            // 
            this.errorSeverityDataGridViewTextBoxColumn.DataPropertyName = "ErrorSeverity";
            this.errorSeverityDataGridViewTextBoxColumn.HeaderText = "Severity";
            this.errorSeverityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorSeverityDataGridViewTextBoxColumn.Name = "errorSeverityDataGridViewTextBoxColumn";
            this.errorSeverityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorStateDataGridViewTextBoxColumn
            // 
            this.errorStateDataGridViewTextBoxColumn.DataPropertyName = "ErrorState";
            this.errorStateDataGridViewTextBoxColumn.HeaderText = "State";
            this.errorStateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorStateDataGridViewTextBoxColumn.Name = "errorStateDataGridViewTextBoxColumn";
            this.errorStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorProcedureDataGridViewTextBoxColumn
            // 
            this.errorProcedureDataGridViewTextBoxColumn.DataPropertyName = "ErrorProcedure";
            this.errorProcedureDataGridViewTextBoxColumn.HeaderText = "Procedure";
            this.errorProcedureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorProcedureDataGridViewTextBoxColumn.Name = "errorProcedureDataGridViewTextBoxColumn";
            this.errorProcedureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorLineDataGridViewTextBoxColumn
            // 
            this.errorLineDataGridViewTextBoxColumn.DataPropertyName = "ErrorLine";
            this.errorLineDataGridViewTextBoxColumn.HeaderText = "Line";
            this.errorLineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorLineDataGridViewTextBoxColumn.Name = "errorLineDataGridViewTextBoxColumn";
            this.errorLineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorMessageDataGridViewTextBoxColumn
            // 
            this.errorMessageDataGridViewTextBoxColumn.DataPropertyName = "ErrorMessage";
            this.errorMessageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.errorMessageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorMessageDataGridViewTextBoxColumn.Name = "errorMessageDataGridViewTextBoxColumn";
            this.errorMessageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorLogBindingSource
            // 
            this.errorLogBindingSource.DataMember = "ErrorLog";
            this.errorLogBindingSource.DataSource = this.bikeStoreDataSet;
            // 
            // bikeStoreDataSet
            // 
            this.bikeStoreDataSet.DataSetName = "BikeStoreDataSet";
            this.bikeStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorLogTableAdapter
            // 
            this.errorLogTableAdapter.ClearBeforeFill = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(12, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(131, 32);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Error Log";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(133, 145);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(109, 22);
            this.dtpFrom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show Errors From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(397, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(512, 145);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(248, 145);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvError);
            this.Name = "frmError";
            this.Text = "frmError";
            this.Load += new System.EventHandler(this.frmError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeStoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvError;
        private BikeStoreDataSet bikeStoreDataSet;
        private System.Windows.Forms.BindingSource errorLogBindingSource;
        private BikeStoreDataSetTableAdapters.ErrorLogTableAdapter errorLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorLogIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorSeverityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorProcedureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorMessageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}