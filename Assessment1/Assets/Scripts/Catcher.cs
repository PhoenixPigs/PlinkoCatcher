using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    public float speed;
    public MoneyManager moneyManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            moneyManager.currentMoney += moneyManager.ballValue;
            moneyManager.currentMoney = Mathf.Round(moneyManager.currentMoney * 100f) / 100f;
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
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -5.75f, 5.75f);
        transform.position = clampedPosition;
    }
}

