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

namespace Security
{
    public partial class workWithWorkers : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        DataTable dt, dtForAddWorkers;
        SqlDataAdapter adapter;
        BindingSource bs, bsForAddWorkers;
        int id;

        public workWithWorkers()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool add = false;
            try
            {
                int id = Convert.ToInt32(cbAllWorkers.SelectedValue);
                connection.Close();
                connection.Open();
                for (int i = 0; i < cbAddWorkers.Items.Count; i++)
                {
                    cbAddWorkers.SelectedIndex = i;
                    if (id == Convert.ToInt32(cbAddWorkers.SelectedValue)) add = true;
                }
                if (add == false)
                {
                    SqlCommand commandInsert = new SqlCommand("INSERT INTO [tWorkerBrigade]" +
                        " VALUES (@ID_Brigade, @ID_Worker)", connection);
                    commandInsert.Parameters.AddWithValue("@ID_Brigade", this.id);
                    commandInsert.Parameters.AddWithValue("@ID_Worker", Convert.ToInt32(cbAllWorkers.SelectedValue));
                    commandInsert.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                connection.Close();
                LoadDataFromWorkerBrigade();
            }
        }

        //загрузка добавленных клиентов
        void LoadDataFromWorkerBrigade()
        {
            adapter = new SqlDataAdapter("SELECT tWorkerBrigade.ID_WorkerBrigade, tWorkerBrigade.ID_Worker, tWorker.sFIO FROM tWorkerBrigade INNER JOIN tBrigade ON tBrigade.ID_Brigade = tWorkerBrigade.ID_Brigade" +
       " inner join tWorker ON tWorkerBrigade.ID_Worker = tWorker.ID_Worker WHERE tWorkerBrigade.ID_Brigade=" + this.id, connection);
            dtForAddWorkers = new DataTable();
            adapter.Fill(dtForAddWorkers);
            bsForAddWorkers = new BindingSource();
            bsForAddWorkers.DataSource = dtForAddWorkers;
            cbAddWorkers.DataSource = bsForAddWorkers;
            cbAddWorkers.ValueMember = "ID_Worker";
            cbAddWorkers.DisplayMember = "sFIO";
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                try
                {
                    DialogResult result = MessageBox.Show(
                    "Вы действительно хотите убрать клиента из данного маршрута",
                    "Удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.No)
                    {
                        LoadDataFromWorkerBrigade();
                        return;
                    }
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        SqlCommand Delete = new SqlCommand("Delete From tWorkerBrigade where ID_Brigade = @ID_Brigade AND ID_Worker=@ID_Worker", connection);
                        Delete.Parameters.AddWithValue("@ID_Brigade", this.id);
                        Delete.Parameters.AddWithValue("@ID_Worker", Convert.ToInt32(cbAddWorkers.SelectedValue));
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
                    LoadDataFromWorkerBrigade();
                }
            }
        }

        public workWithWorkers(int id)
        {
            InitializeComponent();
            this.id = id;
            loadAllWorkers();
            LoadDataFromWorkerBrigade();
            this.BackColor = Color.FromArgb(245, 245, 245);
        }

        void loadAllWorkers()
        {
            SqlDataAdapter allWorkersAdapter;
            allWorkersAdapter = new SqlDataAdapter("Select ID_Worker, sFIO from tWorker Order By sFIO", connection);
            dt = new DataTable();
            allWorkersAdapter.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            cbAllWorkers.DataSource = dt;
            cbAllWorkers.ValueMember = "ID_Worker";
            cbAllWorkers.DisplayMember = "sFIO";
        }
    }
}
