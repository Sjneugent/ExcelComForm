using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary;
using System.IO;
using ExcelLibrary;

namespace ExcelForm
{
    public partial class Form1 : Form
    {
        
        private ExcelReader xls_reader;
        private WorkSheetReader wks_reader;
        private List<ValueLocation> tst { get; set; }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String file_name;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "XLS Files (*.xls)|*.xls";
            opf.Multiselect = false;
            opf.InitialDirectory = @"C:\";
            opf.CheckFileExists = true;
            
            if(opf.ShowDialog() == DialogResult.OK)
            {
                file_name = opf.FileName;
                
                xls_reader = new ExcelReader(file_name);
                wks_reader = new WorkSheetReader(xls_reader.getWorkSheet());
                
                backgroundWorker2.RunWorkerAsync();
                backgroundWorker1.RunWorkerAsync();
                StatusWorker.RunWorkerAsync();
            }
        }

        private void addColumns(List<String> columns)
        {
            dataGridView1.ColumnCount = tst.Count;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }

        #region BackgroundWorker_1
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            
            List<ValueLocation> vl = wks_reader.mapValues();
            tst = vl;
          
            for (int i = 0; i < vl.Count; i++ )
            {
                String s = wks_reader.getValue(vl[i].row, vl[i].col);
                DummyClass dc = new DummyClass(vl[i], s);
                backgroundWorker1.ReportProgress((i+1)/vl.Count, dc);
            }
               
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGridView1.Rows.Add(1);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DummyClass dc = (DummyClass)e.UserState;
            if (dataGridView1.Rows.Count >= (dc.vl.row))
                dataGridView1.Rows.Add(1);
          
            dataGridView1.Rows[dc.vl.row-1].Cells[dc.vl.col-1].Value = dc.data;
        }
        #endregion
        #region BackgroundWorker_2
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            List<String> col_names = wks_reader.getColumnNames();
            for(int i = 0; i < col_names.Count; i++)
            {
                backgroundWorker2.ReportProgress((i + 1) / col_names.Count, col_names[i]);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            dataGridView1.ColumnCount++;
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Name = (String)e.UserState;
        }
        #endregion 
        private void removeRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null)
            {

            }
            else
            {
                DataGridViewSelectedRowCollection DRC = dataGridView1.SelectedRows;
                foreach (DataGridViewRow dataGridViewRow in DRC)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(dataGridViewRow);

                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.StackTrace);
                    }
                }
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = dataGridView1.SelectedCells;
            foreach(DataGridViewCell cell in selectedCells)
            {
                dataGridView1.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = "";
            }
        }

        private void StatusWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (; ; )
            {
                int n = dataGridView1.Rows.Count;
                StatusWorker.ReportProgress(0, n);
                System.Threading.Thread.Sleep(2000);
            }
        }

        private void StatusWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.UserState + " Rows";
        }

       
    }
}
