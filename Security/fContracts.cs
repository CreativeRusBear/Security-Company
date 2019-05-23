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
    public partial class fContracts : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataSet ds;
        DataTable dtForClients;
        SqlDataAdapter adapter;
        BindingSource bs, bsForClients;
        bool forBtn;
        public fContracts()
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
                //adapter = new SqlDataAdapter("Select * From tContract Order By sFIO", connection);
                adapter = new SqlDataAdapter("select tContract.ID_Contract, tContract.ID_Client,  tContract.number, tContract.conclusion, tContract.termination, tContract.sAddress, " +
                       "tContract.priceMonth, tContract.pricePeriod,tClients.sFIO, tService.title  FROM tContract INNER JOIN tClients ON " +
               "tContract.ID_Client = tClients.ID_Client inner join tService ON " +
               "tClients.ID_Service = tService.ID_Service", connection);
                ds = new DataSet();
                adapter.Fill(ds);
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                tbMonth.DataBindings.Clear();
                tbMonth.DataBindings.Add(new Binding("Text", bs, "priceMonth"));
                tbPeriod.DataBindings.Clear();
                tbPeriod.DataBindings.Add(new Binding("Text", bs, "pricePeriod"));
                tbNum.DataBindings.Clear();
                tbNum.DataBindings.Add(new Binding("Text", bs, "number"));
                dtpDateStart.DataBindings.Clear();
                dtpDateStart.DataBindings.Add(new Binding("Text", bs, "conclusion"));
                dtpDateEnd.DataBindings.Clear();
                dtpDateEnd.DataBindings.Add(new Binding("Text", bs, "termination"));
                tbAddress.DataBindings.Clear();
                tbAddress.DataBindings.Add(new Binding("Text", bs, "sAddress"));
                dgvContracts.DataSource = bs;
                dgvContracts.Columns[0].Visible = false;
                dgvContracts.Columns[1].Visible = false;
                dgvContracts.Columns[2].HeaderText = "Номер договора";
                dgvContracts.Columns[3].Visible = false;
                dgvContracts.Columns[4].Visible = false;
                dgvContracts.Columns[5].Visible = false;
                dgvContracts.Columns[6].Visible = false;
                dgvContracts.Columns[7].Visible = false;
                dgvContracts.Columns[8].HeaderText = "Клиент";
                dgvContracts.Columns[9].HeaderText = "Услуга";
                dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvContracts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvContracts.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                loadDataFromClients();
                checkForAvailability();
            }
        }

        void loadDataFromClients()
        {
            adapter = new SqlDataAdapter("SELECT * from tClients inner join tService on tClients.ID_Service=tService.ID_Service  Order by sFIO ", connection);
            dtForClients = new DataTable();
            adapter.Fill(dtForClients);
            bsForClients = new BindingSource();
            bsForClients.DataSource = dtForClients;
            cbClients.DataSource = bsForClients;
            cbClients.ValueMember = "ID_Client";
            cbClients.DisplayMember = "sFIO";
            tbService.DataBindings.Clear();
            tbService.DataBindings.Add(new Binding("Text", bsForClients, "title"));
            if (bs.Count > 0) cbClients.SelectedValue = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Client"]);
        }



        //очистка необходимых полей и ячеек
        private void ClearText()
        {
            tbMonth.Text = "";
            tbNum.Text = "";
            tbAddress.Text = "";
            tbPeriod.Text = "";
            dtpDateStart.Text = DateTime.Now.ToString();
            dtpDateEnd.Text = DateTime.Now.ToString();
            cbClients.SelectedIndex = 0;
        }
        
        //метод проверки наличия записей
        void checkForAvailability()
        {
            if (bs.Count == 0) chooseDisplay(false);
            else chooseDisplay(true);
        }

        //метод отображения элементов
        void chooseDisplay(bool val)
        {
            tbMonth.Enabled = val;
            tbAddress.Enabled = val;
            tbNum.Enabled = val;
            tbPeriod.Enabled = val;
            dtpDateStart.Enabled = val;
            dtpDateEnd.Enabled = val;
            cbClients.Enabled = val;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            forBtn = true;
            saveBtn.Enabled = false;
            chooseDisplay(true);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            if (forBtn) forBtn = false;
            else if (bs.Count > 0)
            {
                int rowPosition = bs.Position;
                int delId = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Contract"]);
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
                        SqlCommand Delete = new SqlCommand("Delete From tContract where ID_Contract = @ID", connection);
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
                   /* else if ((uint)ex.ErrorCode == 0x80131904)
                        MessageBox.Show(
                        "Клиент добавлен в одну из существующих записей",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);*/
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (forBtn)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand MaxID = new SqlCommand("Select Max(ID_Contract) from tContract", connection);
                    int max = int.Parse(dgvContracts.RowCount.ToString());
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tContract]" +
                        " VALUES(@Client, @num, @start, @end, @address, @month, @period)", connection);
                    commandInsert.Parameters.AddWithValue("@Client", cbClients.SelectedValue);
                    commandInsert.Parameters.AddWithValue("@num", tbNum.Text);
                    commandInsert.Parameters.AddWithValue("@start", dtpDateStart.Text);
                    commandInsert.Parameters.AddWithValue("@end", dtpDateEnd.Text);
                    commandInsert.Parameters.AddWithValue("@address", tbAddress.Text);
                    commandInsert.Parameters.AddWithValue("@month", tbMonth.Text);
                    commandInsert.Parameters.AddWithValue("@period", tbPeriod.Text);
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
                int ID_SS = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Contract"]);
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand commandUpdate = new SqlCommand("UPDATE tContract SET " +
                        "ID_Client=@Client, number=@num, conclusion=@start, termination=@end, sAddress=@address, priceMonth=@month," +
                        " pricePeriod=@period WHERE ID_Contract=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@Client", cbClients.SelectedValue);
                    commandUpdate.Parameters.AddWithValue("@num", tbNum.Text);
                    commandUpdate.Parameters.AddWithValue("@start", dtpDateStart.Text);
                    commandUpdate.Parameters.AddWithValue("@end", dtpDateEnd.Text);
                    commandUpdate.Parameters.AddWithValue("@address", tbAddress.Text);
                    commandUpdate.Parameters.AddWithValue("@month", tbMonth.Text);
                    commandUpdate.Parameters.AddWithValue("@period", tbPeriod.Text);
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

        private void tbNum_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }

        private void tbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < '0' || word > '9') && word != '\b')
            {
                e.Handled = true;
            }
            EnabledBtn();
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'А' || word > 'Я') && (word < '0' || word > '9') && (word < 'A' || word > 'Z') && word != '\b' && word != ' ' && word != '.' && (word < 'a' || word > 'z') && (word < 'а' || word > 'я'))
            {
                e.Handled = true;
            }
            EnabledBtn();
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Name = "Список договоров";
            workSheet.Cells[1, 1] = "Номер договора";
            workSheet.Cells[1, 2] = "Дата заключения";
            workSheet.Cells[1, 3] = "Дата рассторжения";
            workSheet.Cells[1, 4] = "Адрес обслуживания";
            workSheet.Cells[1, 5] = "Цена в месяц";
            workSheet.Cells[1, 6] = "Стоимость за весь период";
            workSheet.Cells[1, 7] = "Клиент";
            workSheet.Cells[1, 8] = "Услуга";
            Excel.Range title = workSheet.Range["A1:H1"];
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
            for (int i = 0; i < dgvContracts.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dgvContracts.RowCount; j++)
                {
                    if (i > 0)
                    {
                        workSheet.Cells[j + 2, i] = dgvContracts.Rows[j].Cells[i + 1].Value.ToString();
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
            bs.Filter = string.Format("sFIO LIKE '{0}%' OR title LIKE '{0}%'", tbSearch.Text);
        }

        private void dgvContracts_SelectionChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
        }

        void EnabledBtn()
        {
            if (tbMonth.Text.Length>=5 &&  tbPeriod.Text.Length >=5 && tbNum.Text!="" && cbClients.Text!="") saveBtn.Enabled = true;
            else saveBtn.Enabled = false;
        }
    }
}
