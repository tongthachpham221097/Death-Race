using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownText : BaseText
{
    public Color highlightColor;
    public Vector3 scaleAmount;
    public GameObject inputManager;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInputManager();
    }
    protected virtual void LoadInputManager()
    {
        if (this.inputManager != null) return;
        this.inputManager = GameObject.Find("InputManager");
        Debug.Log(transform.name + ": LoadInputManager", gameObject);
    }
    public virtual void Countdown()
    {
        StartCoroutine(StartCountdown());
    }
    IEnumerator StartCountdown()
    {
        int countdownValue = 3;
        while (countdownValue > 0)
        {
            text.text = countdownValue.ToString();
            text.color = highlightColor;
            text.transform.localScale = scaleAmount;
            yield return new WaitForSeconds(0.5f);
            text.color = Color.white;
            text.transform.localScale = Vector3.one;
            yield return new WaitForSeconds(0.5f);
            countdownValue--;
        }
        yield return new WaitForSeconds(0.5f);
        text.text = "GO!";
        yield return new WaitForSeconds(1f);
        text.color = highlightColor;
        text.transform.localScale = scaleAmount;
        yield return new WaitForSeconds(0.5f);
        InputManager.Instance.countDowned = true;
        text.gameObject.SetActive(false);
    }
}
