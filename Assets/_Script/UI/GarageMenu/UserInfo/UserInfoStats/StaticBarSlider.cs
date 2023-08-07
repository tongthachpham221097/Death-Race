using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StaticBarSlider : BaseSlider
{
    [Header("Stats Slider")]
    [SerializeField] protected PercentText percentText;
    [Header(" ")]
    [SerializeField] protected float maxPercent = 100;
    [SerializeField] protected float defaultPercent = 50;
    [SerializeField] protected float currentPercent = 0;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPercentText();
    }

    void LoadPercentText()
    {
        if (this.percentText != null) return;
        this.percentText = transform.parent.GetComponentInChildren<PercentText>();
        Debug.Log(transform.name + ": LoadPercentText", gameObject);
    }

    protected override void Start()
    {
        base.Start();
        this.UpdatePercent();
    }

    void UpdatePercent()
    {
        this.ShowPercentOnSlider();
        this.ShowPercentOnText();
    }

    void ShowPercentOnSlider()
    {
        this.slider.value = (this.currentPercent + this.defaultPercent) / this.maxPercent;
    }

    void ShowPercentOnText()
    {
        this.percentText.SetPercentText(this.currentPercent + this.defaultPercent);
    }

    protected virtual void IncreaseCurrentPercent(float percent)
    {
        this.currentPercent += percent;
        if (this.currentPercent <= 100) return;
        this.currentPercent = 100;
        this.UpdatePercent();
    }

    protected virtual void DecreaseCurrentPercent(float percent)
    {
        this.currentPercent -= percent;
        if(this.currentPercent >= 0) return;
        this.currentPercent = 0;
        this.UpdatePercent();
    }

    protected override void OnChanged(float newValue) { }

}
