using UnityEngine;

public class HandConrol : MonoBehaviour
{
    private Animation handAnimation;
    public float moveSpeed = 0.05f; // Speed at which the hand moves

    void Start()
    {
        handAnimation = GetComponent<Animation>();
    }

    void Update()
    {
        // Move the hand using arrow keys
        float moveX = Input.GetAxis("Horizontal") * moveSpeed; // Left/Right arrow keys
        float moveY = Input.GetAxis("Vertical") * moveSpeed;   // Up/Down arrow keys

        // Update the hand's position
        transform.position += new Vector3(moveX, moveY, 0);

        // Play the hand animation on mouse click
        if (Input.GetMouseButtonDown(0))
        {
            handAnimation.Play("AnimationClose"); // Replace "AnimationClose" with the exact name of your animation clip
        }

        if (Input.GetMouseButtonDown(1))
        {
            handAnimation.Play("AnimationOpen"); // Replace "AnimationClose" with the exact name of your animation clip
        }
    }
}