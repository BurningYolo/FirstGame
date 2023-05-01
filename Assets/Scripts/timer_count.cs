using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class timer_count : MonoBehaviour
{

    public Text timerText;
    public float startTime = 0.0f;
    public Text pointsText ; 
    public int totalpoints = 0 ; 

    private float timeRemaining;
    private life lifeScript;

    void Start()
    {
    lifeScript = GameObject.Find("Health").GetComponent<life>();
    InvokeRepeating("IncreasePoint", 0f, 5f);

    }

    void Update()
    {
        if (!lifeScript.Gameover)
        {
            startTime += Time.deltaTime;

            int minutes = Mathf.FloorToInt(startTime / 60.0f);
            int seconds = Mathf.FloorToInt(startTime % 60.0f);
            pointsText.text = "Points : "; 
            pointsText.text += totalpoints.ToString() ; 

            timerText.text = "Time : " ; 
            timerText.text += string.Format("{0:00}:{1:00}  ", minutes, seconds);
          



            
        }
        else
        {
            CancelInvoke("IncreasePoint");
        }
    }
     private void IncreasePoint()
    {
        totalpoints += 1;

    }


}
