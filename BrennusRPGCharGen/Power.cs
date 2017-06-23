using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrennusRPGCharGen
{
    class Power
    {

        Tier tier;
        Star star;

        public Power()
        {
            tier = new Tier();
            star = new Star();
        }

        public Power(Tier t, Star s)
        {
            Tier = t;
            Star = s;
        }

        public Tier Tier
        {
            get
            {
                return tier;
            }

            set
            {
                tier = value;
            }
        }

        public Star Star
        {
            get
            {
                return star;
            }

            set
            {
                star = value;
            }
        }
    }
}
