class Program
{
        static void Main( string[] args )
        {

                //blackjack type game (get numbers, try to stay under 21 but beat the computer)
                //player gets random number(1-11)
                //player gets asked if they want another number (take as many as the want)
                //if total number above 21 they lose
                //if total number under 21, they can choose to stay
                //computer picks random numbers
                //if total number is above player and below 22, computer wins
                //if total number passes 21, computer loses player wins

                // Variables
                int playerTotal = 0;
                int computerTotal = 0;
                string response;

                //Creating random number
		Random rand = new Random();

		// Player's turn
		Console.WriteLine("Try to get as close to 21 as possible to beat the computer, but don't go over!");

		do
		{
			int playernumber = rand.Next(1, 12); // random number between 1 and 11
			playerTotal += playernumber;
			Console.WriteLine("You got a " + playernumber);
			Console.WriteLine("Your total is " + playerTotal);

		if (playerTotal > 21)
		{
			Console.WriteLine("You went over 21! You lose.");
			return;
		}

		Console.Write("Enter 'Y' for another number or 'N' to stay on current number: ");
		response = Console.ReadLine();

		} while (response == "Y");

		// Computer's turn
		while (computerTotal < playerTotal && computerTotal <= 21)
		{
			int computernumber = rand.Next(1, 12); // random number between 1 and 11
			computerTotal += computernumber;
			Console.WriteLine("Computer got a " + computernumber);
			Console.WriteLine("Computer's total is " + computerTotal);
		}

		// Determine winner
		if (computerTotal > 21)
		{
			Console.WriteLine("You win!");
		}
		
		else if (playerTotal > computerTotal)
		{
			Console.WriteLine("You win!");
		}
		
		else
		{
			Console.WriteLine("Computer wins!");
		}
	}
}


