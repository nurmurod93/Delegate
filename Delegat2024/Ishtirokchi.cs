using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat2024
{
    public class Ishtirokchi
    {
        public string Name { get; set; }
        public List<int> Ballar { get; set; }
        public int MaxBall 
        { 
            get
            {
                int max = Ballar[0];
                foreach (int bal in Ballar)
                {
                    if (bal > max)
                    {
                        max = bal;
                    }
                }
                return max;
            } 
            
        }
        public int MinBal 
        {
            get
            {
                int min = Ballar[0];
                foreach (int bal in Ballar) 
                {
                    if (bal < min) 
                    {
                        min = bal;
                    }
                }
                return min; 
            }
        }
        public int JamiBall
        {
            get 
            {
                int sum = 0;
                foreach (int bal in Ballar)
                {
                    sum +=bal;
                }
                return sum;
            }           
        }
        public Ishtirokchi(string name)
        {
            name = name;
            Ballar = new List<int>();
        }
        public void BallarniHisoblash(int bal)
        {
            Ballar.Add(bal);
        }
        public override string ToString()
        {
            return $"{Name} - Ballari: ({string.Join(",", Ballar)})"
               + $"(Tot: {JamiBall} - Max: {MaxBall})";
        }
 
    }
}
