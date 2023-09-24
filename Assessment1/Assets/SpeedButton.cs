using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedButton : MonoBehaviour
{
    [SerializeField] Animator button;
    public MoneyManager _mm;

    private void Start()
    {
        button = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_mm.currentMoney > _mm.spawnPrice)
        {
            button.SetBool("Disable", false);
        }
        if (_mm.currentMoney < _mm.spawnPrice)
        {
            button.SetBool("Disable", true);
        }
    }

    public void hover2()
    {
        button.SetTrigger("Hover");
        button.SetBool("UnHover", true);
    }
    public void unhover2()
    {
        button.SetBool("UnHover", false);
    }
    public void click2()
    {
        button.SetTrigger("Click");
        button.SetTrigger("UnHover");
    }
}
