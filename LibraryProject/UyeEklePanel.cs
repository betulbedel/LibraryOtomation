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
    public partial class UyeEklePanel : Form
    {
        List<User> users = new List<User>();
        public UyeEklePanel()
        {
            InitializeComponent();
        }

        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPanel menupanel = new MenuPanel();
            menupanel.Show();
        }

        private void UyeEklePanel_Load(object sender, EventArgs e)
        {
            users = Helper.GetUserList("-1"); //statusu -1 olanları getirir.

            foreach(User user in users)
            {
                ListViewItem item = new ListViewItem(user.id);
                item.SubItems.Add(user.isim);
                item.SubItems.Add(user.soyisim);
                item.SubItems.Add(user.mailadresi);

                listView1.Items.Add(item);
            }


        }

        private void kabuletbutton_Click(object sender, EventArgs e)
        {
            
            foreach(ListViewItem item in listView1.CheckedItems) //tiklenen kişileri dolanır
            {
                foreach(User user in users)
                {
                    if(user.id == item.Text)
                    {
                        user.status = "0";
                        Helper.UpdateUser(user); //kullanıcı updatelenir.
                    }
                }
                
                
            }
            for(int i= listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Checked) //item'in secili olup olmadıgını kontrol eder
                {
                    listView1.Items.Remove(listView1.Items[i]); //listeviewdan siler.

                }
            }
            MessageBox.Show("Üye kabul edildi.");
            return;
        }

        private void reddetbutton_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView1.CheckedItems) 
            {
                foreach (User user in users)
                {
                    if (user.id == item.Text)
                    {
                        
                        Helper.DeleteUser(user); //kullanıcı silinirr.
                    }
                }


            }
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Checked) //item'in secili olup olmadıgını kontrol eder
                {
                    listView1.Items.Remove(listView1.Items[i]); //listeviewdan siler.

                }
            }
            MessageBox.Show("Üye reddedildi.");
            return;
        }
    }
}
