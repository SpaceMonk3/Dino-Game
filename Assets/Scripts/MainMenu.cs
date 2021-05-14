using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void start()
    {
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1;
    }

    public void mainMenu() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
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
        SceneManager.LoadScene("MainScene");
        Time.timeScale = 1;
    }

    public void quit()
    {
        Debug.Log("QUIT!!!!!");
        Application.Quit();
    }
}
