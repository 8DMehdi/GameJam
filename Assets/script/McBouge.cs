using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class McBouge : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float speed;
    public Animator  animator;
    [SerializeField] private TrailRenderer tr;

    private bool canDash = true;
    private bool isDashing;
    public float dashPower;
    public float dashTime;
    public float dashCooldown;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDashing)
         {
            return;
         }   
         if (Input.GetKey("q"))
         {
             transform.position += Vector3.left * speed * Time.deltaTime;
         }
         if (Input.GetKey("d"))
         {
             transform.position += Vector3.right * speed * Time.deltaTime;
         }
         if (Input.GetKey("z"))
         {
          transform.position += Vector3.up * speed * Time.deltaTime;
         }
         if (Input.GetKey("s"))
         {
          transform.position += Vector3.down * speed * Time.deltaTime;
         }
         if (Input.GetKey("space") && canDash == true){
            StartCoroutine(dash());
         }
         if (Input.GetKey("q") || Input.GetKey("z") || Input.GetKey("s") || Input.GetKey("d")){
            animator.SetInteger("course", 1);
         }
         else
         {
            animator.SetInteger("course", 0);
         }
    }

    IEnumerator dash ()
     {
        canDash = false;
        isDashing = true;
        //rb.velocity = new Vector2(transform.localScale.x * dashPower, 0f);


         speed = speed - 10;
     
        
             
        tr.emitting = true;
        yield return new WaitForSeconds(dashTime);
        tr.emitting = false;
        isDashing = false;
        speed = speed + 10;
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
     }
}
