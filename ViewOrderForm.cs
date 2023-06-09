﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Project
{
    public partial class ViewOrderForm : Form
    {
        readonly String dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        DataTable tb;

        public ViewOrderForm()
        {
            InitializeComponent();
        }

        private void ViewOrderForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbConn);
            conn.Open();
            showGRD();
        }

        public void showGRD()
        {
            string sql = "select O.OrderID as 'Order ID', O.OrderDate as 'Order date', A.AgentName as 'Agent name'" + 
                " from _Order O, Agent A" +
                " where O.AgentID = A.AgenID";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            orderGrd.DataSource = tb;
        }

        private void orderGrd_Click(object sender, EventArgs e)
        {
            orderIdTxt.Text = orderGrd.CurrentRow.Cells[0].Value.ToString();
        }

        private void printPreviewBtn_Click(object sender, EventArgs e)
        {
            if (orderIdTxt.Text.Equals("") || orderIdTxt == null)
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "select * from OrderDetail where OrderID = '" + orderIdTxt.Text + "'";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);

            if (tb.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(tb.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataColumn column in tb.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                                pdfTable.AddCell(cell);
                            }

                            for (int i = 0; i < tb.Rows.Count; ++i)
                            {
                                for (int j = 0; j < tb.Columns.Count; ++j)
                                {
                                    if (j != 3)
                                    {
                                        pdfTable.AddCell(tb.Rows[i][j].ToString());
                                    }
                                    else
                                    {
                                        string date = tb.Rows[i][j].ToString();
                                        pdfTable.AddCell(date.Split(' ')[0]);
                                    }

                                }
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }

        }
    }
}
