using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMDSystem.DAL
{
    public class ExportExcel
    {
        public void Export(string fileName, DataGridView dgv)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;

            IWorkbook workbook = new HSSFWorkbook();
            MemoryStream ms = new MemoryStream();

            ICellStyle cellStyle = workbook.CreateCellStyle();
            cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.THIN;
            cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.THIN;
            cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.THIN;
            cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.THIN;
            cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER;
            cellStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont font = workbook.CreateFont();
            font.FontHeightInPoints = 10;
            font.FontName = "微软雅黑";
            cellStyle.SetFont(font);


            NPOI.SS.UserModel.ISheet sheet = workbook.CreateSheet("员工信息表");
            sheet.SetColumnWidth(0, 50 * 256);
            sheet.SetColumnWidth(3, 25 * 256);

            int rowCount = dgv.Rows.Count;
            int colCount = dgv.Columns.Count;

            IRow row = sheet.CreateRow(0);
            ICell coloun0 = row.CreateCell(0);
            ICell coloun1 = row.CreateCell(1);
            ICell coloun2 = row.CreateCell(2);
            ICell coloun3 = row.CreateCell(3);
            ICell coloun4 = row.CreateCell(4);
            ICell coloun5 = row.CreateCell(5);
            coloun0.SetCellValue("编号");
            coloun0.CellStyle = cellStyle;
            coloun1.SetCellValue("工号");
            coloun1.CellStyle = cellStyle;
            coloun2.SetCellValue("姓名");
            coloun2.CellStyle = cellStyle;
            coloun3.SetCellValue("入职时间");
            coloun3.CellStyle = cellStyle;
            coloun4.SetCellValue("民族");
            coloun4.CellStyle = cellStyle;
            coloun5.SetCellValue("籍贯");
            coloun5.CellStyle = cellStyle;



            for (int i = 0; i < rowCount; i++)
            {
                NPOI.SS.UserModel.IRow dataRow = sheet.CreateRow((sheet.LastRowNum + 1));
                for (int j = 0; j < colCount; j++)
                {
                    if (dgv.Columns[j].Visible && dgv.Rows[i].Cells[j].Value != null)
                    {
                        NPOI.SS.UserModel.ICell cell = dataRow.CreateCell(j);
                        cell.SetCellValue(dgv.Rows[i].Cells[j].Value.ToString());
                        cell.CellStyle = cellStyle;
                    }
                }
            }

            workbook.Write(ms);
            FileStream file = new FileStream(saveFileName, FileMode.Create);
            workbook.Write(file);
            file.Close();
            workbook = null;
            ms.Close();
            ms.Dispose();

            MessageBox.Show(fileName + " 保存成功", "提示", MessageBoxButtons.OK);
        }
    }
}
