using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parch : MonoBehaviour
{
    public GameObject parche;
    public GameObject presse;
    public GameObject porteO;
    public GameObject porteL;
    public GameObject battar;
    public GameObject F;
    private int flag =0;
    private int flage =0;

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
            flag = 0;
            porteO.SetActive(true);
            porteL.SetActive(false);
            battar.SetActive(true);
            F.SetActive(false);
            
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
