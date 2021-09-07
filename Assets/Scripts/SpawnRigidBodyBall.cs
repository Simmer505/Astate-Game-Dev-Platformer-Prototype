using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRigidBodyBall : MonoBehaviour
{

    public GameObject ball;
    public float spawnDelay = 3.0f;

    private bool spawned = false;


    // Update is called once per frame
    void Update()
    {
        if (!spawned)
        {
            Instantiate(ball, gameObject.transform.position, Quaternion.identity);
            spawned = true;
            StartCoroutine(SpawnTimer());
        }
    }

    IEnumerator SpawnTimer()
    {
        yield return new WaitForSeconds(spawnDelay);
        spawned = false;
    }
}
