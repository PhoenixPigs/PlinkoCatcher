using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
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
    public Combo _combo;
    public Catcher _catcher;

    private void Start()
    {
        Activated = true;
        Debug.Log("Hi");
        StartCoroutine(SuperBallCooldown());
    }
    // Update is called once per frame
    void Update()
    {
        if (_moneymanager.catcherLevel == 1)
        {
            _catcher = FindObjectOfType<Catcher>();
        }
        if (_moneymanager.catcherLevel == 2)
        {
            _catcher = FindObjectOfType<Catcher>();
        }
        if (_moneymanager.catcherLevel == 3)
        {
            _catcher = FindObjectOfType<Catcher>();
        }

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
            StartCoroutine(SuperBallCooldown());
        }
        if (superDuperActivated == true)
        {
            superDuperActivated = false;
            _combo.comboCount = 10;

            _catcher.rumble = true;
            StartCoroutine(SuperballDuration());         

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
            yield return new WaitForSeconds(4);
            Debug.Log("wait5");
            BallSpawnSpeed = _moneymanager.currentSpeed;
            yield return new WaitForSeconds(25);
            _catcher.rumble = false;
    }
    IEnumerator SuperBallCooldown()
    {
        yield return new WaitForSeconds(150);
        superActivated = true;
    }

    void ComboBonus()
    {
        _moneymanager.ballValue *= 1.5f;
        _moneymanager.ballValue = Mathf.Round(_moneymanager.ballValue * 100f) / 100f;

    }
    void ComboEnd()
    {
        _moneymanager.ballValue /= 1.5f;
        _moneymanager.ballValue = Mathf.Round(_moneymanager.ballValue * 100f) / 100f;
    }
}
