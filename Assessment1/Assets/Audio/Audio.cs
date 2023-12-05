using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioMixer master;
    [SerializeField] Toggle muteButton;
    // Update is called once per frame
    void Update()
    {

        if (muteButton.isOn)
        {
            master.SetFloat("Volume", 0);
        }
        else if (!muteButton.isOn)
        {
            master.SetFloat("Volume", -80);
        }
    }
}
