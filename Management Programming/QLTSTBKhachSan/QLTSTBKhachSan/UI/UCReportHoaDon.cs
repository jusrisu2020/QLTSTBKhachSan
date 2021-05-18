using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTSTBKhachSan.Dataset;
using QLTSTBKhachSan.DTO;
using QLTSTBKhachSan.DAO;
using Microsoft.Reporting.WinForms;

namespace QLTSTBKhachSan.UI
{
    public partial class UCReportHoaDon : UserControl
    {
        public UCReportHoaDon()
        {
            InitializeComponent();
            LoadReport();
        }

        private void LoadReport()
        {
            using (var _dbContext = new ModelReportHoaDon())
            {

                List<HoaDonMuaTBDTO> HoaDonList = HoaDonMuaTBDAO.Instance.LoadListHoaDon();

                if(txtSearch.Text != "")
                {
                    HoaDonMuaTBDAO.Instance.SearchMaHD(txtSearch.Text);
                }

                this.rpvHoaDon.LocalReport.ReportPath = "ReportHoaDon.rdlc";
                var ReportDS = new ReportDataSource("HoaDonDataSet", HoaDonList);
                this.rpvHoaDon.LocalReport.DataSources.Clear();
                this.rpvHoaDon.LocalReport.DataSources.Add(ReportDS);
                this.rpvHoaDon.RefreshReport();

            }
        }
    }
}
