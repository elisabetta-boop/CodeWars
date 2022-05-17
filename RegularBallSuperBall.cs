// Create a class Ball. Ball objects should accept one argument for "ball type" when instantiated.
// If no arguments are given, ball objects should instantiate with a "ball type" of "regular."
// ball1 = new Ball();
// ball2 = new Ball("super");
// ball1.ballType     //=> "regular"
// ball2.ballType     //=> "super"

using System;

public class Ball {
  public string ballType { get; set; }
  
  public Ball() {
    // your code goes here
    this.ballType = "regular";
    }
  public Ball(string ballType) {
    // your code goes here
    this.ballType = ballType;
   
    }
    
  }