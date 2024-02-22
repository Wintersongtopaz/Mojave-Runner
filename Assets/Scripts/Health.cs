using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int healthAmount = 3;

    public void TakeDamage(int damageAmount)
    {
        // If the player hits an obstacle, loose 1 heart and shake the camera.
        healthAmount -= damageAmount;
        GameFeel.AddCameraShake(0.1f);

        if (healthAmount <= 0)
        {
            GameManager.instance.Restart();
        }
    }

    public static void TryDamageTarget(GameObject target, int damageAmount)
    {
        Health targetHealth = target.GetComponent<Health>();
        // The player looses a heart when they hit a cactus.
        if (targetHealth)
        {
            targetHealth.TakeDamage(damageAmount);
        }
    }
}
