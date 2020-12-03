using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{

    private BoxCollider2D bounds;
    private CameraMovement theCamera;

    
    
    // Start is called before the first frame update
    void Start()
    {
        bounds = GetComponent<BoxCollider2D>();
        theCamera = FindObjectOfType<CameraMovement>();
        theCamera.SetBounds(bounds);
    }

   
}
