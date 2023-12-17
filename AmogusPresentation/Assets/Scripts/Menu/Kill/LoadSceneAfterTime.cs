using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfterTime : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    [SerializeField]
    private float timeToWait = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScene());
    }

    public IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
    }

}
