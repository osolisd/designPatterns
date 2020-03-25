package visitor_pattern;

import visitor_pattern.units.Marauder;
import visitor_pattern.units.Marine;
import visitor_pattern.units.Unit;
import visitor_pattern.visitor.TankBullet;
import visitor_pattern.visitor.Visitor;

public class MainClass {

    public static void main(String[] args) {

        final Unit marauder = new Marauder(125d);
        final Unit marine = new Marine(100d);

        final Visitor visitor = new TankBullet();

        System.out.println("--------------------------------------------------------------------");
        System.out.println("Marauder initial health: " + marauder.getHealth());
        marauder.accept(visitor);
        System.out.println("Marauder health after tank bullet attack: " + marauder.getHealth());

        System.out.println("--------------------------------------------------------------------");
        System.out.println("Marine initial health: " + marine.getHealth());
        marine.accept(visitor);
        System.out.println("Marine health after tank bullet attack: " + marine.getHealth());


    }
}
