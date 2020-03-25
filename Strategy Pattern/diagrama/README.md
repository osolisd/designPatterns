# Patrón strategy

Patrón de comportamiento.

Permite mantener un conjunto de algoritmos de entre los cuales el objeto cliente puede elegir aquel que le conviene e intercambiarlo dinámicamente según sus necesidades. 

## Diagrama

La kata propone tener una Unidad específica llamada Viking. Esta unidad se puede desplazar por tierra o por aire y avanzar en su posición.

La clase **Unit** tiene en sus atributos una posición y un comportamiento de movimiento llamado `moveBehavior`.
Esta clase expone un método setter `moveStrategy` para se le pueda asignar una estrategia de movimiento la cual está descrita en la interfaz **IMoveBehavior**.
También existe otro método fundamental llamado `doMove()` el cual usa la estrategia de movimiento que esté asignada en su momento para desplazar la unidad.

Existen dos clases que implementan esta interfaz que se llaman **FlyBehavior** y **WalkBehavior**. La primera implementa el movimiento en aire sumando 10 unidades de desplazamiento y la segunda el movimiento en tierra sumando una unidad desplazamiento.

El cliente inicializa entonces un comportamiento y una unidad enviandole en su constructor el comportamiento de movimiento inicial.

Cuando sea necesario cambiar la forma en que se desplaza la unidad el cliente le asigna un nuevo comportamiento de movimiento a **Unit** por medio de su setter `moveStrategy`, de manera que las llamadas al método `doMove()` dentro de Unit comenzarán a tener un comportamiento diferente debido a este cambio.