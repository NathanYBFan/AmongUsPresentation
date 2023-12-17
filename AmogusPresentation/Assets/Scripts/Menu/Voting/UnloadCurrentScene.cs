using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnloadCurrentScene : MonoBehaviour
{
    [SerializeField]
    private string sceneToUnload;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.UnloadSceneAsync(sceneToUnload);
        }
    }
}
