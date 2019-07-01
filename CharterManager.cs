using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace jcravenAS7
{
    class CharterManager
    {
        #region "instance property"
        public BindingList<Charter> CharterList { get; private set; }
        #endregion "instance property"

        #region "constructor"
        public CharterManager()
        {
            CharterList = new BindingList<Charter>();
        }
        #endregion "constructor"

        #region "methods"
        //add charter object to the CharterList collection
        public void AddCharter(Charter aCharter)
        {
            CharterList.Add(aCharter);
        }

        //instatiate charter object
        public void AddCharter (string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            Charter aCharter = new Charter(customerName, yachtType, yachtSize, charterHours);

            CharterList.Add(aCharter);
        }
        //find and return lowest charter fee
        public decimal FindLowestCharterFee ()
        {
            decimal lowestFee = CharterList[0].CharterFee;

            foreach (Charter aCharter in CharterList)
            {
                if(aCharter.CharterFee < lowestFee)
                {
                    lowestFee = aCharter.CharterFee;
                }
            }

            return lowestFee;
        }

        //sum up and return fees from all charters
        public decimal GetTotalCharterFees()
        {
            decimal total = 0;

            foreach (Charter aCharter in CharterList)
            {
                total += aCharter.CharterFee;
            }

            return total;
        }

        //calculate and return average charter fees
        public decimal GetAverageCharterFee()
        {
            return GetTotalCharterFees() / CharterList.Count;
        }

        //calculate total charters for each size
        public int GetCharterCount()
        {
            int yachtSize = 0;  
            foreach (Charter aCharter in CharterList)
            {
                if (aCharter.YachtSize == yachtSize )
                {
                    ++yachtSize;
                }
            }

            return yachtSize;

        }

        #endregion "methods"
    }
}
