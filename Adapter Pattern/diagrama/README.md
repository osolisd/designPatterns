# Patrón adaptador

Patrón estructural

Convierte la interfaz de una clase en otra interfaz que el cliente espera. El adaptador permite a las clases trabajar juntas, lo que de otra manera no podría hacerse debido a sus interfaces incompatibles. 

## Diagrama

Existe una interfaz objetivo que el cliente usa. En el caso de la Kata se habla de una unidad de ataque que se define en la interfaz **_Unidad_**.

De allí las clases **Marine**, **Zealot** y **Zergling** implementan la interfaz.

La necesidad está en que el personaje **Mario** también pueda atacar pero el no es de tipo Unidad.

En medio de la unidad y Mario se crea entonces un adapter llamado **MarioAdapter** el cual implementa la interfaz de Unidad y en la implementación del método _atacar_ llama internamente al método `atacarSalto` de la clase Mario y de esta manera Mario puede empezar a atacar objetos de tipo Objetivo.

