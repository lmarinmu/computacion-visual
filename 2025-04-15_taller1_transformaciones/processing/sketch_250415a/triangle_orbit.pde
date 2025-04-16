/*Escenario:
Crear un sketch simple (2D o 3D)
Dibujar una figura geométrica (rect, ellipse o box)
Aplicar transformaciones usando:
translate(), rotate(), scale()
pushMatrix() y popMatrix() para aislar transformaciones
frameCount, millis() o sin() para crear transformaciones en el tiempo
Ejemplo: un cubo que gira, se traslada de forma ondulada y se escala cíclicamente en función del tiempo transcurrido
*/

void setup() {
  size(600, 600);       // Set the window size
  frameRate(60);        // Frames per second
}




void draw() {
  background(255);

  float angle = frameCount * 0.03;
  float radius = 100;

  float x = width/2 + cos(angle) * radius;
  float y = height/2 + sin(angle) * radius;
  
  float s = 1 + 0.5 * sin(frameCount * 0.05); // scale pulsing

  
 

  pushMatrix();
  translate(x, y);     // Move the triangle to its orbit position
  scale(s);
  rotate(angle);       // Optional: rotate the triangle as it moves
  fill(100, 150, 255);
  triangle(0, -25, -22, 12, 22, 12);
  popMatrix();
  saveFrame("frames/frame####.png");
}
