using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = -40f;
    public float rotationSpeed = 720;

  void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 MoveDirection = new Vector3(-xDirection, 0.0f,-zDirection);

        MoveDirection.Normalize();

        transform.Translate(MoveDirection*Speed*Time.deltaTime, Space.World);

        if (MoveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(MoveDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }        
   }
}