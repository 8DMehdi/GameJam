using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musique : MonoBehaviour
{

    public int play = 0;

    public AudioSource musiqueBois;
    void Update()
    {
        if (play == 0)
        {
            musiqueBois.Play();
            play = 1;
        }
        DontDestroyOnLoad(musiqueBois);
    }

    private void Load()
    {
        play = PlayerPrefs.GetInt("1");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("1", play);
    }
}
