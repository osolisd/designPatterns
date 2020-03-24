/**
 * Clase que implementa el comportamiento de movimiento por aire. Debe moverse 10 posiciones por cada movimiento.
 */

import IMoveBehavior from "./MoveBehavior";
import Unit from "./Unit";

export default class FlyBehavior implements IMoveBehavior{
    move(unit:Unit):void{
        unit.position += 10;
    }
}