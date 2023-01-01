using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{

    public partial class OduncTeslimPanel : Form
    {
        List<User> lateusers = new List<User>();
        List<User> ontimeusers = new List<User>();
        List<Kitap> borrowbooks = new List<Kitap>();

        public OduncTeslimPanel()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPanel menu = new MenuPanel();
            menu.Show();
        }

        private void OduncTeslimPanel_Load(object sender, EventArgs e)
        {
            List<User> users = Helper.GetUserList("0");

            foreach(User user in users)
            {
                if (user.borrowbook == "0")
                {
                    continue;
                }

                DateTime.TryParse(user.duedate, out DateTime duedate);

                if (duedate > DateTime.Now)
                {
                    ontimeusers.Add(user);
                }

                else
                {
                    lateusers.Add(user);
                }
            }

            foreach (User user in ontimeusers)
            {
                Kitap borrowbook = Helper.GetBook(user.borrowbook);
                borrowbooks.Add(borrowbook);
                ListViewItem item = new ListViewItem(user.id);
                item.SubItems.Add(user.isim);
                item.SubItems.Add(user.soyisim);
                item.SubItems.Add(borrowbook.isim);
                item.SubItems.Add(user.borrowdate);
                item.SubItems.Add(user.duedate);

                listView1.Items.Add(item);
            }

            foreach (User user in lateusers)
            {
                Kitap borrowbook = Helper.GetBook(user.borrowbook);
                borrowbooks.Add(borrowbook);
                ListViewItem item = new ListViewItem(user.id);
                item.SubItems.Add(user.isim);
                item.SubItems.Add(user.soyisim);
                item.SubItems.Add(borrowbook.isim);
                item.SubItems.Add(user.borrowdate);
                item.SubItems.Add(user.duedate);


                listView2.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            if (listView2.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView2.SelectedIndices.Count; i++)
                {
                    listView2.Items[listView2.SelectedIndices[i]].Selected = false;
                }
            }

            ListViewItem selecteditem = listView1.SelectedItems[0]; //bir tane seçilir.

            uyeaditextBox.Text = selecteditem.SubItems[1].Text;
            teslimuyeaditextBox.Text = selecteditem.SubItems[1].Text;

            uyesoyaditextBox.Text = selecteditem.SubItems[2].Text;
            teslimuyesoyaditextBox.Text = selecteditem.SubItems[2].Text;


            kitapaditextBox.Text = selecteditem.SubItems[3].Text;
            teslimkitapaditextBox1.Text = selecteditem.SubItems[3].Text;

            DateTime.TryParse(selecteditem.SubItems[4].Text, out DateTime borrowdate);
            DateTime.TryParse(selecteditem.SubItems[5].Text, out DateTime duedate);

            VerilisdateTimePicker.Value = borrowdate;
            teslimdateTimePicker.Value = duedate;

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0) return;
            if (listView1.SelectedItems.Count > 0)
            {
                for(int i = 0; i < listView1.SelectedIndices.Count; i++)
                {
                    listView1.Items[listView1.SelectedIndices[i]].Selected = false;
                }
            }

            ListViewItem selecteditem = listView2.SelectedItems[0]; //bir tane seçilir.


            uyeaditextBox.Text = selecteditem.SubItems[1].Text;
            teslimuyeaditextBox.Text = selecteditem.SubItems[1].Text;

            uyesoyaditextBox.Text = selecteditem.SubItems[2].Text;
            teslimuyesoyaditextBox.Text = selecteditem.SubItems[2].Text;


            kitapaditextBox.Text = selecteditem.SubItems[3].Text;
            teslimkitapaditextBox1.Text = selecteditem.SubItems[3].Text;

            DateTime.TryParse(selecteditem.SubItems[4].Text, out DateTime borrowdate);
            DateTime.TryParse(selecteditem.SubItems[5].Text, out DateTime duedate);

            VerilisdateTimePicker.Value = borrowdate;
            teslimdateTimePicker.Value = duedate;

        }

        private void teslimetbutton_Click(object sender, EventArgs e)
        {
            string id;
            List<User> selectedlist;
            if(listView1.SelectedItems.Count > 0)
            {
               id= listView1.SelectedItems[0].SubItems[0].Text;
                selectedlist = ontimeusers;

            }
            else if (listView2.SelectedItems.Count > 0)
            {
                id = listView2.SelectedItems[0].SubItems[0].Text;
                selectedlist = lateusers;
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı seçiniz.");
                return;
            }

            foreach(User user in selectedlist)
            {

                if(user.id==id)
                {
                   foreach(Kitap kitap in borrowbooks)
                    {
                        if (kitap.id == user.borrowbook)
                        {
                            kitap.kopyasayisi = $"{Convert.ToInt32(kitap.kopyasayisi)+1}";
                            Helper.UpdateBook(kitap);
                            user.borrowbook = "0";
                            user.borrowdate = "1900-01-01";
                            user.duedate = "1900-01-01";
                            Helper.UpdateUser(user);

                            MessageBox.Show("Kitap başarıyla teslim edildi.");
                            return;
                        }
                    }
                }
            }
        }

        private void teslimuzatbutton_Click(object sender, EventArgs e)
        {
            string id;
            List<User> selectedlist;
            if (listView1.SelectedItems.Count > 0)
            {
                id = listView1.SelectedItems[0].SubItems[0].Text;
                selectedlist = ontimeusers;

            }
            else if (listView2.SelectedItems.Count > 0)
            {
                id = listView2.SelectedItems[0].SubItems[0].Text;
                selectedlist = lateusers;
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı seçiniz.");
                return;
            }

            foreach (User user in selectedlist)
            {

                if (user.id == id)
                {
                    user.duedate = teslimdateTimePicker.Value.ToString("yyyy-MM-dd");
                    Helper.UpdateUser(user);
                    MessageBox.Show("Teslim süresi uzatıldı");
                    return;
                }
            }

        }
    }
}
