using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhone.Base.Components.Calls;
using MobilePhone.Base.Components.SMS;
using MobilePhone.Base.MobilePhones;
using SMSSender;
using CallGenerator = CallGenerator.CallGenerator;

namespace MobilePhone.WindowsFormsApp
{
    public partial class L6_Calls : Form
    {
        private readonly MobilePhoneBase Nokia1100 = new Nokia1100(777);
        private global::CallGenerator.CallGenerator vCallGenerator;
        public L6_Calls()
        {
            InitializeComponent();
        }

        private void L6_Calls_Load(object sender, EventArgs e)
        {
            vCallGenerator = new global::CallGenerator.CallGenerator(Nokia1100);
            vCallGenerator.StartMessaging(1);
            Nokia1100.CallsHistory.CallListChanged += OnCallListChanged;
            Nokia1100.Contacts.ContactListChanged += OnContactListChanged;

            listView_Calls.View = View.Details;
            listView_Calls.GridLines = true;
            listView_Calls.FullRowSelect = true;

            listView_Calls.Columns.Add("Number", 100);
            listView_Calls.Columns.Add("Name", 100);
            listView_Calls.Columns.Add("Last name", 100);
            listView_Calls.Columns.Add("Call started at", 150);
            listView_Calls.Columns.Add("Call time", 100);

            DisplaySortedMessages();
        }

        private void OnCallListChanged()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(OnCallListChanged));
                return;
            }
            DisplaySortedMessages();
        }

        private void OnContactListChanged()
        {
            
        }

        private void DisplaySortedMessages()
        {
            var calls = Nokia1100.CallsHistory.GetAllCalls();
            listView_Calls.Items.Clear();
            foreach (var item in calls)
            {
                var name = string.IsNullOrEmpty(item?.Contact?.Name) ? "" : item.Contact.Name;
                var lastName = string.IsNullOrEmpty(item?.Contact?.LastName) ? "" : item.Contact.LastName;
                listView_Calls.Items.Add(new ListViewItem(new[]
                {
                    item.PhoneNamber.ToString(), name, lastName,
                    item.StartTime.ToString(),
                    item.CallTime.ToString()
                }));
            }
        }
        private void DisplaySortedMessages(PhoneCall phoneCall)
        {
            var calls = Nokia1100.CallsHistory.GetRelatedCalls(phoneCall);
            listView_Calls.Items.Clear();
            foreach (var item in calls)
            {
                var name = string.IsNullOrEmpty(item?.Contact?.Name) ? "" : item.Contact.Name;
                var lastName = string.IsNullOrEmpty(item?.Contact?.LastName) ? "" : item.Contact.LastName;
                listView_Calls.Items.Add(new ListViewItem(new[]
                {
                    item.PhoneNamber.ToString(), name, lastName,
                    item.StartTime.ToString(),
                    item.CallTime.ToString()
                }));
            }
        }

        private void listView_Calls_DoubleClick(object sender, EventArgs e)
        {
            if (listView_Calls.SelectedItems.Count > 0)
            {
                var number = int.Parse(listView_Calls.SelectedItems[0].SubItems[0].Text);
                var name = listView_Calls.SelectedItems[0].SubItems[1].Text.Trim();
                var lastName = listView_Calls.SelectedItems[0].SubItems[2].Text.Trim();
                var call = new PhoneCall();
                call.PhoneNamber = number;
                if(!string.IsNullOrEmpty(name)&& !string.IsNullOrEmpty(lastName))
                    call.Contact = new Contact(name, lastName, number);

                DisplaySortedMessages(call);
            }
            else
            {
                MessageBox.Show("Please select double click on row");
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            DisplaySortedMessages();
        }
    }
}
