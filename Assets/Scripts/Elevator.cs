using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float Speed = 1;
    public float stopTime = 2f;
    public float totalDistance = 10f;

    private Vector3 distanceToMove;
    private bool goingUp = true;
    private float tunnelStartingY;
    private bool stopped = false;


    void Start()
    {
        distanceToMove = new Vector3(0, Speed, 0);
        tunnelStartingY = transform.position.y;
    }

    void Update()
    {
        // Switch goingUp if platform is below its starting position or above the height offset, is not stopped, and is going in the wrong direction
        if ((transform.position.y <= tunnelStartingY && !goingUp && !stopped) || (transform.position.y >= tunnelStartingY + totalDistance && goingUp && !stopped))
        {

            StartCoroutine(StopTimer());
        }

        // Move platform in the direction of goingUp
        if (!stopped && goingUp)
        {
            transform.Translate(distanceToMove * Time.deltaTime, Space.World);
        }
        else if (!stopped && !goingUp)
        {
            transform.Translate(-distanceToMove * Time.deltaTime, Space.World);
        }

    }

    IEnumerator StopTimer()
    {
        stopped = true;
        yield return new WaitForSeconds(stopTime);
        goingUp = !goingUp;
        stopped = false;
    }
}
