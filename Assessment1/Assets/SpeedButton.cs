using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedButton : MonoBehaviour
{
    [SerializeField] Button button;
    public MoneyManager _mm;

    private void Start()
    {

    }

    private void Update()
    {
        if (_mm.currentMoney > _mm.spawnPrice)
        {
            button.interactable = true;
        }
        if (_mm.currentMoney < _mm.spawnPrice)
        {
            button.interactable = false;
        }
    }
}

