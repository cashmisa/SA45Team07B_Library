using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class ReportForm : Form
    {
        public const int BOOK_ASSESSMENT_REPORT = 0;
        public const int MEMBER_DETAIL_REPORT = 1;

        int reportType = 0;
        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(int type): this()
        {
            reportType = type;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            LibraryDataSet dataSet = new LibraryDataSet();
            
            switch (reportType)
            {
                case BOOK_ASSESSMENT_REPORT:
                    LibraryDataSetTableAdapters.BookAssessmentListTableAdapter bookAdapter = new LibraryDataSetTableAdapters.BookAssessmentListTableAdapter();
                    bookAdapter.Fill(dataSet.BookAssessmentList);

                    BookAssessmentReport bookReport = new BookAssessmentReport();
                    bookReport.SetDataSource(dataSet);
                    reportViewer.ReportSource = bookReport;
                    break;
                case MEMBER_DETAIL_REPORT:
                    LibraryDataSetTableAdapters.MemberDetailListTableAdapter memberAdapter = new LibraryDataSetTableAdapters.MemberDetailListTableAdapter();
                    memberAdapter.Fill(dataSet.MemberDetailList);

                    MemberDetailReport memberReport = new MemberDetailReport();
                    memberReport.SetDataSource(dataSet);
                    reportViewer.ReportSource = memberReport;
                    break;
                default:
                    break;
            }
        }
    }
}
