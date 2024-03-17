using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryManager : MonoBehaviour
{
    private float boundaryX = 15.0f;
    private float boundaryZ = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > boundaryX)
        {
            transform.position = new Vector3(boundaryX, transform.position.y, transform.position.z);
        } else if (transform.position.x < -boundaryX)
        {
            transform.position = new Vector3(-boundaryX, transform.position.y, transform.position.z);
        } else if (transform.position.z > boundaryZ )
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, boundaryZ);            
        } else if (transform.position.z < -boundaryZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -boundaryZ);
        }
        
    }
}
