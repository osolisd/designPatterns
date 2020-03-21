Patrón Estado

Este patrón se encuentra en la categoría de patrones de comportamiento. Este le permite a un objeto cambiar su comportamiento cuando su estado interno cambia. 

Este patrón de diseño aplica para cuando un objeto puede tener diferentes estados donde según el estado en el que se encuentre puede cambiar su comportamiento, y teniendo en cuenta que dependiendo del estado en el que se encuentre el objeto se puede mover o no a otro estado.

Esta funcionalidad del manejo de estados también se podría implementar utilizando condicionales o una sentencia switch, y dependiendo de la condición que cumpla se establece el objeto y se cambia el comportamiento del mismo. Pero, esta es la debilidad propia de esta implementación y es que al agregar, modificar o eliminar estados se debe cambiar toda esta lógica, rompiendo con esto el principio “Open to extension closed to modification” de los principios SOLID, haciendo a su vez poco mantenible esta funcionalidad.

Para esto el patrón de diseño Estado (State), sugiere la creación de una nueva clase para cada uno de los posibles estados del objeto y extraer el correcto comportamiento de esa clase.

Los beneficios de la utilización de este patrón son:
    • Facilidad en la adición, eliminación u modificación de estados
    • Posibilidad de cambiar de comportamiento en tiempo de ejecución
      