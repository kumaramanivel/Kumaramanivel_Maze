using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public AudioClip[] soundFiles;
    public AudioSource soundSource;
    bool locked = true;
    bool opening = false;
    private float fullHeight = 5.0f;

    void Update()
    {
        if (opening && transform.position.y < fullHeight)
        {
            transform.Translate(0, 2.5f * Time.deltaTime, 0);
        }
    }

    public void OnDoorClicked()
    {
            int doorLocked = 0;
            int doorOpen = 1;
            if (!locked)
        {
            soundSource.clip = soundFiles[doorOpen];
            soundSource.Play();
            opening = true;
        }
        else
        {
            soundSource.clip = soundFiles[doorLocked];
            soundSource.Play();
        }
    }

    public void Unlock()
    {
        locked = false;
    }
}