using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public virtual void GameOver()
    {
        if (UIManager.instance.UICtrl.buttonRestart.activeSelf) this.ResetGame();
    }
    public virtual void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
