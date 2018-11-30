using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Blackjack
{
	class GambleChips
	{
		private string GambleTokens;
		private const int OneDollarChip = 1;
		private const int FiveDollarChip = 5;
		private const int TwentyFiveDollarChip = 25;
		private const int FiftyDollarChip = 50;
		private const int HundredDollarChip = 100;

		 private const int totalChips;

		public void TotalChips()
		{
			// TODO: Algorithm and code to add up total chips used
			totalChips = OneDollarChip + FiftyDollarChip + TwentyFiveDollarChip + FiftyDollarChip + HundredDollarChip;
			
		}



	}
}