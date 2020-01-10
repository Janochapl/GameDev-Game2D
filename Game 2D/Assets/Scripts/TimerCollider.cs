using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject.Find("TimerText").SendMessage("Finish");
    }
}
