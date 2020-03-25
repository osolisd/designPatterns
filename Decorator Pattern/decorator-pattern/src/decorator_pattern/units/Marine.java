package decorator_pattern.units;

public class Marine implements Unit {

    private double damage;
    private double armor;

    public Marine(double damage, double armor) {
        this.damage = damage;
        this.armor = armor;
    }

    @Override
    public double getDamage() {
        return damage;
    }

    @Override
    public double getArmor() {
        return armor;
    }
}
