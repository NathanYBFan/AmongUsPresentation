using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskCollider : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;


    private bool inCollider = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inCollider = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inCollider = false;
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && inCollider)
        {
            SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Additive);
            Destroy(this.gameObject);
        }
    }
}
