using UnityEngine;

public class TargetEnter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Character"))
        {
            Destroy(collision.gameObject);
        }
    }
}
