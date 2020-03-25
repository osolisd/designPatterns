package visitor_pattern.visitor;

import visitor_pattern.units.Unit;

public class TankBullet implements Visitor {

    @Override
    public void VisitLight(Unit unit) {
        unit.setHealth(unit.getHealth() - 21);
    }

    @Override
    public void VisitArmored(Unit unit) {
        unit.setHealth(unit.getHealth() - 32);
    }
}
