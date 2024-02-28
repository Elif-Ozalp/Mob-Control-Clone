using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TowerMovement : MonoBehaviour
{
    float duration=1f;
    float strength=3f;
    int vibrato=7;
    float randomness=0;
    bool fadeOut=true;
    void OnCollisionEnter(Collision other)
    {
      if(other.gameObject.CompareTag ("Stickman")|| other.gameObject.CompareTag("Stickman2"))
        {
            transform.DORewind();
            transform.DOShakeRotation(duration, strength, vibrato, randomness, fadeOut);

        }
    }
}
