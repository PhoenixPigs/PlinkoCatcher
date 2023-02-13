using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float BallSpawnSpeed;
    [SerializeField] GameObject Ball;
    //[SerializeField] ArrayList Spawns;
    [SerializeField] Transform Spawn;
    [SerializeField] float SpawnTarget;
    [SerializeField] bool Activated;
    private void Start()
    {
        Activated = true;
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
    }
    IEnumerator BallSpawnTimer()
    {
        yield return new WaitForSeconds(BallSpawnSpeed);
        Activated = true;
    }
}
