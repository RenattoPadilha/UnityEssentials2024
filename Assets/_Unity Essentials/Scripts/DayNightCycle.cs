using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Duration of a full day in seconds
    public float dayDurationInSeconds = 120f; // Default is 24 hours

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation speed based on the duration of the day
        float rotationSpeed = 360f / dayDurationInSeconds;

        // Rotate the light around the x-axis
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
