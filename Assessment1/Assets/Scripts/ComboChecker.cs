using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ComboChecker : MonoBehaviour
{

    Combo _cc;
    [SerializeField] TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        _cc = FindObjectOfType<Combo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_cc.comboActive == true)
        {
            text.color = Color.yellow;
        }
        else
        {
            text.color = Color.white;
        }
    }
}
