package decorator_pattern.decorator;

import decorator_pattern.units.Unit;

public class ArmorUpgrade extends UnitDecorator {

    public ArmorUpgrade(Unit unit) {
        super(unit);
    }

    @Override
    public double getArmor() {
        return super.getArmor() + 1;
    }
}
