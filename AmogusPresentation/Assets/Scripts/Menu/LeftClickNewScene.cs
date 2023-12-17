using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftClickNewScene : MonoBehaviour
{
    [SerializeField]
    private string nextSceneToLoad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(nextSceneToLoad, LoadSceneMode.Single);
            Destroy(this.gameObject);
        }
    }
}
