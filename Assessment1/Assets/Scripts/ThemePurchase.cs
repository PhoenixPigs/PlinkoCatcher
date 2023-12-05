using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThemePurchase : MonoBehaviour
{

    MoneyManager _mm;

    public GameObject button1;
    public Button button01;
    bool pressed;

    int price1 = 10000;

    public GameObject button2;
    public Button button02;
    bool pressed2;

    int price2 = 20000;

    public GameObject button3;
    public Button button03;
    bool pressed3;

    int price3 = 1000000;

    public GameObject button4;
    public Button button04;
    bool pressed4;

    int price4 = 2000000;

    // Start is called before the first frame update
    void Start()
    {
       _mm = FindObjectOfType<MoneyManager>();
        pressed = false;
        pressed2 = false;
        pressed3 = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void BuyTheme1()
    {
        if (_mm.currentMoney > price1)
        {
        _mm.currentMoney = _mm.currentMoney - price1;
        button1.SetActive(false);
        pressed = true;

        }
    }
    public void BuyTheme2()
    {
        if (_mm.currentMoney > price2)
        {
            _mm.currentMoney = _mm.currentMoney - price2;
            button2.SetActive(false);
            pressed2 = true;

        }
    }
    public void BuyTheme3()
    {
        if (_mm.currentMoney > price3)
        {
            _mm.currentMoney = _mm.currentMoney - price3;
            button3.SetActive(false);
            pressed3 = true;

        }
    }

    public void BuyTheme4()
    {
        if (_mm.currentMoney > price4)
        {
            _mm.currentMoney = _mm.currentMoney - price4;
            button4.SetActive(false);
            pressed4 = true;

        }
    }

}
