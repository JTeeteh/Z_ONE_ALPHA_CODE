using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void Settings()
    {
        SceneManager.LoadScene("Options");
    }
    public void Retrun()
    {
        SceneManager.LoadScene("MainMenu_StartUp");
    }
    public void VashuKek()
    {
        SceneManager.LoadScene("VashScare");
    }
    public void YouFool()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void ReTry()
    {
        SceneManager.LoadScene("Stage 1");
    }
}
