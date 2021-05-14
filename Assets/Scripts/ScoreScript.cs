using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    float time = 0f;
   
    // Update is called once per frame
    void Update()
    {
        //counting time (score) passed between frames  *Note - Time.time returns the total time passed since start of game 
        time += Time.deltaTime;
        scoreText.text = time.ToString("0");
    }
}
