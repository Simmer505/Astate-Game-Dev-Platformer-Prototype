using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    public GameObject player;

    private CourseTimer playerTimer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerTimer = player.GetComponent <CourseTimer> ();
            playerTimer.start = true;
        } 
    }
}
