using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class McPiece : MonoBehaviour
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
        if (PieceCount >= 3)
        {
            porteO.SetActive(true);
            porteL.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin")
        {
            PieceCount += 1;
            Destroy(collision.gameObject);
            collision.GetComponent<SpriteRenderer>().enabled = true;
            collision.GetComponent<Collider2D>().enabled = true;
            Debug.Log(PieceCount);
        }
    }
}
