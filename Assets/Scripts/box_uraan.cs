using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_uraan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 2.0f;
    public float jump_speed = 4.0f; 

    void Update()
{
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

    if(Input.GetKey(KeyCode.Space))
    {
        transform.position += Vector3.up * jump_speed * Time.deltaTime;
    }
}

}
