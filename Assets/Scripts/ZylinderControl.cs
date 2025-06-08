using UnityEngine;
using System.Collections;

public class ZylinderControl : MonoBehaviour
{
    private CharacterController Figur;
    private Animator anim;
    private Vector3 MoveVector = Vector3.zero;
    public float Speed = 10.0f;
    private int isWalking;
    private Vector3 TurnVector = Vector3.zero;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Figur = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        isWalking = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        MoveVector.x = Input.GetAxis("Horizontal");
        MoveVector.z = Input.GetAxis("Vertical");
        TurnVector.y = Input.GetAxis("Mouse X");
        MoveVector = transform.TransformDirection(MoveVector);


        Figur.Move(MoveVector * Time.deltaTime * Speed);
        transform.Rotate(TurnVector * Time.deltaTime * Turn);
        if (MoveVector.x != 0 || MoveVector.z != 0)
        {
            anim.SetBool(isWalking, true);
        }
        else
        {
            anim.SetBool(isWalking, false);
        }
    }
}
