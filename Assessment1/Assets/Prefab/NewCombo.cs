using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCombo : MonoBehaviour
{
    [SerializeField] MeshRenderer combo1;
    [SerializeField] MeshRenderer combo2;
    [SerializeField] MeshRenderer combo3;
    [SerializeField] MeshRenderer combo4;
    [SerializeField] MeshRenderer combo5;
    [SerializeField] MeshRenderer combo6;
    [SerializeField] MeshRenderer combo7;
    [SerializeField] MeshRenderer combo8;
    [SerializeField] MeshRenderer combo9;
    [SerializeField] MeshRenderer combo10;

    [SerializeField] Material blank;
    [SerializeField] Material newer;
    [SerializeField] Material colour1;
    [SerializeField] Material colour2;
    [SerializeField] Material colour3;
    [SerializeField] Material colour4;
    [SerializeField] Material colour5;
    [SerializeField] Material colour6;
    [SerializeField] Material colour7;
    [SerializeField] Material colour8;
    [SerializeField] Material colour9;
    [SerializeField] Material colour10;

    Combo _c;

    private void Start()
    {
        _c = FindObjectOfType<Combo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_c.comboActive)
        {
            combo1.material = newer;
            combo2.material = newer;
            combo3.material = newer;
            combo4.material = newer;
            combo5.material = newer;
            combo6.material = newer;
            combo7.material = newer;
            combo8.material = newer;
            combo9.material = newer;
            combo10.material = newer;
        }
        else
        {
            if (_c.comboCount == 0)
            {
                combo1.material = blank;
                combo2.material = blank;
                combo3.material = blank;
                combo4.material = blank;
                combo5.material = blank;
                combo6.material = blank;
                combo7.material = blank;
                combo8.material = blank;
                combo9.material = blank;
                combo10.material = blank;
            }
            if (_c.comboCount == 1)
            {
                combo1.material = colour1;
            }
            if (_c.comboCount == 2)
            {
                combo2.material = colour2;
            }
            if (_c.comboCount == 3)
            {
                combo3.material = colour3;
            }
            if (_c.comboCount == 4)
            {
                combo4.material = colour4;
            }
            if (_c.comboCount == 5)
            {
                combo5.material = colour5;
            }
            if (_c.comboCount == 6)
            {
                combo6.material = colour6;
            }
            if (_c.comboCount == 7)
            {
                combo7.material = colour7;
            }
            if (_c.comboCount == 8)
            {
                combo8.material = colour8;
            }
            if (_c.comboCount == 9)
            {
                combo9.material = colour9;
            }
            if (_c.comboCount == 10)
            {
                combo10.material = colour10;
            }
        }
        }
    }
