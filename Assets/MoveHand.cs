using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MoveHand : MonoBehaviour
{
   
    public Camera mainCamera; // Reference to the main camera
    public float zDepth = 5f; // Depth of the hand in the 3D world

    void Update()
    {
        FollowMouse();
    }

    private void FollowMouse()
    {
        // Get the mouse position in screen coordinates
        UnityEngine.Vector3 mouseScreenPosition = Input.mousePosition;

        // Set the depth (z position) in world coordinates
        mouseScreenPosition.z = zDepth;

        // Convert screen position to world position
        UnityEngine.Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mouseScreenPosition);

        // Set the hand's position to the mouse world position
        transform.position = mouseWorldPosition;
    }

}
