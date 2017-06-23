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

        int dvMod;

        public Tier() {
            type = TierType.Normie;
        }

        Tier(TierType t, int plvl, int dv)
        {
            Type = t;
            PreciseLevel = plvl;
            DvMod = dv;
        }

        public static readonly Tier Normie = new Tier(TierType.Normie, 0, 0);
        public static readonly Tier Exemplar1 = new Tier(TierType.Exemplar, 1, 1);
        public static readonly Tier Exemplar2 = new Tier(TierType.Exemplar, 2, 6);
        public static readonly Tier Exemplar3 = new Tier(TierType.Exemplar, 3, 10);
        public static readonly Tier Paragon1 = new Tier(TierType.Paragon, 4, 11);
        public static readonly Tier Paragon2 = new Tier(TierType.Paragon, 5, 17);
        public static readonly Tier Paragon3 = new Tier(TierType.Paragon, 6, 23);
        public static readonly Tier Apex1 = new Tier(TierType.Apex, 7, 38);
        public static readonly Tier Apex2 = new Tier(TierType.Apex, 8, 47);
        public static readonly Tier Apex3 = new Tier(TierType.Apex, 9, 56);
        public static readonly Tier God1 = new Tier(TierType.God, 10, 79);
        public static readonly Tier God2 = new Tier(TierType.God, 11, 85);
        public static readonly Tier God3 = new Tier(TierType.God, 12, 90);
        public static readonly Tier Transcendent = new Tier(TierType.Trancendent, 13, 100);


        public static Tier returnTierByLevel(int level)
        {
            switch (level)
            {
                case 1:
                    return Tier.Exemplar1;
                case 2:
                    return Tier.Exemplar2;
                case 3:
                    return Tier.Exemplar3;
                case 4:
                    return Tier.Paragon1;
                case 5:
                    return Tier.Paragon2;
                case 6:
                    return Tier.Paragon3;
                case 7:
                    return Tier.Apex1;
                case 8:
                    return Tier.Apex2;
                case 9:
                    return Tier.Apex3;
                case 10:
                    return Tier.God1;
                case 11:
                    return Tier.God2;
                case 12:
                    return Tier.God3;
                case 13:
                    return Tier.Transcendent;
            }

            return Tier.Normie;
        }

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

        public int PreciseLevel
        {
            get
            {
                return preciseLevel;
            }

            set
            {
                preciseLevel = value;
            }
        }

        public int DvMod
        {
            get
            {
                return dvMod;
            }

            set
            {
                dvMod = value;
            }
        }
    }
}
