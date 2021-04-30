using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float bulletSpeed = 10.0f; 

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("bullet hit Dino");
        }
        else //if(collision.gameObject.tag != "Obstacle")
        {
            Destroy(gameObject);
            Debug.Log("bullet destroy");
        }
    } 
}
