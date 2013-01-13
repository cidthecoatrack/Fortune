using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune_2._1
{
    public partial class StraightFortune: Fortune
    {
        int Index;

        public StraightFortune(int Index)
        {
            this.Index = Index;
        }
        
        public string ToString()
        {            
            switch (Index)
            {
                case 1:
                    return "Now you may find it inconceivable or at the very least a bit unlikely that the relative positions of the planets and the stars can have a special, deep significance or meaning that exclusively applies to only you, but let me give my assurance that these forcasts and predications are all based on solid scientific documented evidence, so you would have to be some kind of moron not to realize that every single one of them is absolutely true.\n\nWhere was I?";
                case 2:
                    return "You are like pi; you are completely irrational.";
                case 3:
                    return "You are like compex mathematics; you have no simple solution.";
                case 4:
                    return "When life gives you strawberries... wait, I messed up... crap.";
                case 5:
                    return "You will invent the Pepto-Bismal-flavored donut.";
                case 6:
                    return "In all honesty, no one really wants to hear what you have to say.";
                case 7:
                    return "42.";
                case 8:
                    return "After claiming that \"NASA is the place where they do spacey stuff,\" you will lose the science fair.";
                case 9:
                    return "Ducks will fall from the sky in your honor.";
                case 10:
                    return "Your loved ones love you very much.  They'd love you more if you'd just shut up already.";
                case 11:
                    return "You do realize you're asking a computer program made by a high school student for your fortune, right?";
                case 12:
                    return "You will be told a completely bogus fortune today.";
                case 13:
                    return "You were Michael Jackson in a past life.";
                case 14:
                    return "Your life has merely been a figment of your imagination.  Try that one on for size.";
                case 15:
                    return "You fail at life.\n\n*deep inhalation* Mmm, I can almost smell the failure.";
                case 16:
                    return "Nazi penguins will take over the world if you use another fortune.";
                case 17:
                    return "You suck.  You don't get a fortune.";
                case 18:
                    return "You will be attacked by rabid ninja monkeys who will eat your soul.";
                case 19:
                    return "You are about to witness the most spectacular fortune ever!\nIt is so amazing that you will be astounded by its sheer awesomeness!\nCrossbreed magazine gives it 5 thumbs up!  \"It's something every human being should base every aspect of their life on.\"\nBrendan MacCormic says that this fortune is the most incredible thing since nanotechnology!\nJK Hoffman says that every rose has its thorn, just like every cowboy sings a sad, sad song, just like this fortune!\nAnd now, without further ado, the best fortune in the history of all fortunes!";
                case 20:
                    return "You have received the ultimate fortune.  You are welcome.";
                case 21:
                    return "In the future, you will eat the cutest babies...";
                case 22:
                    return "You have no future.  You are going to die alone and naked.";
                case 23:
                    return "Tomorrow, you will feel like death on a Trisquit.";
                case 24:
                    return "All of your teachers are sure that you must be the missing link.";
                case 25:
                    return "Your mother was a hamster and your father smelled of elderberries.";
                case 26:
                    return "Krambo will eat you.";
                case 27:
                    return "You will succumb to scientific poking in the near future.";
                case 28:
                    return "I know who you did last summer.";
                case 29:
                    return "You are deep like a sheep.";
                case 30:
                    return "You make the retarded chocobos look smart.";
                case 31:
                    return "You will have a close encounter with Mr. Herpes today.";
                case 32:
                    return "You will find an earring today and get infected with AIDS.";
                case 33:
                    return "Your intelligence will be multipled a hundredfold today--and yet, you will be unable to progress beyond the special education classes.";
                case 34:
                    return "Chuck Norris approves of this program, but he does not approve of you.  You have been warned.";
                case 35:
                    return "I look forward to killing you soon.";
                case 36:
                    return "You will be viciously sporked to death.";
                case 37:
                    return "Congratulations!  You have found the legendary Missing Fortune!";
                case 38:
                    return "What would you do if I wasted one of your fortunes to ask you a pointless rhetorical question?";
                case 39:
                    return "I hate to break it to you, but size does matter.  A lot.";
                case 40:
                    return "You will graduate from Ninja Tech.";
                case 41:
                    return "If pigs could fly, they would defecate all over you.";
                case 42:
                    return "This program gives a $10,000,000 donation for every victim in the Survivors of Chuck Norris's Roundhouse Kick Foundation.  So far, we've made a dollar.";
                case 43:
                    return "You have a big zit on your neck.\nNo, wait, sorry, that's your face.";
                case 44:
                    return "In your language class, you will learn how to circumcise innocent stick figures.";
                case 45:
                    return "You will be maimed by fish-sucking weasels from hell (otherwise known as lawyers).";
                case 46:
                    return "You have a short atten--ooo, a quarter!";
                case 47:
                    return "Someone is talking about you.  RIGHT NOW!";
                case 48:
                    return "Um... I forgot your fortune... sorry...";
                case 49:
                    return "The Anti-Christ has come, and his name is Furbie.";
                case 50:
                    return "Help!  I'm being forced to work in a programming factory!";
                case 51:
                    return "You are economically retarded.";
                case 52:
                    return "Right now, someone is receiving this fortune.";
                case 53:
                    return "You will be mauled by the uber-bunny.";
                case 54:
                    return "The men in white coats have lied to you.  Bunnies, kittens, and puppy dogs all really DO die!";
                case 55:
                    return "All your dreams will be hopelessly and heartlessly crushed.";
                case 56:
                    return "You are illiteritabit.";
                case 57:
                    return "Thanks to you, the fate of humanity shall be decided by a Dance Dance Revolution competition between God and the Devil.";
                case 58:
                    return "You will be forced to sing the Medley of Doom.";
                case 59:
                    return "Tomorrow will be cold.  Wear long-sleeve pants.";
                case 60:
                    return "You can procrastinate like there's no tomorrow.";
                case 61:
                    return "You owe someone a free grab upon your arse.";
                case 62:
                    return "By watching the OC, you will manage to get into all advanced classes and pass with all A's.";
                case 63:
                    return "If it's any comfort, llamas accept you just the way you are.";
                case 64:
                    return "Who's that behind you?\n\n\n\n\n\n\n\n(Made you look.)";
                case 65:
                    return "Your life is full of bottomless sorrow and topless gaiety.";
                case 66:
                    return "You have temporarily been demoted to nonexistant.";
                case 67:
                    return "Beware!  Death Bunny likes to stick his carrots where they don't belong!";
                case 68:
                    return "You will be locked in a box with pictures of Abraham Lincoln.  Naked.";
                case 69:
                    return "By passing your fruit juice around at lunch, you will contract herpes.";
                case 70:
                    return "In the annals of history, you will not be nameless; you will be Choreographer #2!";
                case 71:
                    return "You must go out and ninja in the night.";
                case 72:
                    return "If your true love did drugs, you would finally have someone to date.";
                case 73:
                    return "I was thinking about giving you a nice fortune, but then I remembered: I never give nice fortunes.";
                case 74:
                    return "You will be glomped by someone's car.";
                case 75:
                    return "Beware!  The blacksmith will turn into a dragon and eat you!";
                case 76:
                    return "You will almost get a date, but will be passed over in favor of an epiphany.";
                case 77:
                    return "You will use quantum physics and burnt toast to achieve immortality.";
                case 78:
                    return "You will get a Mustache o' Herpes for your birthday.";
                case 79:
                    return "In Soviet Russia, fortune gets you!";
                case 80:
                    return "You will soon be so happy that random pedestrians will join you in complicated dance routines!";
                case 81:
                    return "Congratulations!  You just won a smack in the face!";
                case 82:
                    return "Remember, Jesus loves you, but everyone else thinks you're an idiot.";
                case 83:
                    return "Why not make someone's day?  Stick out your butt and sing \"Singing in the Rain\"?";
                case 84:
                    return "The only time success comes before work is in the dictionary.  That's a hint, you lazy bum.";
                case 85:
                    return "I'm sorry, your fortune has been misplaced.  You will be notified when it is located.  Thank you.  Have a nice day.";
                case 86:
                    return "You don't need a parachute to go skydiving.  You need a parachute to go skydiving twice.";
                case 87:
                    return "An alien of some sort will be appearing to you shortly!";
                case 88:
                    return "Life is not a struggle.  It's a wiggle.";
                case 89:
                    return "This fortune was divined in a mere 0.195 seconds.  If it took longer than that, smack your computer upside the head.";
                case 90:
                    return "You are not illiterate.";
                case 91:
                    return "Alas!  The onion you are eating is someone else's flower lily!";
                case 92:
                    return "When you have a fat friend, there are no see-saws: only catapults.";
                case 93:
                    return "You are less nurturing than a desert.";
                case 94:
                    return "You will be violently beaten by teens with baseball bats on Halloween.  In retrospect, a pinata will not be the best choice of costume.";
                case 95:
                    return "If you set yourself on fire, do not run.";
                case 96:
                    return "If you spot a terrorist arrow, pin it against the wall with your shoulder.";
                case 97:
                    return "If you are sprayed with an unknown substance, stand and think about it instead of seeing a doctor.";
                case 98:
                    return "To eliminate smallpox, wash with soap, water and at least one armless hand under a faucet with no sink.";
                case 99:
                    return "Michael Jackson is a terrorist. If you spot this smooth criminal with scary eyes, run away.";
                case 100:
                    return "People, animal corpses, and the biohazard symbol are all at risk of being sucked into time-tunnel vortexes.";
                case 101:
                    return "Be on the lookout for terrorists with pinkeye and leprosy.";
                case 102:
                    return "If a door is closed, karate chop it open.";
                case 103:
                    return "If your building collapses, climb under your table and practice yoga.";
                case 104:
                    return "Try to absorb as much radiation as possible with your groin. The current world record is 5 minutes, 12 seconds.";
                case 105:
                    return "After exposure to radiation it is important to consider that you may have mutated to gigantic dimensions: watch your head.";
                case 106:
                    return "If you've become a radioactive mutant with a deformed hand, remember to close the window. No one wants to see that.";
                case 107:
                    return "If you hear the Backstreet Boys, Michael Bolton or Yanni on the radio, cower in the corner or run like hell.";
                case 108:
                    return "Your respiratory and digestive systems are optional. Cast them aside if you feel you no longer need them.";
                case 109:
                    return "If you are trapped under falling debris, conserve oxygen by not farting.";
                case 110:
                    return "Do not drive station wagons with a utility pole protruding from the hood.";
                case 111:
                    return "A one-inch thick piece of plywood should be sufficient protection against radiation.";
                case 112:
                    return "That closet door in your bedroom leads to the gates of Hell. Don't go there.";
                case 113:
                    return "The middle of a terrorist attack is not an appropriate time to catch up on your reading or paperwork.";
                case 114:
                    return "If the weather is overcast with dark skies, look for worms in the grass.";
                case 115:
                    return "After all life is gone, I will still live. Think about it.";
                case 116:
                    return "Your telephone may be a practicing physician.";
                case 117:
                    return "Only the coolest irradiated citizens will be allowed into the 'underground' rave in the shelter.  You are not among the coolest irradiated citizens.";
                case 118:
                    return "There is a reason you failed chemistry.";
                case 119:
                    return "Watch out for people who come out of white tents and try to steal the shirt off your back.";
                case 120:
                    return "If you are trapped with no hope of being found, amuse yourself in your final moments with shadow puppets.";
                case 121:
                    return "Satellite photos show the large embarrassing radioactive crop circle on your left butt cheek.";
                case 122:
                    return "When looting, remember to consider the weight/value ratio.";
                case 123:
                    return "Ooo, you're really better off not knowing this one, trust me.";
                case 124:
                    return "After reading this fortune, your eyes will be broken.";
                case 125:
                    return "If you're really happy, don't worry; there's a mac truck around the corner with your name on it.";
                case 126:
                    return "You are dismal.";
                case 127:
                    return "You will eat lead paint for lunch.  Yum!";
                case 128:
                    return "Your offspring shall resemble giant mechanical space crabs.";
                case 129:
                    return "Despite your best efforts, you will be unable to pronounce an apostrophe.";
                case 130:
                    return "Despite what you believe, what you see when you open a box of Cheerios are not donut seeds.";
                case 131:
                    return "After having sex with a less-than-desirable person, you will contract a horrible STD called \"babies\".";
                case 132:
                    return "Your crime will be discovered.  You sick bastard.";
                case 133:
                    return "You will manage a great feat of instant BS today.";
                case 134:
                    return "Your life is made of epic fail and awkward turtles.";
                default:
                    return "STOP";
            }
        }
    }
}
