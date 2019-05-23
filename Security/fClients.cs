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
using Excel = Microsoft.Office.Interop.Excel;

namespace Security
{
    public partial class fClients : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataSet ds;
        DataTable dtForServices;
        SqlDataAdapter adapter;
        BindingSource bs, bsForServices;
        bool forBtn;
        public fClients()
        {
            InitializeComponent();
            pMenuTop.BackColor = Color.FromArgb(172, 204, 196);
            pMenuTop.ForeColor = Color.FromArgb(255, 255, 255);
            pMenuBottom.BackColor=Color.FromArgb(172, 204, 196);
            pMenuBottom.ForeColor = Color.FromArgb(255, 255, 255);
            this.BackColor = Color.FromArgb(245, 245, 245);
            LoadDataFromTable();
        }
        

        void LoadDataFromTable()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter("Select * From tClients Order By sFIO", connection);
                ds = new DataSet();
                adapter.Fill(ds);
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                tbFIO.DataBindings.Clear();
                tbFIO.DataBindings.Add(new Binding("Text", bs, "sFIO"));
                tbSeries.DataBindings.Clear();
                tbSeries.DataBindings.Add(new Binding("Text", bs, "series"));
                tbNum.DataBindings.Clear();
                tbNum.DataBindings.Add(new Binding("Text", bs, "number"));
                User_photo.Image = imageList1.Images[0];
                if (bs.Count > 0) LoadPhoto();
                dtpBithday.DataBindings.Clear();
                dtpBithday.DataBindings.Add(new Binding("Text", bs, "bithday"));
                tbPhone.DataBindings.Clear();
                tbPhone.DataBindings.Add(new Binding("Text", bs, "phone"));
                tbEmail.DataBindings.Clear();
                tbEmail.DataBindings.Add(new Binding("Text", bs, "email"));
                dgvClients.DataSource = bs;
                dgvClients.Columns[0].Visible = false;
                dgvClients.Columns[1].Visible = false;
                dgvClients.Columns[2].HeaderText = "ФИО";
                dgvClients.Columns[3].Visible = false;
                dgvClients.Columns[4].Visible = false;
                dgvClients.Columns[5].HeaderText = "День Рождения";
                dgvClients.Columns[6].HeaderText = "Номер телефона";
                dgvClients.Columns[7].Visible = false;
                dgvClients.Columns[8].Visible = false;
                dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvClients.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                loadDataFromServices();
                checkForAvailability();
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

        void LoadPhoto()
        {
            string fileName = "";
            User_photo.Image = imageList1.Images[0];
            string s = ((DataRowView)this.bs.Current).Row["Photo"].ToString();
            if (s != null)
                if (s != "")
                {
                    User_photo.Load(@"img\clients\" + s);
                    fileName = s;
                    foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                    {
                        fileName = fileName.Replace(c, '_');
                    }
                }
            forPhoto.Text = fileName;
        }

        //очистка необходимых полей и ячеек
        private void ClearText()
        {
            User_photo.Image = imageList1.Images[0];
            forPhoto.Text = "";
            tbFIO.Text = "";
            tbNum.Text = "";
            tbEmail.Text = "";
            tbSeries.Text = "";
            tbPhone.Text = "";
            dtpBithday.Text = DateTime.Now.ToString();
            cbService.SelectedIndex = 0;
        }

        //метод проверки наличия записей
        void checkForAvailability()
        {
            if (bs.Count == 0) chooseDisplay(false);
            else chooseDisplay(true);  
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
                int delId = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Client"]);
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
                        SqlCommand Delete = new SqlCommand("Delete From dbo.tClients where ID_Client = @ID", connection);
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
                        "Клиент добавлен в одну из существующих записей",
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
            ClearText();
            LoadDataFromTable();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            forBtn = true;
            saveBtn.Enabled = false;
            chooseDisplay(true);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (forBtn)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand MaxID = new SqlCommand("Select Max(ID_Client) from tClients", connection);
                    int max = int.Parse(dgvClients.RowCount.ToString());
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tClients]" +
                        " VALUES(@Service, @FIO, @series, @nums, @bithday, @phone, @email, @photo)", connection);
                    commandInsert.Parameters.AddWithValue("@Service", cbService.SelectedValue);
                    commandInsert.Parameters.AddWithValue("@FIO", tbFIO.Text);
                    commandInsert.Parameters.AddWithValue("@series", tbSeries.Text);
                    commandInsert.Parameters.AddWithValue("@nums", tbNum.Text);
                    commandInsert.Parameters.AddWithValue("@bithday", dtpBithday.Text);
                    commandInsert.Parameters.AddWithValue("@phone", tbPhone.Text);
                    commandInsert.Parameters.AddWithValue("@email", tbEmail.Text);
                    if ((User_photo.Image != null) && (!(System.IO.File.Exists(@"img\clients\" + forPhoto.Text))))
                    {
                        if (forPhoto.Text != "")
                            User_photo.Image.Save(@"img\clients\" + forPhoto.Text);
                    }
                    commandInsert.Parameters.AddWithValue("@photo", forPhoto.Text);
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
                int ID_SS = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Client"]);
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand commandUpdate = new SqlCommand("UPDATE tClients SET " +
                        "ID_Service=@Service, sFIO=@FIO, series=@series, number=@number, bithday=@bithday, phone=@phone, email=@email," +
                        " photo=@photo WHERE ID_Client=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@Service", cbService.SelectedValue);
                    commandUpdate.Parameters.AddWithValue("@FIO", tbFIO.Text);
                    commandUpdate.Parameters.AddWithValue("@series", tbSeries.Text);
                    commandUpdate.Parameters.AddWithValue("@number", tbNum.Text);
                    commandUpdate.Parameters.AddWithValue("@bithday", dtpBithday.Text);
                    commandUpdate.Parameters.AddWithValue("@phone", tbPhone.Text);
                    commandUpdate.Parameters.AddWithValue("@email", tbEmail.Text);
                    if ((forPhoto.Text != "") && (!(System.IO.File.Exists(@"img\clients\" + forPhoto.Text)))) User_photo.Image.Save(@"img\clients\" + forPhoto.Text);
                    commandUpdate.Parameters.AddWithValue("@photo", forPhoto.Text);
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


        //метод отображения элементов
        void chooseDisplay(bool val)
        {
            tbFIO.Enabled = val;
            cbService.Enabled = val;
            tbNum.Enabled = val;
            dtpBithday.Enabled = val;
            tbSeries.Enabled = val;
            tbPhone.Enabled = val;
            tbSeries.Enabled = val;
            tbEmail.Enabled = val;
        }

        private void User_photo_DoubleClick(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.InitialDirectory = "c:\\";
            Dialog.Filter = "jpg files (*.jpg)|*.jpg| png files (*.png)|*.png";
            Dialog.FilterIndex = 1;
            Dialog.RestoreDirectory = true;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = Dialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            User_photo.Image = Image.FromFile(Dialog.FileName);
                            forPhoto.Text = Dialog.SafeFileName.ToString();
                            EnabledBtn();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка:" + ex.Message);
                }
            }
        }

        private void tbFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'А' || word > 'Я') && (word < 'A' || word > 'Z') && word != '\b' && word != ' ' && word!='.' && (word < 'a' || word > 'z') && (word < 'а' || word > 'я'))
            {
                e.Handled = true;
            }
            EnabledBtn();
        }

        private void tbFIO_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }

        private void tbSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < '0' || word > '9') && word != '\b')
            {
                e.Handled = true;
            }
            EnabledBtn();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                User_photo.Image = imageList1.Images[0];
                LoadPhoto();
                loadDataFromServices();
            }
            saveBtn.Enabled = false;
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledBtn();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = string.Format("sFIO LIKE '{0}%'", tbSearch.Text);
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet.Name = "Список клиентов";
            workSheet.Cells[1, 1] = "ФИО";
            workSheet.Cells[1, 2] = "Серия паспорта";
            workSheet.Cells[1, 3] = "Номер паспорта";
            workSheet.Cells[1, 4] = "День рождения";
            workSheet.Cells[1, 5] = "Номер телефона";
            workSheet.Cells[1, 6] = "Эл. почта";
            Excel.Range title = workSheet.Range["A1:F1"];
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
            for (int i = 0; i < dgvClients.ColumnCount - 2; i++)
            {
                for (int j = 0; j < dgvClients.RowCount; j++)
                {
                    if (i > 0)
                    {
                        workSheet.Cells[j + 2, i] = dgvClients.Rows[j].Cells[i + 1].Value.ToString();
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

        //метод, использующиеся для показа/скрытия кнопки сохранить
        void EnabledBtn()
        {
            if ((tbSeries.Text.Length - tbSeries.MaxLength == 0) && (tbNum.Text.Length - tbNum.MaxLength == 0)
                && tbFIO.Text.Length != 0 && tbPhone.Text.Length != 0 && cbService.Text!="" && tbPhone.Text.Length==11) saveBtn.Enabled = true;
            else saveBtn.Enabled = false;
        }
    }
}
