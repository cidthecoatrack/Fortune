using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune_2._1
{
    public class Confirm
    {
        public int answer(bool ans1, bool ans2, bool ans3, bool ans4, bool ans5, bool ans6)
        {
            if (ans1)
                return 1;
            else if (ans2)
                return 2;
            else if (ans3)
                return 3;
            else if (ans4)
                return 4;
            else if (ans5)
                return 5;
            else if (ans6)
                return 6;
            else
                return 0;
        }
        
        public bool menucheck(bool ans1, bool ans2, bool ans3, bool ans4, bool ans5, bool ans6)
        {
            if (ans1)
                return true;
            else if (ans2)
                return true;
            else if (ans3)
                return true;
            else if (ans4)
                return true;
            else if (ans5)
                return true;
            else if (ans6)
                return true;
            else
                return false;
        }

        //*******************************************************************************
        
        public bool nametest(string target, string[] names)
        {
            foreach (string name in names)
                if (target == name)
                    return true;
            return false;
        }

        //*******************************************************************************
        
        public bool testrunsign(int test)
        {
            string[] filler = new string[1];

            Findfortune fortune = new Findfortune();

            string age = Convert.ToString(test);
            fortune.passin("", age, 0, 1, "", "", "testrun", filler, filler, false);
            
            string out1 = fortune.bigfortune();
            fortune.sign++;
            string out2 = fortune.bigfortune();

            if (out1 == out2)
                return false;
            else
                return true;
        }
        
        //*****************************************************************************
        
        public bool testrungender(int test)
        {
            string[] filler = new string[1];

            Findfortune fortune = new Findfortune();

            string age = Convert.ToString(test);
            fortune.passin("", age, 0, 1, "", "", "testrun", filler, filler, false);
            
            string out1 = fortune.bigfortune();
            fortune.gender++;
            string out2 = fortune.bigfortune();
            fortune.gender++;
            string out3 = fortune.bigfortune();

            if (out1 == out2 && out2 == out3)
                return false;
            else
                return true;
        }
        
        //******************************************************************************************
        
        public bool boxesfilled(string name, string age, string gender, string sign, string noun, string verb, string adjective)
        {          
            if (name == "" || age == "" || gender == "" || sign == "" || noun == "" || verb == "" || adjective == "")
                return false;
            return true;
        }

        //*****************************************************************************************
        
        public int assigngender(string gender)
        {
            switch(gender)
            {
                case "Male":
                    return 1;
                case "Female":
                    return 2;
                case "Other":
                    return 0;
                default:
                    return -1;
            }
        }
        
        //*************************************************************************************8

        public int assignsign(string sign)
        {
            switch (sign)
            {
                case "Aries (March 21 - April 20)":
                    return 1;
                case "Taurus (April 21 - May 21)":
                    return 2;
                case "Gemini (May 22 - June 21)":
                    return 3;
                case "Cancer (June 22 - July 23)":
                    return 4;
                case "Leo (July 24 - August 23)":
                    return 5;
                case "Virgo (August 24 - September 22)":
                    return 6;
                case "Libra (September 23 - October 23)":
                    return 7;
                case "Scorpio (October 24 - November 21)":
                    return 8;
                case "Sagittarius (November 22 - December 21)":
                    return 9;
                case "Capricorn (December 22 - January 20)":
                    return 10;
                case "Aquarius (January 21 - February 19)":
                    return 11;
                case "Pisces (February 20 - March 20)":
                    return 12;
                default:
                    return -1;
            }
        }
    }
}