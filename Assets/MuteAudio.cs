using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    public void MuteToogle(bool muted)
    {
        if(muted)
        {
            AudioListener.volume = 0;
            Debug.Log("Music OFF !");
        }

        else
        {
            AudioListener.volume = 1;
            Debug.Log("Music ON !");
        }
    }
}
