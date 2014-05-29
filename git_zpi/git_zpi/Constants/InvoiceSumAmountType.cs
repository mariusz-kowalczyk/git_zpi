using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_zpi.Constants
{
    class InvoiceSumAmountType
    {
        /**
         *<summary>
         *sumaryczna wartość towarów (bez VAT) ("66")
         * </summary>
         */
        public static string TotalGoodsValue { get { return "66"; } }

        /**
         * <summary>
         * kwota kaucji za towary kaucjonowane
         * </summary>
         */
        public static string GoodsBailAmount { get { return "35E"; } }
    }
}
