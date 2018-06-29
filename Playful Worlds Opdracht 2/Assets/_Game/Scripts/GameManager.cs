using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

     
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void GameWin()
    {
        SceneManager.LoadScene("GameWin");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
