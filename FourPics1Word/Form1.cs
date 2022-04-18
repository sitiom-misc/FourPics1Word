namespace FourPics1Word
{
    public partial class Form1 : Form
    {
        private const string Answer = "EXTRACT";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void char_Click(object sender, EventArgs e)
        {
            Label clicked = (Label)sender;
            for (int i = 0; i < 7; i++)
            {
                if (Controls.Find($"letter{i}", true).First().Text == string.Empty)
                {
                    clicked.Hide();
                    Controls.Find($"letter{i}", true).First().Cursor = Cursors.Hand;
                    Controls.Find($"letter{i}", true).First().BackColor = clicked.BackColor;
                    Controls.Find($"letter{i}", true).First().Text = clicked.Text;
                    break;
                }
            }
        }

        private void letter_Click(object sender, EventArgs e)
        {
            Label clicked = (Label)sender;
            clicked.Cursor = Cursors.Default;
            clicked.BackColor = Color.White;

            for (int i = 1; i <= 10; i++)
            {
                if (Controls.Find($"char{i}", true).First().Text == clicked.Text && !Controls.Find($"char{i}", true).First().Visible)
                {
                    clicked.Text = string.Empty;
                    Controls.Find($"char{i}", true).First().Show();
                    break;
                }
            }
        }

        private void TextChanged(object sender, EventArgs e)
        {
            string result = letter0.Text + letter1.Text + letter2.Text + letter3.Text + letter4.Text + letter5.Text + letter6.Text;
            if (result.Length == 7)
            {
                if (result == Answer)
                {
                    MessageBox.Show("You have completed this puzzle!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong guess.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
