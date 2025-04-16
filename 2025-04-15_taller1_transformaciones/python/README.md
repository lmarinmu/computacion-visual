# Transformation Animation – Python (Jupyter Notebook)

This notebook demonstrates basic **2D geometric transformations** (translation, rotation, scaling) on an **equilateral triangle** centered at the origin.

## 📚 Libraries

```python
import numpy as np
import matplotlib.pyplot as plt
from matplotlib.animation import FuncAnimation
from IPython.display import HTML, display
```
to create the matrices, graph the corresponding shapes, create the animations, and display them on the notebook correctly

## 📐 Shape

The shape used is a triangle with:
- All sides of length 1
- Centered at the origin (0,0)
- Defined using homogeneous coordinates for easy matrix transformations

## 🧠 Transformations Applied

Each frame of the animation applies the following combined transformation:

1. 🔁 **Rotation** – triangle rotates continuously over time
2. 🌀 **Translation** – triangle moves in a circular path
3. 🔍 **Scaling** – triangle pulses by expanding and shrinking smoothly

each transformation was defines as a function previously

## 🎞️ Output

Below is a preview of the generated animation:
![[animated_triangle.gif]]

## 🧑‍💻 Author

`Luis Gabriel Marin Munoz`
Created as part of the `Taller 1` assignment for the computer vision class