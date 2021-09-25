using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject finishLine;

    private void Update()
    {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 500, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            finishLine.GetComponent<FinishTrigger>().coinsCollected += 1;
            Destroy(gameObject);
        }
    }
}
