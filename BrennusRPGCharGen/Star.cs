using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrennusRPGCharGen
{

    enum StarType
    {
        No_Star,
        Living_Star,
        Dead_Star,
        // Dead Stars
        Black_Hole,
        D1,
        D2,
        Failed_Star,
        // Normal Stars
        Y,
        L,
        M,
        K,
        G,
        F,
        O,
        // Living Stars
        Supernova,
        Exotic_Star,
        Binary_Star,
        Star_Forge,
        Quasar,
        White_Hole
    }

    class Star
    {
        StarType type;

        string description;

        int tierModifier;
        int numDreams;
        int numNightmares;
        double DVModifier;

        public Star() { }

        Star(StarType t, string desc, int tierMod, int numD, int numNM, double DVmod)
        {
            Type = t;
            description = desc;
            tierModifier = tierMod;
            numDreams = numD;
            numNightmares = numNM;
            DVModifier = DVmod;
        }

        public static readonly Star No_Star = new Star(StarType.No_Star, "You have no powers. Totally ordinary", 0, 0, 0, 0);
        public static readonly Star Living_Star = new Star(StarType.Living_Star, "Lucky. Look at the rules.", 0, 0, 0, 0);
        public static readonly Star Dead_Star = new Star(StarType.Dead_Star, "Uh-Oh. Look at the rules.", 0, 0, 0, 0);

        public static readonly Star Black_Hole = new Star(StarType.Black_Hole, "Something went wrong. Your power is utterly, inherently broken.", +2, 4, 10, 3);
        public static readonly Star D1_Star = new Star(StarType.Y, "You will die. Either shortly, or over a longer, painful period, your power will kill you long before your natural end, either literally or figuratively.", +2, 5, 5, 2);
        public static readonly Star D2_Star = new Star(StarType.Y, "Your power is dying, fading away. At some point, you will be powerless again.", 1, 3, 5, -15);
        public static readonly Star Failed_Star = new Star(StarType.Y, "Your power failed to properly manifest, leaving it crippled, stillborn.", -2, 0, 5, 20);

        public static readonly Star Y_Star = new Star(StarType.Y, "Your powers are there, but they’re twisted.", -1, 0, 2, 15);
        public static readonly Star L_Star = new Star(StarType.L, "Your power is below average.", 0, 0, 1, 5);
        public static readonly Star M_Star = new Star(StarType.M, "You get an equal share of power and stability.", 0, 1, 1, 0);
        public static readonly Star K_Star = new Star(StarType.K, "Your power is just a little bit better than most.", 0, 1, 0, 5);
        public static readonly Star G_Star = new Star(StarType.G, "You get more power than most, in exchange for more drawbacks.", 0, 2, 1, 10);
        public static readonly Star F_Star = new Star(StarType.F, "There’s just something better about your power.", 0, 2, 0, 15);
        public static readonly Star O_Star = new Star(StarType.O, "Your power is one of the best of its type and class, barring those few exceptional cases that disregard the usual.", +1, 3, 1, 30);

        public static readonly Star Supernova = new Star(StarType.L,    "Your power is usually dormant, functioning at below-peak capacity. Reduce your power level by two." +
                                                        "You have the option to unleash your full power for short intervals of time.Increase your power level by three for the duration."+
                                                        "After your time of power is over, your power goes completely dormant, then recovers at regular intervals, until you are once more at two ranks below your actual power level, allowing you to unleash it again."
                                                        , -2, 3, 1, -20);
        public static readonly Star Exotic_Star = new Star(StarType.L,  "Your power does not shine as bright as others, but it shines in a far more diverse light." +
                                                        "Roll again for a second power - set with its own theme.Do not roll for the second set’s star, apply the modifiers from this result instead."+
                                                        "You cannot use both sets simultaneously.Whether or not and how you can control the switch between them is up to your Dreams, Nightmares and the others making up your powers."
                                                        , -1, 4, 2, 0.75);
        public static readonly Star Binary_Star = new Star(StarType.L,  "See Rules.", +1, 5, 2, 0);
        public static readonly Star Star_Forge = new Star(StarType.L,   "See Rules.", 0, 0, 0, 0);
        public static readonly Star Quasar = new Star(StarType.L,       "Your power is pulsing with potential, a living creature that lies within you." +
                                                        "You increase your tier by one or you get another power at the same level as your strongest power."+
                                                        "Your power gains a mind of its own, essentially giving you an ally that can act independently from you (through your power, not your body, and not necessarily to your satisfaction)."
                                                    , 0, 6, 2, 2);
        public static readonly Star White_Hole = new Star(StarType.L,   "Something just went incredibly right. For better or for worse, your power breaks the rules and reaches into what most people would call “the Divine”."+
                                                        "You have essentially transcended the system."+
                                                        "Your character will not be balanced."+
                                                        "You are, barring extreme circumstances, immune to having your powers or mind messed with."
                                                        , 999, 999, -999, -999);

        public StarType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
