using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject finishLineText;
    public GameObject finishUIText;
    public GameObject restartUIText;

    public int coinsCollected = 0;
    private float restartTimer = 10.0f;

    private CourseTimer playerTimer;
    private bool restarting = false;
    

    private void Update()
    {
        if (coinsCollected >= 2)
        {
            gameObject.GetComponent<BoxCollider> ().isTrigger = true;
            finishLineText.GetComponent<TextMesh>().color = new Color(0.0f, 1.0f, 0.0f);
        }
        if (restarting)
        {
            restartTimer -= Time.deltaTime;
            restartUIText.GetComponent<TMPro.TextMeshProUGUI>().text = "Restarting in " + Mathf.Round(restartTimer).ToString();
            if (restartTimer <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTimer = player.GetComponent<CourseTimer>();
            playerTimer.start = false;
            finishUIText.SetActive(true);
            finishUIText.GetComponent<TMPro.TextMeshProUGUI>().text = "You won in " + Mathf.Round(playerTimer.timer).ToString() + " seconds";
            restartUIText.SetActive(true);
            restarting = true;
        }
    }
}
