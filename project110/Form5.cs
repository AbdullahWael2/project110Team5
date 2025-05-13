using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project110
{
    public partial class Form5 : Form
    {
        Dictionary<char, string> morseMap = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
            {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
            {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"},
            {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."},
            {'7', "--..."}, {'8', "---.."}, {'9', "----."}, {' ', "/"}
        };

        Dictionary<string, char> reverseMorseMap;
        public Form5()
        {
            InitializeComponent();
            reverseMorseMap = new Dictionary<string, char>();
            foreach (var pair in morseMap)
            {
                reverseMorseMap[pair.Value] = pair.Key;
            }
        }

        private void toMorseButton_Click(object sender, EventArgs e)
        {
            string input = textInputTextBox.Text.ToUpper();
            morseInputTextBox.Clear();

            if (string.IsNullOrWhiteSpace(input)) return;

            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (morseMap.ContainsKey(c))
                    result.Append(morseMap[c] + " ");
                else
                    result.Append("? ");
            }

            morseInputTextBox.Text = result.ToString().Trim();

        }

        private void toTextButton_Click(object sender, EventArgs e)
        {
            string input = morseInputTextBox.Text.Trim();
            textInputTextBox.Clear();

            if (string.IsNullOrWhiteSpace(input)) return;

            string[] morseWords = input.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (string code in morseWords)
            {
                if (reverseMorseMap.ContainsKey(code))
                    result.Append(reverseMorseMap[code]);
                else if (code == "/")
                    result.Append(' ');
                else
                    result.Append('?');
            }

            textInputTextBox.Text = result.ToString();

        }
    }
}
