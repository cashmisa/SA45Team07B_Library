using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Team07B
{
    public partial class BaseForm : Form
    {


        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.notifyIconLibraryManagement.ShowBalloonTip(100, "", "Library Management has been closed.", ToolTipIcon.None);
            this.notifyIconLibraryManagement.Visible = false;
            this.notifyIconLibraryManagement.Dispose();
        }

        private void notifyIconLibraryManagement_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }


        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this is BorrowForm)
            {
                return;
            }
            BorrowForm borrowform = new BorrowForm();
            borrowform.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this is ReturnForm)
            {
                return;
            }

            ReturnForm returnform = new ReturnForm();
            returnform.ShowDialog();
        }

        private void adjustStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdjustStock adjuststock = new AdjustStock();
            adjuststock.ShowDialog();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this is BookInfo)
            {
                return;
            }
            BookInfo bookinfo = new BookInfo();
            bookinfo.ShowDialog();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberPopUpSearch mempopupsearch = new MemberPopUpSearch();
            mempopupsearch.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this is AddNewBook)
            {
                return;
            }

            AddNewBook addnewbook = new AddNewBook();
            addnewbook.ShowDialog();
        }

        private void modifyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this is ModifyBook)
            {
                return;
            }
            ModifyBook modifybook = new ModifyBook();
            modifybook.ShowDialog();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this is AddNewMember)
            {
                return;
            }

            AddNewMember addnewmember = new AddNewMember();
            addnewmember.ShowDialog();
        }

        private void modifyInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this is ModifyMember)
            {
                return;
            }

            ModifyMember modifymember = new ModifyMember();
            modifymember.ShowDialog();
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this is AddNewPublisher)
            {
                return;
            }

            AddNewPublisher addnewpublisher = new AddNewPublisher();
            addnewpublisher.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }

        //private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void toolStripButtonBorrow_Click(object sender, EventArgs e)
        {
            if (this is BorrowForm)
            {
                return;
            }
            BorrowForm borrowform = new BorrowForm();
            borrowform.ShowDialog();
        }

        private void toolStripButtonReturn_Click(object sender, EventArgs e)
        {
            if (this is ReturnForm)
            {
                return;
            }
            ReturnForm returnform = new ReturnForm();
            returnform.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this is BookInfo)
            {
                return;
            }
            BookInfo bookinfo = new BookInfo();
            bookinfo.ShowDialog();
        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(ReportForm.BOOK_ASSESSMENT_REPORT);
            form.ShowDialog();
        }

        private void memberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(ReportForm.MEMBER_DETAIL_REPORT);
            form.ShowDialog();
        }
    }
}
