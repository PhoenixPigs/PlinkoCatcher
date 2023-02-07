using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
        }
    }
}
