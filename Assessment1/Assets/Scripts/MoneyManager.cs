using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using System;

public class MoneyManager : MonoBehaviour
{
    public float currentMoney;

    public float ballValue;
    public int ballValueLevel;
    public float ballValuePrice;
    public Button ballValueUpgrade;

    [SerializeField] TMP_Text MoneyText;
    [SerializeField] TMP_Text ballValueText;
    [SerializeField] TMP_Text ballValueUpgradeText;
    [SerializeField] TMP_Text ballValueUpgradeAmountText;

    public BallSpawner _ballSpawner;
    public int spawnSpeedLevel;
    public float spawnPrice;
    public Button spawnSpeedUpgrade;

    [SerializeField] TMP_Text spawnText;
    [SerializeField] TMP_Text spawnPriceText;

    public Transform catcherSpawn;
    public GameObject Catcher1;
    public GameObject Catcher2;
    public GameObject Catcher3;
    public int catcherLevel;
    public int catcherSize;
    public int catcherPrice;
    public Button catcherSizeUpgrade;

    public Combo _combo;


    [SerializeField] TMP_Text catcherText;
    [SerializeField] TMP_Text catcherPriceText;

    public float currentValue;
    private void Start()
    {
        ballValueLevel = 1;
        currentValue = 1;
        catcherLevel = 1;
        Instantiate(Catcher1, catcherSpawn.position, catcherSpawn.rotation);
        Catcher1 = GameObject.FindGameObjectWithTag("Catcher");
    }
    // Update is called once per frame
    void Update()
    {
        ballValuePrice = ballValue * 10.5f;
        spawnPrice = 30 * (spawnSpeedLevel + 1);
        if (catcherLevel == 1)
        {
            catcherPrice = 500;
        }
        if (catcherLevel == 2)
        {
            catcherPrice = 10000;
            Catcher2 = GameObject.FindGameObjectWithTag("Catcher");
        }
        if (catcherLevel == 3)
        {
            Catcher3 = GameObject.FindGameObjectWithTag("Catcher");
        }

        MoneyText.text = "$" + currentMoney;

        ballValueText.text = "$" + ballValue;
        ballValueUpgradeText.text = "$" + ballValuePrice;

        spawnText.text = _ballSpawner.BallSpawnSpeed + "'s";
        spawnPriceText.text = "$" + spawnPrice;

        catcherText.text = "level - " + catcherLevel;
        catcherPriceText.text = "$" + catcherPrice;



    }
    public void UpgradeValue()
        {
            if (ballValuePrice < currentMoney)
            {
            if (_combo.comboActive == true)
            {
                ballValue /= 1.5f;
            }
                ballValue += (ballValueLevel * 0.1f) ;
                ballValueUpgradeAmountText.text = "Upgrade ball value $" + ballValueLevel * 0.1f;
                currentMoney -= ballValuePrice;
                currentMoney = Mathf.Round(currentMoney * 100f) / 100f;
                ballValue = Mathf.Round(ballValue * 100f) / 100f;
                ballValueLevel++;

                if (_combo.comboActive == true)
                {
                    ballValue *= 1.5f;
                }
                ballValue = Mathf.Round(ballValue * 100f) / 100f;
            }
        }
    public void UpgradeSpeed()
    {
        if (_ballSpawner.BallSpawnSpeed > 0.1f && spawnPrice < currentMoney)
        {
            _ballSpawner.BallSpawnSpeed -= 0.1f;
            currentMoney -= spawnPrice;
            _ballSpawner.BallSpawnSpeed = Mathf.Round(_ballSpawner.BallSpawnSpeed * 100f) / 100f;
            currentMoney = Mathf.Round(currentMoney * 100f) / 100f;
            spawnSpeedLevel++;
        }
    }

    public void UpgradeCatcherSize()
    {
        if (catcherLevel != 3 && catcherPrice < currentMoney)
        {
            if (catcherLevel == 2)
            {
                Instantiate(Catcher3, catcherSpawn.position, catcherSpawn.rotation);
                currentMoney -= catcherPrice;
                Destroy(Catcher2);
                Catcher3 = GameObject.FindGameObjectWithTag("Catcher");
                currentMoney = Mathf.Round(currentMoney * 100f) / 100f;
                catcherLevel++;
            }
            if (catcherLevel == 1)
            {
                Instantiate(Catcher2, catcherSpawn.position, catcherSpawn.rotation);
                currentMoney -= catcherPrice;
                Destroy(Catcher1);
                currentMoney = Mathf.Round(currentMoney * 100f) / 100f;
                catcherLevel++;
            }
        }
    }    
}
