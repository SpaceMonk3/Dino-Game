using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float ranSec; 
    private int ranIndex;
    private float timeCounter;
    public GameObject[] prefabs;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        ranSec = Random.Range(2.0f, 5.0f);
        timeCounter = 0.0f;
        ranIndex = 0;//Random.Range(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //timeCounter update;

        if (timeCounter >= ranSec )
        {
            timeCounter = 0.0f;
            Instantiate(prefabs[ranIndex], spawnPoint.position, Quaternion.identity);
            ranSec = Random.Range(2.0f, 5.0f);
            //ranIndex = Random.Range(0, 1);
        }
    }
}
