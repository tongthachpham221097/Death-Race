using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticBar : LoboMonoBehaviour
{

    [SerializeField] private HealthSlider _healthSlider;
    public HealthSlider HealthSlider => _healthSlider;

    [SerializeField] private DamageSlider _damageSlider;
    public DamageSlider DamageSlider => _damageSlider;

    [SerializeField] private SpeedSlider _speedSlider;
    public SpeedSlider SpeedSlider => _speedSlider;

    [SerializeField] private DurabilitySlider _durabilitySlider;
    public DurabilitySlider DurabilitySlider => _durabilitySlider;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadHealthSlider();
        this.LoadDamageSlider();
        this.LoadSpeedSlider();
        this.LoadDurabilitySlider();
    }

    void LoadHealthSlider()
    {
        if (this._healthSlider != null) return;
        this._healthSlider = GetComponentInChildren<HealthSlider>();
        Debug.Log(transform.name + ": LoadHealthSlider", gameObject);
    }

    void LoadDamageSlider()
    {
        if (this._damageSlider != null) return;
        this._damageSlider = GetComponentInChildren<DamageSlider>();
        Debug.Log(transform.name + ": LoadDamageSlider", gameObject);
    }

    void LoadSpeedSlider()
    {
        if (this._speedSlider != null) return;
        this._speedSlider = GetComponentInChildren<SpeedSlider>();
        Debug.Log(transform.name + ": LoadSpeedSlider", gameObject);
    }

    void LoadDurabilitySlider()
    {
        if (this._durabilitySlider != null) return;
        this._durabilitySlider = GetComponentInChildren<DurabilitySlider>();
        Debug.Log(transform.name + ": LoadDurabilitySlider", gameObject);
    }

}
