using System;
using System.Security.Cryptography;

/*
improvements
 - add checkboxes to allow user to control what kind of characters to include?
    - lowercase alphabet a-z
    - numbers            0-9
    - uppercase          A-Z
    - symbols            !?#
    - whitespace         ' '
 how would this work functionally though?
 have a bunch of separate char arrays and join them? 
 or comlicate the selection algorithm?
*/

namespace RandomStringApp {
    /// <summary>
    /// This simple program generates a string by randomly selecting characters from the CharPool array and at a length determined by the user
    /// </summary>
    public partial class Form1 : Form {

        //Pool of characters to pick from
        List <char> CharPool;

        List <char> az = new List<char>{'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        List<char> AZ = new List<char>{'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P','Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        char whiteSpace = ' ';

        List<char> symbols = new List<char>{'~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(',
            ')', '-', '_', '=', '+', '[', '{', ']', '}', '\\', '|', ',', '<', '.',
            '>', '/', '?', ';', ':', '\'', '\"' };
        
        List<char> numeric = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        List<char> test = new List<char>();

        //variable to control length of output string
        int length = 8;
        
        public Form1() {
            InitializeComponent();
            test.Add('a');
        }

        //changes length variable to match UI selection
        private void lengthSelect_ValueChanged(object sender, EventArgs e) {
            length = (int)lengthSelect.Value;
        }

        //generate output string on click 
        private void generateBtn_Click(object sender, EventArgs e) {
            Random rng = new Random();
            String output = "";

            //'Randomly' select character from pool and add to string
            if (CharPool.Count < 1) {
                errorLabel.Visible = true;
            }
            else {
                for (int i = 0; i < this.length; i++) {
                    int randomIndex = rng.Next(CharPool.Count());
                    output += CharPool[randomIndex];
                }
            }

            outputTextBox.Text = output;
        }

        private void checkBox_ValueChanged(object sender, EventArgs e) {
            errorLabel.Visible = false;

            //does this work?
            if (sender.ToString().Equals("alphaLower_checkBox")) {
                CharPool.AddRange(az);
                CharPool.AddRange(test);
            }
            else if (sender.ToString().Equals("alphaUpper_checkBox")) {
                CharPool.AddRange(AZ);
            }
            else if (sender.ToString().Equals("symbols_checkBox")) {
                CharPool.AddRange(symbols);
            }
            else if (sender.ToString().Equals("numeric_checkBox")) {
                CharPool.AddRange(numeric);
            }
            else if (sender.ToString().Equals("space_checkBox")) {
                CharPool.Add(whiteSpace);
            }

        }

    }
}