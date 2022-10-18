using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float m_speed = 5f;
    public float m_rotate = 5f;
    Animator ani;
    bool m_walk;
    // Start is called before the first frame update
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
        m_walk = false;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)&& Input.GetKey(KeyCode.S)&& Input.GetKey(KeyCode.D))
        {
            m_walk = true;
        }
        else
        {
            m_walk = false;
        }

        if (m_walk == false)
        {
            ani.SetBool("walk", false);
        }
        else
        {
            ani.SetBool("walk", true);
        }
    }
    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_walk = true;
            this.transform.Translate(Vector3.forward * m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m_walk = true;
            this.transform.Translate(Vector3.left * m_rotate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_walk = true;
            this.transform.Translate(Vector3.back * m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_walk = true;
            this.transform.Translate(Vector3.right * m_rotate* Time.deltaTime);
        }

    }
}
