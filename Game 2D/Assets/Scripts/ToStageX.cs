using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStageX : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.CompareTag("Player"))
        {
            Debug.Log("OnCollisionEnter2D");
            string stage = "Stage" + number.ToString();
            Application.LoadLevel(stage);
        }
    }
}
