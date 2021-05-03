using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Transform spawnStart;
    public Transform spawnCheck;
    public GameObject groundFab;
    public Vector3 scrollSpeed = new Vector3(0.5f, 0.0f,0.0f);
    public GameObject[] prefabs;
    public Transform spawnPoint; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
            // scrolling ground by subtracting position of x-coordinate
            GetComponent<Transform>().position -= scrollSpeed * Time.deltaTime;
           
    }


    void OnCollisionEnter2D(Collision2D col)
    {

        // destroying ground once it hits the exit point
        if (col.gameObject.tag != "Player" && col.gameObject.tag != "Obstacle")
        {
            
            Destroy(gameObject);
            Debug.Log("invisible");
        }
        
    }
    

    void OnTriggerExit2D()
    {
        // instantiating new ground once it hits the exit point
        groundFab = Instantiate(groundFab, spawnStart.position, Quaternion.identity);
        Debug.Log("Instantiate");

              
            /*instantiating cacti and pterodactyls
            int index = Random.Range(0, 1);
            Instantiate(prefabs[index], spawnPoint.position, Quaternion.identity);
            */
        
    }
}
