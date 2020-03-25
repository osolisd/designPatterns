import Unit from "./../Unit";
import MoveBehavior from "./../MoveBehavior";
import WalkBehavior from "./../WalkBehavior";
import FlyBehavior from "./../FlyBehavior";

describe('Una unidad usa diferentes estrategias de desplazamiento', () => {
    it('Desplazamiento terrestre. Cada movimiento avanza 1 posición', () => {
      const viking:Unit = new Unit(new WalkBehavior());
      viking.doMove();
      expect(viking.position).toBe(1);
      viking.doMove();
      expect(viking.position).toBe(2);
    });

    it('Desplazamiento aereo. Cada movimiento avanza 10 posiciones', () => {
      const viking:Unit = new Unit(new FlyBehavior());
      viking.doMove();
      expect(viking.position).toBe(10);
      viking.doMove();
      expect(viking.position).toBe(20);
    });

    it('Desplazamiento mixto. Un movimiento terrestre (1) y uno aereo (10)', () => {
      const viking:Unit = new Unit(new WalkBehavior());
      viking.doMove();
      expect(viking.position).toBe(1);
      viking.moveStrategy = new FlyBehavior();
      viking.doMove();
      expect(viking.position).toBe(11);
    });
});