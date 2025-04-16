# 🎨 Basic Transformations – Processing

This sketch demonstrates 2D geometric transformations using the Processing environment. 
A triangle is made to rotate, orbit and rescale using processing built-in functions, as well as using pushMatrix() and popMatrix() to revert the canvas to the original state.

Finally we save the frames of the animation to make a gif using a website

## 🔺 2D Orbiting Triangle Animation

An equilateral triangle is:

- 🔁 Rotated continuously using `rotate()`
- 🌍 Translated in a circular orbit using `translate(cos(t), sin(t))`
- 🌀 Optionally scaled over time using `scale(sin(t))` to simulate a pulsing effect

The animation uses `pushMatrix()` and `popMatrix()` to isolate transformations to the triangle only.

### 🧰 Key Functions

- `translate(x, y)` – moves the drawing space
- `rotate(angle)` – rotates the coordinate system
- `triangle(x1, y1, x2, y2, x3, y3)` – draws the shape
- `frameCount` – time/frame-based animation variable
- `fill(r, g, b)` – sets color
- `pushMatrix()` / `popMatrix()` – scopes transformations locally

### 🎞 Preview

![[triangleGif.gif]]

## 🧑‍💻 Author

`Luis Gabriel Marin Munoz`

Created as part of the `Taller 1` assignment for the computer vision class