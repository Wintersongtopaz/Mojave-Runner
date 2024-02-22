using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script requires the use of three components: Animator, Player, and Rigidbody2D
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Player))]
[RequireComponent(typeof(Rigidbody2D))]
// Use the RequireComponent attribute to make sure the GameObject this script is attached to has these components

public class PlayerAnimation : MonoBehaviour
{
    // This script needs a reference variable for each component
    Animator animator;
    Player player;
    Rigidbody2D rigidbody2D;

    public GameObject particlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Get a reference to each component using GetComponent
        animator = GetComponent<Animator>();
        player = GetComponent<Player>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set the snimator bool parameter "Falling" to the value of player.isFalling.
        animator.SetBool("Falling", player.isFalling);
        // Set the animator float parameter "YVelocity" to the value of rigidbody2D.velocity.y
        animator.SetFloat("Y Velocity", rigidbody2D.velocity.y);
    }
    //smoke animation 
    public void Smoke()
    {
        Instantiate(particlePrefab, transform.position, Quaternion.identity);
    }
}
