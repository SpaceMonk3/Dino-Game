using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    [Range(0, 100)] public float jumpForce = 5.0f;
    public float bulletForce = 10;
    public ParticleSystem particle;
    public GameObject landing;
    public Animator anime;
    public Vector2 duckCollider;
    BoxCollider2D col;
    Rigidbody2D rb;
    bool colDetect = false;
    ParticleSystem particleHolder;
    public Transform shootpoint;
    public GameObject bullet;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Ground")
        {
            colDetect = true;
            anime.SetBool("IsOnGround",true);
            particleHolder = Instantiate(particle, landing.transform.position, landing.transform.rotation);
            particleHolder.Play();
            Debug.Log("Collision detected");
        }

    }
    void Update()
    {

        
        if (Input.GetKey(KeyCode.UpArrow) && colDetect)
        {
            anime.SetBool("IsOnGround",false);
            
            colDetect = false;
            Vector2 vec = rb.velocity;
            vec.y = jumpForce;
            rb.velocity = vec;
            Debug.Log("Pressed up arrow");
        }

        if (Input.GetKey(KeyCode.DownArrow) && colDetect)
        {
            anime.SetBool("isDuck", true);
            Debug.Log("Pressed down arrow");
            col.size = duckCollider;
        }
        else
        {
            anime.SetBool("isDuck", false);
            col.size = new Vector2(5.129419f, 6.101331f);
        }

        

    }
    
}
