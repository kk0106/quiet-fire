using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abc : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject thirdPersonPlayer;  //角色
    public float MoveSpeed = 10.0f;       //移動速度
    public float RotateSpeed = 10.0f;     //旋轉速度
    private Rigidbody PlayerRigidbody;    //角色的剛體元件
    void Start()
    {
        PlayerRigidbody = thirdPersonPlayer.GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");  //左右
        float v = Input.GetAxis("Vertical");    //前後

        Vector3 GlobalDirectionForward = thirdPersonPlayer.transform.TransformDirection(Vector3.forward);
        Vector3 ForwardDirection = v * GlobalDirectionForward * Time.fixedDeltaTime;//物體前後移動的方向
        Vector3 GlobalDirectionRight = thirdPersonPlayer.transform.TransformDirection(Vector3.right);
        Vector3 RightDirection = h * GlobalDirectionRight * Time.fixedDeltaTime;//物體左右移動的方向

        Vector3 MainDirection = ForwardDirection + RightDirection;

        PlayerRigidbody.MovePosition(PlayerRigidbody.position + MainDirection * MoveSpeed);
    }
}
