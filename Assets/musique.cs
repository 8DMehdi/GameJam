using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musique : MonoBehaviour
{
    public AudioSource  musiqueBois;


    void Awake()
    {
        if (!musiqueBois.isPlaying)
        {
            musiqueBois.Play();
        }
        DontDestroyOnLoad(musiqueBois);
    }
}
