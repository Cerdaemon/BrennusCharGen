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
        double DVModifier;

        int adonisChance;
        int shadowChance;

        int tierModifier;

        Manifestation() { }

        Manifestation(ManifestationType t, int numD, int numN, double dv, int aC, int sC)
        {
            Type = t;
            numDreams = numD;
            numNightmares = numN;
            DVModifier = dv;
            adonisChance = aC;
            shadowChance = sC;
            tierModifier = 0;
        }

        Manifestation(ManifestationType t, int numD, int numN, double dv, int aC, int sC, int tm)
        {
            Type = t;
            numDreams = numD;
            numNightmares = numN;
            DVModifier = dv;
            adonisChance = aC;
            shadowChance = sC;
            tierModifier = tm;
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
    }
}
