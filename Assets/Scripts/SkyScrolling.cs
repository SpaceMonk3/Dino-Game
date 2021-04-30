using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyScrolling : MonoBehaviour
{

    public Vector2 scrollSpeed = new Vector2(0.5f,0.5f);
    
    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset += scrollSpeed * Time.deltaTime;
    }
}
