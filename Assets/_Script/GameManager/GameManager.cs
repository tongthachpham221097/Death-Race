using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : GameManagerAbstract
{
    protected virtual void Update()
    {
        if(InputManager.Instance.pressKeyEscape != 0) this.PauseGame();
    }
    public virtual void ResetGame()
    {
        this.GameManagerCtrl.DistanceText.SetLastDistance();
        this.GameManagerCtrl.DistanceText.SetHighDistance();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public virtual void PauseGame()
    {
        UIManager.instance.UICtrl.pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public virtual void ExitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public virtual void ResumeGame()
    {
        UIManager.instance.UICtrl.pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
