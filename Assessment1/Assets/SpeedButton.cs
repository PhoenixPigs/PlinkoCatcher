using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedButton : MonoBehaviour
{
    [SerializeField] Button Speed;
    public MoneyManager _mm;

    private void Start()
    {
        Speed = GetComponent<Button>();
    }

    private void Update()
    {
        if (_mm.currentMoney > _mm.spawnPrice)
        {
            Speed.interactable = false;
        }
        if (_mm.currentMoney < _mm.spawnPrice)
        {
            Speed.interactable = true;
        }
    }
}
