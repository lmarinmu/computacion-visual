using UnityEngine;

public class Transformer : MonoBehaviour
{
    public float rotationSpeed = 45f;
    public float moveInterval = 2f;
    public float moveDistance = 2f;
    public float moveSpeed = 2f;
    public float scaleAmplitude = 0.3f;
    public float baseScale = 1f;

    private float lastMoveTime = 0f;
    private Vector3 targetPosition;

    void Start()
    {
        // Start at current position
        targetPosition = transform.position;
    }

    void Update()
    {
        // 1. 🔁 Rotation
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        // 2. 🎯 Pick a new target position every few seconds
        if (Time.time - lastMoveTime > moveInterval)
        {
            float dx = Random.Range(-1f, 1f) * moveDistance;
            float dy = Random.Range(-1f, 1f) * moveDistance;

            // Set new target position based on current position
            targetPosition = transform.position + new Vector3(dx, dy, 0);
            lastMoveTime = Time.time;
        }

        // 3. ➡️ Smoothly move toward target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // 4. 📏 Oscillating scale
        float scale = baseScale + Mathf.Sin(Time.time) * scaleAmplitude;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
