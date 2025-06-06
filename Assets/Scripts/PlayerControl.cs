using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController Figur;
    private Vector3 MoveVector = Vector3.zero;
    public float Speed = 5.0f;

    void Start()
    {
        Figur = GetComponent<CharacterController>();
    }

    void Update()
    {
        MoveVector.x = Input.GetAxis("Horizontal");
        MoveVector.z = Input.GetAxis("Vertical");
        Figur.Move(MoveVector * Time.deltaTime * Speed);
    }
}
