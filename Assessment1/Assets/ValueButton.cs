using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueButton : MonoBehaviour
{
    [SerializeField] Animator button;
    public MoneyManager _mm;

    private void Start()
    {
        button = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_mm.currentMoney > _mm.currentPrice)
        {
            button.SetBool("Disable", false);
        }
        if (_mm.currentMoney < _mm.currentPrice)
        {
            button.SetBool("Disable", true);
        }
    }

    public void hover()
    {
        button.SetTrigger("Hover");
        button.SetBool("UnHover", true);
    }
    public void unhover()
    {
        button.SetBool("UnHover", false);
    }
    public void click()
    {
        button.SetTrigger("Click");
        button.SetTrigger("UnHover");
    }
}
