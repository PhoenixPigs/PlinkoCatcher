using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Animations;

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

    public void Awake()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
        _combo = FindObjectOfType<Combo>();
        _ballSpawner = FindObjectOfType<BallSpawner>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            moneyManager.currentMoney += moneyManager.ballValue;
            moneyManager.currentMoney = Mathf.Round(moneyManager.currentMoney * 100f) / 100f;
            Instantiate(pointPopUp, gameObject.transform.position, gameObject.transform.rotation);
            if (rumble == false)
            {
            _combo.comboCount++;
            }
            BounceBool();
        }
        if (collision.gameObject.tag == "SuperBall")
        {
            Destroy(collision.gameObject);
            moneyManager.currentMoney += moneyManager.ballValue;
            moneyManager.currentMoney = Mathf.Round(moneyManager.currentMoney * 100f) / 100f;
            Instantiate(pointPopUp, gameObject.transform.position, gameObject.transform.rotation);
            if (rumble == false)
            {
                _combo.comboCount++;
            }
            BounceBool();
            _ballSpawner.superDuperActivated = true;
        }
    }
    void BounceBool()
    {
        _combo.comboBounce.SetTrigger("E");
        //_combo.comboBounce.ResetTrigger("E");


    }

    IEnumerator BounceWait()
    {
        yield return new WaitForSeconds(1);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            gameObject.transform.position = gameObject.transform.position + gameObject.transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {

            gameObject.transform.position = gameObject.transform.position + gameObject.transform.right * -speed * Time.deltaTime;
        }
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, clampXLeft, clampXRight);
        transform.position = clampedPosition;
    }
}

