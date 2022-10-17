using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abc : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject thirdPersonPlayer;  //����
    public float MoveSpeed = 10.0f;       //���ʳt��
    public float RotateSpeed = 10.0f;     //����t��
    private Rigidbody PlayerRigidbody;    //���⪺���餸��
    void Start()
    {
        PlayerRigidbody = thirdPersonPlayer.GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");  //���k
        float v = Input.GetAxis("Vertical");    //�e��

        Vector3 GlobalDirectionForward = thirdPersonPlayer.transform.TransformDirection(Vector3.forward);
        Vector3 ForwardDirection = v * GlobalDirectionForward * Time.fixedDeltaTime;//����e�Ჾ�ʪ���V
        Vector3 GlobalDirectionRight = thirdPersonPlayer.transform.TransformDirection(Vector3.right);
        Vector3 RightDirection = h * GlobalDirectionRight * Time.fixedDeltaTime;//���饪�k���ʪ���V

        Vector3 MainDirection = ForwardDirection + RightDirection;

        PlayerRigidbody.MovePosition(PlayerRigidbody.position + MainDirection * MoveSpeed);
    }
}
