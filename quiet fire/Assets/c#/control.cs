using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class control : MonoBehaviour
{
   public Animator ani;
    public int state = 0;
   
    
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            state = 1;
        }
        else
        {
            state = 0;
        }
        ani.SetInteger("state", state);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime *100);
       // transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * 50, 0);
    }
    
}
