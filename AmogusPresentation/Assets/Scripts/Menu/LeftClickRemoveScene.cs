using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftClickRemoveScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.UnloadSceneAsync("Intro");
        }
    }
}
