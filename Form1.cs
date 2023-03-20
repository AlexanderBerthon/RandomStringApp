using System;
using System.Security.Cryptography;

/*

improvements
 1. whitespace is only 1 character in the array. the chance of it showing up in a random string
    could be as low as.. 8.12% if all options are selected. Is that a problem? not enough representation?

    here is a representation chart for each option (again based on all options selected)

    chance at least 1 character from list is represented in random 8 char string (all options selected)-
    symbol     = 96.26% representation
    alphaLower = 92.26% representation
    alphaUpper = 92.26% representation
    numeric    = 58.93% representation
    whitespace = 08.12% representation 

    should all sets be equal in probability? 
    there is a representation skew specifically around whitespace and numeric
    could be solved by duplicating data within these pools until they are around the same size as the other pools
    but is that a good idea?

    issue with having more common whitespace.. if it triggers back to back it gets confusing li   ke how many spaces is that?
    1a. back-to-back whitespace.. p   assword

 2. error message not clearing after good input



*/

namespace RandomStringApp {
    /// <summary>
    /// This simple program generates a string by randomly selecting characters from the CharPool array and at a length determined by the user
    /// </summary>
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

        List<char> symbols = new List<char>{'~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(',
            ')', '-', '_', '=', '+', '[', '{', ']', '}', '\\', '|', ',', '<', '.',
            '>', '/', '?', ';', ':', '\'', '\"' };
        
        List<char> numeric = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

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

            //is there a more efficient way to do all of these checks?
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

            //'Randomly' select character from pool and add to string
            //SUPER RANDOM condition to not allow the program to run if the count is 25 seems very out of place
            //BUT it isn't. please read this comment
            //this is condition is a flag that tells the program the charpool is filled with whitespace
            //if the program tries to generate a random string with only whitespace it will crash
            //the size of the whitespace pool is 25
            //the rest of the pools are of different sizes and no combination of the other pools will ever = 25
            //it is a clever, efficient, and.. imperfect solution
            if (CharPool.Count < 1 || CharPool.Count == 25) {
                errorLabel.Visible = true;
            }
            else {
                int randomIndex = 0;
                
                for (int i = 0; i < this.length; i++) {
                    //case included to prevent string beginning or ending in a whitespace
                    if(i == 0 || i == this.length - 1) {
                        char noSpace = ' ';
                        while(noSpace == ' ') {
                            randomIndex = rng.Next(CharPool.Count());
                            noSpace = CharPool[randomIndex];
                        }
                    }
                    else {
                        randomIndex = rng.Next(CharPool.Count());
                    }
                        output += CharPool[randomIndex];
                }
            }
            outputTextBox.Text = output;
            CharPool.Clear(); //clears out all data for next generation
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e) {
            errorLabel.Visible = false;
        }

    }
}