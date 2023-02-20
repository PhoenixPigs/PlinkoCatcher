using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    public GameObject deathParticle;
    public Catcher _catcher;
    public MoneyManager _moneyManager;

    public GameObject deathParticleCurrent;
    //public  rotate;
    public Combo _combo;
    private void Start()
    {
        _combo = FindObjectOfType<Combo>();
    }

    private void Update()
    {
        if (_moneyManager.catcherLevel == 1)
        {
            _catcher = FindObjectOfType<Catcher>();
        }
        if (_moneyManager.catcherLevel == 2)
        {
            _catcher = FindObjectOfType<Catcher>();
        }
        if (_moneyManager.catcherLevel == 3)
        {
            _catcher = FindObjectOfType<Catcher>();
        }
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
            if (_catcher.rumble == false)
            {
                Debug.Log("False");
            _combo.comboCount = 0;
            }
        }
    }
}
