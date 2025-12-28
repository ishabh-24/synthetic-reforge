using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToTarget : MonoBehaviour
{
    public GameObject snapTarget;   // The target GameObject that the object will snap to
    public float snapDistance = 1f; // Distance threshold for snapping

    private bool isSnapped = false; // Track if the object is snapped
    private Vector3 originalPosition; // Store the original position of the object

    // Start is used to initialize the original position of the object
    void Start()
    {
        originalPosition = transform.position; // Store the original position at the start
    }

    void Update()
    {
        // Check the distance between the object and the snap target
        float distance = Vector3.Distance(transform.position, snapTarget.transform.position);

        // If the object is within the snap range and isn't already snapped, snap it
        if (distance <= snapDistance && !isSnapped)
        {
            SnapObject();
        }
        // If the object moves away from the target, unsnap it
        else if (distance > snapDistance && isSnapped)
        {
            UnSnapObject();
        }
    }

    // This method will snap the object to the target position
    void SnapObject()
    {
        transform.position = snapTarget.transform.position; // Set position to snap target
        isSnapped = true; // Mark as snapped
        Debug.Log("Object snapped to target.");
    }

    // This method will return the object to its original position if it unsnaps
    void UnSnapObject()
    {
        transform.position = originalPosition; // Restore the original position
        isSnapped = false; // Mark as unsnapped
        Debug.Log("Object unsnapped from target.");
    }
}
