import IMoveBehavior from "./MoveBehavior";
import FlyBehavior from "./FlyBehavior";
import WalkBehavior from "./WalkBehavior";
import Unit from "./Unit";

class Client{

    public startGame(){
        // Crear objetos específicos de estrategia
        const flyBehavior:IMoveBehavior = new FlyBehavior();
        const walkBehavior:IMoveBehavior = new WalkBehavior();

        // Crear un contexto y pasarle la estrategia deseada.
        // Viking empieza como una unidad en tierra
        const viking:Unit = new Unit(walkBehavior);
        viking.doMove();
        viking.doMove();
        console.log('Posición de Viking: ', viking.position);

        // Viking cambia de estrategia de movimiento para volar
        viking.moveStrategy = flyBehavior;
        viking.doMove();
        console.log('Posición de Viking: ', viking.position);

    }
}

const client = new Client();
client.startGame();