namespace wizard_ninja_samurai;

public class Wizard : Human {

    public Wizard(string name) : base(name) {
        Intelligence = 25;
        Health = 50;
    }

    public override int Attack(Human target) {
        int damage = 5*Intelligence;
        target.Health -= damage;
        Health += damage;
        return target.Health;

    }
    public int Heal(Human target)
    {
        return target.Health += 10;
    }
}