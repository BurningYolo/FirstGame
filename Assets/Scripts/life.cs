using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class life : MonoBehaviour
{
    public Text numberText;

    public bool Gameover = false ; 

    // Reference to player_collider script
    public player_collider playerCollider;

    // Start is called before the first frame update
    void Start()
    {
        // Get the player_collider component attached to the player object
        playerCollider = GameObject.Find("player").GetComponent<player_collider>();
    }

    // Update is called once per frame
    void Update()
    {
        int number = playerCollider.health; // Get the health value from player_collider script
        numberText.text = "Health : "  +number.ToString();

        if(number == 0 || number < 0  )
        {

            numberText.text = "GAME OVER" ; 
            GameObject player = GameObject.FindWithTag("Player"); // Find the player object by its tag
            numberText.color = Color.red;
            Gameover = true ;
            

        }
    }
}