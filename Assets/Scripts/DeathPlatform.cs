using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<CharacterController>().enabled = false;
            other.transform.position = Vector3.zero;
            other.GetComponent<CourseTimer>().start = false;
            other.GetComponent<CourseTimer>().timer = 0;
            other.GetComponent<CharacterController>().enabled = true;
        }
    }
}
