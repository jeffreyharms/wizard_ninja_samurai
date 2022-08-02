using wizard_ninja_samurai;

Human greg = new Human("Greg");

Ninja hayabusa = new Ninja("Hayabusa");

Wizard merlin = new Wizard("Merlin");

Samurai toshiro = new Samurai("Toshiro");

hayabusa.Attack(merlin);

Console.WriteLine(merlin.Health);

hayabusa.Attack(greg);

Console.WriteLine(greg.Health);

merlin.Heal(greg);