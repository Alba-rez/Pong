# Pong - Unity Game

---

## **Descripción**
Este proyecto es una versión moderna del clásico juego **Pong**, desarrollado en Unity. El objetivo es lograr la máxima puntuación controlando una pala para devolver la pelota al oponente y evitar que entre en tu portería.

---

## **Características**
- **Jugabilidad clásica**: Dos jugadores compiten en tiempo real.
- **Controles personalizables** para cada pala.
- **Física realista** aplicada a la pelota.
- **Efectos de sonido** para colisiones y goles.
- **Inicio del juego** con la barra espaciadora y cierre con la tecla Escape.

---

## **Controles**
### **Jugador 1 (Pala Izquierda)**
- **Mover arriba**: Tecla `W`
- **Mover abajo**: Tecla `S`

### **Jugador 2 (Pala Derecha)**
- **Mover arriba**: Flecha `↑`
- **Mover abajo**: Flecha `↓`

---

## **Estructura del Proyecto**
### **Scripts Principales**
1. **`GameManager`**:
   - Gestiona el marcador.
   - Controla el inicio y fin del juego.
   - Actualiza la interfaz gráfica con las puntuaciones.

2. **`PelotaController`**:
   - Controla el comportamiento físico de la pelota.
   - Implementa la lógica de rebotes y detección de goles.
   - Genera efectos sonoros en las colisiones.

3. **`PalaController`**:
   - Maneja el movimiento de las palas.
   - Diferencia controles entre jugador 1 y jugador 2.

### **Assets**
- **Pelota**: Con un `Rigidbody2D` para aplicar fuerzas.
- **Palas**: Con un diseño sencillo y movimientos verticales.
- **Porterías**: Detectan goles mediante `OnTriggerEnter2D`.
- **Textos**: Dos textos para mostrar las puntuaciones de ambos jugadores.

---

## **Configuración del Proyecto**
1. **Componentes del Juego**:
   - **Pelota**:
     - Agrega un `Rigidbody2D` con una masa y fricción predeterminadas.
   - **Palas**:
     - Establece un `BoxCollider2D` para detectar colisiones.
   - **Porterías**:
     - Configura un `Collider2D` como "Trigger".
   - **Canvas**:
     - Añade dos campos de texto para las puntuaciones de los jugadores.

2. **Configuración del Script `GameManager`**:
   - Vincula los textos para las puntuaciones desde el inspector.
   - Asocia el objeto `Pelota` al script.

3. **Configuración del Script `PelotaController`**:
   - Establece el valor de `force` (fuerza del impulso inicial).
   - Configura los sonidos para colisiones y goles en el inspector.

4. **Configuración del Script `PalaController`**:
   - Define la velocidad de las palas en el inspector.
   - Asegúrate de etiquetar correctamente las palas como `Pala1` y `Pala2`.

---

## **Cómo Jugar**
1. Descarga el proyecto y ejecuta el archivo .exe.
3. Presiona `Espacio` para comenzar la partida.
4. Usa los controles asignados para mover las palas.
5. El primer jugador en alcanzar la puntuación máxima, ¡gana!

---

## **Requisitos del Sistema**
- Unity 2021.3 o superior.
- Sistema operativo Windows, macOS o Linux.

---

## **To-Do List**
- Implementar un modo **un jugador** contra IA.
- Añadir **niveles de dificultad**.

---

### **¡Diviértete jugando a Pong!** 🕹️
