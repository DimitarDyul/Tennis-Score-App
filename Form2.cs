using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Tennis_Score_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public (string, int) FirstPlayer { get; set; }
        public (string, int) SecondPlayer { get; set; }

        private void ButtonSaveGameClick(object sender, EventArgs e)
        {
            string firstPlayerName = firstPlayerbox.Text.Trim();
            int firstPlayerPoints = (int)fplayernumericUpDown1.Value;

            string secondPlayerName = secondPlayerbox.Text.Trim();
            int secondPlayerPoints = (int)splayernumericUpDown2.Value;

            if (!CheckIfInputsAreValid())
            {
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;

            }
        }

        private bool CheckIfInputsAreValid()
            => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();

        private bool CheckIfPlayerNamesAreEmpty()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);

        private bool CheckIfPlayerNamesAreSame()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessage(textBox);
                ShowErrorOnSameNames();
            }
        }

        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player Name should not be left blank!";

            if (textBox == this.firstPlayerbox)
            {
                this.fPlayerError.SetError(textBox, errorText);
                this.fPlayerlbl.Text = "First" + errorText;
            }
            else if (textBox == this.secondPlayerbox)
            {
                this.sPlayerError.SetError(textBox, errorText);
                this.sPlayerlbl.Text = "Second" + errorText;
            }
        }

        private void RemoveErrorMessage(TextBox textBox)
        {
            if (textBox == this.firstPlayerbox)
            {
                this.fPlayerError.SetError(textBox, "");
                this.fPlayerlbl.Text = string.Empty;
            }
            else if (textBox == this.secondPlayerbox)
            {
                this.sPlayerError.SetError(textBox, "");
                this.sPlayerlbl.Text = string.Empty;
            }
        }

        private void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                this.label6.Text =
                    "First Player name should not be same as Second Player name";
            }
            else
            {
                this.label6.Text = string.Empty;
            }
        }
    }
}
