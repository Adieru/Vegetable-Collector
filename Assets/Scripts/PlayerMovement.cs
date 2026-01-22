using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //X movement
    public float playerSpeed = 5.0f;
        
    float horizontalInput;

    //player position
    Vector3 playerPosition;


    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        playerPosition = this.transform.position;

    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        playerPosition.x += horizontalInput * playerSpeed * Time.deltaTime;
        this.transform.position = playerPosition;
    }
}
  