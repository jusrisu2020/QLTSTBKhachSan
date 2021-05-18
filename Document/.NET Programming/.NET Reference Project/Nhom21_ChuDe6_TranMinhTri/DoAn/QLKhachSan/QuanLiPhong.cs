using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKhachSan.DAO;
namespace QLKhachSan
{
    public partial class fQLP : Form
    {
        public fQLP()
        {
            InitializeComponent();
            LoadQLP();
        }
        void LoadQLP()
        {
            string query = @"select * from PHONG";
            DataProvider dataPro = new DataProvider();
            dtgvQLP.DataSource = dataPro.ExecuteQuery(query);
        }
    }   
}
