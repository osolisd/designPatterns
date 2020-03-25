Patrón Visitor

El patrón Visitor es un patrón de diseño del tipo comportamiento, el cual permite separar los algoritmos del objeto sobre el cual operan.

El patrón Visitor sugiere que se cree un nuevo comportamiento de una clase en otra separada, llamada visitante. El objeto original que tenía que realizar el comportamiento ahora se pasa a uno de los métodos del visitante como argumento, proporcionando al método acceso a todos los datos necesarios contenidos dentro del objeto.

Aplicabilidad:

- Cuando necesite realizar una operación en todos los elementos de una estructura de objetos compleja (por ejemplo, un árbol de objetos). El patrón Visitor permite ejecutar una operación sobre un conjunto de objetos con diferentes clases haciendo que un objeto visitante implemente varias variantes de la misma operación, que corresponden a todas las clases objetivo.

- Para limpiar la lógica empresarial de los comportamientos auxiliares. El patrón le permite hacer que las clases principales de su aplicación se centren más en sus trabajos principales al extraer todos los demás comportamientos en un conjunto de clases de visitantes.

Cuando un comportamiento tenga sentido solo en algunas clases de una jerarquía de clases, pero no en otras. Puede extraer este comportamiento en una clase de visitante separada e implementar solo los métodos de visita que aceptan objetos de clases relevantes, dejando el resto vacío