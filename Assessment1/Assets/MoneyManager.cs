using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float currentMoney;

    public float ballValue;
    public int ballValueLevel;

    public int spawnSpeedLevel;

    public int catcherSizeLevel;
    [SerializeField] TMP_Text MoneyText;


    // Update is called once per frame
    void Update()
    {
        if (ballValueLevel < 1)
        {
            ballValue = 1;
        }
        if (ballValueLevel >= 1)
        {
            ballValue = ballValueLevel * 1.1f;
        }
        MoneyText.text = "$" + currentMoney;

    }
}
