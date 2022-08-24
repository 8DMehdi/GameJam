using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionPieces : MonoBehaviour
{
    public GameObject porteO;
    public GameObject porteL;
    public GameObject piece;
    public int PieceCount;

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
    }

     private void OnTriggerEnter2D(Collider2D collision){
        PieceCount += 1;
        //Destroy(gameObject);
        piece.GetComponent<SpriteRenderer>().enabled = true;
        piece.GetComponent<Collider2D>().enabled = true;
        Debug.Log(PieceCount);
    }
}
