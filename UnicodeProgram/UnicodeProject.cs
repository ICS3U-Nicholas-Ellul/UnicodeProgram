/*
 * Created by: Nicholas  Ellul
 * Created on: 16-Oct-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-11
 * This program lists the characters and unicodes from  A-Z.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeProgram
{
    public partial class UnicodeProject : Form
    {
        public UnicodeProject()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //input
            string unicodeAndChar;
          
            //process
            this.lstListBox.Items.Clear();
            for(int loopCounter = 65; loopCounter<91; loopCounter++)
            {
        
               unicodeAndChar = Char.ConvertFromUtf32(loopCounter) + " --> " + loopCounter;

                //output
                this.lstListBox.Items.Add(unicodeAndChar);
            }
        }
    }
}
