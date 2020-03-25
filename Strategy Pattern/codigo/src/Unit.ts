/**
 * Clase Unidad. Esta clase es la que tendrá un comportamiento asignado por Strategy.
 * Expone un setter para cambiar su estrategia en cualquier momento.abs
 * Tiene un método que a su vez llama al método de movimiento de la estrategia
 */

import IMoveBehavior from "./MoveBehavior";

export default class Unit {
    private _moveBehavior:IMoveBehavior;
    private _position:number = 0;

    constructor(behavior:IMoveBehavior ) {
        this._moveBehavior  = behavior;
    }

    // Setter para Strategy
    set moveStrategy(newMoveStrategy: IMoveBehavior) {
        this._moveBehavior = newMoveStrategy;
    }

    // Getter de posición
    get position():number{
        return this._position;
    }

    // Setter
    set position(newPosition: number) {
        this._position = newPosition;
    }

    // Llamada a la estrategia actual de movimiento
    doMove(){
        this._moveBehavior.move(this);
    }
}

