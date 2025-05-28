using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CariHesapTakip.Helpers
{
    /// <summary>
    /// SHA-256 ile özet (hash) oluşturmaya yarayan yardımcı sınıf.
    /// </summary>
    public static class HashHelper
    {
        public static string ComputeSha256Hash(string raw)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(raw));
                var sb = new StringBuilder();
                foreach (var b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }

    /// <summary>
    /// DataGridView’den Excel ve PDF dosyası üretmek için yardımcı sınıf.
    /// </summary>
    public static class ExportHelper
    {
        /// <summary>
        /// DataGridView’i bir DataTable’a dönüştürür.
        /// Sadece Visible = true sütunları alır.
        /// </summary>
        public static DataTable ToDataTable(this DataGridView dgv)
        {
            var dt = new DataTable();

            // Sütunları ekle
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                    dt.Columns.Add(col.HeaderText, col.ValueType ?? typeof(string));
            }

            // Satır verilerini aktar
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    var dr = dt.NewRow();
                    int i = 0;
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        if (col.Visible)
                            dr[i++] = row.Cells[col.Name].Value ?? "";
                    }
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

        /// <summary>
        /// DataGridView içeriğini .xlsx formatında Excel dosyasına kaydeder.
        /// </summary>
        public static void ExportToExcel(DataGridView dgv)
        {
            var dt = dgv.ToDataTable();

            using (var sfd = new SaveFileDialog { Filter = "Excel Dosyası|*.xlsx" })
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using (var wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Sayfa1");
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show(
                    "Excel dosyası başarıyla oluşturuldu:\n" + sfd.FileName,
                    "Tamam",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// DataGridView içeriğini PDF dosyasına kaydeder.
        /// </summary>
        public static void ExportToPdf(DataGridView dgv)
        {
            var dt = dgv.ToDataTable();

            using (var sfd = new SaveFileDialog { Filter = "PDF Dosyası|*.pdf" })
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using (var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    var doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                    var writer = PdfWriter.GetInstance(doc, fs);

                    try
                    {
                        doc.Open();

                        // Başlık ekle
                        var headerFont = FontFactory.GetFont("Arial", 14, Font.BOLD);
                        doc.Add(new Paragraph("Rapor", headerFont)
                        {
                            Alignment = Element.ALIGN_CENTER
                        });
                        doc.Add(new Paragraph(" "));

                        // Tablo oluştur
                        var table = new PdfPTable(dt.Columns.Count)
                        {
                            WidthPercentage = 100
                        };

                        // Sütun başlıkları
                        var colFont = FontFactory.GetFont("Arial", 10, Font.BOLD);
                        foreach (DataColumn col in dt.Columns)
                        {
                            table.AddCell(new PdfPCell(new Phrase(col.ColumnName, colFont)));
                        }

                        // Veri satırları
                        var cellFont = FontFactory.GetFont("Arial", 9, Font.NORMAL);
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (var cell in row.ItemArray)
                            {
                                table.AddCell(new PdfPCell(new Phrase(cell.ToString(), cellFont)));
                            }
                        }

                        doc.Add(table);
                    }
                    finally
                    {
                        // Belgeyi kesinlikle kapat
                        if (doc.IsOpen())
                            doc.Close();
                        // FileStream using bloğu kapanınca otomatik flush ve dispose olur
                    }
                }

                MessageBox.Show(
                    "PDF dosyası başarıyla oluşturuldu:\n" + sfd.FileName,
                    "Tamam",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
