using System;
using System.Drawing.Text;
using System.Security.Cryptography;

namespace RandomStringApp {

    public partial class Form1 : Form {

        //Pool of characters to pick from
        List <char> CharPool = new List<char>();

        List <char> alphaLower = new List<char>{'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        List<char> alphaUpper = new List<char>{'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P','Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        //size = 25 THIS NUMBER IS IMPORTANT do not change
        List<char> whiteSpace = new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',
            ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '};

        List<char> symbols = new List<char>{'~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-',
            '_', '=', '+', '[', '{', ']', '}', '\\', '|', ',', '<', '.', '>', '/', '?', ';', ':', '\'', '\"' };
        
        List<char> numeric = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '1', '2',
            '3', '4', '5', '6', '7', '8', '9', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

        //variable to control length of output string
        int length = 8;
        
        public Form1() {
            InitializeComponent();
        }

        //changes length variable to match UI selection
        private void lengthSelect_ValueChanged(object sender, EventArgs e) {
            length = (int)lengthSelect.Value;
        }

        //generate output string on click 
        private void generateBtn_Click(object sender, EventArgs e) {
            Random rng = new Random();
            String output = "";

            //check for and apply user preferences
            if (alphaLower_checkBox.Checked) {
                CharPool.AddRange(alphaLower);
            }

            if (alphaUpper_checkBox.Checked) {
                CharPool.AddRange(alphaUpper);
            }

            if (numeric_checkBox.Checked) {
                CharPool.AddRange(numeric);
            }

            if (symbols_checkBox.Checked) {
                CharPool.AddRange(symbols);
            }

            if (space_checkBox.Checked) {
                CharPool.AddRange(whiteSpace);
            }

            //'Randomly' select a char from the pool and add to string
            if (CharPool.Count < 1 || CharPool.Count == 25) { //can't generate string from empty pool; can't generate string from pool of whitespace (the whitespace array is size 25 specifically as a flag value)
                errorLabel.Visible = true;
            }
            else {
                int randomIndex = 0;
                
                //generate string
                for (int i = 0; i < this.length; i++) {
                    randomIndex = rng.Next(CharPool.Count());

                    //prevent first character from being whitespace
                    if (CharPool[randomIndex] == ' ' && i == 0) {
                        randomIndex = regenerate(randomIndex);
                    }
                    //prevent last character from being whitespace
                    else if (CharPool[randomIndex] == ' ' && i == this.length - 1) {
                        randomIndex = regenerate(randomIndex);
                    }
                    //prevent multiple whitespace in a row
                    else if (CharPool[randomIndex] == ' ' && output.Last().Equals(' ')) { //will this throw an error at i = 0?
                        randomIndex = regenerate(randomIndex);
                    }

                    output += CharPool[randomIndex];
                }
            }
            outputTextBox.Text = output;
            CharPool.Clear(); //clears out data for next generation

            //helper function to regenerate random index
            int regenerate(int value) {
                char noSpace = ' ';
                while (noSpace == ' ') {
                    value = rng.Next(CharPool.Count());
                    noSpace = CharPool[value];
                }
                return value;
            }
        }

        //function to clear error label
        private void checkBox_CheckedChanged(object sender, EventArgs e) {
            errorLabel.Visible = false;
        }
    }
}