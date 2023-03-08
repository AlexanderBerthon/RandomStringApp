using System;
using System.Security.Cryptography;

namespace RandomStringApp {
    public partial class Form1 : Form {

        char[] options = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A',
            'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5',
            '6', '7', '8', '9', '0', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*',
            '(', ')', '-', '_', '=', '+', '[', '{', ']', '}', '\\', '|', ',', '<', '.',
            '>', '/', '?', ';', ':', '\'', '\"'};

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Random rng = new Random();
            String output = "";

            for (int i = 0; i < 9; i++) {
                int randomIndex = rng.Next(options.Length);
                output += options[randomIndex];
            }

            textBox1.Text = output;
        }
    }
}