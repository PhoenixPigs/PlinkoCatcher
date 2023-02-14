using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Catcher : MonoBehaviour
{
    public float speed = 500;
    public MoneyManager moneyManager;
    public float clampXLeft;
    public float clampXRight;
    public Combo _combo;

    public void Awake()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
        _combo = FindObjectOfType<Combo>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            moneyManager.currentMoney += moneyManager.ballValue;
            moneyManager.currentMoney = Mathf.Round(moneyManager.currentMoney * 100f) / 100f;
            _combo.comboCount++;
        }
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

