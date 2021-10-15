using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public AudioClip triggerSound;
    public AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update(){}
    void OnTriggerEnter (Collider hoopCollider) {
        if(triggerSound != null)
        {
            audioSource.PlayOneShot(triggerSound,0.7F);
        }
    }

}
