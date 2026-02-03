using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //X movement
    public float playerSpeed = 1.0f;

    float horizontalInput;

    Rigidbody playerRb;

    [SerializeField] float minX, maxX;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
       //horizontalInput = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 movement = new Vector3(horizontalInput * playerSpeed, 0, 0);

        playerRb.linearVelocity = movement;

        Vector3 vector3 = playerRb.position;

        Vector3 ClampedPosition = this.transform.position;
        ClampedPosition.x = Mathf.Clamp(ClampedPosition.x, minX, maxX);
        transform.position = ClampedPosition;


    }

    public void MoveLeft()
    {
        horizontalInput = -0.5f;
    }

    public void MoveRight()
    {
        horizontalInput = 0.5f;
    }

    public void stopMove()
    {
        horizontalInput = 0;
    }
}
  