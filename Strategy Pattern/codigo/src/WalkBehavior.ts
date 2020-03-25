/**
 * Clase que implementa el comportamiento de movimiento por tierra. Debe moverse 1 posición por cada movimiento.
 */

import IMoveBehavior from "./MoveBehavior";
import Unit from "./Unit";

export default class WalkBehavior implements IMoveBehavior{
    move(unit:Unit):void{
        unit.position = unit.position + 1;
    }
}