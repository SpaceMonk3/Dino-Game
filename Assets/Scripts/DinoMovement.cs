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
    public Transform shootpoint;
    public GameObject bullet;
    public GameObject menu;

    //private variables
    ParticleSystem particleHolder;
    bool colDetect = false;
    BoxCollider2D col;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        // Playing particle animation
        if (col.gameObject.tag == "Ground")
        {
            colDetect = true;
            anime.SetBool("IsOnGround",true);
            particleHolder = Instantiate(particle, landing.transform.position, landing.transform.rotation);
            particleHolder.Play();
            Debug.Log("Collision detected");
        }

        //pausing game when Dino hits an obstacle (gameover)
        if (col.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
            menu.SetActive(true);
        }

    }
    void Update()
    {

        // keyboard controls (up and down arrow)
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
