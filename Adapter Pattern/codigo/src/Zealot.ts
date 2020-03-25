/**
 * Clase Zealot. Implementa la interfaz Unidad
 */

import Unidad from "./Unidad";
import Objetivo from "./Objetivo";

export default class Zealot implements Unidad {

   public atacar(objetivo:Objetivo){
       objetivo.salud -= 8
   }
}