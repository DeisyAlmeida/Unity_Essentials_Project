using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds")]
    [SerializeField]
    private float dayDurationInSeconds = 120f; // Default: 2 minutes per day

    void Update()
    {
        // Calculate rotation per frame based on day duration
        float rotationSpeed = 360f / dayDurationInSeconds;
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
