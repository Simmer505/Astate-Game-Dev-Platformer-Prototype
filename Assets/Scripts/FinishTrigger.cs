using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameObject player;

    public GameObject finishText;

    public int coinsCollected = 0;

    private CourseTimer playerTimer;

    private void Update()
    {
        if (coinsCollected >= 2)
        {
            gameObject.GetComponent<BoxCollider> ().isTrigger = true;
            finishText.GetComponent<TextMesh>().color = new Color(0.0f, 1.0f, 0.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTimer = player.GetComponent<CourseTimer>();
            playerTimer.start = false;
        }
    }
}
