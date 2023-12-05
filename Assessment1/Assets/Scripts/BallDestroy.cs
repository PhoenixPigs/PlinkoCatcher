using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    public GameObject deathParticle;
    public Catcher _catcher;
    public MoneyManager _moneyManager;

    public GameObject deathParticleCurrent;
    public AudioSource deathSound;
    public AudioClip deathNoise;
    //public  rotate;
    public Combo _combo;
    public List<GameObject> _clean;
    private void Start()
    {
        _combo = FindObjectOfType<Combo>();
        List<GameObject> _clean = new List<GameObject>();
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
            //deathParticleCurrent = Instantiate(deathParticle, spawnLocation, transform.rotation);
            //_clean.Add(deathParticleCurrent);
            //deathSound.PlayOneShot(deathNoise);
            //deathParticleCurrent.transform.rotation.y += 90;
            Destroy(other.gameObject);

            if (_catcher.rumble == false)
            {
                Debug.Log("False");
            _combo.comboCount = 0;
            }
            //StartCoroutine(ParticleDestroy());
        }

    }
    IEnumerator ParticleDestroy()
    {
        yield return new WaitForSeconds(2f);
        
        foreach (GameObject i in _clean)
        {
            Destroy(deathParticleCurrent);
        }
    }
}
