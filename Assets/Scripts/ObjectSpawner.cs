using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    private float ranSec; 
    private int ranIndex;
    private float timeCounter;
    public GameObject[] prefabs;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
  
        ranSec = Random.Range(1.0f, 4.0f);
        timeCounter = 0.0f;
        ranIndex = 0;//Random.Range(0, 1);

        Debug.Log("prefabs array size at start = " + prefabs.Length);
        Debug.Log("random second at start = " + ranSec);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeCounter += Time.deltaTime;

        if (timeCounter >= ranSec )
        {
            timeCounter = 0.0f;

            Debug.Log("prefabs array size = " + prefabs.Length);
            Debug.Log("Random Index = " + ranIndex);
            
            Instantiate(prefabs[ranIndex], spawnPoint.position, Quaternion.identity);
            ranSec = Random.Range(0.0f, 2.0f);
            // write code so there is atleast .5 sec of gap btwn each instantiating
            Debug.Log("random second = " + ranSec);
            //ranIndex = Random.Range(0, 1);
        }
    }
}
