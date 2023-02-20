using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.UI;

public class Combo : MonoBehaviour
{
    [SerializeField] MoneyManager _moneyManager;
    [SerializeField] BallDestroy _ballDestroy;
    public Catcher _catcher;

    public int comboCount;
    public TMP_Text comboText;
    public TMP_Text comboText2;
    public bool comboActive;

    public GameObject Splat;
    public Animator comboBounce;
    public Animator splatAnim;

    // Start is called before the first frame update
    void Start()
    {
        comboActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (comboCount >= 10)
        {
            Splat.gameObject.SetActive(true);
            splatAnim.SetBool("Splat", true);
        }
        else
        {
            splatAnim.SetBool("Splat", false);
            Splat.gameObject.SetActive(false);
        }


        if (comboCount == 10 && comboActive == false)
        {
            comboActive = true;
            ComboBonus();
        }
        if (comboCount < 10 && comboActive== true)
        {
            comboActive = false;
            ComboEnd();
        }


        if (_moneyManager.catcherLevel == 1)
        {
            _catcher = FindObjectOfType<Catcher>();
        }
        if (_moneyManager.catcherLevel == 2)
        {
            _catcher = FindObjectOfType<Catcher>();
        }
        if (_moneyManager.catcherLevel == 3)
        {
            _catcher = FindObjectOfType<Catcher>();
        }


        if (_catcher.rumble == false)
        {
        comboText.text = "COMBO " + comboCount + "x";
        comboText2.text = "COMBO " + comboCount + "x";
        }

        if (_catcher.rumble == true)
        {
            comboText.text = "SUPER COMBO";
            comboText2.text = "SUPER COMBO";
        }

    }



    void ComboBonus()
    {
            _moneyManager.ballValue *= 1.5f;
            _moneyManager.ballValue = Mathf.Round(_moneyManager.ballValue * 100f) / 100f;

    }
    void ComboEnd()
    {
        _moneyManager.ballValue /= 1.5f;
        _moneyManager.ballValue = Mathf.Round(_moneyManager.ballValue * 100f) / 100f;
    }
}
