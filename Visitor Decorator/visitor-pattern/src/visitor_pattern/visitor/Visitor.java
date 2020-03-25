package visitor_pattern.visitor;

import visitor_pattern.units.Unit;

public interface Visitor {

    void VisitLight(Unit unit);
    void VisitArmored(Unit unit);

}
