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

    public GameObject Catcher12;
    public GameObject Catcher22;
    public GameObject Catcher32;

    public int catcherLevel;
    public int catcherSize;
    public int catcherPrice;
    public Button catcherSizeUpgrade;

    public Combo _combo;


    [SerializeField] TMP_Text catcherText;
    [SerializeField] TMP_Text catcherPriceText;

    public float currentPrice;
    public float currentSpeed;

    public int prestigeLevel;
    public float prestigeCost;
    public TMP_Text prestigeCostText;
    public TMP_Text prestigeLevelText;
    public Button prestigeUpgrade;

    public float prestigeMultiplier;


    //public float currentValue;
    private void Start()
    {
        ballValueLevel = 1;
        prestigeLevel = 0;
        //spawnSpeedLevel = 1;
        //currentValue = 1;
        catcherLevel = 1;
        Instantiate(Catcher1, catcherSpawn.position, catcherSpawn.rotation);


    }
    // Update is called once per frame
    void Update()
    {
        if (_combo.comboActive == false)
        {
            currentPrice = ballValuePrice;
        }
        else
        {
            currentPrice = ballValuePrice / 1.5f;
        }
        prestigeLevelText.text = "PRESTIGE: " + prestigeLevel;
        prestigeCost = 2000 * (prestigeLevel + 1);
        prestigeCostText.text = "$" + prestigeCost;
        


        currentSpeed = 2 - (spawnSpeedLevel * 0.1f);
        ballValuePrice = ballValue * 10.5f;
        spawnPrice = 30 * (spawnSpeedLevel + 1);

            if (ballValueLevel == 1)
            {
                ballValueUpgradeAmountText.text = "Upgrade ball value $" + 0.1;
            }
            if (ballValueLevel >= 2)
            {
            ballValueUpgradeAmountText.text = "Upgrade ball value $" + ballValueLevel * 0.1f;
            }

        if (catcherLevel == 1)
        {
            catcherPrice = 500;
            Catcher12 = GameObject.FindGameObjectWithTag("Catcher");
        }
        if (catcherLevel == 2)
        {
            catcherPrice = 10000;
            Catcher22 = GameObject.FindGameObjectWithTag("Catcher");
        }
        if (catcherLevel == 3)
        {
            Catcher32 = GameObject.FindGameObjectWithTag("Catcher");
        }

        MoneyText.text = "$" + currentMoney;

        ballValueText.text = "$" + ballValue;
        ballValueUpgradeText.text = "$" + currentPrice;

        spawnText.text = _ballSpawner.BallSpawnSpeed + "'s";
        spawnPriceText.text = "$" + spawnPrice;

        catcherText.text = "level - " + catcherLevel;
        catcherPriceText.text = "$" + catcherPrice;



    }
    public void Prestige()
    {
        if (prestigeCost < currentMoney)
        {
            prestigeLevel++;
            ballValueLevel = 1;
            ballValue = 1;
            prestigeMultiplier = (0.15f * prestigeLevel) + 1;
            ballValue *= prestigeMultiplier;
            spawnSpeedLevel = 0;
            _ballSpawner.BallSpawnSpeed = 2;
            currentMoney = 0;
            if (catcherLevel >= 2)
            {
                Instantiate(Catcher1, catcherSpawn.position, catcherSpawn.rotation);
                Destroy(Catcher22);
                Destroy(Catcher32);
                catcherLevel = 1;
                Catcher12 = GameObject.FindGameObjectWithTag("Catcher");
            }
        }
    }

    public void UpgradeValue()
    {
        if (currentPrice < currentMoney)
        {
            if (_combo.comboActive == true)
            {
                ballValue /= 1.5f;
            }
            if (prestigeLevel >= 1)
            {
                ballValue /= prestigeMultiplier;
            }

            ballValue += (ballValueLevel * 0.1f);


            currentMoney -= currentPrice;
            //currentMoney = Mathf.Round(currentMoney * 100f) / 100f;
            //ballValue = Mathf.Round(ballValue * 100f) / 100f;
            ballValueLevel++;

            if (prestigeLevel >= 1)
            {
                ballValue *= prestigeMultiplier;
            }
            if (_combo.comboActive == true)
            {
                ballValue *= 1.5f;
            }
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
                Destroy(Catcher22);
                currentMoney = Mathf.Round(currentMoney * 100f) / 100f;
                catcherLevel++;
            }
            if (catcherLevel == 1)
            {
                Instantiate(Catcher2, catcherSpawn.position, catcherSpawn.rotation);
                currentMoney -= catcherPrice;
                Destroy(Catcher12);
                currentMoney = Mathf.Round(currentMoney * 100f) / 100f;
                catcherLevel++;
            }
        }
    }
}
