using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController Cylinder;
    private Vector3 MoveVector = Vector3.zero;
    public float Speed = 5.0f;

    void Start()
    {
        Cylinder = GetComponent<CharacterController>();
    }

    void Update()
    {
        MoveVector.x = Input.GetAxis("Horizontal");
        MoveVector.z = Input.GetAxis("Vertical");
        Cylinder.Move(MoveVector * Time.deltaTime * Speed);
    }
}
