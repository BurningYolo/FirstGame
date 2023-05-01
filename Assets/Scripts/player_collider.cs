using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collider : MonoBehaviour
{
  private Renderer cubeRenderer;
  public int health = 5 ; 

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "bullets" || collision.gameObject.name == "bullets (Clone)")
        {
            cubeRenderer.material.color = Color.red;
            health -- ; 
            Debug.Log("Health" + health);
            

        }
    }

    void OnCollisionExit(Collision collision)
    {
         if (collision.gameObject.name == "bullets" || collision.gameObject.name == "bullets (Clone)")
        {
            cubeRenderer.material.color = Color.green;
            Destroy(collision.gameObject); 
        }
    }
}
