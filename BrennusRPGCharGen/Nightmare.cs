using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrennusRPGCharGen
{
    class Nightmare
    {
        string name;
        string description;
        int dvModifier;
        int stack;


        public Nightmare()
        {
            name = "";
            description = "";
            dvModifier = 0;
            stack = 0;
        }

        Nightmare(string n, string d, int dv, int s)
        {
            Name = n;
            Description = d;
            DvModifier = dv;
            Stack = s;
        }



        public static readonly Nightmare Secrets = new Nightmare("Secrets", "The full extent of your power is hidden to you." +
                                                                "Either reduce the level, tier, or versatility, or, if you have multiple powers, keep a number of them secret from the character.The character’s power should be reduced by 25 % overall, whether in raw power, versatility or other aspects."+
                                                                "At some point(decided by the GM), the full extent of your power is revealed to you.It should somehow correlate with your trigger event."
                                                                , -10, 3);
        public static readonly Nightmare Lost_Woods = new Nightmare("Lost Woods" ,"You have a hard time staying yourself when using your power, getting lost in whatever emotions and/or traumata led to your manifestation.", 20, 1);
        public static readonly Nightmare Loss = new Nightmare("Loss", "Some part of your power costs you something every time you use it.", 10, 0);
        public static readonly Nightmare Enemies = new Nightmare("Enemies", "Your power puts you at odds with most decent people, unless they know you very well (and even then, not always).", 10, 1);
        public static readonly Nightmare Shadows = new Nightmare("Shadows", "Your power twists and deforms your body.", 0, 0);
        public static readonly Nightmare Monsters = new Nightmare("Monsters", "Your power twists your mind, making it hard for you to relate properly to others.", 50, 0);
        public static readonly Nightmare The_Dead = new Nightmare("The Dead", "Your power has a high risk of collateral damage or it is hard to use in non-lethal ways.", 20, 0);
        public static readonly Nightmare A_Witch = new Nightmare("A Witch", "Your power requires a fetish object (staffs, guns, etc). This object is not a part of your power, nor is this one specific item - you might need guns to channel your power through, but it doesn’t have to be a particular gun.", 10, 3);
        public static readonly Nightmare Abuse = new Nightmare("Abuse", "Your power requires other people as catalysts.", 20, 2);
        public static readonly Nightmare Lunacy = new Nightmare("Lunacy", "Your power waxes and wanes based on some circumstances outside, or mostly outside, your control. ", 10, 1);
        public static readonly Nightmare Strangers = new Nightmare("Strangers", "Your power cripples your mind, making it impossible for you to communicate/relate to others normally, if at all.", 35, 1);
        public static readonly Nightmare Discord = new Nightmare("Discord", "Your power does not play well with others. It is all but impossible for you to heterodyne it with others, and just using your power around others may disrupt their own powers in minor ways.", 20, 1);
        public static readonly Nightmare A_Fall = new Nightmare("A Fall", "You lack control over your power. Using it for delicate tasks is out of the question for you, and you can rarely use it casually.", -15, 3);
        public static readonly Nightmare Shame = new Nightmare("Shame", "Some part of your power actively violates a closely held, dear belief of yours, a standard, an ideal.", 50, 1);
        public static readonly Nightmare Demons = new Nightmare("Demons", "Your power actively manipulates you in some way towards its own ends, which are usually dependant on its theme.", 50, 3);
        public static readonly Nightmare The_Unknown = new Nightmare("The Unknown", "You have a blindspot in regards to your power, unable to truly grasp it.", 30, 1);
        public static readonly Nightmare Lack = new Nightmare("Lack", "You require one minor addition to your daily necessities in order to function properly (submerging yourself in water for a while, bathing in sunlight, tobacco, etc). Lack of such effects you like lack of sleep or food.", 20, 3);
        public static readonly Nightmare Fatigue = new Nightmare("Fatigue", "Your power is running on a limited, but replenishable resource. As you use it, you burn through it, and it recovers by some means fitting to your theme and power.", -25, 0);
        public static readonly Nightmare Lust = new Nightmare("Lust", "Your power has caused a noticeable shift in your behavior, things you used to like are now abhorrent to you, or vice versa", 30, 0);
        public static readonly Nightmare Your_Bane = new Nightmare("Your Bane", "There is something, a material, or an action or a symbol that acts as a bane to your powers, penetrating defenses, defending flawlessly against your strongest attacks, etc.", 0, 0);
        public static readonly Nightmare The_Abyss = new Nightmare("The Abyss", "Your power is at the top of its Tier. If you have multiple powers, apply this only to half of them (round down)." +
                                                                        "Reroll on this chart thrice, pick two."
                                                                        , 75, 0);



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
