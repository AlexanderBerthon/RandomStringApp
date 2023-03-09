using System;
using System.Security.Cryptography;

namespace RandomStringApp {
    /// <summary>
    /// This simple program generates a string by randomly selecting characters from the CharPool array and at a length determined by the user
    /// </summary>
    public partial class Form1 : Form {

        //Pool of characters to pick from
        char[] CharPool = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A',
            'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5',
            '6', '7', '8', '9', '0', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*',
            '(', ')', '-', '_', '=', '+', '[', '{', ']', '}', '\\', '|', ',', '<', '.',
            '>', '/', '?', ';', ':', '\'', '\"'};

        //variable to control length of output string
        int length = 8;
        
        public Form1() {
            InitializeComponent();
        }

        private void lengthSelect_ValueChanged(object sender, EventArgs e) {
            length = (int)lengthSelect.Value;
        }

        private void generateBtn_Click(object sender, EventArgs e) {
            Random rng = new Random();
            String output = "";

            //'Randomly' select character from pool and add to string
            for (int i = 0; i < this.length; i++) {
                int randomIndex = rng.Next(CharPool.Length);
                output += CharPool[randomIndex];
            }

            outputTextBox.Text = output;
        }
    }
}