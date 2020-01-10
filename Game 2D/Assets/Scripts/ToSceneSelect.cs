using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSceneSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        Application.LoadLevel("SceneSelect");
        Debug.Log("Coś niby robię");
    }
}
