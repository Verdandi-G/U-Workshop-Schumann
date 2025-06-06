using UnityEngine;

public class ZylinderControl : MonoBehaviour
{
    private CharacterController Figur;
    private Vector3 MoveVector = Vector3.zero;
    public float Speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Figur = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveVector.x = Input.GetAxis("Horizontal");
        MoveVector.z = Input.GetAxis("Vertical");
        Figur.Move(MoveVector * Time.deltaTime * Speed);
    }
}
