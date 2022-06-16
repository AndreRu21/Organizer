//Рудаков Андрей 3 вариант
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Media;

namespace Органайзер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SayTime(DateTime time)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Stream = Properties.Resources.кукушка;
            sp.PlaySync();

            int h = time.Hour;
            int m = time.Minute;

            if (h <= 19)
                sp.Stream = (Stream)Properties.Resources.ResourceManager.GetObject("_" + h.ToString());
            else sp.Stream = Properties.Resources._20;
            sp.PlaySync();

            if(h >20)
            {
                sp.Stream = (Stream)Properties.Resources.ResourceManager.GetObject
                    ("_" + (h%10).ToString());
                sp.PlaySync();
            }

            if (h == 0 || h >= 5 && h <= 20) sp.Stream = Properties.Resources.часов;
            else if (h == 1 || h == 21) sp.Stream = Properties.Resources.час;
            else sp.Stream = Properties.Resources.часа;
            sp.PlaySync();

            if (m == 0) sp.Stream = Properties.Resources.ровно;
            if (m == 1) sp.Stream = Properties.Resources.одна;
            if (m == 2) sp.Stream = Properties.Resources.две;
            if (m >= 3 && m <= 20 || m == 30 || m == 40 || m == 50)
                sp.Stream = (Stream) Properties.Resources.ResourceManager.GetObject("_" + m.ToString());

            if (m > 20 && m % 10 != 0)
                sp.Stream = (Stream)Properties.Resources.ResourceManager.GetObject("_" + (m / 10).ToString() + "0");
            sp.PlaySync();

            if (m > 20)
            {
                if (m % 10 == 1) sp.Stream = Properties.Resources.одна;
                if (m % 10 == 2) sp.Stream = Properties.Resources.две;
                if(m % 10 >=3 && m%10 <=9)
                    sp.Stream = 
                         (Stream)Properties.Resources.ResourceManager.GetObject("_" + (m % 10).ToString());
                if (m % 10 != 0) sp.PlaySync();
            }

            if (m % 10 >= 5 && m % 10 <= 9) sp.Stream = Properties.Resources.минут;
            if (m % 10 == 1) sp.Stream = Properties.Resources.минута;
            if( m % 10 >=2 && m% 10 <=4) sp.Stream = Properties.Resources.минуты;
            if (m >=5 && m<= 20 || m == 30 || m == 40|| m == 50)
                sp.Stream = Properties.Resources.минут;
            if (m > 0) sp.PlaySync();
        }

        int cntdone = 0;
        void PrintStatus()
        {
            tslAllEvent.Text = "Всего событий: " + lstEvent.Count;
            tslDoneEvent.Text = "За последний сеанс работы наступило событий: " + cntdone;
        }

        void EnableBtn()
        {
            Boolean sel = ListBoxEvent.SelectedItems.Count > 0;
            tsbEdit.Enabled = sel;
            evEdit.Enabled = sel;
            cmEdit.Enabled = sel;
            tsbDel.Enabled = sel;
            evDelete.Enabled = sel;
            cmDel.Enabled = sel;

            Boolean notempty = ListBoxEvent.Items.Count > 0;
            tsbClearAll.Enabled = notempty;
            evClearAll.Enabled = notempty;
            cmClearAll.Enabled = notempty;
            fSave.Enabled = notempty;
            tsbSave.Enabled = notempty;
        }

        [Serializable()]
      struct ItemEvent
        {
            public DateTime evDate;
            public DateTime evTime;
            public string evMessage;
            public Boolean evFlag;
            public bool evSayTime;
            public bool evRepeatEachYear;
        }

        void SaveToFile(string fname)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream f = File.OpenWrite(fname);
            bf.Serialize(f, lstEvent);
            f.Close();
        }

        void LoadFromFile(string fname)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream f = File.OpenRead(fname);
            lstEvent = (List<ItemEvent>)bf.Deserialize(f);
            f.Close();

            ListBoxEvent.Items.Clear();

            string t = "", txt = "";
            for (int i = 0; i <= lstEvent.Count - 1; i++)
            {
                t = lstEvent[i].evTime.ToShortTimeString();

                if (lstEvent[i].evTime.Hour < 10) t = "0" + t;
                txt = lstEvent[i].evDate.ToShortDateString() + "    " +
                    t + "    " + lstEvent[i].evMessage;

                ListBoxEvent.Items.Add(txt);
            }
            EnableBtn();
        }

        List<ItemEvent> lstEvent = new List<ItemEvent>();
        ItemEvent tmp;

        private void evAdd_Click(object sender, EventArgs e)
        {
            AddEditEvent frmAddEdit = new AddEditEvent();
            frmAddEdit.Text = "Добавление нового события";

            if(frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                ItemEvent newEvent;
                newEvent.evDate = frmAddEdit.monthCalendar1.SelectionStart.Date;
                newEvent.evTime = Convert.ToDateTime(frmAddEdit.tbxTime.Text);
                newEvent.evMessage = frmAddEdit.tbxMessage.Text;
                newEvent.evFlag = false;
                newEvent.evSayTime = frmAddEdit.cbxSayTime.Checked;

                newEvent.evRepeatEachYear = false;
                if (frmAddEdit.rbtRepeatYear.Checked == true)
                    newEvent.evRepeatEachYear = true;

                lstEvent.Add(newEvent);
                
                string txt = newEvent.evDate.ToShortDateString() + "      " +
                    frmAddEdit.tbxTime.Text + "      " +
                    newEvent.evMessage;

                ListBoxEvent.Items.Add(txt);
            }
        }

        private void evEdit_Click(object sender, EventArgs e)
        {
            int i = ListBoxEvent.SelectedIndex;
            AddEditEvent frmAddEdit = new AddEditEvent();
            frmAddEdit.Text = "Редактирование события";

            ItemEvent editEvent = lstEvent[i];

            frmAddEdit.monthCalendar1.SetDate(editEvent.evDate);

            if (editEvent.evRepeatEachYear == true)
                frmAddEdit.rbtRepeatYear.Checked = true;
            else if (editEvent.evRepeatEachYear == false)
                frmAddEdit.rbtOne.Checked = true;
                

            if (editEvent.evTime.Hour < 10)
                frmAddEdit.tbxTime.Text = "0" + editEvent.evTime.ToShortTimeString();
            else
                frmAddEdit.tbxTime.Text = editEvent.evTime.ToShortTimeString();

            frmAddEdit.tbxMessage.Text = editEvent.evMessage;

            frmAddEdit.cbxSayTime.Checked = editEvent.evSayTime;
           

            if(frmAddEdit.ShowDialog() == DialogResult.OK)
            {
                if (frmAddEdit.rbtOne.Checked == true)
                    editEvent.evRepeatEachYear = false;
                else if (frmAddEdit.rbtRepeatYear.Checked == true)
                    editEvent.evRepeatEachYear = true;
                editEvent.evDate = frmAddEdit.monthCalendar1.SelectionStart.Date;
                editEvent.evTime = Convert.ToDateTime(frmAddEdit.tbxTime.Text);
                editEvent.evMessage = frmAddEdit.tbxMessage.Text;
                editEvent.evSayTime = frmAddEdit.cbxSayTime.Checked;
               

                lstEvent[i] = editEvent;

                string txt = editEvent.evDate.ToShortDateString() + "      " +
                    frmAddEdit.tbxTime.Text + "      " +
                    editEvent.evMessage;

                ListBoxEvent.Items[i] = txt;
            }
        }

        private void evDelete_Click(object sender, EventArgs e)
        {
            int i = ListBoxEvent.SelectedIndex;
            DialogResult rez;

            rez = MessageBox.Show("Удалить событие:\r\n" + ListBoxEvent.Items[i].ToString(), "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
            {
                lstEvent.RemoveAt(i);
                ListBoxEvent.Items.RemoveAt(i);
            }
        }

        private void evClearAll_Click(object sender, EventArgs e)
        {
            DialogResult rez;

            rez = MessageBox.Show("Очистить весь список с событиями?", "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
            {
                lstEvent.Clear();
                ListBoxEvent.Items.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= lstEvent.Count - 1; i++)
            {
                tmp = lstEvent[i];
                if (tmp.evRepeatEachYear == false)
                {
                    if (tmp.evDate.ToShortDateString() == DateTime.Now.ToShortDateString()
                        && tmp.evTime.ToShortTimeString() == DateTime.Now.ToShortTimeString())
                    {
                        if (tmp.evFlag == false)
                        {
                            tmp.evFlag = true;
                            lstEvent[i] = tmp;
                            cntdone++;
                            timer1.Enabled = false;
                            if (tmp.evSayTime) SayTime(tmp.evTime);
                            MessageBox.Show(tmp.evMessage, "Внимание! Наступило событие!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            timer1.Enabled = true;
                        }
                    }
                    else tmp.evFlag = false;
                    lstEvent[i] = tmp;

                    EnableBtn();
                    PrintStatus();
                }
                else
                if (tmp.evRepeatEachYear == true)
                {
                    if (tmp.evDate.Month == DateTime.Now.Month && tmp.evDate.Day == DateTime.Now.Day
                        && tmp.evTime.Hour == DateTime.Now.Hour && tmp.evTime.Minute == DateTime.Now.Minute)
                    {
                        if (tmp.evFlag == false)
                        {
                            tmp.evFlag = true;
                            lstEvent[i] = tmp;
                            cntdone++;
                            timer1.Enabled = false;
                            if (tmp.evSayTime) SayTime(tmp.evTime);
                            MessageBox.Show(tmp.evMessage, "Внимание! Наступило событие!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            timer1.Enabled = true;
                        }
                    }

                    else tmp.evFlag = false;
                    lstEvent[i] = tmp;

                    EnableBtn();
                    PrintStatus();
                }
            }
        }

        private void fSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                SaveToFile(saveFileDialog1.FileName);
        }

        private void fOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                LoadFromFile(openFileDialog1.FileName);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveToFile(Application.StartupPath + "\\organizer.evnt");
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFromFile(Application.StartupPath + "\\organizer.evnt");
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayTime(Convert.ToDateTime("03:35"));
        }
    }
}
