using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLL
{
    public class ExportToExcel
    {
        public static void ExcelExport(DataGridView dgvEmployeeList, string v)
        {
            string dirProExcel = ConfigurationSettings.AppSettings["ProExcel"];

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = new Microsoft.Office.Interop.Excel.Workbook();
            Microsoft.Office.Interop.Excel._Worksheet worksheet = new Microsoft.Office.Interop.Excel.Worksheet();

            app.Visible = true;
            //  worksheet = workbook.Sheets[0];
            //  worksheet = workbook.ActiveSheet;

            var workbook = app.Workbooks.Add();
            worksheet = workbook.ActiveSheet;

            for (int i = 1; i < dgvEmployeeList.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvEmployeeList.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvEmployeeList.Rows.Count; i++)
            {
                for (int j = 0; j < dgvEmployeeList.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvEmployeeList.Rows[i].Cells[j].Value.ToString();
                }
            }

            string filename = DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss_") + v + ".xlsx";
            workbook.SaveAs(dirProExcel + filename); ;
            workbook.Close();
            app.Quit();
        }
    }
}
