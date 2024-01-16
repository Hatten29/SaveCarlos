using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.5f;
    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void Update()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        movement.Normalize();
        FlipCharacter(horizontalInput);
        transform.Translate(movement * speed * Time.deltaTime);

        // Check if the player is in the trigger zone and press the "E" key
        if (Input.GetKeyDown(KeyCode.E))
        {
            HandleInteraction();
        }
    }

    private void FlipCharacter(float horizontalInput)
    {
        if (horizontalInput > 0)
        {
            transform.localScale = originalScale;
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
        }
    }

    private void HandleInteraction()
    {
        // Implement interaction logic here if needed
        Debug.Log("Interaction Key (E) Pressed");
    }
}
