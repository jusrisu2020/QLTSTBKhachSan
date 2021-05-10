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
    public partial class fQLNV : Form
    {
        public fQLNV()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {
            string query = @"exec Account @User";
            
            dtgvDSNV.DataSource = DataProvider.Instance1.ExecuteQuery(query);
        }
        
    }
}
