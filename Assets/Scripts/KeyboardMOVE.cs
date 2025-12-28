using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMOVE : MonoBehaviour
{

    public float speed = 5.0f;
    private float HorizontalInput;
    private float VerticalInput;
    private float UpInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        UpInput = Input.GetAxis("Up");

        transform.Translate(Vector3.forward *Time.deltaTime * speed * VerticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * speed * UpInput);
    }
}
