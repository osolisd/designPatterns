package visitor_pattern.units;

import visitor_pattern.visitor.Visitor;

public class Marauder implements Unit {

    private double health;

    public Marauder(double health) {
        this.health = health;
    }

    @Override
    public void accept(Visitor visitor) {
        visitor.VisitArmored(this);
    }

    @Override
    public double getHealth() {
        return this.health;
    }

    @Override
    public void setHealth(double health) {
        this.health = health;
    }
}
