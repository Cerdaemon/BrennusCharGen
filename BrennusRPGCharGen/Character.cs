using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrennusRPGCharGen
{
    class Character
    {

        string name;
        int totalDreams;
        int totalNightmares;

        List<int> linkDVmods = new List<int>();

        List<double> dvModifiers = new List<double>();
        double totalDerangement;

        Manifestation manifestation;
        List<Power> powers = new List<Power>();

        List<Dream> dreams = new List<Dream>();
        List<Nightmare> nightmares = new List<Nightmare>();
       

        public Character() { }

        public void passManifestation(Manifestation m)
        {
            //Dreams.Add(m.NumDreams);
            //Nightmares.Add(m.NumNightmares);
            //DerangementValues.Add(m.DvModifier);
            Manifestation = m;
            recalculateCharacter();
        }

        public void passAmountOfLinks(int a)
        {
            LinkDVmods.Clear();
            for (int i = 0; i < a; i++)
            {
                LinkDVmods.Add(0);
            }
        }

        public void passLinkDV(int dv, int index)
        {
            int dvMod = dv;
            LinkDVmods[index - 1] = dvMod;
            recalculateCharacter();
        }

        public void passAmountOfPowers(int a)
        {
            Powers.Clear();
            for(int i = 0; i < a; i++)
            {
                Power p = new Power();
                Powers.Add(p);
            }        
        }

        public void passAmountODreamsAndNightmares()
        {
            Dreams.Clear();
            Nightmares.Clear();
            for (int i = 0; i < TotalDreams; i++)
            {
                Dream d = new Dream();
                Dreams.Add(d);
            }
            for (int i = 0; i < TotalNightmares; i++)
            {               
                Nightmare n = new Nightmare();                
                Nightmares.Add(n);
            }
        }

        public void passTier(Tier t, int index)
        {
            Tier tier = t;
            Powers[index - 1].Tier = tier;
            recalculateCharacter();
        }

        public void passStar(Star s, int index)
        {
            Star star = s;
            Powers[index - 1].Star = star;
            recalculateCharacter();
        }

        public void passDream(Dream d, int index)
        {
            Dream dream = d;
            Dreams[index - 1] = dream;
            recalculateCharacter();
        }

        public void passNightmare(Nightmare n, int index)
        {
            Nightmare nightmare = n;
            Nightmares[index - 1] = nightmare;
            recalculateCharacter();
        }

        public void recalculateCharacter()
        {
            /**
            foreach(int d in Dreams)
            {
                TotalDreams += d;
            }

            foreach (int n in Nightmares)
            {
                TotalNightmares += n;
            }

            foreach (double dv in DerangementValues)
            {
                TotalDerangement += dv;
            }

            foreach(double dvm in DvModifiers)
            {
                TotalDerangement *= dvm;
            }
            **/
            TotalDreams = 0;
            TotalNightmares = 0;
            TotalDerangement = 0;
            DvModifiers.Clear();

            if (Manifestation != null)
            {
                TotalDreams = Manifestation.NumDreams;
                TotalNightmares = Manifestation.NumNightmares;
                TotalDerangement = Manifestation.DvModifier;
            }

            foreach(Dream d in Dreams)
            {
                TotalDerangement += d.DvModifier;
                Console.WriteLine("Name: " + d.Name + " DV: " + d.DvModifier + " Total: " + TotalDerangement);
            }

            foreach (Nightmare n in Nightmares)
            {
                TotalDerangement += n.DvModifier;
                Console.WriteLine("Name: " + n.Name + " DV: " + n.DvModifier + " Total: " + TotalDerangement);
            }

            Tier strongest = new Tier();
            if (Powers.Count > 0)
            {
                strongest = Powers[0].Tier;                
            }
            int addedTierDV = 0;

            foreach (Power p in Powers)
            {

                if(p.Tier != null)
                {
                    if(p.Tier.PreciseLevel + (p.Star.TierModifier * 3) > strongest.PreciseLevel)
                    {
                        strongest = Tier.returnTierByLevel(p.Tier.PreciseLevel + (p.Star.TierModifier * 3));
                    }
                    addedTierDV += Tier.returnTierByLevel(p.Tier.PreciseLevel + (p.Star.TierModifier * 3)).DvMod;
                }


                if(p.Star != null)
                {
                    TotalDreams += p.Star.NumDreams;
                    TotalNightmares += p.Star.NumNightmares;

                    //Careful here
                    if(p.Star == Star.Black_Hole || p.Star == Star.D1_Star || p.Star == Star.Exotic_Star || p.Star == Star.Quasar)
                    {
                        DvModifiers.Add(p.Star.DVModifier);
                    }
                    else if(p.Star == Star.White_Hole || p.Star == Star.Binary_Star || p.Star == Star.Star_Forge)
                    {
                        //See Rules
                    }
                    else
                    {
                        TotalDerangement += p.Star.DVModifier;
                    }                    
                }                
            }

            TotalDerangement += (strongest.DvMod + ((addedTierDV - strongest.DvMod) / 4));

            foreach (int i in LinkDVmods)
            {
                TotalDerangement += i;
            }

            foreach (double dvm in DvModifiers)
            {
                TotalDerangement *= dvm;
            }

        }


        public int TotalDreams
        {
            get
            {
                return totalDreams;
            }

            set
            {
                totalDreams = value;
            }
        }

        public int TotalNightmares
        {
            get
            {
                return totalNightmares;
            }

            set
            {
                totalNightmares = value;
            }
        }

        public List<double> DvModifiers
        {
            get
            {
                return dvModifiers;
            }

            set
            {
                dvModifiers = value;
            }
        }

        public double TotalDerangement
        {
            get
            {
                return totalDerangement;
            }

            set
            {
                totalDerangement = value;
            }
        }

        internal List<Power> Powers
        {
            get
            {
                return powers;
            }

            set
            {
                powers = value;
            }
        }

        public List<int> LinkDVmods
        {
            get
            {
                return linkDVmods;
            }

            set
            {
                linkDVmods = value;
            }
        }

        internal List<Dream> Dreams
        {
            get
            {
                return dreams;
            }

            set
            {
                dreams = value;
            }
        }

        internal List<Nightmare> Nightmares
        {
            get
            {
                return nightmares;
            }

            set
            {
                nightmares = value;
            }
        }

        internal Manifestation Manifestation
        {
            get
            {
                return manifestation;
            }

            set
            {
                manifestation = value;
            }
        }
    }
}
