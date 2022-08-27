using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
            Debug.Log("Vous �tes mort");
            GameManager.Instance.GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
