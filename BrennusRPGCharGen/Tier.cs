using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrennusRPGCharGen
{

    enum TierType
    {
        Normie,
        Exemplar,
        Paragon,
        Apex,
        God,
        Trancendent
    }

    class Tier
    {

        TierType type;

        int preciseLevel;

        Tier() { }

        Tier(TierType t, int plvl)
        {
            Type = t;
            preciseLevel = plvl;
        }

        public static readonly Tier Normie = new Tier(TierType.Normie, 0);
        public static readonly Tier Exemplar1 = new Tier(TierType.Exemplar, 1);
        public static readonly Tier Exemplar2 = new Tier(TierType.Exemplar, 2);
        public static readonly Tier Exemplar3 = new Tier(TierType.Exemplar, 3);
        public static readonly Tier Paragon1 = new Tier(TierType.Paragon, 4);
        public static readonly Tier Paragon2 = new Tier(TierType.Paragon, 5);
        public static readonly Tier Paragon3 = new Tier(TierType.Paragon, 6);
        public static readonly Tier Apex1 = new Tier(TierType.Apex, 7);
        public static readonly Tier Apex2 = new Tier(TierType.Apex, 8);
        public static readonly Tier Apex3 = new Tier(TierType.Apex, 9);
        public static readonly Tier God1 = new Tier(TierType.God, 10);
        public static readonly Tier God2 = new Tier(TierType.God, 11);
        public static readonly Tier God3 = new Tier(TierType.God, 12);
        public static readonly Tier Transcendent = new Tier(TierType.Trancendent, 13);

        public TierType Type
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
