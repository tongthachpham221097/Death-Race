using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPause : BaseButton
{
    protected virtual void PauseGame()
    {
        Time.timeScale = 0;
    }
}
