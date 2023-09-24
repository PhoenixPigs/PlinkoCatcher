using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatcherButton : MonoBehaviour
{
    [SerializeField] Animator button;
    public MoneyManager _mm;

    private void Start()
    {
        button = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_mm.currentMoney > _mm.catcherPrice)
        {
            button.SetBool("Disable", false);
        }
        if (_mm.currentMoney < _mm.catcherPrice)
        {
            button.SetBool("Disable", true);
        }
    }

    public void hover3()
    {
        button.SetTrigger("Hover");
        button.SetBool("UnHover", true);
    }
    public void unhover3()
    {
        button.SetBool("UnHover", false);
    }
    public void click3()
    {
        button.SetTrigger("Click");
        button.SetTrigger("UnHover");
    }
}
