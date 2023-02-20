using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegGlow : MonoBehaviour
{
    public Material PegOn;
    public Material SuperPegOn;
    public Material PegOff;
    public MeshRenderer PegRenderer;
    public bool PegEnabled = false;
    [SerializeField] float PegDelay;

    private void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == "Ball")
        {            
            PegRenderer = this.gameObject.GetComponent<MeshRenderer>();
            StartCoroutine(PegTimer());
        }
        if (Other.gameObject.tag == "SuperBall")
        {
            PegRenderer = this.gameObject.GetComponent<MeshRenderer>();
            StartCoroutine(PegTimer2());
        }
    }
    IEnumerator PegTimer()
    {
        PegRenderer.material = PegOn;
        PegEnabled = true;
        yield return new WaitForSeconds(PegDelay);
        PegRenderer.material = PegOff;
        PegEnabled = false;
    }
    IEnumerator PegTimer2()
    {
        PegRenderer.material = SuperPegOn;
        PegEnabled = true;
        yield return new WaitForSeconds(PegDelay);
        PegRenderer.material = PegOff;
        PegEnabled = false;
    }
}
