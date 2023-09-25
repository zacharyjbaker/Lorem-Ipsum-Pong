using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HitFX : MonoBehaviour
{
    public AudioClip[] notes;

    // Start is called before the first frame update
    void Start()
    {
        Ball.BallHitEvent += this.PlaySound;
    }

    void PlaySound()
    {
        //Debug.Log("Play!");
        int rnd = Random.Range(0, 7);
        GetComponent<AudioSource>().PlayOneShot(notes[rnd]);
    }

    void OnDisable()
    {
        Ball.BallHitEvent -= this.PlaySound;
    }
}
