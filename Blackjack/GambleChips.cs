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

		int sumOfChips;
		int differenceOfChips;

		public void addChips()
		{
			// TODO: Algorithm and code to add up total chips won
			sumOfChips = OneDollarChip + FiftyDollarChip + TwentyFiveDollarChip + FiftyDollarChip + HundredDollarChip;
			
		}
		
		public void subtractChips()
		{
			// TODO: Algorithm and code to subtract the total chips loss
			differenceOfChips = HundredDollarChip - FiftyDollarChip - TwentyFiveDollarChip - FiveDollarChip - OneDollarChip;
		}

		public void surrenderChips()
		{

		}
	
		public void doubleChips()
		{

		}

	}
}