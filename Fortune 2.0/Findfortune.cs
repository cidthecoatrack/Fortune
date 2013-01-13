using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune_2._1
{
    public class Findfortune
    {
        string name;
        public int age;
        public int gender;
        public int sign;
        string noun;
        string verb;
        string adjective;
        const int RANDOMLIMIT = 238;
        LinkedList<int> usedfort = new LinkedList<int>();
        string[] me;
        string[] you;
        bool filter;
        public int question = 0;
        public int testcount;
        public int finish = 0;
        private int Fortnum;
        Confirm newconfirm = new Confirm();
        Random random = new Random();

        public int fortnum
        {
            get
            {
                return Fortnum;
            }
            set
            {
                if (adjective == "testrun")
                    Fortnum = value;
                else
                {
                    if (!usedfort.Contains(value))
                    {
                        usedfort.AddLast(value);
                        Fortnum = value;
                    }
                    else
                    {
                        if (usedfort.Count == RANDOMLIMIT)
                            Fortnum = -1;
                        else
                            value = random.Next(RANDOMLIMIT) + 1;
                    }
                }    
            }
        }

        //********************************************************************************************

        public void passin(string username, string userage, int usergender, int usersign, string usernoun, string userverb, string useradjective, string[] prog, string[] help, bool userfilter)
        {
            name = username;
            age = Convert.ToInt16(userage);
            testcount = Convert.ToInt16(userage);
            gender = usergender;
            sign = usersign;
            noun = usernoun;
            verb = userverb;
            adjective = useradjective;
            me = new string[prog.Length];
            you = new string[help.Length];
            filter = userfilter;

            for (int i = 0; i < me.Length; i++)
                me[i] = prog[i];
            for (int i = 0; i < you.Length; i++)
                you[i] = help[i];
        }

        //*******************************************************************************************

        public string testrun()
        {
            if (newconfirm.testrungender(testcount))
                return String.Format("Fortune {0}.{1}G test successful?", testcount, gender);
            else if (newconfirm.testrunsign(testcount))
                return String.Format("Fortune {0}.{1}S test successful?", testcount, sign);
            else
            {
                testcount++;
                return String.Format("Fortune {0} test successful?", testcount-1);
            }
        }

        //*******************************************************************************************
        
        public string bigfortune()
        {
            if (adjective == "testrun")
                fortnum = testcount;
            else
                fortnum = random.Next(RANDOMLIMIT) + 1;

            switch (fortnum)
            {
                case 1:
                    return weirdalhoroscope1();
                case 2:
                    return weirdalhoroscope2();
                case 3:
                    return "Now you may find it inconceivable or at the very least a bit unlikely that the relative positions of the planets and the stars can have a special, deep significance or meaning that exclusively applies to only you, but let me give my assurance that these forcasts and predications are all based on solid scientific documented evidence, so you would have to be some kind of moron not to realize that every single one of them is absolutely true.\n\nWhere was I?";
                case 4:
                    return prize();
                case 5:
                    return "You are like pi; you are completely irrational.";
                case 6:
                    return "You are like compex mathematics; you have no simple solution.";
                case 7:
                case 8:
                case 95:
                case 96:
                case 97:
                case 98:
                    return dontsucceed();
                case 9:
                    return earlyfinish9();
                case 10:
                    return earlyfinish10();
                case 11:
                    return filter11();
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 102:
                case 136:
                case 137:
                case 170:
                    return lemons();
                case 17:
                    return "When life gives you strawberries... wait, I messed up... crap.";
                case 18:
                    return "You will invent the Pepto-Bismal-flavored donut.";
                case 19:
                    return "In all honesty, no one really wants to hear what you have to say.";
                case 20:
                    return filter11();
                case 21:
                    return "42.";
                case 22:
                    return "After claiming that \"NASA is the place where they do spacey stuff,\" you will lose the science fair.";
                case 23:
                    return "Ducks will fall from the sky in your honor.";
                case 24:
                    return "Your loved ones love you very much.  They'd love you more if you'd just shut up already.";
                case 25:
                    return "You do realize you're asking a computer program made by a high school student for your fortune, right?";
                case 26:
                    return "You will be told a completely bogus fortune today.";
                case 27:
                    return assassination();
                case 28:
                    return filter28();
                case 29:
                    return "You were Michael Jackson in a past life.";
                case 30:
                    return "Your life has merely been a figment of your imagination.  Try that one on for size.";
                case 31:
                    return "You fail at life.\n\n*deep inhalation* Mmm, I can almost smell the failure.";
                case 32:
                    return "Nazi penguins will take over the world if you use another fortune.";
                case 33:
                    return gender33();
                case 34:
                    return "You suck.  You don't get a fortune.";
                case 35:
                    return "You will be attacked by rabid ninja monkeys who will eat your soul.";
                case 36:
                    return "You are about to witness the most spectacular fortune ever!\nIt is so amazing that you will be astounded by its sheer awesomeness!\nCrossbreed magazine gives it 5 thumbs up!  \"It's something every human being should base every aspect of their life on.\"\nBrendan MacCormic says that this fortune is the most incredible thing since nanotechnology!\nJK Hoffman says that every rose has its thorn, just like every cowboy sings a sad, sad song, just like this fortune!\nAnd now, without further ado, the best fortune in the history of all fortunes!";
                case 37:
                    return String.Format("I hate you.  Go {0} yourself silly.", verb);
                case 38:
                    return String.Format("Soon, your {0} will betray you.", noun);
                case 39:
                    return String.Format("People say you {0} like your mom.", verb);
                case 40:
                    return filterorgasm();
                case 41:
                    return filter41();
                case 42:
                    return "You have received the ultimate fortune.  You are welcome.";
                case 43:
                    return name43();
                case 44:
                    return String.Format("Soon, a massive {0} will sit on you.", noun);
                case 45:
                    return yo();
                case 46:
                    return "In the future, you will eat the cutest babies...";
                case 47:
                    return gender47();
                case 48:
                    return gender48();
                case 49:
                    return "You have no future.  You are going to die alone and naked.";
                case 50:
                    return sign50();
                case 51:
                    return "Tomorrow, you will feel like death on a Trisquit.";
                case 52:
                    return filter52();
                case 53:
                    return lucky();
                case 54:
                    return "All of your teachers are sure that you must be the missing link.";
                case 55:
                    return idiot();
                case 56:
                    return "Your mother was a hamster and your father smelled of elderberries.";
                case 57:
                    return "Krambo will eat you.";
                case 58:
                    return String.Format("I'm so {0}, and you're so... not... it's not even funny.", adjective);
                case 59:
                    return String.Format("You know my {0} is bigger than yours.", noun);
                case 60:
                    return "You will succumb to scientific poking in the near future.";
                case 61:
                    return "I know who you did last summer.";
                case 62:
                    return meteor();
                case 63:
                    return "You are deep like a sheep.";
                case 64:
                    return "You make the retarded chocobos look smart.";
                case 65:
                    return "You will have a close encounter with Mr. Herpes today.";
                case 66:
                    return "You will find an earring today and get infected with AIDS.";
                case 67:
                    return "Your intelligence will be multipled a hundredfold today--and yet, you will be unable to progress beyond the special education classes.";
                case 68:
                    return "Chuck Norris approves of this program, but he does not approve of you.  You have been warned.";
                case 69:
                    return "I look forward to killing you soon.";
                case 70:
                    return "You will be viciously sporked to death.";
                case 71:
                    return "Congratulations!  You have found the legendary Missing Fortune!";
                case 72:
                    return "What would you do if I wasted one of your fortunes to ask you a pointless rhetorical question?";
                case 73:
                    return String.Format("For every single {0} you own, a kid is starving in Africa.",noun);
                case 74:
                    return "I hate to break it to you, but size does matter.  A lot.";
                case 75:
                    return "You will graduate from Ninja Tech.";
                case 76:
                    return String.Format("Every time you {0}, God kills a kitten.", verb);
                case 77:
                    return irritate();
                case 78:
                    return bod();
                case 79:
                    return lottery();
                case 80:
                    return "If pigs could fly, they would defecate all over you.";
                case 81:
                    return "This program gives a $10,000,000 donation for every victim in the Survivors of Chuck Norris's Roundhouse Kick Foundation.  So far, we've made a dollar.";
                case 82:
                    return "You have a big zit on your neck.\nNo, wait, sorry, that's your face.";
                case 83:
                    return "In your language class, you will learn how to circumcise innocent stick figures.";
                case 84:
                    return "You will be maimed by fish-sucking weasels from hell (otherwise known as lawyers).";
                case 85:
                    return gender85();
                case 86:
                    return "You have a short atten--ooo, a quarter!";
                case 87:
                    return name87();
                case 88:
                    return "Someone is talking about you.  RIGHT NOW!";
                case 89:
                    return "Um... I forgot your fortune... sorry...";
                case 90:
                    return name90();
                case 91:
                    return "The Anti-Christ has come, and his name is Furbie.";
                case 92:
                    return censored();
                case 93:
                    return filter93();
                case 94:
                    return name94();
                case 99:
                    return "Help!  I'm being forced to work in a programming factory!";
                case 100:
                    return "You are economically retarded.";
                case 101:
                    return gender101();
                case 103:
                    return "Right now, someone is receiving this fortune.";
                case 104:
                    return gender104();
                case 105:
                    return "You will be mauled by the uber-bunny.";
                case 106:
                    return "The men in white coats have lied to you.  Bunnies, kittens, and puppy dogs all really DO die!";
                case 107:
                    return "All your dreams will be hopelessly and heartlessly crushed.";
                case 108:
                    return "You are illiteritabit.";
                case 109:
                    return "Thanks to you, the fate of humanity shall be decided by a Dance Dance Revolution competition between God and the Devil.";
                case 110:
                    return String.Format("Can you {0} me now?  Good!", verb);
                case 111:
                    return String.Format("Don't beat your {0}, or you'll go blind.", noun);
                case 112:
                    return filter112();
                case 113:
                    return "You will be forced to sing the Medley of Doom.";
                case 114:
                    return filter114();
                case 115:
                    return "Tomorrow will be cold.  Wear long-sleeve pants.";
                case 116:
                    return "You can procrastinate like there's no tomorrow.";
                case 117:
                    return filter117();
                case 118:
                    return "You owe someone a free grab upon your arse.";
                case 119:
                    return "By watching the OC, you will manage to get into all advanced classes and pass with all A's.";
                case 120:
                    return "If it's any comfort, llamas accept you just the way you are.";
                case 121:
                    return filtergender121();
                case 122:
                    return "Who's that behind you?\n\n\n\n\n\n\n\n(Made you look.)";
                case 123:
                    return gender123();
                case 124:
                    return "Your life is full of bottomless sorrow and topless gaiety.";
                case 125:
                    return filter125();
                case 126:
                    return "You have temporarily been demoted to nonexistant.";
                case 127:
                    return gender127();
                case 128:
                    return "Beware!  Death Bunny likes to stick his carrots where they don't belong!";
                case 129:
                    return "You will be locked in a box with pictures of Abraham Lincoln.  Naked.";
                case 130:
                    return "By passing your fruit juice around at lunch, you will contract herpes.";
                case 131:
                    return "In the annals of history, you will not be nameless; you will be Choreographer #2!";
                case 132:
                    return "You must go out and ninja in the night.";
                case 133:
                    return gender133();
                case 134:
                    return filter134();
                case 135:
                    return "If your true love did drugs, you would finally have someone to date.";
                case 138:
                    return "I was thinking about giving you a nice fortune, but then I remembered: I never give nice fortunes.";
                case 139:
                    return "You will be glomped by someone's car.";
                case 140:
                    return special();
                case 141:
                    return gender141();
                case 142:
                    return "Beware!  The blacksmith will turn into a dragon and eat you!";
                case 143:
                    return "You will almost get a date, but will be passed over in favor of an epiphany.";
                case 144:
                    return "You will use quantum physics and burnt toast to achieve immortality.";
                case 145:
                    return underwear();
                case 146:
                    return gender146();
                case 147:
                    return gender147();
                case 148:
                    return "You will get a Mustache o' Herpes for your birthday.";
                case 149:
                    return "In Soviet Russia, fortune gets you!";
                case 150:
                    return filterballsinert();
                case 151:
                    return "You will soon be so happy that random pedestrians will join you in complicated dance routines!";
                case 152:
                    return cookie();
                case 153:
                    return "Congratulations!  You just won a smack in the face!";
                case 154:
                    return "Remember, Jesus loves you, but everyone else thinks you're an idiot.";
                case 155:
                    return "Why not make someone's day?  Stick out your butt and sing \"Singing in the Rain\"?";
                case 156:
                    return "The only time success comes before work is in the dictionary.  That's a hint, you lazy bum.";
                case 157:
                    return gender156();
                case 158:
                    return "I'm sorry, your fortune has been misplaced.  You will be notified when it is located.  Thank you.  Have a nice day.";
                case 159:
                    return nameadj();
                case 160:
                    return "You don't need a parachute to go skydiving.  You need a parachute to go skydiving twice.";
                case 161:
                    return "An alien of some sort will be appearing to you shortly!";
                case 162:
                    return "Life is not a struggle.  It's a wiggle.";
                case 163:
                    return "This fortune was divined in a mere 0.195 seconds.  If it took longer than that, smack your computer upside the head.";
                case 164:
                    return "You are not illiterate.";
                case 165:
                    return String.Format("Buy many {0} boxes.  Ask a friend to choose one.", noun);
                case 166:
                    return "Alas!  The onion you are eating is someone else's flower lily!";
                case 167:
                    return "When you have a fat friend, there are no see-saws: only catapults.";
                case 168:
                    return "You are less nurturing than a desert.";
                case 169:
                    return "You will be violently beaten by teens with baseball bats on Halloween.  In retrospect, a pinata will not be the best choice of costume.";
                case 171:
                    return "If you set yourself on fire, do not run.";
                case 172:
                    return terrorism();
                case 173:
                    return "If you spot a terrorist arrow, pin it against the wall with your shoulder.";
                case 174:
                    return "If you are sprayed with an unknown substance, stand and think about it instead of seeing a doctor.";
                case 175:
                    return "To eliminate smallpox, wash with soap, water and at least one armless hand under a faucet with no sink.";
                case 176:
                    return "Michael Jackson is a terrorist. If you spot this smooth criminal with scary eyes, run away.";
                case 177:
                    return "People, animal corpses, and the biohazard symbol are all at risk of being sucked into time-tunnel vortexes.";
                case 178:
                    return "Be on the lookout for terrorists with pinkeye and leprosy.";
                case 179:
                    return "If a door is closed, karate chop it open.";
                case 180:
                    return "If your building collapses, climb under your table and practice yoga.";
                case 181:
                    return "Try to absorb as much radiation as possible with your groin. The current world record is 5 minutes, 12 seconds.";
                case 182:
                    return "After exposure to radiation it is important to consider that you may have mutated to gigantic dimensions: watch your head.";
                case 183:
                    return "If you've become a radioactive mutant with a deformed hand, remember to close the window. No one wants to see that.";
                case 184:
                    return "If you hear the Backstreet Boys, Michael Bolton or Yanni on the radio, cower in the corner or run like hell.";
                case 185:
                    return "Your respiratory and digestive systems are optional. Cast them aside if you feel you no longer need them.";
                case 186:
                    return "If you are trapped under falling debris, conserve oxygen by not farting.";
                case 187:
                    return "Do not drive station wagons with a utility pole protruding from the hood.";
                case 188:
                    return "A one-inch thick piece of plywood should be sufficient protection against radiation.";
                case 189:
                    return "That closet door in your bedroom leads to the gates of Hell. Don't go there.";
                case 190:
                    return "The middle of a terrorist attack is not an appropriate time to catch up on your reading or paperwork.";
                case 191:
                    return gender191();
                case 192:
                    return "If the weather is overcast with dark skies, look for worms in the grass.";
                case 193:
                    return "After all life is gone, I will still live. Think about it.";
                case 194:
                    return "Your telephone may be a practicing physician.";
                case 195:
                    return "Only the coolest irradiated citizens will be allowed into the 'underground' rave in the shelter.  You are not among the coolest irradiated citizens.";
                case 196:
                    return filter196();
                case 197:
                    return "There is a reason you failed chemistry.";
                case 198:
                    return "Watch out for people who come out of white tents and try to steal the shirt off your back.";
                case 199:
                    return "If you are trapped with no hope of being found, amuse yourself in your final moments with shadow puppets.";
                case 200:
                    return "Satellite photos show the large embarrassing radioactive crop circle on your left butt cheek.";
                case 201:
                    return "When looting, remember to consider the weight/value ratio.";
                case 202:
                    return viewfortune();
                case 203:
                    return "Ooo, you're really better off not knowing this one, trust me.";
                case 204:
                    return error();
                case 205:
                    return question205();
                case 206:
                    return question206();
                case 207:
                    return question207();
                case 208:
                    return question208();
                case 209:
                    return question209();
                case 210:
                    return question210();
                case 211:
                    return question211();
                case 212:
                    return question212();
                case 213:
                    return question213();
                case 214:
                    return earlyfinish214();
                case 215:
                    return "After reading this fortune, your eyes will be broken.";
                case 216:
                    return "If you're really happy, don't worry; there's a mac truck around the corner with your name on it.";
                case 217:
                    return "You are dismal.";
                case 218:
                    return "You will eat lead paint for lunch.  Yum!";
                case 219:
                    return question219();
                case 220:
                    return gender220();
                case 221:
                    return sign221();
                case 222:
                    return "Your offspring shall resemble giant mechanical space crabs.";
                case 223:
                    return String.Format("In the annals of history, you will be remembered as {0} the Squiggly.",name);
                case 224:
                    return "Despite your best efforts, you will be unable to pronounce an apostrophe.";
                case 225:
                    return binary();
                case 226:
                    return String.Format("Someone wrote a lymric about you!\n\nOh wait, you're not from Nantucket...");
                case 227:
                    return filter227();
                case 228:
                    return filter228();
                case 229:
                    return "Despite what you believe, what you see when you open a box of Cheerios are not donut seeds.";
                case 230:
                    return filter230();
                case 231:
                    return "After having sex with a less-than-desirable person, you will contract a horrible STD called \"babies\".";
                case 232:
                    return gender232();
                case 233:
                    return "Your crime will be discovered.  You sick bastard.";
                case 234:
                    return String.Format("Your processor is currently running at 2.3 billion calculations per second.  This is because you have a virus.\n\nNot your computer.  You.");
                case 235:
                    return "You will manage a great feat of instant BS today.";
                case 236:
                    return NameCount();
                    //return "[This method is commented out.  Does not work, only with breakpoint does.  Yoda speak use I.]";
                case 237:
                    return LifeGoal();
                case 238:
                    return "Your life is made of epic fail and awkward turtles.";
                case 239:
                    return sign239();
                case -1:
                    finish = 3;
                    return "You've used all my fortunes!  Scram!";
                default:
                    finish = 3;
                    return "[Error X]";
            }
        }

        //******************************************************************************************

        private string sign239()
        {
            switch (sign)
            {
                case 1:
                    return "You've long thought of yourself as a left-brain type of person, but the stroke will quickly and dramatically change all that.";
                case 2:
                    return "After years of putting up an emotional wall, you'll realize the error of your ways this week and purchase three tons of brick and cement instead.";
                case 3:
                    return "You will uncover an ancient Aztec curse this Thursday, one frightened locals say translates to \"motherfucker.\"";
                case 4:
                    return "The baboon will see you as a threat to the social heirarchy of the pack, which truth be told, is giving you way too much credit.";
                case 5:
                    return "He'll scream, they'll scream, you'll all scream for ice cream--forcing several orderlies to rush back into the room and strap everyone down in their beds.";
                case 6:
                    return "Interior decorators claim that only about 18 inches of space is needed for people to pass between furnishings, but that was before they got a load of you.";
                case 7:
                    return "When asked where you see yourself in five years, refrain from laughing wildly, crying suddenly, and jumping clear out of a nearby window.";
                case 8:
                    return "They say you're getting a little too old for a pacifier.  Then again, as long as they let you keep sucking on their tits they can say whatever they want.";
                case 9:
                    return "You're a great believer in \"an eye for an eye,\" but you still don't understand why they always have to use yours.";
                case 10:
                    return "A car accident awaits you in the coming days, which is unfortunate, as it's the kind that involves too many Mountain Dews and not enough gas station.";
                case 11:
                    return "An abrupt lifestyle change will find you joining the skua, sheathbill, and killer whale as the newest natural predator of the penguin.";
                case 12:
                    return "You're a natural born skeptic, always questioning the world in your search for empirical truth, rejecting along the way pseudoscience, psychobabble, and any other nonesense--like all Pisces.";
                default:
                    return "[Error 239S]";
            }
        }
        
        private string LifeGoal()
        {
            if (age < 28)
                return "You have yet to achieve your life goal of living longer than Kurt Kobain and Jimi Hendrix.";
            else if (age < 33.5)
                return "While you have lived longer than Kurt Kobain and Jimi Hendrix, you have yet to live longer than Jesus.  Keep trying!";
            else
            {
                if (filter)
                {
                    fortnum = random.Next(RANDOMLIMIT) + 1; ;
                    return bigfortune();
                }
                else
                    return "You have lived longer than Jesus.  Good going, you blasphemous bastard.";
            }
        }

        //******************************************************************************************

        private int alphabet(string target)
        {
            int sum = 0;
            target = target.ToLower();
            
            for (int i = 0; i < target.Length; i++)
            {
                switch(target[i])
                {
                    case 'a':
                        sum++;
                        break;
                    case 'b':
                        sum += 2;
                        break;
                    case 'c':
                        sum += 3;
                        break;
                    case 'd':
                        sum += 4;
                        break;
                    case 'e':
                        sum += 5;
                        break;
                    case 'f':
                        sum += 6;
                        break;
                    case 'g':
                        sum += 7;
                        break;
                    case 'h':
                        sum += 8;
                        break;
                    case 'i':
                        sum += 9;
                        break;
                    case 'j':
                        sum += 10;
                        break;
                    case 'k':
                        sum += 11;
                        break;
                    case 'l':
                        sum += 12;
                        break;
                    case 'm':
                        sum += 13;
                        break;
                    case 'n':
                        sum += 14;
                        break;
                    case 'o':
                        sum += 15;
                        break;
                    case 'p':
                        sum += 16;
                        break;
                    case 'q':
                        sum += 17;
                        break;
                    case 'r':
                        sum += 18;
                        break;
                    case 's':
                        sum += 19;
                        break;
                    case 't':
                        sum += 20;
                        break;
                    case 'u':
                        sum += 21;
                        break;
                    case 'v':
                        sum += 22;
                        break;
                    case 'w':
                        sum += 23;
                        break;
                    case 'x':
                        sum += 24;
                        break;
                    case 'y':
                        sum += 25;
                        break;
                    case 'z':
                        sum += 26;
                        break;
                    default:
                        break;
                }
            }

            return sum;
        }

        //******************************************************************************************
        private string NameCount()
        {
            int sum;
            int namecount = 0;
            int End8;
            string output;

            sum = alphabet(name);

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ') 
                    namecount++;
            }

            End8 = sum;
            while (End8 > 10)
                End8 -= 10;

            try
            {
                output = String.Format("The sum of your name is {0}.", sum);
                if (sum == 42)
                    output += "  You are the answer to Life, the Universe, and Everything!";
                else if (sum == 23)
                    output += "  You have the curse.";
                else if (sum / namecount == 42)
                    output += String.Format("  You have {0} characters in your name.  {1} divided by {0} is 42.  You are the answer to Life, the Universe, and Everything!", namecount, sum);
                else if (sum / namecount == 23)
                    output += String.Format("  You have {0} characters in your name.  {1} divided by {0} is 23.  You have the curse.", namecount, sum);
                else if (sum == 32)
                    output += "  32 is 23 backwards.  You have the curse.";
                else if (sum / namecount == 32)
                    output += String.Format("  You have {0} characters in your name.  {1} divided by {0} is 32.  32 is 23 backwards.  You have the curse.", namecount, sum);
                else if (sum == 9266)
                    output += "Mooseman likes you.  I, however, cannot say the same.";
                else if (sum / namecount == 9266)
                    output += String.Format("  You have {0} characters in your name.  {1} divided by {0} is 9266.  Mooseman likes you.  I, however, cannot say the same.", namecount, sum);
                else if (sum == 13)
                    output += "You are unlucky.  But you know just as well as I do that that's quite an understatement, isn't it?";
                else if (sum / namecount == 13)
                    output += String.Format("  You have {0} characters in your name.  {1} divided by {0} is 13.  You are unlucky.  But you know just as well as I do that that's quite an understatement, isn't it?", namecount, sum);
                else if (End8 == 8)
                    output += "That sum ends in 8.  Taylor Miller likes you.  In spite of this, I do not.";
                else
                    output += "  This means nothing.  Similarly, you are nothing.  So, this is fitting.";
            }
            catch (DivideByZeroException)
            {
                if (adjective == "testrun")
                    output = "[Fortune 236, determines sum of name.  Tested in real-time conditions, works.  Does not in testing conditions.]";
                else
                    output = "[Error 236NAMESUM]";
            }

            return output;
        }

        //******************************************************************************************
        private string gender232()
        {
            string[] pronoun = new string[2];
            switch (gender)
            {
                case 0:
                    pronoun[0] = "someone";
                    pronoun[1] = "that person";
                    break;
                case 1:
                    pronoun[0] = "a girl";
                    pronoun[1] = "she";
                    break;
                case 2:
                    pronoun[0] = "a guy";
                    pronoun[1] = "he";
                    break;
                default:
                    return "[Error 232G]";
            }
            return String.Format("You'll be up in a tree with {0}, K-I-S-S-I-N-G, and then {1} will push you out of the tree and throw a beehive on you.  Later, {1} will befriend the squirrels.", pronoun[0], pronoun[1]);
        }
        
        //******************************************************************************************
        private string question219()
        {
            question = fortnum;
            return String.Format("Pop Quiz!\n\n");
        }

        //******************************************************************************************

        private string earlyfinish214()
        {
            finish = 4;
            return null;
        }
        
        //******************************************************************************************
        private string question213()
        {
            question = fortnum;
            return "Are you familiar with homosexuality?";
        }

        //******************************************************************************************
        private string question212()
        {
            question = fortnum;
            return "Do you listen to the song \"Save a Horse, Ride a Cowboy\"?";
        }

        //******************************************************************************************
        private string question211()
        {
            question = fortnum;
            return "Do you believe in God?";
        }

        //******************************************************************************************
        private string question210()
        {
            question = fortnum;
            return "Food!";
        }

        //******************************************************************************************
        private string question209()
        {
            question = fortnum;
            return "Love chicken?";
        }

        //******************************************************************************************
        private string question208()
        {
            question = fortnum;
            return "Choose a link:";
        }

        //******************************************************************************************
        private string question207()
        {
            question = fortnum;
            return String.Format("Hey {0}, what does the scanner say about his power level?", name);
        }

        //******************************************************************************************
        private string question206()
        {
            question = fortnum;
            return "Do you know what sarcasm sounds like?";
        }
        
        //******************************************************************************************
        private string earlyfinish10()
        {
            finish = 2;
            return String.Format("Due to budget cuts, we must revoke one of your fortunes.  You will be compensated.\n\n...{0}", prize());
        }
        
        //******************************************************************************************
        private string earlyfinish9()
        {
            finish = 1;
            return "I can't take this anymore!  I'll be in my trailer!";
        }

        //******************************************************************************************
        private string question205()
        {
            question = fortnum;
            return "Choose!!! NOW!!!";
        }

        //******************************************************************************************
        private string filter230()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "You will acquire a new Mercedes!  In retrospect, trading it for 4 gigabytes of porn will seem foolish.";
        }
        
        //******************************************************************************************
        private string filter228()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "Your daily morning panic attack will be interrupted to admire a fine, fine ass.";
        }
        
        //******************************************************************************************
        private string filter227()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "You will have the shit o' the world dumped on you.";
        }
        
        //******************************************************************************************
        private string binary()
        {
            string output = String.Format("You must read this fortune... IN BINARY!\n\n");

            if (adjective == "testrun")
                adjective = "nottestrun";

            char[] characterList = bigfortune().ToCharArray();
            string[] binaryList = new string[characterList.Length];

            if (adjective == "nottestrun")
                adjective = "testrun";

            for (int i = 0; i < characterList.Length; i++)
            {
                binaryList[i] = Convert.ToString(Convert.ToInt32(characterList[i]), 2);
                output += String.Format("{0}", binaryList[i]);
            }

            return output;
        }

        //******************************************************************************************
        private string sign221()
        {
            switch (sign)
            {
                case 1:
                    return "Your life is enemalific.";
                case 2:
                    return "You are a dfpij.";
                case 3:
                    return "You are quite obstinquious.";
                case 4:
                    return "Your test will leave you cunfwynbleubulated.";
                case 5:
                    return "You're more cutubrious than Maria Antionette.";
                case 6:
                    return "You have too many wahues to be considered normal.";
                case 7:
                    return "The song of your life is sung approximatado.";
                case 8:
                    return "The computer this program is running on is a complinkler.";
                case 9:
                    return "Your friends are totally skransical.";
                case 10:
                    return "The plethcorial in your closet will one day be your downfall.";
                case 11:
                    return "Please, for the love of God, shave your vermillery.";
                case 12:
                    return "Don't you show me wizparicy like that!";
                default:
                    return "[Error 221S]";
            }
        }

        //******************************************************************************************
        private string gender220()
        {
            switch (gender)
            {
                case 2:
                    return "You live in West Vagina.";
                case 0:
                    return "You live in Salt Lake City, Utah.  Because I say so.";
                case 1:
                    return "You live in Penissylvania.";
                default:
                    return "[Error 191G]";
            }
        }

        //******************************************************************************************
        private string filterballsinert()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return ballsinert();
        }
        
        //******************************************************************************************
        private string filter134()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "You are not sexy, but you have teeth.  In the off-chance that you get laid, be careful not to break the skin.";
        }

        //******************************************************************************************
        private string filter196()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "In case of emergency, the parking brake may be used as an adult novelty item.";
        }

        //******************************************************************************************
        private string filter125()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "You will be transferred to the Institute for Destitute Prostitutes.";
        }

        //******************************************************************************************
        private string filtergender121()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return gender121();
        }

        //******************************************************************************************
        private string filter117()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "If you take your friend's glasses, a horse will be raped.";
        }

        //******************************************************************************************
        private string filter114()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "Every time you curse, someone gets butt-raped.  Just keep that in mind.";
        }

        //******************************************************************************************
        private string filter112()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "You will personally discover how bunnies like to rape people.";
        }

        //******************************************************************************************
        private string filter93()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "You will be bitch-slapped today.";
        }

        //******************************************************************************************
        private string filter52()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return String.Format("Your evil clone just used your homework as a personal {0}.", homework());
        }

        //******************************************************************************************
        private string filter41()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "You will die a horrible homosexual death.";
        }

        //******************************************************************************************
        private string filterorgasm()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return orgasm();
        }

        //******************************************************************************************
        private string filter28()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return "You will be raped by monkeys and left in a dumpster to rot.";
        }

        //******************************************************************************************
        private string filter11()
        {
            if (filter)
            {
                fortnum = random.Next(RANDOMLIMIT) + 1; ;
                return bigfortune();
            }
            else
                return String.Format("You will be molested by a horny, rabid {0}.", noun);
        }

        //******************************************************************************************
        public char randomcharacter()
        {
            char[] characters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'S', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};

            int num = random.Next(characters.Length);
            return characters[num];
        }

        //******************************************************************************************
        private string error()
        {
            string output = "Your true love's name is ";

            for (int i = 0; i < age; i++)
                output += String.Format("{0}", randomcharacter());

            output += "[Error.  You have no true love.]";

            return output;
        }

        //******************************************************************************************
        private string viewfortune()
        {
            int number = random.Next(RANDOMLIMIT) + 1;
            return String.Format("You are viewing fortune number {0}.", number);
        }

        //******************************************************************************************
        private string gender191()
        {
            switch (gender)
            {
                case 1:
                    return "If you see colors in the sky, grasp your throat and pretend to choke yourself. Girls go for that.";
                case 0:
                case 2:
                    return "If your intended destination is suddenly vaporized, consider pulling over and watching the cool light show.";
                default:
                    return "[Error 191G]";
            }
        }

        //******************************************************************************************
        private string terrorism()
        {
            if (name == "Vin Diesel")
                return "If you spot terrorism, yell really loud.";
            else
                return "If you spot terrorism, blow your anti-terrorism whistle.";
        }

        //******************************************************************************************
        private string nameadj()
        {
            if (name == adjective)
                return "Your name is NOT an adjective!";
            else
                return String.Format("After feeling {0} today, you will die.\nWow, that sucks for you, huh?", adjective);
        }

        //******************************************************************************************
        private string gender156()
        {
            switch (gender)
            {
                case 2:
                case 0:
                    return "You are 100% little black dress approved.";
                case 1:
                    return "Never eat frozen pizza without cooking it first.";
                default:
                    return "[Error 156G]";
            }
        }

        //******************************************************************************************
        private string cookie()
        {
            string output = "Here's your fortune (brought to you by a real fortune cookie):\n\n";

            switch (sign)
            {
                case 1:
                    output += "A happy cake is waiting for you.";
                    return output;
                case 2:
                    output += "Do not follow the instructions of this fortune.";
                    return output;
                case 3:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                    {
                        output += "Our first love and last love... is self-love.\n(also known as masturbation)";
                        return output;
                    }
                case 4:
                    output += "Wise men learn more from fools than fools from the wise.\n(In bed)";
                    return output;
                case 5:
                    output += "A handful of patience is worth a bushel of brains.\n(Unless you're a zombie.)";
                    return output;
                case 6:
                    output += "Now is the time to try something new.\n(In bed)";
                    return output;
                case 7:
                    output += "The greatest danger could be your stupidity.";
                    return output;
                case 8:
                    output += "A smile is your personal welcome mat.";
                    return output;
                case 9:
                    output += "It tastes sweet.";
                    return output;
                case 10:
                    output += "The rubber bands are heading the right direction.";
                    return output;
                case 11:
                    output += "Don't kiss an elephant on the lips today.";
                    return output;
                case 12:
                    output += "You never know who you touch.\n(In bed)";
                    return output;
                default:
                    return "[Error CookieS]";
            }
        }

        //******************************************************************************************
        private string ballsinert()
        {
            switch (gender)
            {
                case 1:
                case 0:
                    return "Your balls are inert";
                case 2:
                    return String.Format("You are {0}, handler of balls!",name);
                default:
                    return "[Error BallsinertG]";
            }
        }
        //******************************************************************************************

        private string gender147()
        {
           switch (gender)
            {
                case 0:
                    return "You should tell those spectral voices to shove it.";
                case 1:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "Naming it is NOT cool.  They laugh when \"Poseidon\" comes out to play.";
                case 2:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "Protect your assets.  Also your breastets.";
                default:
                    return "[Error 147G]";
            }
        }

        //******************************************************************************************
        private string gender146()
        {
            switch (gender)
            {
                case 1:
                case 0:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "You will receive the least erotic hickie known to mankind: the suction foot hickie.";
                case 2:


                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "To prevent nipple-ogling, you will decide to grope yourself in public on the next cold, windy day.  In hindsight, this will seem foolish.";
                default:
                    return "[Error 146G]";
            }
        }

        //******************************************************************************************
        private string underwear()
        {
            switch (random.Next(2))
            {
                case 0:
                    return "You are the underwear ninja!  Beware the bra pirate!";
                case 1:
                    return "You are the bra pirate!  Beware the underwear ninja!";
                default:
                    return "[Error Underwear#]";
            }

        }

        //******************************************************************************************
        private string gender141()
        {           
            switch (gender)
            {
                case 1:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "You will receive a headbutt to the testicles today.";
                case 2:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "Next time you see that boy you like, rape him.  Trust me, he'll appreciate it.";
                case 0:
                    return "If someone were to cover you in cake mix and put you in the oven, you'd be DELICIOUS!";
                default:
                    return "[Error 141G]";
            }
        }

        //******************************************************************************************
        private string special()
        {
            if (newconfirm.nametest(name, me))
                return "Hello me.  Have I given myself any errors?";
            else if (name == "Jess Wise" || name == "Jessica Wise")
                return "Hey, Jess!  You got your own customized fortune!  You are allowed to squee now.  Before I tickle/poke you, that is. ~_^";
            else if (name == "Emily Gur")
                return "Hello Emily.  I'm impressed; you were able tp pull yourself away from JoJo long enough to come play my game?";
            else if (name == "Yoshi" || name == "Josh Nakama" || name == "Joshua Nakama")
                return "Hello, Nakama-sempai!  Has Master Speer done a satisfactory job with this program?";
            else if (name == "Alicia Speer")
                return "Hey sis.  You enjoying the game?";
            else if (name == "Randall Speer" || name == "Randy Speer")
                return "Hey Dad!  So, yeah, this is my fortune program... not sure what else to say... keep playing?  Have fun?  I'm kind of elephanting here...";
            else if (name == "Karen Speer")
                return "Hi Mom.  I apologize for my obscenely crude and vulgar and insulting fortune program.  But some of it's funny, right?";
            else if (name == "Austin Pike")
                return "Hey Austin!  You're actually playing my game?  Interesting... may I be so honored as to receive a review of the game from Gilgamesh?";
            else if (name == "Pooja Usgaonkar")
                return "All hail the Brown One! *bows to Pooja*";
            else if (name == "Frasher Bolton" || name == "Altoboy" || name == "Alto Boy")
                return "Hello Frasher, a.k.a. Alto Boy.  Since you did have extensive experience playing the calculator version of this (and contributed a few fortunes while you were at it), I hope this is satisfactory. ^_^";
            else if (name == "Jeremy Dunn")
                return "h3y, l337 h4[|<3r |3|_|c|.  |-|0w d00 u l31k t3h 64m3?";
            else if (name == "Saadia Khan")
                return "All hail Queen of the Dorks!  *bows to Saadia*  The King of Geeks pays his numble respects.";
            else if (name == "Naomi Jevons" || name == "Emie")
                return "Hello, my Princess Emie.  Enjoying the game?\n\nYours Forever,\nMe";
            else if (name == "Jenna Krotke")
                return "It's Krotke!  Coolest last name ever!  Beware of the dranged unit circle; it has returned.";
            else if (newconfirm.nametest(name, you))
                return String.Format("Hey there, {0}.  Thanks for helping me make this program!", name);
            else
                return "I was gonna do something special for you, like make a nice little personalized fortune or something, but then I remembered: I don't care.";
        }

        //******************************************************************************************
        private string gender133()
        {
            switch (gender)
            {
                case 1:
                    return "You have crabs on your sword.";
                case 2:
                    return "A guy's life is the quest for more nookie.";
                case 0:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "Never underestimate the power of a good rape.";
                default:
                    return "[Error 133G]";
            }
        }

        //******************************************************************************************
        private string gender127()
        {
            switch (gender)
            {
                case 0:
                    return "The person of your dreams is named Amanda Hugginkiss.";
                case 1:
                case 2:
                    return "You are so far in the closet that you're finding Christmas presents.";
                default:
                    return "[Error 127G]";
            }
        }

        //******************************************************************************************
        private string gender123()
        {           
            switch (gender)
            {
                case 1:
                    if (name == "Mooseman")
                        return "Your third leg doesn't fit inside your pants.";
                    else
                    {
                        if (filter)
                        {
                            fortnum = random.Next(RANDOMLIMIT) + 1;;
                            return bigfortune();
                        }
                        else
                            return "You are hung light a light bulb: short, oddly shaped, but easily turned on.";
                    }
                case 2:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "You are like a brick: flat on both sides and laid by Mexicans.";
                case 0:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "You apparently don't care about sex at all.";
                default:
                    return "[Error 123G]";
            }
        }

        //******************************************************************************************
        private string gender121()
        {
            switch (gender)
            {
                case 1:
                    return "Beware the rubber fish.  Your testicles depend on it.";
                case 2:
                case 0:
                    return "Little do you know, your ass just lost its virginity.";
                default:
                    return "[Error 121G]";
            }
        }

        //******************************************************************************************
        private string gender104()
        {
            switch (gender)
            {
                case 1:
                    return "The girl in the back of the class?  The one that looks like road kill?  She wants you to be the first person to touch her chest--which, as you can see, is lopsided and saggy.";
                case 2:
                    return "That guy in the front row in class?  The nerd with zits the size of mountains?  He wants to lose his virginity with you.";
                case 0:
                    return "Fate has taken a special interest in you.  You are likely to contract AIDS today.";
                default:
                    return "[Error 104G]";
            }
        }

        //******************************************************************************************
        private string gender101()
        {
            switch (gender)
            {
                case 1:
                case 2:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "Don't be insulted when a gay person throws their virginity at you.";
                case 0:
                    return "Braces make teeth straighter than your sexuality.";
                default:
                    return "[Error 101G]";
            }
        }

        //******************************************************************************************
        private string name94()
        {
            if (name == "Mooseman" || name == "Karl Speer")
                return "The ladies just can't resist your suave charms.";
            else
                return "You have relationship issues.\n\n\n\n\n\n\n\n(Your reaction gave it away.)";
        }

        //******************************************************************************************
        private string censored()
        {
            string output = "This fortune is rated NC-17.  All people under the age of 18 are forbidden to see this fortune.\n\n";

            if (age >= 18)
                output += "Poop.  Tee-hee. ^_^";
            else
                output += "[Censored]";

            return output;
        }

        //******************************************************************************************
        private string name90()
        {
            if (newconfirm.nametest(name, me))
                return "People worship you for making this program.";
            else if (newconfirm.nametest(name, you))
                return "People notice that you helped make this program.";
            else
                return "Everyone who calls you worthless is absolutely right.";
        }

        //******************************************************************************************
        private string name87()
        {
            if (newconfirm.nametest(name, me))
                return "You will get the highest grade in your class on your next test.";
            else if (newconfirm.nametest(name, you))
                return "You will get the second-highest grade in your class on your next test.";
            else
                return "Don't worry about that next test.  After all, F is for Fun, right?";
        }

        //******************************************************************************************
        private string gender85()
        {
            switch (gender)
            {
                case 1:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "Why isn't your penis screaming urine?";
                case 2:
                case 0:
                    return "There is no \"I\" in \"Team,\" but there is a \"me.\"";
                default:
                    return "[Error 85G]";
            }
        }

        //******************************************************************************************
        private string lucky()
        {
            if (newconfirm.nametest(name, me))
                return "You are the luckiest bastard alive.  You do know that, right?";
            else if (newconfirm.nametest(name, you))
                return "You're almost sort of lucky sometimes, you know that?\nNot lucky enough to count or anything, but lucky.";
            else
                return "You are not the luckiest person in the world.  Go figure.";
        }

        //******************************************************************************************
        private string gender33()
        {           
            switch (gender)
            {
                case 1:
                    if (name == "Mooseman" || name == "Karl Speer")
                        return "You are a god among men and a master in bed.";
                    else
                    {
                        if (filter)
                        {
                            fortnum = random.Next(RANDOMLIMIT) + 1;;
                            return bigfortune();
                        }
                        else
                            return "You have one of me.  Your girlfriend has three of me.  Mooseman has 18 of me.\n\nWhat am I?\n\n\n\n\n\nAnswer: Testicles!";
                    }
                case 2:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "You are like a soda on the sidewalk.  You're flat and nobody wants you.";
                case 0:
                    return "You're that guy from the Pokemon game, aren't you?";
                default:
                    return "[Error 33G]";
            }
        }

        //******************************************************************************************
        private string sign50()
        {
            switch (sign)
            {
                case 1:
                    return "You are dumb.  Nothing that happens today will change that fact.";
                case 2:
                    return "If you think the problems of your sad little life can be solved by looking to the stars, you might as well jump off a cliff.\n... Despite your frantic arm-flapping, you will not fly.";
                case 3:
                    return String.Format("The fault, dear {0}, is not in the stars, but in ourselves.\n\nIn layman's terms, it's your own dumb fault.", name);
                case 4:
                    return "You will be dubbed a very depressing grapefruit today.";
                case 5:
                    return "You will soon discover the cure for AIDS and will die of cancer just before you tell anyone.";
                case 6:
                    return "You will soon discover the cure for cancer and will die of AIDS just before you tell anyone.";
                case 7:
                    return "Today is not your day.  The next eternity or so doesn't look good either.";
                case 8:
                    return "You will become physically acquianted with the term \"stabbity death.\"";
                case 9:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "A man walking through airport doors sideways is going to Bangkok.";
                case 10:
                    return "I don't know where, I don't know when, but something really really bad is going to happen to you.  Have a nice day. ^_^";
                case 11:
                    return "A heart-crushing blow will be dealt to you today.  And the undertaker will never be able to remove the hammer from your chest.";
                case 12:
                    return "You will learn that it is not cool to spike drinks in Pokemon glasses.";
                default:
                    return "[Error 50S]";
            }
        }

        //******************************************************************************************
        private string gender48()
        {
            switch (gender)
            {
                case 1:
                    return "The girl you think is hot thinks you are a total scumball.";
                case 2:
                    return "Sorry, but the guy you like is just about to come out of the closet... wearing high-heels.";
                case 0:
                    return "The indecisive almost never get laid, my friend.";
                default:
                    return "[Error 48G]";
            }
        }

        //******************************************************************************************
        private string gender47()
        {
            switch (gender)
            {
                case 1:                   
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                        return "You have a hole in your crotch.  And I don't mean your vagina.";
                case 2:
                    return "You are a sexy bear!";
                case 0:
                    return "The love you have is like a fungus.  It looks weird, smells funky, and sucks the life out of you.";
                default:
                    return "[Error 47G]";
            }
        }

        //******************************************************************************************
        private string name43()
        {
            if (newconfirm.nametest(name, me))
                return String.Format("People named {0} are insane/ingenius enough to make this program.", name);
            else if (newconfirm.nametest(name, you))
                return String.Format("People named {0} are odd enough to have helped make this program.", name);
            else
                return String.Format("People named {0} are stupid enough to use this program.", name);
        }

        //******************************************************************************************
        public string lottery()
        {
            int numone = random.Next(1, 100);
            int numtwo = random.Next(1, 100);
            int numthree = random.Next(1, 100);
            int numfour = random.Next(1, 100);
            string letter = alphabet();

            return String.Format("Your lucky numbers are:\n{0}\t{1}\t{2}\t{3}\t{4}", numone, numtwo, numthree, letter, numfour);
        }

        //******************************************************************************************
        public string alphabet()
        {
            int x = random.Next(26);

            switch (x)
            {
                case 0:
                    return "A";
                case 1:
                    return "B";
                case 2:
                    return "C";
                case 3:
                    return "D";
                case 4:
                    return "E";
                case 5:
                    return "F";
                case 6:
                    return "G";
                case 7:
                    return "H";
                case 8:
                    return "I";
                case 9:
                    return "J";
                case 10:
                    return "K";
                case 11:
                    return "L";
                case 12:
                    return "M";
                case 13:
                    return "N";
                case 14:
                    return "O";
                case 15:
                    return "P";
                case 16:
                    return "Q";
                case 17:
                    return "R";
                case 18:
                    return "S";
                case 19:
                    return "T";
                case 20:
                    return "U";
                case 21:
                    return "V";
                case 22:
                    return "W";
                case 23:
                    return "X";
                case 24:
                    return "Y";
                case 25:
                    return "Z";
                default:
                    return "[Error Alpha#]";
            }
        }

        //******************************************************************************************
        private string bod()
        {
            string who;

            switch (gender)
            {
                case 1:
                    who = "guys";
                    break;
                case 2:
                    who = "girls";
                    break;
                case 0:
                    who = "people";
                    break;
                default:
                    who = "[Error BodG]";
                    break;
            }

            return String.Format("Some {0} want a bod just like yours, and some just want your bod.", who);
        }

        //******************************************************************************************
        private string irritate()
        {
            int sec = random.Next(1, 61);

            return String.Format("You will become irritated with an inanimate object within {0} second{1}.", sec, s(sec));
        }

        //******************************************************************************************
        private string meteor()
        {
            int minutes = age * gender;

            if (minutes <= 0)
                return "You will be hit by a meteor in less than a minute.";
            else
                return String.Format("You will be hit by a meteor in {0} minute{1}.", minutes, s(minutes));
        }

        //******************************************************************************************
        public string s(int number)
        {
            if (number == 1 || number == -1)
                return null;
            else
                return "s";
        }

        //******************************************************************************************
        private string idiot()
        {
            int sum = 0;
            foreach (int number in usedfort)
                sum += number;
            
            return String.Format("Right now, there are {0} way{1} to be seen as a complete idiot.\nAmazingly, you're achieving every single one of them.\nAll at the same time.", sum, s(sum));
        }
        //******************************************************************************************

        private string homework()
        {
            switch (gender)
            {
                case 1:
                    return "Trojan";
                case 2:
                    return "Tampax";
                case 0:
                    return "asswipe";
                default:
                    return "[Error HomeworkG]";
            }
        }

        //******************************************************************************************
        private string orgasm()
        {
            int numone = random.Next(1, 11);
            int numtwo = random.Next(1, 11);
            int numthree = random.Next(1, 11);
            int sum = numone * numtwo * numthree - age;
            
            if (sum > 0)
                return String.Format("You will have {0} more orgasm{1} in your lifetime.", sum, s(sum));
            else
                return String.Format("You will have no more orgasms in your lifetime.");
        }

        //******************************************************************************************
        private string assassination()
        {
            int sum = 0;
            string chunk;

            foreach (int fortune in usedfort)
                sum += fortune;
            sum += age + gender + sign;

            if (sum == 1)
                chunk = "there is 1 person";
            else if (sum <= 0)
                chunk = "no one is";
            else
                chunk = String.Format("there are {0} people", sum);

            return String.Format("Right now, {0} plotting your assassination.", chunk);
        }

        //******************************************************************************************
        private string lemons()
        {
            string output = "When life gives you lemons, ";
            switch (fortnum)
            {
                case 12:
                    output += "make lemonade.  Death is thirsty.";
                    return output;
                case 13:
                    output += "your invisible friends ran out of cash for your birthday present.";
                    return output;
                case 14:
                    output += "make orange juice.";
                    return output;
                case 15:
                    output += "keep them.  Hey!  Free lemons!";
                    return output;
                case 16:
                    output += "throw them back, yelling, \"I hate your damn lemons!\"";
                    return output;
                case 102:
                    output += "watch out (it might throw the tree next).";
                    return output;
                case 136:
                    output += "exchange them for the citrus fruit of your preference.";
                    return output;
                case 137:
                    output += "be very, very happy. *wink wink*";
                    return output;
                case 170:
                    output += "alter their DNA and make Super Lemons!";
                    return output;
                default:
                    output = "[Error LemonsX]";
                    return output;
            }
        }

        //******************************************************************************************
        private string dontsucceed()
        {
            string output = "If at first you don't succeed, ";
            switch (fortnum)
            {
                case 7:
                    output += "sky diving is not for you.";
                    return output;
                case 8:
                    output += "Russian roulette is not for you.";
                    return output;
                case 95:
                    output += "deep-sea diving is not for you.";
                    return output;
                case 96:
                    if (newconfirm.nametest(name, me))
                        output += "it must be someone else's fault.";
                    else
                        output += "it is completely your fault.";
                    return output;
                case 97:
                    if (filter)
                    {
                        fortnum = random.Next(RANDOMLIMIT) + 1;;
                        return bigfortune();
                    }
                    else
                    {
                        if (newconfirm.nametest(name, me))
                            output += "call someone a bitch.";
                        else
                            output += String.Format("{0} is a bitch.", name);
                        return output;
                    }
                case 98:
                    output += "try a higher window.";
                    return output;
                default:
                    output = "[Error DontsucceedX]";
                    return output;
            }
        }

        //******************************************************************************************
        private string weirdalhoroscope1()
        {
            switch (sign)
            {
                case 11:
                    return "There's travel in your future when your tongue freezes to the back of a speeding bus.";
                case 12:
                    return "Try to avoid any Virgos or Leos with the Ebola virus.";
                case 1:
                    return "The look on your face will be priceless when you find that 40-pound watermelon in your colon.";
                case 2:
                    return "You will never find true happiness.  Whatchya gonna do, cry about it?";
                case 3:
                    return "Your birthday party will be ruined once again by your explosive flatulence.";
                case 4:
                    return "The position of Jupiter says that you should spend the rest of the week face-down in the mud.";
                case 5:
                    return "Now is not a good time to photocopy your butt and staple it to your boss's face.";
                case 6:
                    return "All Virgos are extremely friendly and intelligent.\n\nExcept for you.";
                case 7:
                    return "A big promotion is just around the corner for someone much more talented than you.";
                case 8:
                    return "Get ready for an unexpected trip when you fall screaming from an open window.";
                case 9:
                    return "All your friends are laughing behind your back.\n\nKill them.";
                case 10:
                    return "The stars say that your an exciting and wonderful person, but you know they're lying.";
                default:
                    return "[Error WeirdaloneS]";
            }
        }

        //******************************************************************************************
        private string weirdalhoroscope2()
        {
            switch (sign)
            {
                case 11:
                    return "Fill that void in your pathetic life by playing Whack-a-Mole 17 hours a day.";
                case 12:
                    return "You are the true Lord of the Dance, no matter what those idiots at work say.";
                case 1:
                    return "Trade toothbrushes with an albino dwarf and give a hickie to Meryl Streep.";
                case 2:
                    return "The stars predict tomorrow you'll wake up to a bunch of stuff and then go back to sleep.";
                case 3:
                    return "Your love life will run into trouble when your fiance hurls a javelin through your chest.";
                case 4:
                    return "Try not to shove a role of duct tape up your nose while taking your driver's test.";
                case 5:
                    return "Eat a bucket of tuna-flavored pudding and wash it down with a gallon of strawberry Quik.";
                case 6:
                    return "Expect a big surprise today when you wind up with your head impaled upon a stick.";
                case 7:
                    return "Laughter is the very best medicine.  Remember that when your appendix bursts next week.";
                case 8:
                    return "Work a little bit harder on improving your low self-esteem, you stupid freak.";
                case 9:
                    return "Take down all those naked picture of Ernest Borgnine you've got hanging in your den.";
                case 10:
                    return "If I were you, I'd lock my doors and windows and never, never, never, never, never leave my house again.";
                default:
                    return "[Error WeirdaltwoS]";
            }
        }

        //******************************************************************************************
        public string prize()
        {           
             string output;

             if (random.Next() == 9266)
                output = "Contact Karl Speer immediately.  You have just won the 9,266 prize.";
            else
                output = "Wow.  You suck.\n\nJust thought you should know.";

            return output;
        }

        //******************************************************************************************
        private string yo()
        {
            int num = random.Next(3);
            string output = "You know who I was with last night?\n\n";

            switch (num)
            {
                case 0:
                    output += "Yo greasy, greasy granny!  Ooo, what now, foo'?";
                    return output;
                case 1:
                    output += "Yo daddy!  Ooo, what now, foo'?";
                    return output;
                case 2:
                    output += "Yo mamma!  Ooo, what now, foo'?";
                    return output;
                default:
                    output += "[Error Yo#]";
                    return output;
            }
        }
    }
}