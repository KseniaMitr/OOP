using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            no.Visible = false;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsDataGridView (DataGridView dataGried, int k)
        {
            Matrix matr = new Matrix(k, k);
            dataGried.ColumnCount = matr.Cols;
            dataGried.RowCount = matr.Rows;

            dataGried.AutoResizeColumns();
            dataGried.RowHeadersVisible = false;
            dataGried.ColumnHeadersVisible = false;
            dataGried.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGried.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGried.ClearSelection();           
        }       

        private void sizeMatr_Click(object sender, EventArgs e)
        {
            if (razmM.Text == "" || Convert.ToInt32(razmM.Text) <= 0)
            {
                no.Visible = true;
                return;
            }
            no.Visible = false;
            int k = Convert.ToInt32(razmM.Text);
            SettingsDataGridView(matr1,k);
            SettingsDataGridView(matr2,k);
            SettingsDataGridView(matrResult,k);
        }

        private Matrix fillRandomValues(Matrix matr, DataGridView dataGrid)
        {            
            matr = matr.WriteIn(matr);
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {                       
                   dataGrid[i, j].Value = matr[i, j];
                }
            }
            return matr;
        }

        private void fillRandomValues1_Click(object sender, EventArgs e)
        {
            Matrix dat1 = new Matrix(matr1.RowCount, matr1.ColumnCount);           
            fillRandomValues(dat1, matr1);           
        }

        private void fillRandomValues2_Click(object sender, EventArgs e)
        {
            Matrix dat2 = new Matrix(matr2.RowCount, matr2.ColumnCount);            
            fillRandomValues(dat2, matr2);
        }

        private Matrix Transpose(Matrix matr, DataGridView dataGrid)
        {            
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {
                    matr[i, j] = Convert.ToDouble(dataGrid[i, j].Value);                                        
                }
            }

            matr = !matr;

            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {                    
                    dataGrid[i, j].Value = matr[i, j];                    
                }
            }
            return matr;
        }


        private void butTran1_Click(object sender, EventArgs e)
        {
            Matrix dat1 = new Matrix(matr1.RowCount, matr1.ColumnCount);
            Transpose(dat1, matr1);
        }

        private void butTran2_Click(object sender, EventArgs e)
        {
            Matrix dat2 = new Matrix(matr2.RowCount, matr2.ColumnCount);
            Transpose(dat2,matr2);
        }

        private void butTran3_Click(object sender, EventArgs e)
        {
            Matrix dat3 = new Matrix(matrResult.RowCount, matrResult.ColumnCount);
            Transpose(dat3, matrResult);
        }

        private void butSum_Click(object sender, EventArgs e)
        {
            Matrix dat1 = new Matrix(matr1.RowCount, matr1.ColumnCount);
            Matrix dat2 = new Matrix(matr2.RowCount, matr2.ColumnCount);
            Matrix res = null;

            for (int i = 0; i < matr1.RowCount; i++)
            {
                for (int j = 0; j < matr1.ColumnCount; j++)
                {
                    dat1[i, j] = Convert.ToDouble(matr1[i, j].Value);
                    dat2[i, j] = Convert.ToDouble(matr2[i, j].Value);
                }
            }
            res = dat1 + dat2;
            fillAnswer(res);
        }

        private void butUmnog_Click(object sender, EventArgs e)
        {
            Matrix dat1 = new Matrix(matr1.RowCount, matr1.ColumnCount);
            Matrix dat2 = new Matrix(matr2.RowCount, matr2.ColumnCount);
            Matrix res = null;

            for (int i = 0; i < matr1.RowCount; i++)
            {
                for (int j = 0; j < matr1.ColumnCount; j++)
                {
                    dat1[i, j] = Convert.ToDouble(matr1[i, j].Value);
                    dat2[i, j] = Convert.ToDouble(matr2[i, j].Value);
                }
            }
            res = dat1 * dat2;
            fillAnswer(res);
        }       


        private Matrix fillAnswer (Matrix matr)
        {
            for (int i = 0; i < matrResult.RowCount; i++)
            {
                for (int j = 0; j < matrResult.ColumnCount; j++)
                {
                    matrResult[i, j].Value = matr[i, j];
                }
            }
            return matr;
        }

        private void razmM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
          
}
