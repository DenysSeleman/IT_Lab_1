namespace IT_Lab_1
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.butOpen = new System.Windows.Forms.Button();
            this.butSaveDB = new System.Windows.Forms.Button();
            this.butCreate = new System.Windows.Forms.Button();
            this.tbCreateDBName = new System.Windows.Forms.TextBox();
            this.butAddTable = new System.Windows.Forms.Button();
            this.tbAddTableName = new System.Windows.Forms.TextBox();
            this.butDeleteTable = new System.Windows.Forms.Button();
            this.butAddColumn = new System.Windows.Forms.Button();
            this.tbAddColumnName = new System.Windows.Forms.TextBox();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.tbTypeInterval = new System.Windows.Forms.TextBox();
            this.butDeleteColumn = new System.Windows.Forms.Button();
            this.butAddRow = new System.Windows.Forms.Button();
            this.butDeleteRow = new System.Windows.Forms.Button();
            this.butJoinTables = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.sfdSaveDB = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenDB = new System.Windows.Forms.OpenFileDialog();
            this.cbJoinTables1Table = new System.Windows.Forms.ComboBox();
            this.cbJoinTables2Table = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 159);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 346);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(12, 12);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(75, 23);
            this.butOpen.TabIndex = 1;
            this.butOpen.Text = "Open";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // butSaveDB
            // 
            this.butSaveDB.Location = new System.Drawing.Point(93, 12);
            this.butSaveDB.Name = "butSaveDB";
            this.butSaveDB.Size = new System.Drawing.Size(75, 23);
            this.butSaveDB.TabIndex = 2;
            this.butSaveDB.Text = "Save";
            this.butSaveDB.UseVisualStyleBackColor = true;
            this.butSaveDB.Click += new System.EventHandler(this.butSaveDB_Click);
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(215, 12);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(75, 23);
            this.butCreate.TabIndex = 3;
            this.butCreate.Text = "New DB";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // tbCreateDBName
            // 
            this.tbCreateDBName.Location = new System.Drawing.Point(174, 41);
            this.tbCreateDBName.Name = "tbCreateDBName";
            this.tbCreateDBName.Size = new System.Drawing.Size(154, 20);
            this.tbCreateDBName.TabIndex = 4;
            // 
            // butAddTable
            // 
            this.butAddTable.Location = new System.Drawing.Point(374, 12);
            this.butAddTable.Name = "butAddTable";
            this.butAddTable.Size = new System.Drawing.Size(75, 23);
            this.butAddTable.TabIndex = 5;
            this.butAddTable.Text = "Add Table";
            this.butAddTable.UseVisualStyleBackColor = true;
            this.butAddTable.Click += new System.EventHandler(this.butAddTable_Click);
            // 
            // tbAddTableName
            // 
            this.tbAddTableName.Location = new System.Drawing.Point(334, 41);
            this.tbAddTableName.Name = "tbAddTableName";
            this.tbAddTableName.Size = new System.Drawing.Size(154, 20);
            this.tbAddTableName.TabIndex = 6;
            // 
            // butDeleteTable
            // 
            this.butDeleteTable.Location = new System.Drawing.Point(374, 67);
            this.butDeleteTable.Name = "butDeleteTable";
            this.butDeleteTable.Size = new System.Drawing.Size(76, 23);
            this.butDeleteTable.TabIndex = 7;
            this.butDeleteTable.Text = "Delete Table";
            this.butDeleteTable.UseVisualStyleBackColor = true;
            this.butDeleteTable.Click += new System.EventHandler(this.butDeleteTable_Click);
            // 
            // butAddColumn
            // 
            this.butAddColumn.Location = new System.Drawing.Point(533, 11);
            this.butAddColumn.Name = "butAddColumn";
            this.butAddColumn.Size = new System.Drawing.Size(75, 23);
            this.butAddColumn.TabIndex = 8;
            this.butAddColumn.Text = "Add Column";
            this.butAddColumn.UseVisualStyleBackColor = true;
            this.butAddColumn.Click += new System.EventHandler(this.butAddColumn_Click);
            // 
            // tbAddColumnName
            // 
            this.tbAddColumnName.Location = new System.Drawing.Point(494, 41);
            this.tbAddColumnName.Name = "tbAddColumnName";
            this.tbAddColumnName.Size = new System.Drawing.Size(154, 20);
            this.tbAddColumnName.TabIndex = 9;
            // 
            // cbTypes
            // 
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Items.AddRange(new object[] {
            "Integer",
            "Real",
            "Char",
            "String",
            "CharInvl",
            "String(CharInvl)"});
            this.cbTypes.Location = new System.Drawing.Point(494, 67);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(154, 21);
            this.cbTypes.TabIndex = 10;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.cbTypes_SelectedIndexChanged);
            // 
            // tbTypeInterval
            // 
            this.tbTypeInterval.Location = new System.Drawing.Point(654, 68);
            this.tbTypeInterval.Name = "tbTypeInterval";
            this.tbTypeInterval.Size = new System.Drawing.Size(134, 20);
            this.tbTypeInterval.TabIndex = 11;
            this.tbTypeInterval.Text = "Interval";
            // 
            // butDeleteColumn
            // 
            this.butDeleteColumn.Location = new System.Drawing.Point(525, 94);
            this.butDeleteColumn.Name = "butDeleteColumn";
            this.butDeleteColumn.Size = new System.Drawing.Size(92, 23);
            this.butDeleteColumn.TabIndex = 12;
            this.butDeleteColumn.Text = "Delete Column";
            this.butDeleteColumn.UseVisualStyleBackColor = true;
            this.butDeleteColumn.Click += new System.EventHandler(this.butDeleteColumn_Click);
            // 
            // butAddRow
            // 
            this.butAddRow.Location = new System.Drawing.Point(713, 11);
            this.butAddRow.Name = "butAddRow";
            this.butAddRow.Size = new System.Drawing.Size(75, 23);
            this.butAddRow.TabIndex = 13;
            this.butAddRow.Text = "Add Row";
            this.butAddRow.UseVisualStyleBackColor = true;
            this.butAddRow.Click += new System.EventHandler(this.butAddRow_Click);
            // 
            // butDeleteRow
            // 
            this.butDeleteRow.Location = new System.Drawing.Point(713, 39);
            this.butDeleteRow.Name = "butDeleteRow";
            this.butDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.butDeleteRow.TabIndex = 14;
            this.butDeleteRow.Text = "Delete Row";
            this.butDeleteRow.UseVisualStyleBackColor = true;
            this.butDeleteRow.Click += new System.EventHandler(this.butDeleteRow_Click);
            // 
            // butJoinTables
            // 
            this.butJoinTables.Location = new System.Drawing.Point(12, 88);
            this.butJoinTables.Name = "butJoinTables";
            this.butJoinTables.Size = new System.Drawing.Size(75, 23);
            this.butJoinTables.TabIndex = 15;
            this.butJoinTables.Text = "Join Tables";
            this.butJoinTables.UseVisualStyleBackColor = true;
            this.butJoinTables.Click += new System.EventHandler(this.butJoinTables_Click);
            // 
            // tabControl
            // 
            this.tabControl.ItemSize = new System.Drawing.Size(0, 18);
            this.tabControl.Location = new System.Drawing.Point(12, 132);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 27);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // cbJoinTables1Table
            // 
            this.cbJoinTables1Table.FormattingEnabled = true;
            this.cbJoinTables1Table.Location = new System.Drawing.Point(93, 89);
            this.cbJoinTables1Table.Name = "cbJoinTables1Table";
            this.cbJoinTables1Table.Size = new System.Drawing.Size(121, 21);
            this.cbJoinTables1Table.TabIndex = 16;
            // 
            // cbJoinTables2Table
            // 
            this.cbJoinTables2Table.FormattingEnabled = true;
            this.cbJoinTables2Table.Location = new System.Drawing.Point(220, 89);
            this.cbJoinTables2Table.Name = "cbJoinTables2Table";
            this.cbJoinTables2Table.Size = new System.Drawing.Size(121, 21);
            this.cbJoinTables2Table.TabIndex = 17;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.cbJoinTables2Table);
            this.Controls.Add(this.cbJoinTables1Table);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.butJoinTables);
            this.Controls.Add(this.butDeleteRow);
            this.Controls.Add(this.butAddRow);
            this.Controls.Add(this.butDeleteColumn);
            this.Controls.Add(this.tbTypeInterval);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.tbAddColumnName);
            this.Controls.Add(this.butAddColumn);
            this.Controls.Add(this.butDeleteTable);
            this.Controls.Add(this.tbAddTableName);
            this.Controls.Add(this.butAddTable);
            this.Controls.Add(this.tbCreateDBName);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.butSaveDB);
            this.Controls.Add(this.butOpen);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Button butSaveDB;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.TextBox tbCreateDBName;
        private System.Windows.Forms.Button butAddTable;
        private System.Windows.Forms.TextBox tbAddTableName;
        private System.Windows.Forms.Button butDeleteTable;
        private System.Windows.Forms.Button butAddColumn;
        private System.Windows.Forms.TextBox tbAddColumnName;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.TextBox tbTypeInterval;
        private System.Windows.Forms.Button butDeleteColumn;
        private System.Windows.Forms.Button butAddRow;
        private System.Windows.Forms.Button butDeleteRow;
        private System.Windows.Forms.Button butJoinTables;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.SaveFileDialog sfdSaveDB;
        private System.Windows.Forms.OpenFileDialog ofdOpenDB;
        private System.Windows.Forms.ComboBox cbJoinTables1Table;
        private System.Windows.Forms.ComboBox cbJoinTables2Table;
    }
}

