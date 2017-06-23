using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrennusRPGCharGen
{

    enum ManifestationType
    {
        Normal,
        Drug_Use,
        Drug_Overdose,
        Near_Death,
        After_Death,
        Returner
    }

    class Manifestation
    {
        ManifestationType type;

        int numDreams;
        int numNightmares;
        double dvModifier;

        int adonisChance;
        int shadowChance;

        int tierModifier;

        public Manifestation() { }

        Manifestation(ManifestationType t, int numD, int numN, double dv, int aC, int sC)
        {
            Type = t;
            NumDreams = numD;
            NumNightmares = numN;
            DvModifier = dv;
            AdonisChance = aC;
            ShadowChance = sC;
            TierModifier = 0;
        }

        Manifestation(ManifestationType t, int numD, int numN, double dv, int aC, int sC, int tm)
        {
            Type = t;
            NumDreams = numD;
            NumNightmares = numN;
            DvModifier = dv;
            AdonisChance = aC;
            ShadowChance = sC;
            TierModifier = tm;
        }

        public static readonly Manifestation Normal = new Manifestation(ManifestationType.Normal, 0, 0, 0, 0, 0);
        public static readonly Manifestation Drugged = new Manifestation(ManifestationType.Drug_Use, 0, 1, 50, 0, 25);
        public static readonly Manifestation Overdose = new Manifestation(ManifestationType.Drug_Overdose, 0, 3, 75, 0, 50);  //Special Rules for Nightmares apply
        public static readonly Manifestation Near_Death = new Manifestation(ManifestationType.Near_Death, 1, 1, 75, 25, 0);
        public static readonly Manifestation After_Death = new Manifestation(ManifestationType.After_Death, 3, 3, 100, 50, 0);
        public static readonly Manifestation Returner = new Manifestation(ManifestationType.Returner, 3, -2, -100, 0, 0, 1);

        internal ManifestationType Type
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

        public int NumDreams
        {
            get
            {
                return numDreams;
            }

            set
            {
                numDreams = value;
            }
        }

        public int NumNightmares
        {
            get
            {
                return numNightmares;
            }

            set
            {
                numNightmares = value;
            }
        }

        public double DvModifier
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

        public int AdonisChance
        {
            get
            {
                return adonisChance;
            }

            set
            {
                adonisChance = value;
            }
        }

        public int ShadowChance
        {
            get
            {
                return shadowChance;
            }

            set
            {
                shadowChance = value;
            }
        }

        public int TierModifier
        {
            get
            {
                return tierModifier;
            }

            set
            {
                tierModifier = value;
            }
        }
    }
}
