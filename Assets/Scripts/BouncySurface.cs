using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
            this.transform.localScale += new Vector3(0.4f, 0.4f, 0.4f);
            Invoke("Shrink", 0.09f);
        }
    }

    public void Shrink()
    {
        this.transform.localScale += new Vector3(-0.4f, -0.4f, -0.4f);
    }
}
