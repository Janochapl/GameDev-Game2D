﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Destroy()
    {
        Debug.Log("Send for destroy the timer...");
        GameObject.Find("TimerText").SendMessage("Destroy");
    }
}
