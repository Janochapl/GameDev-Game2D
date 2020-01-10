using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerToTimer : MonoBehaviour
{

    public Text textTimer;
    private Text realTextTimer;
    public Text yourTime;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            realTextTimer = GameObject.Find("TimerText").GetComponent<Text>();
            Debug.Log("Uruchamiam się");
            textTimer.text = realTextTimer.GetComponent<Text>().text;
            GameObject.Find("TimerText").SendMessage("Destroy");
        }
        catch
        {
            textTimer.text = "";
            yourTime.text = "";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
