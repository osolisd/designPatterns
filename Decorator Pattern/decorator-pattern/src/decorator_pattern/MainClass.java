package decorator_pattern;

import decorator_pattern.decorator.ArmorUpgrade;
import decorator_pattern.decorator.WeaponUpgrade;
import decorator_pattern.units.Marine;
import decorator_pattern.units.Unit;

public class MainClass {

    public static void main(String[] args) {

        Unit marine = new Marine(5d, 0d);

        System.out.println("Marine initial stats: Damage: " + marine.getDamage()
        + " - Armor: " + marine.getArmor());
        System.out.println("----------------------------------------------");

        marine = new WeaponUpgrade(marine);
        System.out.println("Marine's damage after upgrade: " + marine.getDamage());
        marine = new WeaponUpgrade(marine);
        System.out.println("Marine's damage after upgrade: " + marine.getDamage());
        marine = new WeaponUpgrade(marine);
        System.out.println("Marine's damage after upgrade: " + marine.getDamage());

        System.out.println();
        marine = new ArmorUpgrade(marine);
        System.out.println("Marine's armor after upgrade: " + marine.getArmor());
        marine = new ArmorUpgrade(marine);
        System.out.println("Marine's armor after upgrade: " + marine.getArmor());
    }
}
