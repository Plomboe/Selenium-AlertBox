using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HappyBirthday birthdayMessage = new HappyBirthday();
            string returnedMessage;

            birthdayMessage.PresentCount = 5;
            birthdayMessage.MyProperty = " Shahid";
            returnedMessage = birthdayMessage.MyProperty;

            MessageBox.Show(returnedMessage);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    HappyBirthday birthdayMessage; //creates place in heap for variable 
        //    birthdayMessage = new HappyBirthday(); //Creating a new Object, has to have brackets outside

        //    MessageBox.Show(birthdayMessage.getMessage(" Shahid"));//Object_name.Method_Name() *Only shows up if it's public

        //}

    }
}
