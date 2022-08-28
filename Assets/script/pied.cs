using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pied : MonoBehaviour
{
    public GameObject parche;
    public GameObject presse;
    public GameObject F;
    public GameObject gun;
    public GameObject ung;
    private int flag =0;
    private int flage =0;


    public AudioSource krchh;

    // Update is called once per frame
    void Update()
    {
        //flage =0;
        if (Input.GetKeyDown("e") && flag == 0 && flage == 1)
        {
            parche.SetActive(true);
            presse.SetActive(false);
            F.SetActive(true);
            flag = 1;
        }
        if (Input.GetKeyDown("f") && flag == 1 )
        {
            parche.SetActive(false);
            gun.SetActive(false);
            ung.SetActive(true);
            flag = 0;
            F.SetActive(false);
            krchh.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        flage =1;
        Debug.Log(flage);
        if (flag==0)
        {
            presse.SetActive(true);
        }
    }
}