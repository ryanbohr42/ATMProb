using System;
using System.Collections.Generic;
using System.Text;

namespace ATMapp
{
    class Currency
    {
        private int value;
        private String name;
        private int amount;

        public Currency(int xValue, String xName)
        {
            value = xValue;
            name = xName;
            amount = 10;
        }

        public int getValue()
        {
            return value;
        }

        public void setValue(int xValue)
        {
            value = xValue;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String xName)
        {
            name = xName;
        }

        public int getAmount()
        {
            return amount;
        }

        public void setAmount(int xAmount)
        {
            amount = xAmount;
        }
    }
}
