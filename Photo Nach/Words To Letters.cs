using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Nach
{
    public partial class Words_To_Letters : Form
    {
        public Words_To_Letters()
        {
            InitializeComponent();
        }

        private readonly Dictionary<string, char> lookupTable = new Dictionary<string, char>();

        private void TxtWords_TextChanged(object sender, EventArgs e)
        {
            lookupTable.Clear();
            int characterIncrementor = 1;
            string output = "";

            txtLetters.Clear();
            
            txtWords.Text = txtWords.Text.Replace(Environment.NewLine, " ");
            while (txtWords.Text.Contains("  "))
            {
                txtWords.Text = txtWords.Text.Replace("  ", " ");
            }

            foreach (string word in txtWords.Text.Split(' '))
            {
                if (!lookupTable.ContainsKey(word))
                {
                    lookupTable.Add(word, (char)characterIncrementor);
                    characterIncrementor++;    
                }
                output += lookupTable[word];
            }

            txtLetters.Text = output;
            cbLookupWord.DataSource = new BindingSource(lookupTable, null);
            cbLookupWord.DisplayMember = "Key";
            cbLookupWord.ValueMember = "Value";

            cbLookupCharacter.DataSource = new BindingSource(lookupTable, null);
            cbLookupCharacter.DisplayMember = "Value";
            cbLookupCharacter.ValueMember = "Key";
        }

        private void CbLookupWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lookupTable.ContainsKey(cbLookupWord.Text))
            {
                cbLookupCharacter.Text = lookupTable[cbLookupWord.Text].ToString();
            }
            toolTip.SetToolTip(cbLookupWord, "Index: " + cbLookupWord.SelectedIndex.ToString());
        }

        private void CbLookupCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lookupTable.ContainsValue(cbLookupCharacter.Text.ToCharArray()[0]))
            {
                cbLookupWord.Text = lookupTable.FirstOrDefault(x => x.Value == cbLookupCharacter.Text.ToCharArray()[0]).Key;
            }
            toolTip.SetToolTip(cbLookupCharacter, "Index: " + cbLookupCharacter.SelectedIndex.ToString());
        }
    }
}
