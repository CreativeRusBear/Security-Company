using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Security
{
    public partial class fService : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bs;
        bool forBtn;

        void LoadDataFromTable()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter("Select * From tService Order By title", connection);
                ds = new DataSet();
                adapter.Fill(ds);
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                tbTitle.DataBindings.Clear();
                tbTitle.DataBindings.Add(new Binding("Text", bs, "title"));
                dgvService.DataSource = bs;
                dgvService.Columns[0].Visible = false;
                dgvService.Columns[1].HeaderText = "Услуга";
                dgvService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvService.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvService.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

                checkHasNotes();
            }
        }

        //метод проверки наличия записей
        void checkHasNotes()
        {
            if (bs.Count == 0) tbTitle.Enabled=false;
            else tbTitle.Enabled=true;
        }

        //метод, использующиеся для показа/скрытия кнопки сохранить
        void EnabledBtn()
        {
            if (tbTitle.Text.Length != 0 && tbTitle.Text.Trim() !="") saveBtn.Enabled = true;
            else saveBtn.Enabled = false;
        }

        public fService()
        {
            InitializeComponent();
            pMenuBottom.BackColor = Color.FromArgb(172, 204, 196);
            pMenuBottom.ForeColor = Color.FromArgb(255, 255, 255);
            this.BackColor = Color.FromArgb(245, 245, 245);
            LoadDataFromTable();
            forBtn = false;
        }

        //Вывод в Excel
        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Name = "Список предоставляемых услуг";
            workSheet.Cells[1, 1] = "Услуга";
            Excel.Range title = workSheet.Range["A1"];
            title.Cells.Font.Name = "Tahoma";
            title.Font.Size = "16";
            title.Cells.Font.Color = ColorTranslator.ToOle(Color.Green);
            title.Interior.Color = ColorTranslator.ToOle(Color.FromArgb(0xFF, 0xFF, 0xCC));
            title.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            title.EntireColumn.AutoFit();
            title.EntireRow.AutoFit();
            title.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            for (int i = 0; i < dgvService.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dgvService.RowCount; j++)
                {

                        workSheet.Cells[j + 2, i + 1] = dgvService.Rows[j].Cells[i + 1].Value.ToString();
                        workSheet.Cells[j + 2, i + 1].Font.Name = "Tahoma";
                        workSheet.Cells[j + 2, i + 1].Font.Size = "14";
                        workSheet.Cells[j + 2, i + 1].EntireColumn.AutoFit();
                        workSheet.Cells[j + 2, i + 1].EntireRow.AutoFit();
                        workSheet.Cells[j + 2, i + 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        workSheet.Cells[j + 2, i + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    
                }

            }
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            if (forBtn)
            {
                //отмена
                forBtn = false;
            }
            else if (bs.Count > 0)
            {
                //удаление
                int rowPosition = bs.Position;
                int delId = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Service"]);
                try
                {
                    DialogResult result = MessageBox.Show(
                   "Нажмите \"Ок\", чтобы удалить запись. \"Отмена\" - для того, чтобы отменить внесенные изменения",
                   "Удаление",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.Cancel)
                    {
                        tbTitle.Text = "";
                        LoadDataFromTable();
                        return;
                    }
                    if (result == DialogResult.OK)
                    {
                        connection.Open();
                        SqlCommand Delete = new SqlCommand("Delete From dbo.tService where ID_Service = @ID", connection);
                        Delete.Parameters.AddWithValue("@ID", delId);
                        Delete.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    if ((uint)ex.ErrorCode == 0x80004005)
                        MessageBox.Show(
                        "В таблицах есть связанные записи",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    else if ((uint)ex.ErrorCode == 0x80131904)
                        MessageBox.Show(
                        "Услга добавлена в одну из существующих записей",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    else
                        MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            tbTitle.Text = "";
            LoadDataFromTable();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "";
            forBtn = true;
            saveBtn.Enabled = false;
            tbTitle.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (forBtn)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand MaxID = new SqlCommand("Select Max(ID_Service) from tService", connection);
                    int max = int.Parse(dgvService.RowCount.ToString());
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tService] VALUES(@Title)", connection);
                    commandInsert.Parameters.AddWithValue("@Title", tbTitle.Text);
                    commandInsert.ExecuteNonQuery();
                    MessageBox.Show("Запись добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    forBtn = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                    LoadDataFromTable();
                }

            }
            else if (bs.Count > 0)
            {
                int i = bs.Position;
                int ID_SS = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Service"]);
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand commandUpdate = new SqlCommand("UPDATE tService SET Title=@Title WHERE ID_Service=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@Title", tbTitle.Text);
                    commandUpdate.Parameters.AddWithValue("@IDSS", ID_SS);
                    commandUpdate.ExecuteNonQuery();
                    MessageBox.Show("Запись обновлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                    LoadDataFromTable();
                    bs.Position = i;
                }

            }
            saveBtn.Enabled = false;
        }

        private void fService_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }

        private void dgvService_SelectionChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
        }
    }
}
