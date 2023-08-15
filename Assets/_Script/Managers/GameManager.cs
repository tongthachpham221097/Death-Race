using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class GameManager : LoboMonoBehaviour
{
    protected virtual void Update()
    {
        if(InputManager.Instance.PressKeyEsc) this.PauseGame();
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
