using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public Transform spawnpoint;
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.transform.CompareTag("Player"))
        {
            Debug.Log("OnCollisionEnter2D");
            col.transform.position = spawnpoint.position;
        }
    }
}
