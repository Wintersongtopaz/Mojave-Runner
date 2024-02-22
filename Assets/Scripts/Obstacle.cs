using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // TODO: A public float variable to control how fast the obstacle moves across the screen
    public Parallax.Layer layer;
    // TODO: A public float variable to control how far the object should go before being destroyed offscreen.
    public float endRange = -12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Move the obstacle to the left at a constant rate. 
        // Make sure this calculation is frame rate independent (hint: use Time.deltaTime)
        transform.position += Vector3.left * Parallax.GetSpeed(layer) * Time.deltaTime;

        // TODO: If the obstalce is off screen to the left, destroy this GameObject (hint: Destroy(gameObject))
        if (transform.position.x <= endRange){
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Health.TryDamageTarget(other.gameObject, 1);
    }
}
