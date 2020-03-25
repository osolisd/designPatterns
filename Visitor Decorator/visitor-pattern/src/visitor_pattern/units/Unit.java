package visitor_pattern.units;

import visitor_pattern.visitor.Visitor;

public interface Unit {

    void accept(Visitor visitor);

    double getHealth();

    void setHealth(double health);
}
