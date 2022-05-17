// Create a function that returns the name of the winner in a fight between two fighters.
// Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.
// Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.
// Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.
// Example:
//   declare_winner(Fighter("Lew", 10, 2), Fighter("Harry", 5, 4), "Lew") => "Lew"

//   Lew attacks Harry; Harry now has 3 health.
//   Harry attacks Lew; Lew now has 6 health.
//   Lew attacks Harry; Harry now has 1 health.
//   Harry attacks Lew; Lew now has 2 health.
//   Lew attacks Harry: Harry now has -1 health and is dead. Lew wins.
// public class Fighter {
//   public string Name;
//   public int Health, DamagePerAttack;
//   public Fighter(string name, int health, int damagePerAttack) {
//     this.Name = name;
//     this.Health = health;
//     this.DamagePerAttack = damagePerAttack;
//   }
// }

using System;


public class Kata {
  
  public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker) {
    bool turn1 = fighter1.Name == firstAttacker;
    
    while (true) {
      if (turn1) {
        fighter2.Health -= fighter1.DamagePerAttack;
        if (fighter2.Health <= 0)
        return fighter1.Name;
      } else {
        fighter1.Health -= fighter2.DamagePerAttack;
        if (fighter1.Health <= 0)
          return fighter2.Name;
      }
      turn1 = !turn1;
    }
  }
}