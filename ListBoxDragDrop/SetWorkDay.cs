using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDragDrop
{
    public partial class SetWorkDay : Form
    {
        public SetWorkDay()
        {
            InitializeComponent();
            this.lstOrderWorkDayPerson.AllowDrop = true;
        }

        private void btnAddWorkDayPerson_Click(object sender, EventArgs e)
        {
            if (txtWorkDayPerson.Text!="")
            {
                lstOrderWorkDayPerson.Items.Add((lstOrderWorkDayPerson.Items.Count+1).ToString()+"_"+txtWorkDayPerson.Text);
            }
            txtWorkDayPerson.Text = "";
        }

        private void btnDeleteWorkDayPerson_Click(object sender, EventArgs e)
        {

            if (lstOrderWorkDayPerson.SelectedIndex!=-1)
            {
                lstOrderWorkDayPerson.Items.RemoveAt(lstOrderWorkDayPerson.SelectedIndex);
            }
            
        }

        private void lstOrderWorkDayPerson_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstOrderWorkDayPerson.SelectedItem==null)
            {
                return;
            }
            lstOrderWorkDayPerson.DoDragDrop(lstOrderWorkDayPerson.SelectedItem,DragDropEffects.Move);

        }

        private void lstOrderWorkDayPerson_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstOrderWorkDayPerson_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstOrderWorkDayPerson.PointToClient(new Point(e.X,e.Y));
            int index = lstOrderWorkDayPerson.IndexFromPoint(point);

            if (index<0)
            {
                //如果沒有選到就是最後一項
                index = lstOrderWorkDayPerson.Items.Count - 1;
                
            }
            object data = e.Data.GetData(typeof(string));
            lstOrderWorkDayPerson.Items.Remove(data);
            lstOrderWorkDayPerson.Items.Insert(index, data);
            ReSetOrder();
        }

        public void ReSetOrder() 
        {
            if (lstOrderWorkDayPerson.Items.Count>0)
            {
                for (int i = 0; i < lstOrderWorkDayPerson.Items.Count; i++)
                {
                    lstOrderWorkDayPerson.Items[i] = (i+1).ToString()+"_"+lstOrderWorkDayPerson.Items[i].ToString().Split('_')[1];
                }
            }
        
        }
    }
}
