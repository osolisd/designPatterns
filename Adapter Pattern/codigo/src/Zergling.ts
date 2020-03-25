/**
 * Clase Zergling. Implementa la interfaz Unidad
 */

import Unidad from "./Unidad";
import Objetivo from "./Objetivo";

export default class Zergling implements Unidad {

   public atacar(objetivo:Objetivo){
       objetivo.salud -= 5
   }
}