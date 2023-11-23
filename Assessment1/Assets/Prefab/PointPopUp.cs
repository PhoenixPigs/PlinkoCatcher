using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointPopUp : MonoBehaviour
{
    [SerializeField] TMP_Text popUp;
    public MoneyManager _mm;
    public Combo combo;
    // Update is called once per frame\\

    private void Start()
    {
        _mm = GetComponent<MoneyManager>();
        combo = GetComponent<Combo>();
    }
    void Update()
    {
        if (!combo.comboActive)
        {
            popUp.text = "$" + _mm.ballValue;
        }
        else if (combo.comboActive)
        {
            popUp.text = "$" + _mm.ballValue * 1.5f;
        }
    }
}
