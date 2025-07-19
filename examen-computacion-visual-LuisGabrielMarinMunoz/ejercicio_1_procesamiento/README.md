# Ejercicio 1 - Procesamiento de Imagen y Detección con YOLO

Este ejercicio aplica un filtro de suavizado, detecta bordes y realiza detección de objetos con YOLOv8 sobre una imagen.

## Plataforma
ejercico realizado en colab, en el siguiente cuaderno, acceder con correo institucional

https://colab.research.google.com/drive/1ecpBqV5GvixDvLzCybelfB5VDvTQTZeI?usp=sharing
## Pasos Principales

```python
# Cargar imagen
img = cv2.imread(img_path)
img_rgb = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)

# Suavizado y bordes
img_suavizada = cv2.GaussianBlur(img_rgb, (5, 5), 0)
img_bordes = cv2.Canny(img_suavizada, 100, 200)

# YOLOv8
model = YOLO('yolov8n.pt')
results = model(img_rgb)
res_img = results[0].plot()
```

## Resultados

- `suavizado.png`
- `bordes.png`
- `deteccion_yolo.png`

## Vista de Imágenes

![alt text](image.png)
![alt text](image-1.png)
![alt text](image-2.png)
