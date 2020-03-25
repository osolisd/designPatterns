import Objetivo  from "./Objetivo";
import Unidad from "./Unidad";

import Marine from "./Marine";
import Zergling from "./Zergling";
import Zealot from "./Zealot";
import MarioAdapter from "./MarioAdapter";

class Juego{

    public iniciarJuego(){
        const enemigo1:Objetivo = new Objetivo(100);
        const enemigo2:Objetivo = new Objetivo(50);

        const marine:Unidad = new Marine();
        const zergling:Unidad = new Zergling();
        const zealot:Unidad = new Zealot();
        const mario:Unidad = new MarioAdapter();

        // Enemigo 1 recibe ataques de marine y zealot
        marine.atacar(enemigo1);
        zealot.atacar(enemigo1);

        // Enemigo 2 recibe ataques de marine, zergling y mario
        marine.atacar(enemigo2);
        zergling.atacar(enemigo2);
        mario.atacar(enemigo2);

        console.log('Luego de los ataques');
        console.log('Salud enemigo 1: ', enemigo1.salud);
        console.log('Salud enemigo 2: ', enemigo2.salud);
    }
}

const juego = new Juego();
juego.iniciarJuego();