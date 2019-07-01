using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jcravenAS7
{
    class Charter
    {
        #region "auto-implemented properties"
        public string CustomerName { get; private set; }
        public string YachtType { get; private set; }
        public int YachtSize { get; private set; }
        public decimal CharterHours { get; private set; }
        public decimal CharterFee { get; private set; }
        #endregion "auto-implemented properties"

        #region "constructors"
        public Charter(string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            CustomerName = customerName;
            YachtType = yachtType;
            YachtSize = yachtSize;
            CharterHours = charterHours;

            CalculateCharterFee();
        }

        public Charter() { }
        #endregion "constructors"

        #region "methods"
        private decimal CalculateCharterFee()
        {
            if (YachtSize <= 22)
            {
                CharterFee = 198 * CharterHours;
            }
            else if (YachtSize <= 24)
            {
                CharterFee = 243 * CharterHours;
            }
            else if (YachtSize <= 30)
            {
                CharterFee = 275 * CharterHours;
            }
            else if (YachtSize <= 32)
            {
                CharterFee = 361 * CharterHours;
            }
            else if (YachtSize <= 36)
            {
                CharterFee = 492 * CharterHours;
            }
            else if (YachtSize <= 38)
            {
                CharterFee = 521 * CharterHours;
            }
            else
            {
                CharterFee = 658 * CharterHours;
            }

            return CharterFee;
        }
        #endregion "methods"
    }
}
