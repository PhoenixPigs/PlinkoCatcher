using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    public GameObject deathParticle;

    public GameObject deathParticleCurrent;
    //public  rotate;
    public Combo _combo;
    private void Start()
    {
        _combo = FindObjectOfType<Combo>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            //Vector3 spawnLocation = new Vector3(other.gameObject.transform.position.x, deathParticle.gameObject.transform.position.y + 10, deathParticle.gameObject.transform.position.z);
            Vector3 spawnLocation = new Vector3(other.gameObject.transform.position.x, deathParticle.gameObject.transform.position.y - 0.4f, deathParticle.gameObject.transform.position.z + 1);
            //Instantiate(deathParticle, spawnLocation, Quaternion.Euler(Vector3.up));
            Instantiate(deathParticle, spawnLocation, transform.rotation);
            //deathParticleCurrent.transform.rotation.y += 90;
            Destroy(other.gameObject);
            _combo.comboCount = 0;
        }
    }
}
