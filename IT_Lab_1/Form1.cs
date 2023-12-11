using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Lab_1
{
    public partial class MainMenuForm : Form
    {
        dbManager dbm = new dbManager();
        string cellOldValue = "";
        string cellNewValue = "";
        public MainMenuForm()
        {
            InitializeComponent();
            cbTypes.SelectedIndex = 0;
            tbTypeInterval.Enabled = false;
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            if (dbm.CreateDB(tbCreateDBName.Text))
            {
                tabControl.TabPages.Clear();
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
                Text = "Database " + "\"" + dbm.GetDBName() + "\"";
                tbCreateDBName.Text = "";
            }
        }

        private void butAddTable_Click(object sender, EventArgs e)
        {
            if (dbm.AddTable(tbAddTableName.Text))
            {
                tabControl.TabPages.Add(tbAddTableName.Text);
                cbJoinTables1Table.Items.Add(tbAddTableName.Text);
                cbJoinTables2Table.Items.Add(tbAddTableName.Text);
                tbAddTableName.Text = "";
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = tabControl.SelectedIndex;
            if (ind != -1) VisualTable(dbm.GetTable(ind));
        }

        void VisualTable(Table t)
        {
            try
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                foreach (Column c in t.tColumnsList)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = c.cName;
                    column.HeaderText = c.cName + " (" + c.typeName + ")";
                    dataGridView.Columns.Add(column);
                }

                foreach (Row r in t.tRowsList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    foreach (string s in r.rValuesList)
                    {
                        DataGridViewCell cell = new DataGridViewTextBoxCell();
                        cell.Value = s;
                        row.Cells.Add(cell);
                    }
                    try
                    {
                        dataGridView.Rows.Add(row);
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void butAddColumn_Click(object sender, EventArgs e)
        {
            if (dbm.AddColumn(tabControl.SelectedIndex, tbAddColumnName.Text, cbTypes.Text, tbTypeInterval.Text))
            {
                int ind = tabControl.SelectedIndex;
                if (ind != -1) VisualTable(dbm.GetTable(ind));
                tbAddColumnName.Text = "";
                tbTypeInterval.Text = "Interval";
            }
        }

        private void butAddRow_Click(object sender, EventArgs e)
        {
            if (dbm.AddRow(tabControl.SelectedIndex))
            {
                int ind = tabControl.SelectedIndex;
                if (ind != -1) VisualTable(dbm.GetTable(ind));
            }
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellOldValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cellNewValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (!dbm.ChangeValue(cellNewValue, tabControl.SelectedIndex, e.ColumnIndex, e.RowIndex))
            {
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellOldValue;
            }

            int ind = tabControl.SelectedIndex;
            if (ind != -1) VisualTable(dbm.GetTable(ind));
        }

        private void butDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            try
            {
                dbm.DeleteRow(tabControl.SelectedIndex, dataGridView.CurrentCell.RowIndex);
            }
            catch { }

            int ind = tabControl.SelectedIndex;
            if (ind != -1) VisualTable(dbm.GetTable(ind));
        }

        private void butDeleteColumn_Click(object sender, EventArgs e)
        {
            if (dataGridView.Columns.Count == 0) return;
            try
            {
                dbm.DeleteColumn(tabControl.SelectedIndex, dataGridView.CurrentCell.ColumnIndex);
            }
            catch { }

            int ind = tabControl.SelectedIndex;
            if (ind != -1) VisualTable(dbm.GetTable(ind));
        }

        private void butDeleteTable_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount == 0) return;
            string tname = tabControl.SelectedTab.Text;
            try
            {
                dbm.DeleteTable(tabControl.SelectedIndex);
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
            }
            catch { }
            cbJoinTables1Table.Items.Remove(tname);
            cbJoinTables2Table.Items.Remove(tname);
            if (tabControl.TabCount == 0) return;

            int ind = tabControl.SelectedIndex;
            if (ind != -1) VisualTable(dbm.GetTable(ind));
        }

        private void butSaveDB_Click(object sender, EventArgs e)
        {
            Stream myStream;

            sfdSaveDB.Filter = "tdb files (*.tdb)|*.tdb";
            sfdSaveDB.FilterIndex = 1;
            sfdSaveDB.RestoreDirectory = true;

            if (sfdSaveDB.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = sfdSaveDB.OpenFile()) != null)
                {
                    myStream.Close();
                    dbm.SaveDB(sfdSaveDB.FileName);
                }
            }
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            ofdOpenDB.Filter = "tdb files (*.tdb)|*.tdb";
            ofdOpenDB.FilterIndex = 1;
            ofdOpenDB.RestoreDirectory = true;

            if (ofdOpenDB.ShowDialog() == DialogResult.OK)
            {
                dbm.OpenDB(ofdOpenDB.FileName);

                tabControl.TabPages.Clear();
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
                Text = "Database " + "\"" + dbm.GetDBName() + "\"";

                List<string> buf = dbm.GetTableNameList();
                foreach (string s in buf)
                    tabControl.TabPages.Add(s);

                int ind = tabControl.SelectedIndex;
                if (ind != -1) VisualTable(dbm.GetTable(ind));
            }

            cbJoinTables1Table.Items.Clear();
            cbJoinTables2Table.Items.Clear();
            cbJoinTables1Table.Text = "";
            cbJoinTables2Table.Text = "";
            foreach (string tname in dbm.GetTableNameList())
            {
                cbJoinTables1Table.Items.Add(tname);
                cbJoinTables2Table.Items.Add(tname);
            }
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypes.Text == "CharInvl" || cbTypes.Text == "String(CharInvl)")
                tbTypeInterval.Enabled = true;
            else
                tbTypeInterval.Enabled = false;
        }

        private void butJoinTables_Click(object sender, EventArgs e)
        {
            string t1name = cbJoinTables1Table.Text, t2name = cbJoinTables2Table.Text;
            if (dbm.JoinTables(t1name, t2name))
            {
                tabControl.TabPages.Add(t1name + "_" + t2name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
