using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiderAnimation : LoboMonoBehaviour
{
    [SerializeField] private Animator _animator;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAnimator();
    }

    void LoadAnimator()
    {
        if (this._animator != null) return;
        this._animator = GetComponent<Animator>();
        Debug.LogWarning(transform.name + ": LoadAnimator", gameObject);
    }

    private void Update()
    {
        this.SetPressHorizontal();
        this.SetIsAttacking();
    }

    void SetPressHorizontal()
    {
        if (InputManager.Instance.PressHorizontal == 0) return;
        float pressHorizontal = InputManager.Instance.PressHorizontal;
        this._animator.SetFloat("pressHorizontal", pressHorizontal);
    }    

    void SetIsAttacking()
    {
        bool isAttack = InputManager.Instance.PressCtrl;
        this._animator.SetBool("isAttack", isAttack);
    }

}
