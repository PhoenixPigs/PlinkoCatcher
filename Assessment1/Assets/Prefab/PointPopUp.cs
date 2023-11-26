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
        _mm = FindObjectOfType<MoneyManager>();
        combo = FindObjectOfType<Combo>();
    }
    void Update()
    {
            popUp.text = "$" + _mm.ballValue;
    }
}
