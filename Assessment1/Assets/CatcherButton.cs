using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatcherButton : MonoBehaviour
{
    [SerializeField] Button button;
    public MoneyManager _mm;

    private void Start()
    {

    }

    private void Update()
    {
        if (_mm.currentMoney > _mm.catcherPrice)
        {
            button.interactable = true;
        }
        if (_mm.currentMoney < _mm.catcherPrice)
        {
            button.interactable = false;
        }
    }
}
