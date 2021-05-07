using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turrentScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPoint;
    public Vector3 scrollSpeed = new Vector3(0.5f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position -= scrollSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag != "Player" && col.gameObject.tag != "Ground")
        {

            Destroy(gameObject);
            Debug.Log("invisible");
            
        }

    }


}
