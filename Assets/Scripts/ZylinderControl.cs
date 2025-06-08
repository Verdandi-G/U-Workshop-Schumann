using UnityEngine;
using System.Collections;

public class ZylinderControl : MonoBehaviour
{
    private CharacterController Figur;
    private Animator anim;
    private Vector3 MoveVector = Vector3.zero;
    public float Speed = 10.0f;
    private int isWalking;
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
        Figur.Move(MoveVector * Time.deltaTime * Speed);
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
