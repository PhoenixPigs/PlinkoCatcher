using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
    [SerializeField] TMP_Text spawnSpeedUpgradeText;



    public int catcherSizeLevel;
    private void Start()
    {
        ballValueLevel = 1;
    }
    // Update is called once per frame
    void Update()
    {
        ballValuePrice = ballValue * 10.5f;
        spawnPrice = _ballSpawner.BallSpawnSpeed * 10.5f;

        MoneyText.text = "$" + currentMoney;

        ballValueText.text = "$" + ballValue;
        ballValueUpgradeText.text = "$" + ballValuePrice;

        spawnText.text = "$" + _ballSpawner.BallSpawnSpeed;
        spawnPriceText.text = "$" + spawnPrice;

    }

    public void UpgradeValue()
        {
            if (ballValuePrice < currentMoney)
            {
                ballValue += (ballValueLevel * 0.1f) ;
                ballValueUpgradeAmountText.text = "Upgrade ball value $" + ballValueLevel * 0.1f;
                currentMoney -= ballValuePrice;
                currentMoney = Mathf.Round(currentMoney * 100f) / 100f;
                ballValueLevel++;
            }
        }
    public void UpgradeSpeed()
    {
        if (_ballSpawner.BallSpawnSpeed > 0.1f && spawnPrice < currentMoney)
        {
            _ballSpawner.BallSpawnSpeed -= 0.1f;
            spawnSpeedUpgradeText.text = "Upgrade ball speed " + 0.1f + "'s";
            currentMoney -= spawnPrice;
            _ballSpawner.BallSpawnSpeed = Mathf.Round(_ballSpawner.BallSpawnSpeed * 100f) / 100f;
            currentMoney = Mathf.Round(currentMoney * 100f) / 100f;
            spawnSpeedLevel++;
        }
    }
        


    
}
