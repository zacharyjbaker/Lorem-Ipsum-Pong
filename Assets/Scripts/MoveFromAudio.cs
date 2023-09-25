using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFromAudio : PlayerPaddle
{
    public AudioSource source;
    public AudioLoudnessDetection detector;

    public float loudnessSensibility = 100;
    public float threshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromAudioClip(source.timeSamples, source.clip) * loudnessSensibility;
        if (loudness < threshold)
            loudness = 0;

        Debug.Log(loudness);
    }
}
