using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseTimer : MonoBehaviour
{

    public bool start = false;
    public float timer = 0;

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
        Debug.Log(timer);
        
    }

}
