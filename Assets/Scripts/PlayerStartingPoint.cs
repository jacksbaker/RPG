using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartingPoint : MonoBehaviour
{

    private PlayerMovement thePlayer;
    private CameraMovement theCamera;

    public Vector2 startDirection;

    public string pointName;

    // Start is called before the first frame update
    void Start()
    {
        
        thePlayer = FindObjectOfType<PlayerMovement>();

        if(thePlayer.startPoint == pointName)
        {
            thePlayer.transform.position = transform.position;
            thePlayer.lastMove = startDirection;

            theCamera = FindObjectOfType<CameraMovement>();
            theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
