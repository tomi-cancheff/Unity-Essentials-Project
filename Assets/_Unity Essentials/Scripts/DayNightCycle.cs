
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds")]
    public float dayDuration = 60f; // Default duration for a full day in seconds

    private float rotationSpeed;

    void Start()
    {
        // Calculate the rotation speed based on the duration of the day
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light around the X-axis to simulate the day-night cycle
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
