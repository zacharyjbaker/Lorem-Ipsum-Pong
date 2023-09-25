using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFromMicrophone : PlayerPaddle
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioPitchEstimator estimator;
    public TextMesh textFrequency;
    public AudioLoudnessDetection detector;
    //public AudioPitchEstimator estimator;

    public float estimateRate = 30;
    public float loudnessSensibility = 100;
    public float threshold = .5f;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating(nameof(UpdateVisualizer), 0, 1.0f / estimateRate);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(audioSource);
        var frequency = estimator.Estimate(audioSource);
        //Debug.Log(frequency);
        //var srh = estimator.SRH;
        //var numPoints = srh.Count;
        //var positions = new Vector3[numPoints];
        textFrequency.text = string.Format("{0}\n{1:0.0} Hz", GetNameFromFrequency(frequency), frequency);

        //var frequency = estimator.Estimate(source);
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;
        if (loudness < threshold)
            loudness = 0;

        //Debug.Log(loudness);
        if (loudness > 7.5)
        {
            //Debug.Log("up");
            _rigidbody.AddForce(_direction * loudness / 10);
            _direction = Vector2.up;
        }
        else if (loudness > 3)
        {
            _direction = Vector2.up;
        }
        else if (loudness <= 4)
        {
            //Debug.Log("down");
            _direction = Vector2.down;
            //speed = (loudness / 10.0f);
        }
        else if (loudness <= 2)
        {
            _rigidbody.AddForce(_direction * loudness * 4);
            _direction = Vector2.zero;
        }
    }

    string GetNameFromFrequency(float frequency)
    {
        var noteNumber = Mathf.RoundToInt(12 * Mathf.Log(frequency / 440) / Mathf.Log(2) + 69);
        string[] names = {
            "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        };
        return names[noteNumber % 12];
    }
}
