using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl1 : MonoBehaviour
{
    public Slider VolumeSlider;
    float masterVolume = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVolume()
    {
        masterVolume = VolumeSlider.value;
        AudioListener.volume = masterVolume;
    }
}
