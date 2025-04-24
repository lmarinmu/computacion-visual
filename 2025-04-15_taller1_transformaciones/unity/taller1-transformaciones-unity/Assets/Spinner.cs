// Escenario:
// Crear un proyecto vacío en 3D
// Agregar un cubo o esfera a la escena
// Crear un script en C# que aplique:
// Traslación aleatoria por eje X o Y cada ciertos segundos
// Rotación constante dependiente de Time.deltaTime
// Escalado oscilante en función de Mathf.Sin(Time.time)
// Requisitos: usar transform.Translate(), transform.Rotate(), transform.localScale


using UnityEngine;



public class Transformer : MonoBehaviour
{
    public float rotationSpeed = 45f;          // degrees per second
    public float moveInterval = 2f;            // seconds between random moves
    public float moveAmount = 1f;              // amount to move in x or y
    public float scaleAmplitude = 0.3f;        // how much it pulses
    public float baseScale = 1f;               // starting size

    private float lastMoveTime = 0f;

    void Update()
    {
        // 1. 🔁 Constant rotation
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        // 2. ↔ Random translation every few seconds
        if (Time.time - lastMoveTime > moveInterval)
        {
            float dx = Random.Range(-1f, 1f) * moveAmount;
            float dy = Random.Range(-1f, 1f) * moveAmount;
            transform.Translate(new Vector3(dx, dy, 0));
            lastMoveTime = Time.time;
        }

        // 3. 📏 Oscillating scale using sin()
        float scale = baseScale + Mathf.Sin(Time.time) * scaleAmplitude;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
