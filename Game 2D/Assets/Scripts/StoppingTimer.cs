using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoppingTimer : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Timer");
        DontDestroyOnLoad(this.gameObject);
    }
}
