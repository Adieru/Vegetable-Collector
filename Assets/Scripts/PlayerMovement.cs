using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //X movement
    public float playerSpeed = 20.0f;

    float horizontalInput;

    Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 movement = new Vector3(horizontalInput * playerSpeed, 0, 0);

        playerRb.linearVelocity = movement;
    }
}
  