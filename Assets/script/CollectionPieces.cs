using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionPieces : MonoBehaviour
{
    private int PieceCount;
    public GameObject porteO;
    public GameObject porteL;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PieceCount >= 3)
        {
            porteO.SetActive(true);
            porteL.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            PieceCount += 1; 
        }
    }

     private void OnTriggerEnter2D(Collider2D collision){
        PieceCount += 1;
        Destroy(gameObject);
    }
}
