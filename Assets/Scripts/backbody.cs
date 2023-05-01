using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbody : MonoBehaviour
{

    private Renderer cubeRenderer;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        
    }

    // Update is called once per frame

    
        void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "bullets" || collision.gameObject.name == "bullets (Clone)")
        {

            Destroy(collision.gameObject); 
        
        
        
    }
    }
}
