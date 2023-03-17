using System;
using System.Security.Cryptography;

/*
improvements
 - kind of bad to have a string start or end with whitespace
 - whitespace is only 1 character in the array. the chance of it showing up in a random string
could be as low as.. 8.42% if all options are selected. Is that a problem? not enough representation?

here is a representation chart for each option (again based on all options selected)

-chance at least 1 character from list is represented in random 8 char string (all options selected)-
alphaLower = 
alphaUpper = 
symbol     = 
whitespace =  
numeric    = 
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

        char whiteSpace = ' ';

        List<char> symbols = new List<char>{'~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(',
            ')', '-', '_', '=', '+', '[', '{', ']', '}', '\\', '|', ',', '<', '.',
            '>', '/', '?', ';', ':', '\'', '\"' };
        
        List<char> numeric = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

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
                CharPool.Add(whiteSpace);
            }

            //'Randomly' select character from pool and add to string
            if (CharPool.Count < 1) {
                errorLabel.Visible = true;
            }
            else {
                int testcount = 0;
                for (int t = 0; t < 100000; t++) {
                    for (int i = 0; i < this.length; i++) {
                        int randomIndex = rng.Next(CharPool.Count());
                        output += CharPool[randomIndex];
                    }
                    if(output.Contains(" ")){
                        testcount++;
                    }
                    output = "";
                }
                outputTextBox.Text = testcount.ToString();
            }

            CharPool.Clear(); //clears out all data for next generation
        }


        //I don't want to make an interaction function for every single check box
        //because I would be repeating some code like 6 times
        //but combining all the logic in one function is very messy
        //both options are bad
        //

        //why should I do work when the user clicks the box?
        //what if the user clicks the box 10 times?
        //then I am modifying the list 10 times
        //that's stupid
        //instead, when the user clicks the generate button, check all the boxes and make ONE modification
        //



    }
}