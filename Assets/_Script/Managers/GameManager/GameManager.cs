using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class GameManager : GameManagerAbstract
{
    protected virtual void Update()
    {
        if(InputManager.Instance.PressKeyEsc) this.PauseGame();
    }
    public virtual async void ResetGame()
    {
        this.gameManagerCtrl.DistanceText.SetLastDistance();
        this.gameManagerCtrl.DistanceText.SetHighDistance();
        this.gameManagerCtrl.PlayerCollider.isGameOver = false;
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        while (!asyncLoad.isDone)
        {
            await Task.Yield();
        }
        MainMenu mainMenu = FindObjectOfType<MainMenu>();
        if (mainMenu != null)
        {
            mainMenu.DisableMainMenu();
        }
        PauseMenu pauseMenu = FindObjectOfType<PauseMenu>();
        if (pauseMenu != null)
        {
            pauseMenu.DisablePauseMenu();
        }
        AudioSource soundMainMenu = GameObject.Find("SoundMainMenu").GetComponent<AudioSource>();
        soundMainMenu.mute = true;
        CountDownText countDownText = FindObjectOfType<CountDownText>();
        countDownText.Countdown();
        Time.timeScale = 1;
    }
    public virtual void StartGame()
    {
        this.gameManagerCtrl.pauseMenu.SetActive(false);
        this.gameManagerCtrl.soundMainMenu.mute = true;
    }
    public virtual void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public virtual void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}
