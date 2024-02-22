using UnityEngine;

// TODO: Script should require a Rigidbody2D component
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    // TODO: Reference to Rigidbody2D component should have class scope.
    Rigidbody2D rigidbody2D;
    // TODO: A float variable to control how high to jump / how much upwards
    // force to add.
    public float jumpForce = 10.0f;

    public bool isFalling = true;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: Use GetComponent to get a reference to attached Rigidbody2D
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFalling)
        {
            // TODO: On the frame the player presses down the space bar, add an instant upwards
            // force to the rigidbody.
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2D.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        print("On Collision Enter");
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = true;
        }
    }
}
