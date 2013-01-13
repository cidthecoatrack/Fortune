using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune_2._1
{
    class Pop_Quiz
    {
        private int question;

        //*****************************************************************************

        public int find_question()
        {
            Random random = new Random();

            question = random.Next(4);
            //question = 0;

            return question;
        }

        //*****************************************************************************

        public string Question()
        {
            switch (question)
            {
                case 0:
                    return "Let us assume that--this is an integration question.  Let us assume that there is an integral function of two factors, and one factor happens to be x squared, and the other factor happens to be sine of x.  What is the capitol of Iowa?";
                case 1:
                    return "\"Non-parishable items!\"\n\nCorrect this phrase.";
                case 2:
                    return "What temperature does water boil?  Please answer in radians.";
                case 3:
                    return "When was the war of 1812?";
                default:
                    return "[Error Pop_Quiz:question]";
            }
        }

        //*****************************************************************************
        
        public string AnswerA()
        {
            switch (question)
            {
                case 0:
                    return "The cube root of 5";
                case 1:
                    return "Non parishable items!";
                case 2:
                    return "2 pi";
                case 3:
                    return "1712";
                default:
                    return "[Error Pop_Quiz:question]";
            }
        }

        //*****************************************************************************

        public string AnswerB()
        {
            switch (question)
            {
                case 0:
                    return "42";
                case 1:
                    return "Non-parishabel items!";
                case 2:
                    return "Square root of 3 over 2";
                case 3:
                    return "George Washington";
                default:
                    return "[Error Pop_Quiz:question]";
            }
        }

        //*****************************************************************************

        public string AnswerC()
        {
            switch (question)
            {
                case 0:
                    return "9,266";
                case 1:
                    return "Parishable non-items!";
                case 2:
                    return "Pi divided by 2";
                case 3:
                    return "Canadia";
                default:
                    return "[Error Pop_Quiz:question]";
            }
        }

        //*****************************************************************************

        public string AnswerD()
        {
            switch (question)
            {
                case 0:
                    return "7";
                case 1:
                    return "No ecclesiastical items!";
                case 2:
                    return "3.14157";
                case 3:
                    return "The Delaware River";
                default:
                    return "[Error Pop_Quiz:question]";
            }
        }

        //*****************************************************************************

        public string AnswerE()
        {
            switch (question)
            {
                case 0:
                    return "3 - 2i";
                case 1:
                    return "Non-parishable itums!";
                case 2:
                    return "17";
                case 3:
                    return "Emil Leutze";
                default:
                    return "[Error Pop_Quiz:question]";
            }
        }

        //*****************************************************************************

        public string AnswerF()
        {
            switch (question)
            {
                case 0:
                    return "6i";
                case 1:
                    return "Non-parrishable items!";
                case 2:
                    return "187.2i divivded by pi";
                case 3:
                    return "Pyotr Ilyich Tchaikovsky";
                default:
                    return "[Error Pop_Quiz:question]";
            }
        }

        //*****************************************************************************

        public string right_wrong(bool a, bool b, bool c, bool d, bool e, bool f)
        {
            Confirm test = new Confirm();
            Random random = new Random();
            Findfortune fortune = new Findfortune();
            
            string output;
            int target = test.answer(a, b, c, d, e, f);

            if (target == random.Next(6))
            {
                output = "Well done!  Here's your reward:\n\n";
                output += fortune.prize();
            }
            else
                output = "Wrong!  You're hopeless!  You fail!  Your miserable existance has no meaning!  Have a good day. ^_^";

            return output;
        }
    }
}
