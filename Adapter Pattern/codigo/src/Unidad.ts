/**
 * Interfaz para una unidad de ataque
 */

import Objetivo  from "./Objetivo";

export default interface Unidad {
    atacar(objetivo:Objetivo):void;
}