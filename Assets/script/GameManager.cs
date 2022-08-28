using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject GameOver;
    public GameObject Win;
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void MyLoadScene(int idScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(idScene);
        Time.timeScale = 1;
    }
}
