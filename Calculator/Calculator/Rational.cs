using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Rational
    {
        public int chis;
        public int znam;
        
        public Rational(int newChis, int newZnam)
        {
            chis = newChis;
            znam = newZnam;
        }

        public Rational Sum (Rational other)
        {            
            int newZnam = this.znam * other.znam;
            int newChis = this.chis * other.znam + this.znam * other.chis;
            Rational resalt = new Rational(newChis, newZnam);           
            return resalt;
        }

        public Rational Minus (Rational other)
        {
            int newZnam = this.znam * other.znam;
            int newChis = this.chis * other.znam - this.znam * other.chis;
            Rational resalt = new Rational(newChis, newZnam);
            return resalt;

        }

        public Rational Pel (Rational other)
        {
            int newZnam = this.znam * other.znam;
            int newChis = this.chis * other.chis;
            Rational resalt = new Rational(newChis, newZnam);
            return resalt;
        }

        public Rational Del(Rational other)
        {
            int newZnam = this.znam * other.chis;
            int newChis = this.chis * other.znam;
            Rational resalt = new Rational(newChis, newZnam);
            return resalt;
        }

        public Rational NOD (int kChis, int kZnam)
        {
            if (kChis == kZnam && kZnam != 0 && kChis != 0)
            {
                Rational resalt = new Rational(kChis / kChis, kZnam / kChis);
                return resalt;
            }

            else
            {
                int nod = 0;

                while (kChis != 0 && this.znam > this.chis && kZnam != 0 && kChis != 0)
                {
                    int temp = kChis;
                    kChis = kZnam % kChis;
                    kZnam = temp;
                    nod = kZnam;
                }

                while (kChis != 0 && this.znam < this.chis && kZnam != 0 && kChis != 0)
                {
                    int temp = kZnam;
                    kZnam = kChis % kZnam;
                    kChis = temp;
                    if ( kChis !=0 ) nod = kChis;
                }

                Rational resalt = new Rational(this.chis / nod, this.znam / nod);
                return resalt;
            }

            
            
        }


    }
}
