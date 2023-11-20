using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueButton : MonoBehaviour
{
    [SerializeField] Button value;
    public MoneyManager _mm;
    [SerializeField] Animator test;

    private void Start()
    {
        value = GetComponent<Button>();
    }

    private void Update()
    {
        if (_mm.currentMoney > _mm.currentPrice)
        {
            value.interactable = false;
        }
        if (_mm.currentMoney < _mm.currentPrice)
        {
            test.SetTrigger("Disabled");
            value.interactable = true;
        }
    }
}
