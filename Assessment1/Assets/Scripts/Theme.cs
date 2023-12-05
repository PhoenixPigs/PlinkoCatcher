using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

public class Theme : MonoBehaviour
{

    public Material Ball;
    public Material Back;
    public Material Pegs;

    public bool themea;
    public bool themeata;
    public bool themit;
    public bool thor;
    public bool Nurple;
    


    Color Theme11 = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    Color Theme12 = new Color(0f, 0f, 0f, 1.0f);
    Color Theme13 = new Color(0f, 0f, 0f, 1.0f);

    Color Theme21 = new Color(0f, 0.4198113f, 0.8396226f, 1.0f);
    Color Theme21E = new Color(0f, 0.5019608f, 1f, 1.0f);
    Color Theme22 = new Color(0.2641509f, 0.2641509f, 0.2641509f, 1.0f);
    Color Theme23 = new Color(0f, 0f, 0f, 1.0f);

    Color Theme31 = new Color(1f, 0.612016f, 0f, 1.0f);
    Color Theme31E = new Color(1f, 0.8444079f, 0f, 1.0f);
    Color Theme32 = new Color(0.07744224f, 0.05669276f, 0.1320755f, 1.0f);
    Color Theme33 = new Color(0.2461098f, 0.2026077f, 0.2735848f, 1.0f);

    Color Theme41 = new Color(1f, 0f, 0.01960802f, 1.0f);
    Color Theme41E = new Color(0.5754717f, 0.01579726f, 0f, 1.0f);
    Color Theme42 = new Color(0.8773585f, 0.3931559f, 0.4154758f, 1.0f);
    Color Theme43 = new Color(1f, 1f, 1f, 1.0f);

    Color Theme51 = new Color(0.4043819f, 0f, 0.9245283f, 1.0f);
    Color Theme51E = new Color(0.3690425f, 0f, 0.9528302f, 1.0f);
    Color Theme52 = new Color(0f, 0f, 0f, 1.0f);
    Color Theme53 = new Color(0.01438676f, 0f, 0.03773582f, 1.0f);

    // Start is called before the first frame update
    void Start()
    {
        Theme1();
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
        if (themit)
        {
            Theme3();
        }
        if (thor)
        {
            Theme4();
        }
        if (Nurple)
        {
            Theme5();
        }
    }

    public void Theme1()
    {

        Ball.color = Theme11;
        Ball.SetColor("_EmissiveColor", Theme11);
        Back.color = Theme12;
        Pegs.color = Theme13;
    }

    public void Theme2()
    {

        Ball.color = Theme21;
        Ball.SetColor("_EmissiveColor", Theme21E);
        Back.color = Theme22;
        Pegs.color = Theme23;
    }
    public void Theme3()
    {

        Ball.color = Theme31;
        Ball.SetColor("_EmissiveColor", Theme31E);
        Back.color = Theme32;
        Pegs.color = Theme33;
    }
    public void Theme4()
    {

        Ball.color = Theme41;
        Ball.SetColor("_EmissiveColor", Theme41E);
        Back.color = Theme42;
        Pegs.color = Theme43;
    }
    public void Theme5()
    {

        Ball.color = Theme51;
        Ball.SetColor("_EmissiveColor", Theme51E);
        Back.color = Theme52;
        Pegs.color = Theme53;
    }

}
