using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    float score = 0f; //time in seconds


    // Start is called before the first frame update
    void Start()
    {
        //getting a stored key-value pair from the system, returns default value of "0f" if key-value pair doesn't exist
        highScoreText.text = PlayerPrefs.GetFloat("HighScore", 0f).ToString("0"); 
    }

    // Update is called once per frame
    void Update()
    {
        //counting time (score) passed between frames  *Note - Time.time returns the total time passed since start of game 
        score += Time.deltaTime;
        string textScore = score.ToString("0");
        scoreText.text = textScore;

        if (GameObject.Find("DinoT").GetComponent<DinoMovement>().gameOver == true)
        {
            //comparing highscore and updating it
            if (PlayerPrefs.GetFloat("HighScore", 0f) < score)
            {
                PlayerPrefs.SetFloat("HighScore", score);
                highScoreText.text = PlayerPrefs.GetFloat("HighScore", 0f).ToString("0"); //"PlayerPrefs" stores player preferences 
                                                                                          //in the system even when game is quit
            }
        }
    }
}
