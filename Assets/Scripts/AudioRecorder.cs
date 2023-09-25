using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRecorder : MonoBehaviour
{
    public AudioSource audioSource1;
    //public AudioSource audioSource2;
    public int duration = 40;

    void Start()
    {
      
        foreach (var device in Microphone.devices)
        {
            Debug.Log(device);
            //Debug.Log(Microphone.devices[0]);
        }

        audioSource1.clip = Microphone.Start(string.Empty, audioSource1.loop, duration, AudioSettings.outputSampleRate);
        audioSource1.Play();

        /*

        if (Microphone.devices[0] == null)
        {
            Debug.Log("Comp Input");
            audioSource1.clip = Microphone.Start(string.Empty, true, duration, AudioSettings.outputSampleRate);
            audioSource1.Play();
        }
        else
        {
            Debug.Log("Mic Input");
            //audioSource1.clip = Microphone.Start(string.Empty, true, duration, AudioSettings.outputSampleRate);
            audioSource1.clip = Microphone.Start("Scarlett 2i2 USB", audioSource1.loop, duration, AudioSettings.outputSampleRate);
            audioSource1.Play();
        }*/
    }

}
