using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    
    // Start is called before the first frame update
    public void pause()
    {
        Time.timeScale = 0;
    }

    public void resume()
    {
        Time.timeScale = 1;
    }

    public void replay()
    {
        SceneManager.LoadScene("Main Scene");
        Time.timeScale = 1;
    }

    public void quit()
    {
        Debug.Log("QUIT!!!!!");
        Application.Quit();
    }
}
