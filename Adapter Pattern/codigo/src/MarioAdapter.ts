/**
 * Clase Mario Adapter. Tiene su adaptee de tipo Mario e implementa la interfaz
 * de Unidad para poder ser compatible con el resto de unidades nativas.
 */

 import Unidad from "./Unidad";
 import Objetivo from "./Objetivo";
 import Mario from "./Mario";

export default class MarioAdapter implements Unidad {
    private marioAdaptee:Mario;

    constructor(){
        this.marioAdaptee = new Mario();
    }

    public atacar(objetivo:Objetivo){
        objetivo.salud -= this.marioAdaptee.atacarSalto()
    }
 }