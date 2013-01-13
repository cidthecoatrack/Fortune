using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fortune_2._1
{
    public partial class Form1 : Form
    {
        //initialize variables
        string[] programmers = { "Karl Speer", "Cid the Coatrack", "Mooseman", "Ludwig Elchmann", "Monica Speer", "Guako Moley", "Klarx" };
        string[] contrib = { "http://bash.org", "Brandom Amsel", "http://www.askaninja.com", "Shelbi Bennett", "Jessica Bibb", "Frasher Bolton", "Brian Clevinger", "Joel Colton", "Darby Conley", "The Dead Alewives", "Doki Doki Productions", "Michelle Gabathuler", "Nick Gorman", "Emily Gur", "Peyton Harvey", "Bryan Hedrick", "JK Hoffman", "Steve Howard", "Gayle Huiner", "J. Jacques", "Yasmeen Johnson", "junklandred@livejournal.com", "Lloyd Kramer", "Brendan MacCormic", "Demetri Martin", "Brian McCraw", "Tom Morgan", "Adam Nakama", "Joshua \"Yoshi\" Nakama", "Munty Natour", "The Onion News", "R. R. Palmer", "Monty Python", "Austin Pike", "Scott Ramsoomair", "http://www.safenow.org/", "Peter Schickele", "Paula Shaibani", "Jessie Sheffield", "Sijl & Olly", "Stucke", "http://www.weirdfortunecookies.com", "Charlotte Trant", "Pooja Usgaonkar", "Patty Worsham", "Robin Williams", "\"Weird Al\" Yankovic" };
        bool filter = false;
        bool choice1 = false;
        bool choice2 = false;
        bool choice3 = false;
        bool choice4 = false;
        bool choice5 = false;
        bool choice6 = false;
        int gender;
        int sign;
        int counter = 0;
        int multiquestioncount = 0;
        bool lovemeat = false;

        //create class-wide constructors
        Findfortune newfortune = new Findfortune();
        Confirm newconfirm = new Confirm();
        Pop_Quiz quiz = new Pop_Quiz();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set text boxes to empty on load
            Nametext.Text = null;
            Agetext.Text = null;
            Gendertext.Text = null;
            Signtext.Text = null;
            Nountext.Text = null;
            Verbtext.Text = null;
            Adjectivetext.Text = null;
        }

        //******************************************************************************************
        //on-off methods
        //******************************************************************************************

        private void offmain()
        {
            Nametext.Enabled = false;
            Agetext.Enabled = false;
            Signtext.Enabled = false;
            Gendertext.Enabled = false;
            Nountext.Enabled = false;
            Verbtext.Enabled = false;
            Adjectivetext.Enabled = false;
            fortunebutton.Enabled = false;
            fortunebutton.Visible = false;
            Filtercheck.Enabled = false;
            creditbutton.Enabled = false;
            creditbutton.Visible = false;
        }

        //******************************************************************************************

        private void onmain()
        {
            Nametext.Enabled = true;
            Agetext.Enabled = true;
            Signtext.Enabled = true;
            Gendertext.Enabled = true;
            Nountext.Enabled = true;
            Verbtext.Enabled = true;
            Adjectivetext.Enabled = true;
            fortunebutton.Enabled = true;
            fortunebutton.Visible = true;
            Filtercheck.Enabled = true;
            creditbutton.Enabled = true;
            creditbutton.Visible = true;
        }

        //******************************************************************************************

        private void offquestion()
        {
            menu.Enabled = false;
            menu.Visible = false;
            option1.Enabled = false;
            option1.Visible = false;
            option1.Text = null;
            option1.Checked = false;
            option2.Enabled = false;
            option2.Visible = false;
            option2.Text = null;
            option2.Checked = false;
            option3.Enabled = false;
            option3.Visible = false;
            option3.Text = null;
            option3.Checked = false;
            option4.Enabled = false;
            option4.Visible = false;
            option4.Text = null;
            option4.Checked = false;
            option5.Enabled = false;
            option5.Visible = false;
            option5.Text = null;
            option5.Checked = false;
            option6.Enabled = false;
            option6.Visible = false;
            option6.Text = null;
            option6.Checked = false;
        }

        //******************************************************************************************

        private void clearquestion()
        {
            multiquestioncount = 0;
            lovemeat = false;
            newfortune.question = 0;
        }

        //******************************************************************************************
        
        private void oncontinue()
        {
            remaining.Enabled = true;
            remaining.Visible = true;
            yesok.Enabled = true;
            yesok.Visible = true;
            no.Enabled = true;
            no.Visible = true;
        }

        //******************************************************************************************

        private void clearall()
        {
            onmain();
            offcontinue();
            offquestion();
            Fortunetext.Text = null;
            Nametext.Text = null;
            Agetext.Text = null;
            Gendertext.Text = null;
            Signtext.Text = null;
            Nountext.Text = null;
            Verbtext.Text = null;
            Adjectivetext.Text = null;
            Filtercheck.Checked = false;
            counter = 0;
        }

        //******************************************************************************************
        
        private void offcontinue()
        {
            remaining.Enabled = false;
            remaining.Visible = false;
            yesok.Enabled = false;
            yesok.Visible = false;
            no.Enabled = false;
            no.Visible = false;
        }

        //******************************************************************************************
        //runtime methods
        //******************************************************************************************

        private void testrun()
        {
            remaining.Text = newfortune.testrun();
            oncontinue();
        }

        //******************************************************************************************

        private void fortuneend()
        {
            offquestion();

            if (newfortune.finish == 4)//if "fatal error" end is chosen
            {
                MessageBox.Show("404 Fatal Error:\n\nSystem overload.  Restart your computer immediately.", "404 Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newfortune.finish = 0;
                clearall();
            }
            else if (newfortune.finish == 3)//if imemdiate stop error is chosen
            {
                oncontinue();
                remaining.Text = "You are finished.";
                yesok.Text = "OK";
                no.Enabled = false;
                no.Visible = false;
            }
            else if (newfortune.question != 0)//if question variable is activited
                whichquestion(newfortune.question);
            else if (Adjectivetext.Text == "testrun")//if running a test run
                testrun();
            else
            {
                if (newfortune.finish == 2)//if "lose a fortune" end is chosen
                {
                    counter++;
                }
                else if (newfortune.finish == 1)//if "lose 5" end chosen
                {
                    counter = 4;
                }
                newfortune.finish = 0;

                if (counter > 3)//when all five fortunes have been given
                {
                    oncontinue();
                    remaining.Text = "All fortunes divined.";
                    yesok.Text = "OK";
                    no.Enabled = false;
                    no.Visible = false;
                }
                else
                {
                    oncontinue();
                    remaining.Text = String.Format("Would you like another fortune?  You have used {0} of 5.", counter + 1);
                }
            }
        }

        //******************************************************************************************
        //button click methods
        //******************************************************************************************

        private void creditbutton_Click(object sender, EventArgs e)
        {
            string output;

            output = String.Format("Programmers:\n");//loop through list of programmers and display
            for (int counter = 0; counter < programmers.Length; counter++)
                output += String.Format("\t{0}\n", programmers[counter]);

            output += String.Format("\nContributors:\n");//loop through list of contributors and display
            for (int counter = 0; counter < contrib.Length; counter++)
                output += String.Format("\t{0}\n", contrib[counter]);
            output += "\n\n\nBrought to you by the Central Virginia Governor's School for Science and Technology\n\nA Moosentertainment production.\n\nMoosentertainment\na division of Moose Inc.";

            Fortunetext.Text = output;
        }

        //******************************************************************************************

        private void fortunebutton_Click(object sender, EventArgs e)
        {
            gender = newconfirm.assigngender(Gendertext.Text);
            sign = newconfirm.assignsign(Signtext.Text);

            if (newconfirm.boxesfilled(Nametext.Text, Agetext.Text, Gendertext.Text, Signtext.Text, Nountext.Text, Verbtext.Text, Adjectivetext.Text) == true)//don't continue unless all information given
            {
                if (gender == -1 || sign == -1)//if an invalid age or gender is given
                    Fortunetext.Text = "You screwed something up.  Idiot...";
                else
                {
                    if (Adjectivetext.Text == "testrun")//check to see if a test run is being run
                    {
                        //reset variables for each fortune, makes sure it can loop through each fortune
                        gender = 0;
                        sign = 1;
                    }
                    newfortune.passin(Nametext.Text, Agetext.Text, gender, sign, Nountext.Text, Verbtext.Text, Adjectivetext.Text, programmers, contrib, filter);
                    offmain();
                    Fortunetext.Text = newfortune.bigfortune();
                    fortuneend();
                }
            }
            else
                Fortunetext.Text = "You haven't given me all the information I need, idiot!";
        }

        //******************************************************************************************

        private void Filtercheck_CheckedChanged(object sender, EventArgs e)
        {
            if (filter)
                filter = false;
            else
                filter = true;
        }

        //******************************************************************************************

        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            if (choice1)
                choice1 = false;
            else
                choice1 = true;
        }

        //******************************************************************************************

        private void option2_CheckedChanged(object sender, EventArgs e)
        {
            if (choice2)
                choice2 = false;
            else
                choice2 = true;
        }

        //******************************************************************************************

        private void option3_CheckedChanged(object sender, EventArgs e)
        {
            if (choice3)
                choice3 = false;
            else
                choice3 = true;
        }

        //******************************************************************************************

        private void option4_CheckedChanged(object sender, EventArgs e)
        {
            if (choice4)
                choice4 = false;
            else
                choice4 = true;
        }

        //******************************************************************************************

        private void option5_CheckedChanged(object sender, EventArgs e)
        {
            if (choice5)
                choice5 = false;
            else
                choice5 = true;
        }

        //******************************************************************************************

        private void option6_CheckedChanged(object sender, EventArgs e)
        {
            if (choice6)
                choice6 = false;
            else
                choice6 = true;
        }

        //******************************************************************************************

        private void no_Click(object sender, EventArgs e)
        {
            clearall();
        }

        //******************************************************************************************

        private void yesok_Click(object sender, EventArgs e)
        {
            if (newfortune.finish == 3)//stop everything and terminate fortunes if ending 3 is selected
            {
                newfortune.finish = 0;
                clearall();
            }
            else if (Adjectivetext.Text == "testrun")//if a test run is going on
            {
                //loop through each gender option and sign option where applicable, determined by the confirm method
                if (newconfirm.testrungender(newfortune.testcount))
                {
                    newfortune.gender++;
                    
                    if (newfortune.gender > 2)
                    {
                        newfortune.gender = 0;
                        newfortune.testcount++;
                    }
                }
                else if (newconfirm.testrunsign(newfortune.testcount))
                {
                    newfortune.sign++;
                    
                    if (newfortune.sign > 12)
                    {
                        newfortune.sign = 1;
                        newfortune.testcount++;
                    }
                }

                offcontinue();
                offquestion();
                Fortunetext.Text = newfortune.bigfortune();
                fortuneend();
            }
            else
            {
                if (counter > 3 && !no.Enabled)//checks to see, when 5 is used, if yes/no buttons are available
                {
                    //when "no" is unavailable, turn it on
                    oncontinue();
                    remaining.Text = "Would you like 5 more fortunes?";
                }
                else if (counter > 3 && no.Enabled)//if "no" is available...
                {
                    //reset the counter (since 5 fortunes have been given) and turn off "no"
                    counter = 0;
                    offcontinue();
                    Fortunetext.Text = newfortune.bigfortune();
                    fortuneend();
                }
                else//if not at end of 5-fortune loop, simply increment and go on
                {
                    counter++;
                    offcontinue();
                    Fortunetext.Text = newfortune.bigfortune();
                    fortuneend();
                }
            }
        }

        //******************************************************************************************

        private void menu_Click(object sender, EventArgs e)//when user submits an answer via the menu
        {
            //determine which question should be used in determing results of user's answer
            if (newconfirm.menucheck(choice1, choice2, choice3, choice4, choice5, choice6))
            {
                switch (newfortune.question)
                {
                    case 205:
                        question205();
                        break;
                    case 206:
                        question206();
                        break;
                    case 207:
                        question207();
                        break;
                    case 208:
                        question208();
                        break;
                    case 209:
                        question209();
                        break;
                    case 210:
                        question210();
                        break;
                    case 211:
                        question211();
                        break;
                    case 212:
                        question212();
                        break;
                    case 213:
                        question213();
                        break;
                    case 219:
                        popquiz();
                        break;
                    default:
                        Fortunetext.Text = String.Format("[Error menu_ClickQuestion: {0} is invalid number]", newfortune.question);
                        onmain();
                        break; 
                }
            }
            else
            {
                Fortunetext.Text = "You didn't answer, loser.  I'm done playing with you.";
                clearall();
            }
        }

        //******************************************************************************************
        //Question methods
        //******************************************************************************************
        
        private void whichquestion(int which)//turns on menu, with appropriate text
        {
            menu.Enabled = true;
            menu.Visible = true;

            //turns on number of answer needed, with text applicable to corresponding question
            switch (which)
            {
                case 205:
                    option1.Enabled = true;
                    option1.Visible = true;
                    option1.Text = "Moose";
                    option2.Enabled = true;
                    option2.Visible = true;
                    option2.Text = "42";
                    option3.Enabled = true;
                    option3.Visible = true;
                    option3.Text = "9000";
                    option4.Enabled = true;
                    option4.Visible = true;
                    option4.Text = "Donkey Kong";
                    option5.Enabled = true;
                    option5.Visible = true;
                    option5.Text = "Afro";
                    option6.Enabled = true;
                    option6.Visible = true;
                    option6.Text = "Rubber";
                    break;
                case 207:
                    option1.Enabled = true;
                    option1.Visible = true;
                    option1.Text = "It's 9000!";
                    option2.Enabled = true;
                    option2.Visible = true;
                    option2.Text = "It's over 9000!";
                    option3.Enabled = true;
                    option3.Visible = true;
                    option3.Text = "It's under 9000!";
                    option4.Enabled = true;
                    option4.Visible = true;
                    option4.Text = "Who are we talking about?";
                    option5.Enabled = true;
                    option5.Visible = true;
                    option5.Text = "He's at Ludicrous speed!";
                    option6.Enabled = true;
                    option6.Visible = true;
                    option6.Text = "His balls are inert!";
                    break;
                case 208:
                    option1.Enabled = true;
                    option1.Visible = true;
                    option1.Text = "Hot girls xxx";
                    option2.Enabled = true;
                    option2.Visible = true;
                    option2.Text = "Asian pottery";
                    option3.Enabled = true;
                    option3.Visible = true;
                    option3.Text = "Roe v. Wade";
                    option4.Enabled = true;
                    option4.Visible = true;
                    option4.Text = "Steamy gay sexing";
                    option5.Enabled = true;
                    option5.Visible = true;
                    option5.Text = "Buddhism";
                    option6.Enabled = true;
                    option6.Visible = true;
                    option6.Text = "Lolita in bed";
                    break;
                case 206://all for any simple yes/no question
                case 209:
                case 211:
                case 212:
                    option1.Enabled = true;
                    option1.Visible = true;
                    option1.Text = "Yes";
                    option2.Enabled = true;
                    option2.Visible = true;
                    option2.Text = "No";
                    break;
                case 210:
                    option1.Enabled = true;
                    option1.Visible = true;
                    option2.Enabled = true;
                    option2.Visible = true;
                    option3.Enabled = true;
                    option3.Visible = true;
                    option4.Enabled = true;
                    option4.Visible = true;
                    option5.Enabled = true;
                    option5.Visible = true;
                    option6.Enabled = true;
                    option6.Visible = true;
                    //this question value asks more than one question.  Determines which set of answers should be displayed
                    switch (multiquestioncount)
                    {
                        case 0:
                            option1.Text = "Ramen";
                            option2.Text = "Doughnut";
                            option3.Text = "Roast Beast";
                            option4.Text = "Salad";
                            option5.Text = "Other";
                            option6.Text = "None";
                            break;
                        case 1:
                            option1.Text = "Moose";
                            option2.Text = "Penguin";
                            option3.Text = "Avacado";
                            option4.Text = "Pink";
                            option5.Text = "42";
                            option6.Text = "Duck";
                            break;
                        case 2:
                            option1.Text = Nametext.Text;
                            option2.Text = Nountext.Text;
                            option3.Text = Verbtext.Text;
                            option4.Text = Adjectivetext.Text;
                            option5.Text = "All";
                            option6.Text = "None";
                            break;
                        default:
                            Fortunetext.Text = "[Error WhichquestionMultiquestioncount]";
                            break;
                    }
                    break;
                case 213:
                    option1.Enabled = true;
                    option1.Visible = true;
                    option2.Enabled = true;
                    option2.Visible = true;
                    //this question value asks more than one question.  Determines which set of answers should be displayed
                    switch (multiquestioncount)
                    {
                        case 0:
                            option1.Text = "Yes, very much so.";
                            option2.Text = "Homowhat?";
                            break;
                        case 1:
                            option1.Text = "I... have a gay friend...";
                            option2.Text = "I'm a flamer!";
                            break;
                        case 2:
                            option1.Text = "I... don't remember...";
                            option2.Text = Nametext.Text;
                            break;
                        default:
                            Fortunetext.Text = "[Error WhichquestionMultiquestioncount]";
                            break;
                    }
                    break;
                case 219:
                    //determine the pop quiz question
                    quiz.find_question();

                    //give answers appropriate
                    Fortunetext.Text += quiz.Question();
                    option1.Enabled = true;
                    option1.Visible = true;
                    option1.Text = quiz.AnswerA();
                    option2.Enabled = true;
                    option2.Visible = true;
                    option2.Text = quiz.AnswerB();
                    option3.Enabled = true;
                    option3.Visible = true;
                    option3.Text = quiz.AnswerC();
                    option4.Enabled = true;
                    option4.Visible = true;
                    option4.Text = quiz.AnswerD();
                    option5.Enabled = true;
                    option5.Visible = true;
                    option5.Text = quiz.AnswerE();
                    option6.Enabled = true;
                    option6.Visible = true;
                    option6.Text = quiz.AnswerF();
                    break;
                default:
                    Fortunetext.Text = "[Error WhichquestionWhich]";
                    break;
            }
        }

        //******************************************************************************************

        private void popquiz()
        {
            clearquestion();

            //determine whether user's answer was correct answer to pop quiz question
            Fortunetext.Text = quiz.right_wrong(choice1, choice2, choice3, choice4, choice5, choice6);

            fortuneend();
        }

        //******************************************************************************************

        private void question206()
        {
            //ignores user's answer, gives one repsonse
            clearquestion();

            Fortunetext.Text = "Well good for you.";

            fortuneend();
        }

        //******************************************************************************************

        private void question205()
        {
            //ignores user's answer, gives one repsonse
            clearquestion();

            Fortunetext.Text = "Hmm... very interesting...";

            fortuneend();
        }

        //******************************************************************************************

        private void question207()
        {
            clearquestion();

            if (choice2)
                Fortunetext.Text = "What, 9000?!";
            else if (choice6)
                Fortunetext.Text = "Oh, so close, and yet, you're wrong.";
            else if (choice5)
                Fortunetext.Text = "Geez, get on the internet sometime, will you? (But kudos for catching the Spaceballs reference.)";
            else
                Fortunetext.Text = "Geez, get on the internet sometime, will you?";

            fortuneend();
        }

        //******************************************************************************************

        private void question208()
        {
            clearquestion();

            if (choice6 || choice4 || choice1)
                Fortunetext.Text = "Hah!  I caught you!  You naughty person you.";
            else
                Fortunetext.Text = "You wuss.";

            fortuneend();
        }

        //******************************************************************************************

        private void question209()
        {
            if (choice1)
                lovemeat = true;

            switch (multiquestioncount)
            {
                case 0:
                    Fortunetext.Text = "Love pork?";
                    break;
                case 1:
                    Fortunetext.Text = "Love beef?";
                    break;
                default:
                    break;
            }

            multiquestioncount++;
            if (multiquestioncount > 2)
            {
                if (lovemeat)
                {
                    clearquestion();
                    Fortunetext.Text = "You love molesting animals!";
                }
                else
                {
                    clearquestion();
                    Fortunetext.Text = "Are you a vegetarian or something?";
                }
            }
            fortuneend();

        }

        //******************************************************************************************

        private void question210()
        {
            switch (multiquestioncount)
            {
                case 0:
                    Fortunetext.Text = "Animal!";
                    break;
                case 1:
                    Fortunetext.Text = "Favorite!";
                    break;
                default:
                    break;
            }

            multiquestioncount++;
            if (multiquestioncount > 2)
            {
                clearquestion();
                Fortunetext.Text = "Hmm... very interesting indeed...";
            }
            fortuneend();
        }

        //******************************************************************************************

        private void question211()
        {
            clearquestion();

            if (choice1)
                Fortunetext.Text = "Here's your proof: Dismember-Me-Elmo.";
            else
                Fortunetext.Text = "Here's your proof: Muppet Porn.";

            fortuneend();
        }

        //******************************************************************************************

        private void question212()
        {
            Fortunetext.Text = "Do you save horses?";
            multiquestioncount++;

            if (multiquestioncount > 1)
            {
                clearquestion();
                Fortunetext.Text = "Sure... *wink wink*";
            }

            fortuneend();
        }

        //******************************************************************************************

        private void question213()
        {
            multiquestioncount++;
            if (choice1 && multiquestioncount < 3)
            {
                switch (multiquestioncount)
                {
                    case 1:
                        Fortunetext.Text = "Oh really?  How is that?";
                        break;
                    case 2:
                        Fortunetext.Text = "And the name of this friend is... ?";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (multiquestioncount)
                {
                    case 1:
                        Fortunetext.Text = "Wow, where HAVE you been the past few years?  In a homophobic cave?";
                        break;
                    case 2:
                        Fortunetext.Text = "Wow, open, are we?";
                        break;
                    case 3:
                        if (choice1)
                            Fortunetext.Text = "Mmhm, of coarse you do...\n\n... *taps foot* ...\n\n... Come on, we know it's you already!\n\n*sigh* Stubborn, aren't you?  Well, that's your problem.";
                        else
                            Fortunetext.Text = "Ah, I see.  Well then... *awkward turtle*";
                        break;
                    default:
                        break;
                }
                clearquestion();
            }
            fortuneend();
        }
    }
}