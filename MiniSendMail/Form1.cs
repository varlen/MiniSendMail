using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace MiniSendMail
{
    public partial class Sendmail : Form
    {
        public Sendmail()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var host = hostTextBox.Text;
            if (!int.TryParse(portTextBox.Text, out var port))
            {
                return;
            }

            var client = new SmtpClient(
                host, port);

            var message = new MailMessage(fromTextBox.Text, toTextBox.Text, subjectTextBox.Text, bodyTextBox.Text);

            client.Send(message);
        }
    }
}
