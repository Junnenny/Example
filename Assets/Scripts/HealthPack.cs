using UnityEngine;

public class HealthPack : MonoBehaviour
{
    private int healthRestoreAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.RestoreHealth(healthRestoreAmount);
            }

            Destroy(gameObject);
        }
    }
}
