# Scripts
## Suscriptor y Notificador
Mediante ambos scripts, se pone a prueba el funcionamiento del código de las transparencias referente a Eventos.

Se ha añadido un objeto de tipo texto para mostrar como el color del suscriptor cambia tras alcanzar una cifra divisible por 100.

![](https://github.com/alu0101444741/InterfacesInteligentes_3/blob/main/ScriptsGIFs/SuscriptorNotificador.gif)

## ObjectABehaviour
Una colisión del jugador con un objeto de tipo A, provocará que un objeto tipo B (cubos) elegido al azar incremente su tamaño ligeramente.
Además, añade un campo de tipo booleano para detectar si el objeto actual se encuentra en el suelo. 
![](https://github.com/alu0101444741/InterfacesInteligentes_3/blob/main/ScriptsGIFs/ObjectABehaviour.gif)

## ObjectBBehaviour
Una colisión del jugador con un objeto de tipo B, provocará que todos los objetos de tipo A (cápsulas) se dirijan hacia el objeto de tipo C (esfera) y avancen en esa dirección.
Esto se logra mediante la función 'LookAt' y finalmente 'transform.forward'. 
![](https://github.com/alu0101444741/InterfacesInteligentes_3/blob/main/ScriptsGIFs/ObjectBBehaviour.gif)

## ObjectCBehaviour
Una colisión del jugador con un objeto de tipo C, provocará que todos los objetos de tipo A salten y cambien su color por otro aleatorio.
El salto se logra mediante el método 'AddForce', aplicando una fuerza de tipo impulso (ForceMode.Impulse) sobre el eje Y.
![](https://github.com/alu0101444741/InterfacesInteligentes_3/blob/main/ScriptsGIFs/ObjectCBehaviour.gif)