using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseTimer : MonoBehaviour
{

    public bool start = false;
    public float timer = 0;

    public GameObject timerText;
    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            timer += Time.deltaTime;
        }
        timerText.GetComponent<TMPro.TextMeshProUGUI>().text = Mathf.Round(timer).ToString();
    }

}
