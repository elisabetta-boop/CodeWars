// Rock Paper Scissors
// Let's play! You have to return which player won! In case of a draw return Draw!.

// Examples:

// rps('scissors','paper') // Player 1 won!
// rps('scissors','rock') // Player 2 won!
// rps('paper','paper') // Draw!


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public string Rps(string p1, string p2)
  {
    
    string draw = "Draw!";
    string player1 = "Player 1 won!";
    string player2 = "Player 2 won!";
    
    string scissors = "scissors";
    string paper = "paper";
    string rock = "rock";
    
    if((p1 == scissors && p2 == paper) || (p1 == rock && p2 == scissors) || (p1 == paper && p2 == rock))
       return player1;
    else if(p1==p2)
       return draw;
    else
       return player2;
    
    
  }
}