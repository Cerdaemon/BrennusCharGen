using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrennusRPGCharGen
{
    class Dream
    {

        string name;
        string description;
        int dvModifier;
        int stack;


        public Dream()
        {
            name = "";
            description = "";
            dvModifier = 0;
            stack = 0;
        }

        Dream(string n, string d, int dv, int s)
        {
            Name = n;
            Description = d;
            DvModifier = dv;
            Stack = s;
        }



        public static readonly Dream Wetness = new Dream("Wetness", "Your power has a socially useful, but innocuous side. An advantage small enough not to accuse you of mind control.", 0, 1);
        public static readonly Dream Fragments = new Dream("Fragments", "Your power is more versatile than most..", 10, 0);
        public static readonly Dream Power = new Dream("Power", "Your power is just a bit stronger than most..", 5, 0);
        public static readonly Dream Peace = new Dream("Peace", "Your power is more stable than one would think.", -50, 0);
        public static readonly Dream Friends = new Dream("Friends", "You get to have more control over what your power will be. Take one aspect (besides the theme and the central concept) and tweak it to your liking", -5, 1);
        public static readonly Dream Freedom = new Dream("Freedom", "You have the potential to initiate a Swan Song.", 0, 1);
        public static readonly Dream Forests = new Dream("Forests", "Your power has an aspect that makes it very good for teamwork.", -5, 0);
        public static readonly Dream Life = new Dream("Life", "Your power has an aspect that makes it beneficial to others.", 5, 0);
        public static readonly Dream Family = new Dream("Family", "Your power is just a bit more protective and supporting than most (related to you).", -10, 0);
        public static readonly Dream Love = new Dream("Love", "Your power gets stronger when you approach the mindset/emotions you had during your manifestation.", 15, 1);
        public static readonly Dream Colours = new Dream("Colours", "Your power is a bit crazier than most. In a good way... maybe.", 20, 0);
        public static readonly Dream Harmony = new Dream("Harmony", "Your power is particularly well-suited to working together with other powers, and particularly good at heterodyning with appropriate powers.", -10, 1);
        public static readonly Dream Riches = new Dream("Riches", "Your power provides some manner of material reward or advantage.", -5, 1);
        public static readonly Dream Flying = new Dream("Flying", "Your power is easily controlled. Even if it would normally be brute, you can use it even for fine tasks.", -10, 2);
        public static readonly Dream Home = new Dream("Home", "Your power is soothing and supporting, a natural extension of your own self, speaking to a closely held belief, a dear ideal, to your very nature.", -25, 1);
        public static readonly Dream Rest = new Dream("Rest", "You no longer require one basic necessity of life (breath, food, drink, rest, sleep), though you can choose to partake in it", -10, 3);
        public static readonly Dream Angels = new Dream("Angels", "Some aspect of your power elevates it above and beyond other powers - a knack, a trick, something that makes it special", 20, 0);
        public static readonly Dream Yourself = new Dream("Yourself", "Your power changes and improves your body.", 0, 1);
        public static readonly Dream Defiance = new Dream("Defiance", "Your power has a hidden knack, an extra reserve, some kind of potential it holds back which goes beyond what it normally can do. You can only access this aspect when you are driven to the edge of your ability, when you are at the very verge of failing, giving you an extra boost.", 20, 1);
        public static readonly Dream Progeny = new Dream("Progeny", "Any person with a stable link to you is almost assured to manifest, given the circumstances. You provide twice the normal bonus to your link’s DV."+
                                                                    "Each time you roll this Dream again, double the Bonus you give to your links again."
                                                                    , 0, 0);
        public static readonly Dream Fantasia = new Dream("Fantasia", "Your power is at the top of its Tier. If you have multiple powers, apply this only to half of them (round down)."+
                                                                        "Reroll on this chart thrice, pick two."
                                                                        , -50, 0);



        //Properties
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int DvModifier
        {
            get
            {
                return dvModifier;
            }

            set
            {
                dvModifier = value;
            }
        }

        public int Stack
        {
            get
            {
                return stack;
            }

            set
            {
                stack = value;
            }
        }
    }
}
