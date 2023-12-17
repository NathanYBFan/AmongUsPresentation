using UnityEngine;

public class MainMenuCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Character"))
        {
            collision.GetComponent<BounceBetweenPoints>().PickNextTarget();
        }
    }
}
