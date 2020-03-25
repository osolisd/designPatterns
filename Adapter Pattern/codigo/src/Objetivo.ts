/**
 * Clase objetivo. Recibe los ataques de las diferentes unidades
 */

export default class Objetivo {
    private _salud: number;

    constructor( saludInicial:number ) {
        this._salud  = saludInicial;
    }

    get salud(): number {
        return this._salud;
    }

    set salud(nuevaSalud: number) {
        this._salud = nuevaSalud;
    }
}

