using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class HappyBirthday //name of class
    {
        // CLASS VARIABLES
        //========================
        private int numberOfPresents;
        private string birthdayMessage;

        //=============================
        // DEFAULT CONTRUCTOR
        //=============================
        public HappyBirthday() //Constructors
        {
            numberOfPresents = 0;
        }

        //==================================
        //          METHOD
        //==================================
        private string getMessage(string givenName)
        {
            string theMessage;

            theMessage = "Happy Birthday" + givenName + "\n";
            theMessage += "Number of presents=" + numberOfPresents.ToString();

            return theMessage;
        }

        //===================================
        //      READ AND WRITE PROPERTY
        //===================================
        public string MyProperty
        {
            get { return birthdayMessage; }
            set { birthdayMessage = getMessage(value); }
        }


        //==============================
        //      WRITE-ONLY PROPERTY
        //==============================
        public int PresentCount//Property
        {
            set { numberOfPresents = value; }
        }

    }
}
