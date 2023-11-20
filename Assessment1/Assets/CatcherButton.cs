using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatcherButton : MonoBehaviour
{
    [SerializeField] Button catcher;
    public MoneyManager _mm;

    private void Start()
    {
        catcher = GetComponent<Button>();
    }

    private void Update()
    {
        if (_mm.currentMoney > _mm.catcherPrice)
        {
            catcher.interactable = false;
        }
        if (_mm.currentMoney < _mm.catcherPrice)
        {
            catcher.interactable = true;
        }
    }
}
