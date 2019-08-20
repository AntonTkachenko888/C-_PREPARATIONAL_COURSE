using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhone.Base.Components.SMS;
using MobilePhone.Base.MobilePhones;
using SMSSender;

namespace MobilePhone.WindowsFormsApp
{
    public partial class L4_MessageFiltering : Form
    {
        private readonly MobilePhoneBase Nokia1100 = new Nokia1100(777);
        private SmsSender SmsSender;
        private MessageFilteringParams vMessageFilteringParams =new MessageFilteringParams();
        public L4_MessageFiltering()
        {
            InitializeComponent();
        }
        private void L4_MessageFiltering_Load(object sender, EventArgs e)
        {
            SmsSender = new SmsSender(Nokia1100);
            Nokia1100.Storage.MessageAdded += OnMessageAdded;
            Nokia1100.Storage.MessageRemoved += OnMessageRemoved;

            dateTimePicker_FromDate.Value = dateTimePicker_FromDate.MinDate;
            dateTimePicker_BeforeDate.Value = dateTimePicker_BeforeDate.MaxDate;

            listView_Messages.View = View.Details;
            listView_Messages.GridLines = true;
            listView_Messages.FullRowSelect = true;

            listView_Messages.Columns.Add("User", 100);
            listView_Messages.Columns.Add("Message", 450);
            listView_Messages.Columns.Add("ReceivingTime", 200);
        }
        private void OnMessageAdded()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(OnMessageAdded));
                return;
            }
            Reload();
        }
        private void OnMessageRemoved()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(OnMessageRemoved));
                return;
            }
            Reload();
        }
        private void SetState()
        {
            vMessageFilteringParams.SelectedUser = comboBox_Users.Text.Trim();
            if(radioButton_Users_AND.Checked & !radioButton_Users_OR.Checked)
            {
                vMessageFilteringParams.UsersSortOptions=SortOptions.AND;
            }
            else
            {
                vMessageFilteringParams.UsersSortOptions = SortOptions.OR;
            }
            vMessageFilteringParams.MessageText = textBox_MessageText.Text.Trim();
            if (radioButton__MessageText_AND.Checked & !radioButton__MessageText_OR.Checked)
            {
                vMessageFilteringParams.MessageTextSortOptions = SortOptions.AND;
            }
            else
            {
                vMessageFilteringParams.MessageTextSortOptions = SortOptions.OR;
            }
            vMessageFilteringParams.FromDate = dateTimePicker_FromDate.Value;
            vMessageFilteringParams.BeforeDate = dateTimePicker_BeforeDate.Value;
            vMessageFilteringParams.FormattingOptions = comboBox_FormattingOptions.Text.Trim();
        }
        private void SetUsers()
        {
            comboBox_Users.DataSource = Nokia1100.Storage.GetUsers(comboBox_Users.Text.Trim());
        }
        private void DisplaySortedMessages()
        {
            var messages = Nokia1100.Storage.GetMessages(vMessageFilteringParams);
            listView_Messages.Items.Clear();
            foreach (var item in messages)
            {
                listView_Messages.Items.Add(new ListViewItem(new[] { item.User, item.Text, item.ReceivingTime.ToString()}));
            }
        }
        private void Reload()
        {
            SetState();
            DisplaySortedMessages();
            SetUsers();
        }

        private void button_RemoveSelectedMessage_Click(object sender, EventArgs e)
        {
            if (listView_Messages.SelectedItems.Count > 0)
            {
                var messageToRemove = new Base.Components.SMS.Message()
                {
                    User = listView_Messages.SelectedItems[0].SubItems[0].Text,
                    Text = listView_Messages.SelectedItems[0].SubItems[1].Text,
                    ReceivingTime = DateTime.Parse(listView_Messages.SelectedItems[0].SubItems[2].Text)
                };
                Nokia1100.Storage.Remove(messageToRemove);

                MessageBox.Show($"Message was removed :{messageToRemove.User} | {messageToRemove.Text} | {messageToRemove.ReceivingTime}");
            }
            else
            {
                MessageBox.Show("Please select any message");
            }
        }

        private void button_StartReceivingMessages_Click(object sender, EventArgs e)
        {
            SmsSender.TimerTick(1);
        }
        #region StateChanged
        private void comboBox_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void radioButton_Users_OR_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void radioButton_Users_AND_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void textBox_MessageText_TextChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void radioButton__MessageText_OR_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void radioButton__MessageText_AND_CheckedChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void dateTimePicker_FromDate_ValueChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void dateTimePicker_BeforeDate_ValueChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void comboBox_FormattingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }


        #endregion
    }
}
