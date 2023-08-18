using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : LoboMonoBehaviour
{
    
    public void OnEnableMainMenu()
    {
        UICtrl.Instance.MainMenu.gameObject.SetActive(true);
    }

    public void DisableMainMenu()
    {
        UICtrl.Instance.MainMenu.gameObject.SetActive(false);    
    }

    public void OnEnableGarageMenu()
    {
        UICtrl.Instance.GarageMenu.gameObject.SetActive(true);
    }

    public void DisableGarageMenu()
    {
        UICtrl.Instance.GarageMenu.gameObject.SetActive(false);
    }

    public void DisableChooseRaceMenu()
    {
        UICtrl.Instance.ChooseRaceMenu.gameObject.SetActive(false);
    }

}
