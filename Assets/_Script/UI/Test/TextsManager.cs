using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TextsManager : LoboMonoBehaviour
{
    protected virtual IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            this.CheckTexts();
        }
    }

    protected virtual void CheckTexts()
    {
        foreach(Transform text in transform)
        {
            bool textActiveSelf = text.gameObject.activeSelf;
            text.gameObject.SetActive(!textActiveSelf);
        }
    }
}
