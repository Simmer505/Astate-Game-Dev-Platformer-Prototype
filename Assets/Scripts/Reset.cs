using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject player;

    private CourseTimer timerScript;

    private CharacterController charController;


    private void OnTriggerEnter(Collider other)
    {
        // If the player goes out of bounds move it back the the starting point
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        // Delete any obstacles that go out of bounds
        else if (other.tag == "Obstacle")
        {
            Destroy(other);
        }
    }
}
