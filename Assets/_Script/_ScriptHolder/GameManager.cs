using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public virtual void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public virtual void PauseGame()
    {
        Time.timeScale = 0;
        UIManager.instance.UICtrl.pauseMenu.SetActive(true);
    }
    public virtual void ExitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public virtual void ResumeGame()
    {
        Time.timeScale = 1;
        UIManager.instance.UICtrl.pauseMenu.SetActive(false);
    }
}
