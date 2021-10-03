using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlatform : MonoBehaviour
{
    public GameObject youLostUIText;
    public GameObject restartUIText;

    private bool restarting = false;
    private float restartTimer = 5.0f;

    private void Update()
    {
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
            youLostUIText.SetActive(true);
            restartUIText.SetActive(true);
            restarting = true;
        }
    }
}
