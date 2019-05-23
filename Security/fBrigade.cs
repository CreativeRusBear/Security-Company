using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Security
{
    public partial class fBrigade : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataSet ds;
        DataTable dtForServices;
        SqlDataAdapter adapter;
        BindingSource bs, bsForServices;
        bool forBtn;

        public fBrigade()
        {
            InitializeComponent();
            pMenuTop.BackColor = Color.FromArgb(172, 204, 196);
            pMenuTop.ForeColor = Color.FromArgb(255, 255, 255);
            pMenuBottom.BackColor = Color.FromArgb(172, 204, 196);
            pMenuBottom.ForeColor = Color.FromArgb(255, 255, 255);
            this.BackColor = Color.FromArgb(245, 245, 245);
            LoadDataFromTable();
        }

        void LoadDataFromTable()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter("select tBrigade.ID_Brigade, tBrigade.ID_Service,  tBrigade.crash, tBrigade.cause, tBrigade.callDate, tService.title " +
                     "FROM tBrigade INNER JOIN tService ON tBrigade.ID_Service = tService.ID_Service", connection);
                ds = new DataSet();
                adapter.Fill(ds);
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                tbCrashes.DataBindings.Clear();
                tbCrashes.DataBindings.Add(new Binding("Text", bs, "crash"));
                tbCause.DataBindings.Clear();
                tbCause.DataBindings.Add(new Binding("Text", bs, "cause"));
                dtpCall.DataBindings.Clear();
                dtpCall.DataBindings.Add(new Binding("Text", bs, "callDate"));
                dgvBrigade.DataSource = bs;
                dgvBrigade.Columns[0].Visible = false;
                dgvBrigade.Columns[1].Visible = false;
                dgvBrigade.Columns[2].HeaderText = "Проишествия";
                dgvBrigade.Columns[3].HeaderText = "Причина вызвова";
                dgvBrigade.Columns[4].Visible = false;
                dgvBrigade.Columns[5].HeaderText = "Услуга";
                dgvBrigade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBrigade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvBrigade.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                loadDataFromServices();
                checkForAvailability();
            }
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            if ((bs.Count > 0) && (dgvBrigade.SelectedRows.Count > 0))
            {
                int ID_SS = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Brigade"]);
                workWithWorkers www = new workWithWorkers(ID_SS);
                www.ShowDialog();

                LoadDataFromTable();
                bs.Position = bs.Find("ID_Brigade", ID_SS);
            }
        }

        void loadDataFromServices()
        {
            adapter = new SqlDataAdapter("SELECT * from tService Order by title", connection);
            dtForServices = new DataTable();
            adapter.Fill(dtForServices);
            bsForServices = new BindingSource();
            bsForServices.DataSource = dtForServices;
            cbService.DataSource = bsForServices;
            cbService.ValueMember = "ID_Service";
            cbService.DisplayMember = "title";
            if (bs.Count > 0) cbService.SelectedValue = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Service"]);
        }

        private void ClearText()
        {
            tbCrashes.Text = "";
            tbCause.Text = "";
            dtpCall.Text = "";
            cbService.SelectedIndex = 0;
        }

        //метод проверки наличия записей
        void checkForAvailability()
        {
            if (bs.Count == 0) chooseDisplay(false);
            else chooseDisplay(true);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            forBtn = true;
            saveBtn.Enabled = false;
            chooseDisplay(true);
            workersBtn.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (forBtn)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand MaxID = new SqlCommand("Select Max(ID_Brigade) from tBrigade", connection);
                    int max = int.Parse(dgvBrigade.RowCount.ToString());
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tBrigade]" +
                        " VALUES(@Service, @crash, @cause, @callDate)", connection);
                    commandInsert.Parameters.AddWithValue("@Service", cbService.SelectedValue);
                    commandInsert.Parameters.AddWithValue("@crash", tbCrashes.Text);
                    commandInsert.Parameters.AddWithValue("@cause", tbCause.Text);
                    commandInsert.Parameters.AddWithValue("@callDate", dtpCall.Text);
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
                int ID_SS = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Brigade"]);
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand commandUpdate = new SqlCommand("UPDATE tBrigade SET " +
                        "ID_Service=@Service, crash=@crash, cause=@cause, callDate=@callDate WHERE ID_Brigade=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@Service", cbService.SelectedValue);
                    commandUpdate.Parameters.AddWithValue("@crash", tbCrashes.Text);
                    commandUpdate.Parameters.AddWithValue("@cause", tbCause.Text);
                    commandUpdate.Parameters.AddWithValue("@callDate", dtpCall.Text);
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

        private void delBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            if (forBtn) forBtn = false;
            else if (bs.Count > 0)
            {
                int rowPosition = bs.Position;
                int delId = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Brigade"]);
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
                        ClearText();
                        LoadDataFromTable();
                        return;
                    }
                    if (result == DialogResult.OK)
                    {
                        connection.Open();
                        SqlCommand Delete = new SqlCommand("Delete From tBrigade where ID_Brigade = @ID", connection);
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
                    else
                        MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            ClearText();
            LoadDataFromTable();
        }

        //метод отображения элементов
        void chooseDisplay(bool val)
        {
            tbCrashes.Enabled = val;
            tbCause.Enabled = val;
            dtpCall.Enabled = val;
            cbService.Enabled = val;
            workersBtn.Enabled = val;
        }

        private void tbCrashes_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }

        private void dgvBrigade_SelectionChanged(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                loadDataFromServices();
            }
            saveBtn.Enabled = false;

        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Name = "Список бригад";
            workSheet.Cells[1, 1] = "Проишествия";
            workSheet.Cells[1, 2] = "Причина вызова";
            workSheet.Cells[1, 3] = "Услуга";
            workSheet.Cells[1, 4] = "Дата вызова";
            Excel.Range title = workSheet.Range["A1:D1"];
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
            for (int i = 0; i < dgvBrigade.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dgvBrigade.RowCount; j++)
                {
                    if (i > 0)
                    {
                        workSheet.Cells[j + 2, i] = dgvBrigade.Rows[j].Cells[i + 1].Value.ToString();
                        workSheet.Cells[j + 2, i].Font.Name = "Tahoma";
                        workSheet.Cells[j + 2, i].Font.Size = "14";
                        workSheet.Cells[j + 2, i].EntireColumn.AutoFit();
                        workSheet.Cells[j + 2, i].EntireRow.AutoFit();
                        workSheet.Cells[j + 2, i].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        workSheet.Cells[j + 2, i].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    }
                    else
                    {
                        break;
                    }
                }

            }
            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = string.Format("cause LIKE '{0}%' OR crash LIKE '{0}%' OR title LIKE '{0}%'", tbSearch.Text);
        }

        private void fBrigade_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
        }

        void EnabledBtn()
        {
            if (tbCause.Text != "" && cbService.Text!= "") saveBtn.Enabled = true;
            else saveBtn.Enabled = false;
        }
    }
}
