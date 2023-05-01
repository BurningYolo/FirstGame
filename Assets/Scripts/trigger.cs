using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject player;
    public GameObject bulletPrefab;
    public float spawnInterval = -1f ;  
    public float bulletSpeed = 20f; 
    private Coroutine spawnCoroutine;
    private List<GameObject> bulletList = new List<GameObject>();
    private life lifeScript;
    private timer_count points ; 
    public GameObject endMenu;
    public GameObject ingameMenu; 


    
  void Start()
{
    endMenu.SetActive(false) ; 
    lifeScript = GameObject.Find("Health").GetComponent<life>();
    points = GameObject.Find("Points").GetComponent<timer_count>(); 
    
    Invoke("StartSpawnCoroutine", 2f);
}

  void Update()
    {
        if (lifeScript.Gameover)
        {
            StopCoroutine(spawnCoroutine);
            
            foreach (GameObject bullet in bulletList)
            {
                Destroy(bullet);
            }
            bulletList.Clear();
            endMenu.SetActive(true) ; 


        }
    }



  

  IEnumerator SpawnBullets()
{
    while (true)
    {
      bulletSpeed += points.totalpoints ; 
      for (int i = 0; i < points.totalpoints; i++)
      {

      

      Debug.Log("Bullet Speed" + bulletSpeed) ; 
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-4, 6), Random.Range(1, 3), 7);
        GameObject bullet = Instantiate(bulletPrefab, randomSpawnPosition, Quaternion.identity);
        bulletList.Add(bullet); // Add the spawned bullet to the bulletList

        // Calculate the direction vector from the bullet's position to the player's position
        Vector3 direction = (player.transform.position - bullet.transform.position).normalized;

        // Set the velocity of the bullet's Rigidbody to be the direction multiplied by a speed value
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = direction * bulletSpeed;

      }
        yield return new WaitForSeconds(spawnInterval);
    } 
}

void StartSpawnCoroutine()
{
  
    
        spawnCoroutine = StartCoroutine(SpawnBullets());
    
}
}
