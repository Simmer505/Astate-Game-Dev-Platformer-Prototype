using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseTimer : MonoBehaviour
{

    public bool start = false;
    public float timer = 0;

    public GameObject timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            timer += Time.deltaTime;
        }
        timerText.GetComponent<TMPro.TextMeshProUGUI>().text = (Mathf.Round(timer * 100.0f) * 0.01f).ToString();
    }

}
