using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comboer : MonoBehaviour
{
    public List<GameObject> comboPegs;

    Combo _com;

    private void Start()
    {
        _com = GetComponent<Combo>();
    }
    // Update is called once per frame
    void Update()
    {
        if (_com.comboCount == 1)
        {
            comboPegs[0].SetActive(true);
        }
        if (_com.comboCount == 2)
        {
            comboPegs[1].SetActive(true);
        }
    }
}
