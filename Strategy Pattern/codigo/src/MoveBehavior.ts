/**
 * Interfaz para comportamiento de movimiento.
 * Cualquier comportamiento debe implementar el método move
 */
import Unit from "./Unit";

export default interface IMoveBehavior {
    move(unit:Unit):void;
}