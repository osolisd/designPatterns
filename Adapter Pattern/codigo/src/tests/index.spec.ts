import Marine from "../Marine";
import MarioAdapter from "../MarioAdapter";
import Objetivo from "../Objetivo";

describe('Una unidad nativa ataca a un enemigo', () => {
    it('Unidad Marine (daño 6) ataca a enemigo con salud 100 y lo deja con salud 94', () => {
      const unidadMarine = new Marine();
      const enemigo:Objetivo = new Objetivo(100);
      unidadMarine.atacar(enemigo);
      expect(enemigo.salud).toBe(94);
    });
});

describe('Mario también puede atacar como unidad', () => {
    it('Unidad Mario (daño 3) ataca a enemigo con salud 50 y lo deja con salud 47', () => {
      const unidadMario = new MarioAdapter();
      const enemigo:Objetivo = new Objetivo(50);
      unidadMario.atacar(enemigo);
      expect(enemigo.salud).toBe(47);
    });
});

