using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Animations;
using Unity.VisualScripting;

public class Catcher : MonoBehaviour
{
    public float speed = 500;
    public MoneyManager moneyManager;
    public float clampXLeft;
    public float clampXRight;
    public Combo _combo;
    public BallSpawner _ballSpawner;
    public bool rumble = false;
    [SerializeField] GameObject pointPopUp;
    [SerializeField] AudioSource pop;
    [SerializeField] AudioClip popAudio;
    [SerializeField] AudioClip superPop;
    public List<GameObject> _clean;
    public GameObject currentPopUp;

    [SerializeField] GameObject _empty;

    public void Awake()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
        _combo = FindObjectOfType<Combo>();
        _ballSpawner = FindObjectOfType<BallSpawner>();
        List<GameObject> _clean = new List<GameObject>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            Instantiate(pointPopUp, gameObject.transform.position, gameObject.transform.rotation);
            moneyManager.currentMoney += moneyManager.ballValue;
            moneyManager.currentMoney = Mathf.Round(moneyManager.currentMoney * 100f) / 100f;
            if (!_combo.comboActive)
            {
                pop.PlayOneShot(popAudio);

            }
            else
            {
                pop.PlayOneShot(superPop);
            }

            if (rumble == false)
            {
            _combo.comboCount++;
            }
            StartCoroutine(PointDeath());
        }
        if (collision.gameObject.tag == "SuperBall")
        {
            Destroy(collision.gameObject);
            moneyManager.currentMoney += moneyManager.ballValue;
            moneyManager.currentMoney = Mathf.Round(moneyManager.currentMoney * 100f) / 100f;
            Instantiate(pointPopUp, gameObject.transform.position, gameObject.transform.rotation);
            if (!_combo.comboActive)
            {
                pop.PlayOneShot(popAudio);

            }
            else
            {
                pop.PlayOneShot(superPop);
            }
            if (rumble == false)
            {
                _combo.comboCount++;
            }
            _ballSpawner.superDuperActivated = true;
        }
    }


    IEnumerator PointDeath()
    {
        yield return new WaitForSeconds(1);

        foreach (GameObject i in _clean)
        {
            Destroy(currentPopUp);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (_combo.comboCount <= 10)
        {
            pop.pitch = 0.7f + (0.05f * _combo.comboCount);
        }


        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
        {

            gameObject.transform.position = gameObject.transform.position + gameObject.transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
        {

            gameObject.transform.position = gameObject.transform.position + gameObject.transform.right * -speed * Time.deltaTime;
        }
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, clampXLeft, clampXRight);
        transform.position = clampedPosition;
    }
}

