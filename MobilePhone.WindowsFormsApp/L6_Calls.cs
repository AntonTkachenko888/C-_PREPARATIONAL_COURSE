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
        private PhoneCall GroupByPhoneCall;
        private IEnumerable<PhoneCall> PhoneCallsToDisplay = new List<PhoneCall>();
        public L6_Calls()
        {
            InitializeComponent();
        }

        private void L6_Calls_Load(object sender, EventArgs e)
        {
            vCallGenerator = new global::CallGenerator.CallGenerator(Nokia1100);
            
            Nokia1100.CallsHistory.CallListChanged += OnCallListChanged;

            listView_Calls.View = View.Details;
            listView_Calls.GridLines = true;
            listView_Calls.FullRowSelect = true;

            listView_Calls.Columns.Add("Number", 90);
            listView_Calls.Columns.Add("Direction", 90);
            listView_Calls.Columns.Add("Name", 70);
            listView_Calls.Columns.Add("Last name", 100);
            listView_Calls.Columns.Add("Call started at", 120);
            listView_Calls.Columns.Add("Call time", 90);
            listView_Calls.Columns[1].TextAlign = HorizontalAlignment.Center;

            CallDisable();

            DisplaySortedCalls();
        }

        private void OnCallListChanged()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(OnCallListChanged));
                return;
            }
            if (button_Back.Visible == false)
                DisplaySortedCalls();
            else
                GetGroupBySelectedRow();
        }
        
        #region DisplayCallInfo
        private void CallDisable()
        {
            textBox_CurrentCallNumber.Enabled = false;
            textBox_ContactName.Enabled = false;
            textBox_ContactLastName.Enabled = false;
            richTextBox_ContactNumbers.Enabled = false;
            button_AddNumberToContact.Enabled = false;
            button_Add_Contact.Enabled = false;
            button_RemoveContact.Enabled = false;
            comboBox_Contacts.Enabled = false;
        }
        private void DisplayCallInfo(int number,string name, string lastName)
        {
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(lastName))
            {
                DisplayCallInfo(number);
            }
            else
            {
                DisplayCallInfo(name, lastName);
            }
        }
        private void DisplayCallInfo(int number)
        {
            textBox_CurrentCallNumber.Text = number.ToString();
            comboBox_Contacts.DataSource = Nokia1100.Contacts.Get();

            button_Add_Contact.Enabled = true;
            textBox_ContactName.Enabled = true;
            textBox_ContactLastName.Enabled = true;
            comboBox_Contacts.Enabled = true;
            button_AddNumberToContact.Enabled = true;
        }
        private void DisplayCallInfo(string name, string lastName)
        {
            var contact = Nokia1100.Contacts.Get(name, lastName);
            textBox_ContactName.Text = contact.Name;
            textBox_ContactLastName.Text = contact.LastName;
            richTextBox_ContactNumbers.Text = contact.GetAllNumbers().ToString();
            
            button_RemoveContact.Enabled = true;
        }
        private void ClearDisplayCallInfo()
        {
            textBox_CurrentCallNumber.Text = "";
            textBox_ContactName.Text = "";
            textBox_ContactLastName.Text = "";
            richTextBox_ContactNumbers.Text = "";
        }
        #endregion

        #region DisplayCalls
        private void listView_Calls_DoubleClick(object sender, EventArgs e)
        {
            GetGroupBySelectedRow();
            button_Back.Visible = true;
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            DisplaySortedCalls();
            button_Back.Visible = false;
            GroupByPhoneCall = null;
            ClearDisplayCallInfo();
            CallDisable();
        }

        private void DisplaySortedCalls()
        {
            PhoneCallsToDisplay = Nokia1100.CallsHistory.GetAllCalls();
            Display(PhoneCallsToDisplay);
        }
        private void DisplaySortedCalls(PhoneCall phoneCall)
        {
            PhoneCallsToDisplay = Nokia1100.CallsHistory.GetRelatedCalls(phoneCall);
            Display(PhoneCallsToDisplay);
        }
        private void Display(IEnumerable<PhoneCall> calls)
        {
            listView_Calls.Items.Clear();
            foreach (var item in calls)
            {
                var name = string.IsNullOrEmpty(item?.Contact?.Name) ? "" : item.Contact.Name;
                var lastName = string.IsNullOrEmpty(item?.Contact?.LastName) ? "" : item.Contact.LastName;
                var direction = item.CallDirection == CallDirection.incoming ? "<-" : "->";
                listView_Calls.Items.Add(new ListViewItem(new[]
                {
                    item.PhoneNamber.ToString(),
                    direction,
                    name,
                    lastName,
                    item.StartTime.ToString(),
                    item.CallTime.ToString("ss")
                }));
            }
        }
        private void GetGroupBySelectedRow()
        {
            if (GroupByPhoneCall != null)
            {
                DisplaySortedCalls(GroupByPhoneCall);
                return;
            }
            if (listView_Calls.SelectedItems.Count > 0)
            {
                var number = int.Parse(listView_Calls.SelectedItems[0].SubItems[0].Text);
                var name = listView_Calls.SelectedItems[0].SubItems[2].Text.Trim();
                var lastName = listView_Calls.SelectedItems[0].SubItems[3].Text.Trim();
                GroupByPhoneCall = new PhoneCall();
                GroupByPhoneCall.PhoneNamber = number;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(lastName))
                    GroupByPhoneCall.Contact = new Contact(name, lastName, number);

                DisplaySortedCalls(GroupByPhoneCall);
                DisplayCallInfo(number,name, lastName);
            }
            else
            {
                MessageBox.Show("Please select double click on row");
            }
        }
        #endregion
       
        #region Start/Stop call generation
        private void button_StartCallGeneration_Click(object sender, EventArgs e)
        {
            vCallGenerator.Start(1);
        }

        private void button_StopCallGeneration_Click(object sender, EventArgs e)
        {
            vCallGenerator.Stop();
        }
        #endregion

        #region History 
        private void button_DeleteCurrentCall_Click(object sender, EventArgs e)
        {
            try
            {
                var callToDelete = new PhoneCall();
                var number = int.Parse(listView_Calls.SelectedItems[0].SubItems[0].Text);
                var startTime = DateTime.Parse(listView_Calls.SelectedItems[0].SubItems[4].Text.Trim());
                callToDelete.PhoneNamber = number;
                callToDelete.StartTime = startTime;
                Nokia1100.CallsHistory.Remove(callToDelete);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select any items");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: "+ex.Message);
            }
        }
        private void button_ClearHistory_Click(object sender, EventArgs e)
        {
            Nokia1100.CallsHistory.ClearCallHistory();
        }
        #endregion

        #region Contacts
        private void button_AddNumberToContact_Click(object sender, EventArgs e)
        {
            try
            {
                var s = comboBox_Contacts.Text.Split(' ');
                var name = s.First();
                var lastName = s.Last();
                var contactToAddNumber = Nokia1100.Contacts.Get(name, lastName);
                int number = int.Parse(textBox_CurrentCallNumber.Text);
                contactToAddNumber.AddNumberToContact(number);
                
                GetGroupBySelectedRow();

                CallDisable();
                button_RemoveContact.Enabled = true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Message: " + er.Message);
            }

        }

        private void button_Add_Contact_Click(object sender, EventArgs e)
        {
            try
            {
                Nokia1100.Contacts.Add(new Contact(textBox_ContactName.Text.Trim(),
                textBox_ContactLastName.Text.Trim(),
                int.Parse(textBox_CurrentCallNumber.Text)));

                GetGroupBySelectedRow();

                CallDisable();
                button_RemoveContact.Enabled = true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Message: " + ex.Message);
            }
            
        }

        private void button_RemoveContact_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact();
                contact.Name = textBox_ContactName.Text.Trim();
                contact.LastName = textBox_ContactLastName.Text.Trim();
                Nokia1100.Contacts.Remove(contact);

                GroupByPhoneCall = null;

                DisplaySortedCalls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message: " + ex.Message);
            }
        }
        #endregion
    }
}
