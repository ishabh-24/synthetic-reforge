using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 targetPosition; 

 
    public Material newMaterial; 


    public float tolerance = 0.1f; 

    private Renderer objectRenderer;
    private bool materialSwitched = false;

    void Start()
    {
       
        objectRenderer = GetComponent<Renderer>();

 
       
    }

    void Update()
    {
        if (!materialSwitched && Vector3.Distance(transform.position, targetPosition) <= tolerance)
        {
            SwitchMaterial();
        }
    }

    void SwitchMaterial()
    {

        if (objectRenderer != null && newMaterial != null)
        {
            objectRenderer.material = newMaterial;
            materialSwitched = true;
            Debug.Log("Material switched!");
        }
    }
}
