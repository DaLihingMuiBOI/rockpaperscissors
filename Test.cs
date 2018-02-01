using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test : MonoBehaviour {
	    static int DRAW = 0;
		static int LOSE = -1;
		static int WIN = 1;

	int[,] winTable = new int[5,5] { 
			// ROCK
			{ 
				// ROCK
				DRAW, 
				// PAPER
				LOSE, 
				// SCISSOR
				WIN,
				//LIZARD
				LOSE,
				//SPOCK
				LOSE 
			}, 
			// PAPER
			{ // ROCK
				WIN, 
				// PAPER
				DRAW, 
				// SCISSOR
				LOSE,
				//LIZARD
				LOSE,
				//SPOCK
				WIN  
			}, 
			// SCISSORS
			{ // ROCK
				LOSE, 
				// PAPER
				WIN, 
				// SCISSOR
				DRAW,
				//LIZARD
				WIN,
				//SPOCK
				WIN  
			},
			//Lizard
			{ 
				// ROCK
				LOSE, 
				// PAPER
				WIN, 
				// SCISSOR
				LOSE,
				//LIZARD
				DRAW,
				//SPOCK
				WIN 
			},
			//Spock
			{ 
				// ROCK
				WIN, 
				// PAPER
				LOSE, 
				// SCISSOR
				WIN,
				//LIZARD
				LOSE,
				//SPOCK
				DRAW 
			},  
		};
	    int playerScore = 0;
		int computerScore = 0;
		int drawScore = 0;

	System.Random rand = new System.Random ();


	
		static string answer = "";

	// Use this for initialization
	void Start () {

//		int ROCK = 0;
//		int PAPER = 1;
//		int SCISSORS = 2;
//		int LIZARD = 3;
//      int SPOCK = 4;

		DRAW = 0;
		LOSE = -1;
		WIN = 1;
				
		winTable = new int[5,5] { 
			// ROCK
			{ 
				// ROCK
				DRAW, 
				// PAPER
				LOSE, 
				// SCISSOR
				WIN,
				//LIZARD
				LOSE,
				//SPOCK
				LOSE 
			}, 
			// PAPER
			{ // ROCK
				WIN, 
				// PAPER
				DRAW, 
				// SCISSOR
				LOSE,
				//LIZARD
				LOSE,
				//SPOCK
				WIN  
			}, 
			// SCISSORS
			{ // ROCK
				LOSE, 
				// PAPER
				WIN, 
				// SCISSOR
				DRAW,
				//LIZARD
				WIN,
				//SPOCK
				WIN  
			},
			//Lizard
			{ 
				// ROCK
				LOSE, 
				// PAPER
				WIN, 
				// SCISSOR
				LOSE,
				//LIZARD
				DRAW,
				//SPOCK
				WIN 
			},
			//Spock
			{ 
				// ROCK
				WIN, 
				// PAPER
				LOSE, 
				// SCISSOR
				WIN,
				//LIZARD
				LOSE,
				//SPOCK
				DRAW 
			},  
		};

		playerScore = 0;
		computerScore = 0;
		drawScore = 0;

		rand = new System.Random ();


	
		string answer = "";
		Debug.Log("-- Rock, Paper, Scissors, Lizard, Spock --");

	}
	
	// Update is called once per frame
	void Update () {
		
		Console.WriteLine("-- Rock, Paper, Scissors, Lizard, Spock --");

			int computerChoice = rand.Next(0,6);

			Console.WriteLine("HURRY UP AND CHOOSE ALREADY!!! SANIC HAS ALREADY CHOSEN DA WAE\n\n");

			Console.WriteLine("Player Score: " + playerScore + " Computer Score: " + computerScore + " Draws: " + drawScore + "\n\n");

			Console.Write("1] Rock\n2] Paper\n3] Scissors\n4]Lizard\n5]Spock\n\n::--> ");

			int playerChoice = Convert.ToInt32(Console.ReadLine());
			playerChoice = playerChoice - 1;

			if(winTable[playerChoice,computerChoice] == DRAW) {
				Console.WriteLine("YOU TOUCHA MAH SPAGHET! I SPIT ON YOU NEXT TIME!!!");
				drawScore = drawScore + 1;
			} else if(winTable[playerChoice,computerChoice] == LOSE) {
				Console.WriteLine("Stop it, get some help.");
				computerScore = computerScore + 1;
			} else if(winTable[playerChoice,computerChoice] == WIN) {
				Console.WriteLine("So you do know da wae...");
				playerScore = playerScore + 1;
			}

			Console.WriteLine("Do u want to play yourself again? [y/n]");
			string answer = Console.ReadLine();
	}
}
