/************************************************************
* COMPONENT OF: Player
* REQUIRED DEPENDENCIES: Rigidbody Component
* DESCRIPTION: It listens for WASD and Arrow key presses to set
*              vertical and horizontal directions. It uses those
*              to push the player's Rigidbody in that direction
*              at a preset force.
* AUTHOR: KaiHislop
* VERSION: 1.0
*************************************************************/

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Movement fields
    private float horizontalMovement;
    private float verticalMovement;
    private float force;

    // Start is called once
    void Start()
    {
        force = 4.75f;
    }

    // Physics update
    void FixedUpdate()
    {
        MovePlayer();
    }

    // Moves the player
    private void MovePlayer()
    {
        Vector3 direction = new Vector3(horizontalMovement, 0, verticalMovement);
        direction = direction.normalized;
        GetComponent<Rigidbody>().AddForce(direction * force);
    }

    // Gets the user key input and assigns movement directions
    private void SetMoveDirection(Vector2 input)
    {
        horizontalMovement = input.x;
        verticalMovement = input.y;
    }

    // Listens for movement input
    public void OnMoveInput(InputAction.CallbackContext ctx)
    {
        SetMoveDirection(ctx.ReadValue<Vector2>());
    }
}