package visitor_pattern.units;

import visitor_pattern.visitor.Visitor;

public class Marine implements Unit {

    private double health;

    public Marine(double health) {
        this.health = health;
    }

    @Override
    public void accept(Visitor visitor) {
        visitor.VisitLight(this);
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
