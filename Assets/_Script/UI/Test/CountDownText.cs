using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownText : BaseText
{
    public Color highlightColor;
    public Vector3 scaleAmount;
    public GameObject carSpawner;
    public AudioSource soundIdle;
    public AudioSource soundRacing;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCarSpawner();
        this.LoadSoundIdle();
        this.LoadSoundRacing();
    }
    protected virtual void LoadCarSpawner()
    {
        if (this.carSpawner != null) return;
        this.carSpawner = GameObject.Find("CarSpawner");
        Debug.Log(transform.name + ": LoadCarSpawner", gameObject);
    }
    protected virtual void LoadSoundIdle()
    {
        if (this.soundIdle != null) return;
        this.soundIdle = GameObject.Find("SoundIdle").GetComponent<AudioSource>();
        Debug.Log(transform.name + ": LoadSoundIdle", gameObject);
    }
    protected virtual void LoadSoundRacing()
    {
        if (this.soundRacing != null) return;
        this.soundRacing = GameObject.Find("SoundRacing").GetComponent<AudioSource>();
        Debug.Log(transform.name + ": LoadSoundRacing", gameObject);
    }
    public virtual void Countdown()
    {
        //StartCoroutine(StartCountdown());
    }
    IEnumerator StartCountdown()
    {
        for (int countdownValue = 3; countdownValue > 0; countdownValue--)
        {
            text.text = countdownValue.ToString();
            this.SetHighlightStyle();
            yield return new WaitForSeconds(0.5f);
            text.color = Color.white;
            text.transform.localScale = Vector3.one;
            yield return new WaitForSeconds(0.5f);
        }

        text.text = "GO!";
        this.SetHighlightStyle();
        yield return new WaitForSeconds(0.5f);
        text.color = Color.white;
        text.transform.localScale = Vector3.one;
        yield return new WaitForSeconds(1f);

        this.FinishCountDown();
        text.gameObject.SetActive(false);
    }
    protected virtual void SetHighlightStyle()
    {
        this.text.color = highlightColor;
        this.text.transform.localScale = scaleAmount;
    }
    protected virtual void FinishCountDown()
    {
        //InputManager.Instance.CountDowned = true;
        this.carSpawner.SetActive(true);
        this.soundIdle.mute = true;
        this.soundRacing.mute = false;
    }
}
