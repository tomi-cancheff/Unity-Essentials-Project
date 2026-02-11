using UnityEngine;

// Controls player movement and rotation.
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Set player's movement speed.
    public float rotationSpeed = 120.0f; // Set player's rotation speed.
    public float jumpForce = 0.5f; // Jump force.

    [Header("Jump Settings")]
    [Min(1)] public int maxJumps = 2; // Number of consecutive jumps allowed before landing.

    private Rigidbody rb; // Reference to player's Rigidbody.
    private int jumpsUsed; // Number of jumps used since last grounded state.
    private bool isGrounded; // Whether the player is currently touching walkable ground.

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody.
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && CanJump())
        {
            Jump();
        }
    }

    // Handle physics-based movement and rotation.
    private void FixedUpdate()
    {
        // Ground state will be restored in OnCollisionStay when touching floor.
        isGrounded = false;

        // Move player based on vertical input.
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotate player based on horizontal input.
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }

    private bool CanJump()
    {
        if (isGrounded)
        {
            jumpsUsed = 0;
        }

        return jumpsUsed < maxJumps;
    }

    private void Jump()
    {
        // Reset vertical velocity for predictable jump height in multi-jump scenarios.
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        jumpsUsed++;
        isGrounded = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        // Consider grounded only when colliding with a mostly-upward surface.
        for (int i = 0; i < collision.contactCount; i++)
        {
            if (collision.GetContact(i).normal.y > 0.5f)
            {
                isGrounded = true;
                jumpsUsed = 0;
                return;
            }
        }
    }
}
