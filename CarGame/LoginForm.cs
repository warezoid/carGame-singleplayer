using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class LoginForm : Form
    {
        /***** VARIABLES *****/
        private string difficultyValue;

        public LoginForm()
        {
            InitializeComponent();
        }

        /***** StartingGame *****/
        private void StartingGame(string difficulty)
        {
            GameMain newForm = new GameMain(difficulty);

            this.Hide();

            newForm.ShowDialog();
            difficultyComboBox.Text = null;

            this.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            difficultyValue = difficultyComboBox.Text;

            if (difficultyValue != "")
            {
                StartingGame(difficultyValue);
            }
            else
            {
                MessageBox.Show("Difficulty field must be filled in!");
            }
        }
    }
}
