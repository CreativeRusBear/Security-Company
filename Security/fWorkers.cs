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
    public partial class fWorkers : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataSet ds;
        SqlDataAdapter adapter;
        BindingSource bs;
        bool forBtn;

        //переменные для корректной работы рейтинга
        bool clickImg;
        string click = "";

        public fWorkers()
        {
            InitializeComponent();
            LoadDataFromTable();
            forBtn = false;
            saveBtn.Enabled = false;
            pMenuTop.BackColor = Color.FromArgb(172, 204, 196);
            pMenuTop.ForeColor = Color.FromArgb(255, 255, 255);
            pMenuBottom.BackColor = Color.FromArgb(172, 204, 196);
            pMenuBottom.ForeColor = Color.FromArgb(255, 255, 255);
            this.BackColor = Color.FromArgb(245, 245, 245);
        }

        //загрузка данных из таблицы   
        void LoadDataFromTable()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter("Select * From tWorker Order By sFIO", connection);
                ds = new DataSet();
                adapter.Fill(ds);
                bs = new BindingSource();
                bs.DataSource = ds.Tables[0];
                tbFIO.DataBindings.Clear();
                tbFIO.DataBindings.Add(new Binding("Text", bs, "sFIO"));
                tbCar.DataBindings.Clear();
                tbCar.DataBindings.Add(new Binding("Text", bs, "car"));
                tbGun.DataBindings.Clear();
                tbGun.DataBindings.Add(new Binding("Text", bs, "gun"));
                tbPhone.DataBindings.Clear();
                tbPhone.DataBindings.Add(new Binding("Text", bs, "phone"));
                dtpStartWork.DataBindings.Clear();
                dtpStartWork.DataBindings.Add(new Binding("Text", bs, "startWork"));
                User_photo.Image = imageList1.Images[0];
                if (bs.Count > 0)
                {
                    LoadRating();
                    LoadPhoto();
                }
                tbMoney.DataBindings.Clear();
                tbMoney.DataBindings.Add(new Binding("Text", bs, "salary"));

                dgvWorkers.DataSource = bs;
                dgvWorkers.Columns[0].Visible = false;
                dgvWorkers.Columns[1].HeaderText = "ФИО";
                dgvWorkers.Columns[2].Visible = false;
                dgvWorkers.Columns[3].Visible = false;
                dgvWorkers.Columns[4].Visible = false;
                dgvWorkers.Columns[5].Visible = false;
                dgvWorkers.Columns[6].HeaderText = "Начало работы";
                dgvWorkers.Columns[7].HeaderText = "Зарплата";
                dgvWorkers.Columns[8].Visible = false;

                dgvWorkers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvWorkers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvWorkers.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                checkForAvailability();
            }
        }

        void LoadPhoto()
        {
            string fileName = "";
            User_photo.Image = imageList1.Images[0];
            string s = ((DataRowView)this.bs.Current).Row["photo"].ToString();
            if (s != null)
                if (s != "")
                {
                    User_photo.Load(@"img\workers\" + s);
                    fileName = s;
                    foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                    {
                        fileName = fileName.Replace(c, '_');
                    }
                }
            forPhoto.Text = fileName;
        }

        //метод работы с рейтингом
        void LoadRating()
        {
            string s = ((DataRowView)this.bs.Current).Row["wRank"].ToString();
            if (s != null)
                if (s != "" && s != 0.ToString())
                {
                    clickImg = true;
                    lRank.Text = s;
                    switch (lRank.Text)
                    {
                        case "1":
                            click = "oneStar";
                            printStarsBack(oneStar, clickImg, click);
                            break;
                        case "2":
                            click = "twoStars";
                            printStarsBack(twoStars, clickImg, click);
                            break;
                        case "3":
                            click = "threeStars";
                            printStarsBack(threeStars, clickImg, click);
                            break;
                        case "4":
                            click = "fourStars";
                            printStarsBack(fourStars, clickImg, click);
                            break;
                        case "5":
                            click = "fiveStars";
                            printStarsBack(fiveStars, clickImg, click);
                            break;
                    }
                }
                else
                {
                    clickImg = false;
                    click = "";
                    lRank.Text = "0";
                    printStarsBack(fiveStars, clickImg, click);
                }
        }

        //метод отображения оранжевых звезд рейтинга
        void printStars(PictureBox nameOfPicture)
        {
            switch (nameOfPicture.Name.ToString())
            {
                case "oneStar":
                    nameOfPicture.Load(@"img\btns\star_orange.png");
                    break;
                case "twoStars":
                    oneStar.Load(@"img\btns\star_orange.png");
                    nameOfPicture.Load(@"img\btns\star_orange.png");
                    break;
                case "threeStars":
                    oneStar.Load(@"img\btns\star_orange.png");
                    twoStars.Load(@"img\btns\star_orange.png");
                    nameOfPicture.Load(@"img\btns\star_orange.png");
                    break;
                case "fourStars":
                    oneStar.Load(@"img\btns\star_orange.png");
                    twoStars.Load(@"img\btns\star_orange.png");
                    threeStars.Load(@"img\btns\star_orange.png");
                    nameOfPicture.Load(@"img\btns\star_orange.png");
                    break;
                case "fiveStars":
                    oneStar.Load(@"img\btns\star_orange.png");
                    twoStars.Load(@"img\btns\star_orange.png");
                    threeStars.Load(@"img\btns\star_orange.png");
                    fourStars.Load(@"img\btns\star_orange.png");
                    nameOfPicture.Load(@"img\btns\star_orange.png");
                    break;
            }
        }

        //метод отображения синих звезд рейтинга
        void printStarsBack(PictureBox nameOfPicture, bool star, string click)
        {
            if (star)
            {
                if (click != "")
                {
                    switch (click)
                    {
                        case "oneStar":
                            nameOfPicture.Load(@"img\btns\star_orange.png");
                            twoStars.Load(@"img\btns\star_blue.png");
                            threeStars.Load(@"img\btns\star_blue.png");
                            fourStars.Load(@"img\btns\star_blue.png");
                            fiveStars.Load(@"img\btns\star_blue.png");
                            lRank.Text = "1";
                            break;
                        case "twoStars":
                            oneStar.Load(@"img\btns\star_orange.png");
                            nameOfPicture.Load(@"img\btns\star_orange.png");
                            threeStars.Load(@"img\btns\star_blue.png");
                            fourStars.Load(@"img\btns\star_blue.png");
                            fiveStars.Load(@"img\btns\star_blue.png");
                            lRank.Text = "2";
                            break;
                        case "threeStars":
                            oneStar.Load(@"img\btns\star_orange.png");
                            twoStars.Load(@"img\btns\star_orange.png");
                            nameOfPicture.Load(@"img\btns\star_orange.png");
                            fourStars.Load(@"img\btns\star_blue.png");
                            fiveStars.Load(@"img\btns\star_blue.png");
                            lRank.Text = "3";
                            break;
                        case "fourStars":
                            oneStar.Load(@"img\btns\star_orange.png");
                            twoStars.Load(@"img\btns\star_orange.png");
                            threeStars.Load(@"img\btns\star_orange.png");
                            nameOfPicture.Load(@"img\btns\star_orange.png");
                            fiveStars.Load(@"img\btns\star_blue.png");
                            lRank.Text = "4";
                            break;
                        case "fiveStars":
                            oneStar.Load(@"img\btns\star_orange.png");
                            twoStars.Load(@"img\btns\star_orange.png");
                            threeStars.Load(@"img\btns\star_orange.png");
                            fourStars.Load(@"img\btns\star_orange.png");
                            nameOfPicture.Load(@"img\btns\star_orange.png");
                            lRank.Text = "5";
                            break;
                    }
                }
            }
            else
            {
                oneStar.Load(@"img\btns\star_blue.png");
                twoStars.Load(@"img\btns\star_blue.png");
                threeStars.Load(@"img\btns\star_blue.png");
                fourStars.Load(@"img\btns\star_blue.png");
                fiveStars.Load(@"img\btns\star_blue.png");
            }
        }

        //очитка необходмых полей
        private void ClearText()
        {
            User_photo.Image = imageList1.Images[0];
            forPhoto.Text = "";
            tbFIO.Text="";
            clickImg = false;
            lRank.Text = "0";
            click = "";
            tbGun.Text = "";
            tbCar.Text = "";
            tbMoney.Text = "";
            dtpStartWork.Text = DateTime.Now.ToString();
            tbPhone.Text = "";
            tbMoney.Text = "";
            printStarsBack(fiveStars, clickImg, "fiveStars");
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
            tbFIO.Enabled = val;
            tbCar.Enabled = val;
            tbGun.Enabled = val;
            tbPhone.Enabled = val;
            dtpStartWork.Enabled = val;
            tbMoney.Enabled = val;
            oneStar.Enabled = val;
            twoStars.Enabled = val;
            threeStars.Enabled = val;
            fourStars.Enabled = val;
            fiveStars.Enabled = val;
        }

        void EnabledBtn()
        {
            if (tbFIO.Text.Trim() != ""  && tbPhone.Text.Length == 11 && Convert.ToInt32(lRank.Text) != 0) saveBtn.Enabled = true;
            else saveBtn.Enabled = false;
            
        }

        private void oneStar_MouseEnter(object sender, EventArgs e)
        {
            printStars((sender as PictureBox));
        }

        private void oneStar_MouseLeave(object sender, EventArgs e)
        {
            printStarsBack((sender as PictureBox), clickImg, click);
        }

        private void oneStar_Click(object sender, EventArgs e)
        {
            clickImg = true;
            click = (sender as PictureBox).Name.ToString();
            printStarsBack((sender as PictureBox), clickImg, click);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (forBtn)
            {
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand MaxID = new SqlCommand("Select Max(ID_Worker) from tWorker", connection);
                    int max = int.Parse(dgvWorkers.RowCount.ToString());
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tWorker]" +
                        " VALUES(@FIO, @Rank, @car, @gun, @phone, @startWork, @salary, @photo)", connection);
                    commandInsert.Parameters.AddWithValue("@FIO", tbFIO.Text);
                    commandInsert.Parameters.AddWithValue("@Rank", lRank.Text);
                    commandInsert.Parameters.AddWithValue("@car", tbCar.Text);
                    commandInsert.Parameters.AddWithValue("@gun", tbGun.Text);
                    commandInsert.Parameters.AddWithValue("@phone", tbPhone.Text);
                    commandInsert.Parameters.AddWithValue("@startWork", dtpStartWork.Text);
                    commandInsert.Parameters.AddWithValue("@salary", tbMoney.Text);
                    if ((User_photo.Image != null) && (!(System.IO.File.Exists(@"img\workers\" + forPhoto.Text))))
                    {
                        if (forPhoto.Text != "")
                            User_photo.Image.Save(@"img\workers\" + forPhoto.Text);
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
                int ID_SS = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Worker"]);
                try
                {
                    connection.Close();
                    connection.Open();
                    SqlCommand commandUpdate = new SqlCommand("UPDATE tWorker SET " +
                        "sFIO=@FIO, wRank=@Rank, car=@car, gun=@gun, phone=@phone, startWork=@startWork, salary=@money, photo=@photo WHERE ID_Worker=@IDSS", connection);
                    commandUpdate.Parameters.AddWithValue("@FIO", tbFIO.Text);
                    commandUpdate.Parameters.AddWithValue("@Rank", lRank.Text);
                    commandUpdate.Parameters.AddWithValue("@car", tbCar.Text);
                    commandUpdate.Parameters.AddWithValue("@gun", tbGun.Text);
                    commandUpdate.Parameters.AddWithValue("@phone", tbPhone.Text);
                    commandUpdate.Parameters.AddWithValue("@startWork", dtpStartWork.Text);
                    commandUpdate.Parameters.AddWithValue("@money", tbMoney.Text);
                    if ((forPhoto.Text != "") && (!(System.IO.File.Exists(@"img\workers\" + forPhoto.Text)))) User_photo.Image.Save(@"img\workers\" + forPhoto.Text);
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

        private void delBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;
            if (forBtn) forBtn = false;
            else if (bs.Count > 0)
            {
                int rowPosition = bs.Position;
                int delId = Convert.ToInt32(((DataRowView)this.bs.Current).Row["ID_Worker"]);
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
                        SqlCommand Delete = new SqlCommand("Delete From dbo.tWorker where ID_Worker = @ID", connection);
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
                        "В одном из существующих бригад находится данный сотрудник",
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

        private void tbFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'А' || word > 'Я') && (word < 'A' || word > 'Z') && word != '\b' && word != ' ' && word != '.' && (word < 'a' || word > 'z') && (word < 'а' || word > 'я'))
            {
                e.Handled = true;
            }
            EnabledBtn();
        }

        private void tbFIO_TextChanged(object sender, EventArgs e)
        {
            EnabledBtn();
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

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < '0' || word > '9') && word != '\b') e.Handled = true;
            EnabledBtn();
        }

        private void tbCar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'А' || word > 'Я') && (word < '0' || word > '9') && (word < 'A' || word > 'Z') && word != '\b'  && word != '.' && (word < 'a' || word > 'z') && (word < 'а' || word > 'я')) e.Handled = true;
            EnabledBtn();
        }

        private void dgvWorkers_SelectionChanged(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                User_photo.Image = imageList1.Images[0];
                LoadPhoto();
                LoadRating();
            }
            saveBtn.Enabled = false;
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
            workSheet.Name = "Список сотрудников";
            workSheet.Cells[1, 1] = "ФИО";
            workSheet.Cells[1, 2] = "Ранг";
            workSheet.Cells[1, 3] = "Номер машины";
            workSheet.Cells[1, 4] = "Номер табельного орудия";
            workSheet.Cells[1, 5] = "Номер телефона";
            workSheet.Cells[1, 6] = "Дата начала работы в компнии";
            workSheet.Cells[1, 7] = "Зарплата";
            Excel.Range title = workSheet.Range["A1:G1"];
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
            for (int i = 0; i < dgvWorkers.ColumnCount - 2; i++)
            {
                for (int j = 0; j < dgvWorkers.RowCount; j++)
                {
                   
                        workSheet.Cells[j + 2, i + 1] = dgvWorkers.Rows[j].Cells[i + 1].Value.ToString();
                        workSheet.Cells[j + 2, i + 1].Font.Name = "Tahoma";
                        workSheet.Cells[j + 2, i + 1].Font.Size = "14";
                        workSheet.Cells[j + 2, i + 1].EntireColumn.AutoFit();
                        workSheet.Cells[j + 2, i + 1].EntireRow.AutoFit();
                        workSheet.Cells[j + 2, i + 1].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        workSheet.Cells[j + 2, i + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    
                }

            }
            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ClearText();
            forBtn = true;
            saveBtn.Enabled = false;
            chooseDisplay(true);
        }
    }
}
