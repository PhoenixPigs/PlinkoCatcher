using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theme : MonoBehaviour
{

    public Material Ball;
    public Material Back;
    public Material Pegs;

    public bool themea;
    public bool themeata;


    Color Theme11 = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    Color Theme12 = new Color(0f, 0f, 0f, 1.0f);
    Color Theme13 = new Color(0f, 0f, 0f, 1.0f);

    Color Theme21 = new Color(0.4491811f, 0.6909288f, 0.9245283f, 1.0f);
    Color Theme21E = new Color(0f, 0.4755965f, 0.9433962f, 1.0f);
    Color Theme22 = new Color(0.4433962f, 0.3251897f, 0.2447045f, 1.0f);
    Color Theme23 = new Color(0.8962264f, 0.4958815f, 0f, 1.0f);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (themea == true)
        {
            Theme1();
        }
        if (themeata)
        {
            Theme2();
        }
    }

    void Theme1()
    {
        Debug.Log("Setting Theme 1 colors");
        Ball.SetColor("_Color", Theme11);
        Ball.SetColor("_EmissiveColor", Theme11);
        Back.SetColor("_Color", Theme12);
        Pegs.SetColor("_Color", Theme13);
        Debug.Log(Ball.color);
    }

    void Theme2()
    {
        Debug.Log("Setting Theme 2 colors");
        Ball.SetColor("_Color", Theme21);
        Ball.SetColor("_EmissiveColor", Theme21E);
        Back.SetColor("_Color", Theme22);
        Pegs.SetColor("_Color", Theme23);
    }
}
