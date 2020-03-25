package decorator_pattern.decorator;

import decorator_pattern.units.Unit;

public class WeaponUpgrade extends UnitDecorator {

    public WeaponUpgrade(Unit unit) {
        super(unit);
    }

    @Override
    public double getDamage() {
        return super.getDamage() + 1;
    }
}
