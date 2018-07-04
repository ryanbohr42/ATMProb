using System;
using System.Collections.Generic;
using System.Text;

namespace ATMapp
{
    class ATM
    {

        private Currency[] rack;

        public ATM()
        {
            rack = new Currency[6];
            rack[0] = new Currency(100, "100");
            rack[1] = new Currency(50, "50");
            rack[2] = new Currency(20, "20");
            rack[3] = new Currency(10, "10");
            rack[4] = new Currency(5, "5");
            rack[5] = new Currency(1, "1");
        }

        public int getFranklin()
        {
            return rack[0].getAmount();
        }

        public void setFranklin(int xFranklin)
        {
            rack[0].setAmount(xFranklin);
        }

        public int getGrant()
        {
            return rack[1].getAmount();
        }

        public void setGrant(int xGrant)
        {
            rack[1].setAmount(xGrant);
        }

        public int getJackson()
        {
            return rack[2].getAmount();
        }

        public void setJackson(int xJackson)
        {
            rack[2].setAmount(xJackson);
        }

        public int getHamilton()
        {
            return rack[3].getAmount();
        }

        public void setHamilton(int xHamilton)
        {
            rack[3].setAmount(xHamilton);
        }

        public int getLincoln()
        {
            return rack[4].getAmount();
        }

        public void setLincoln(int xLincoln)
        {
            rack[4].setAmount(xLincoln);
        }

        public int getWashington()
        {
            return rack[5].getAmount();
        }

        public void setWashington(int xWashington)
        {
            rack[5].setAmount(xWashington);
        }

        public void reset() //Restocks the bill amounts to ten
        {
            for (int i = 0; i < rack.Length; i++)
                rack[i].setAmount(10);
        }

        public bool withdraw(int money) //Reduces money amounts if possible
        {
            bool worked;
            int[] oldAmounts = new int[6];
            for (int i = 0; i < oldAmounts.Length; i++)
                oldAmounts[i] = rack[i].getAmount();

            for (int j = 0; j < rack.Length; j++)
            {
                while (money >= rack[j].getValue() && rack[j].getAmount() > 0)
                {
                    money -= rack[j].getValue();
                    rack[j].setAmount(rack[j].getAmount() - 1);
                }
            }
            if (money == 0)
                worked = true;
            else
            {
                worked = false;
                for (int k = 0; k < rack.Length; k++)
                    rack[k].setAmount(oldAmounts[k]);
            }
            return worked;
        }

        public void denominations(String[] types) //Displays the amounts of the requested denominations
        {
            for (int i = 1; i < types.Length; i++)
            {
                for (int j = 0; j < rack.Length; j++)
                {
                    if (types[i].Substring(1).ToUpper().Equals(rack[j].getName().ToUpper()))
                        Console.WriteLine("$" + rack[j].getName() + " - " + rack[j].getAmount());
                }
            }
        }

        public void displayAmounts() //Displays all the amounts of the bills
        {
            for (int i = 0; i < rack.Length; i++)
                Console.WriteLine("$" + rack[i].getName() + " - " + rack[i].getAmount());
        }
    }
}
