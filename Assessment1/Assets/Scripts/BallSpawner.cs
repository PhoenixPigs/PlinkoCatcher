using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float BallSpawnSpeed;
    [SerializeField] GameObject Ball;
    [SerializeField] GameObject SuperBall;
    [SerializeField] Transform Spawn;
    [SerializeField] float SpawnTarget;
    [SerializeField] bool Activated;
    public bool superActivated;
    public bool superDuperActivated;

    public MoneyManager _moneymanager;

    private void Start()
    {
        Activated = true;
        Debug.Log("Hi");
        SpawnTarget = Random.Range(6f, -6f);
        Spawn.position = new Vector3(SpawnTarget, Spawn.position.y, Spawn.position.z);
        Instantiate(SuperBall, Spawn.position, Spawn.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (Activated == true)
        {
            SpawnTarget = Random.Range(6f, -6f);
            Spawn.position = new Vector3(SpawnTarget, Spawn.position.y, Spawn.position.z);
            Instantiate(Ball, Spawn.position, Spawn.rotation);
            Activated = false;
            StartCoroutine(BallSpawnTimer());
        }
        if (superActivated == true)
        {
            SpawnTarget = Random.Range(6f, -6f);
            Spawn.position = new Vector3(SpawnTarget, Spawn.position.y, Spawn.position.z);
            Instantiate(SuperBall, Spawn.position, Spawn.rotation);
            superActivated = false;
            superDuperActivated = true;
        }
        if (superDuperActivated == true)
        {
            superDuperActivated = false;
            StartCoroutine(SuperballDuration());
            StartCoroutine(SuperBallCooldown());           

        }

    }
    IEnumerator BallSpawnTimer()
    {
        yield return new WaitForSeconds(BallSpawnSpeed);
        Activated = true;
    }
    IEnumerator SuperballDuration()
    {
            Debug.Log("false");
            BallSpawnSpeed = -1;
            Debug.Log("-1");
        yield return new WaitForSeconds(5);
            Debug.Log("wait5");
            BallSpawnSpeed = _moneymanager.currentSpeed;
    }
    IEnumerator SuperBallCooldown()
    {
        yield return new WaitForSeconds(300);
        superActivated = true;
    }
}
