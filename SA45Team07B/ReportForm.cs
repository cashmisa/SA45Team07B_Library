using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SA45Team07B.Reports;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class ReportForm : Form
    {
        public const int BOOK_ASSESSMENT_REPORT = 0;
        public const int MEMBER_DETAIL_REPORT = 1;
        public const int CHART_REPORT = 2;

        int reportType = 2;
        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(int type) : this()
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
                    var bookAdapter = new LibraryDataSetTableAdapters.BookAssessmentListTableAdapter();
                    bookAdapter.Fill(dataSet.BookAssessmentList);

                    BookAssessmentReport bookReport = new BookAssessmentReport();
                    bookReport.SetDataSource(dataSet);
                    reportViewer.ReportSource = bookReport;
                    break;
                case MEMBER_DETAIL_REPORT:
                    var memberAdapter = new LibraryDataSetTableAdapters.MemberDetailListTableAdapter();
                    memberAdapter.Fill(dataSet.MemberDetailList);

                    MemberDetailReport memberReport = new MemberDetailReport();
                    memberReport.SetDataSource(dataSet);
                    reportViewer.ReportSource = memberReport;
                    break;
                case CHART_REPORT:
                    var subjectAdapter = new LibraryDataSetTableAdapters.BooksBySubjectTableAdapter();
                    subjectAdapter.Fill(dataSet.BooksBySubject);

                    ChartReport chartReport = new ChartReport();
                    chartReport.SetDataSource(dataSet);
                    reportViewer.ReportSource = chartReport;
                    break;
                default:
                    break;
            }
        }
    }
}
