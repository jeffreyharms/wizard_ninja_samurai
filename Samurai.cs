namespace wizard_ninja_samurai;

public class Samurai : Human {
    public Samurai(string name) : base(name) {
        Health = 200;
    }
    public override int Attack(Human target) {
        int damage = 5*Strength;
        target.Health -= damage;
        if(target.Health <= 50) 
        {
            target.Health = 0;
        }
        return target.Health;
    }
    public int Meditate() {
        Health = 200;
        return Health;
    }

}