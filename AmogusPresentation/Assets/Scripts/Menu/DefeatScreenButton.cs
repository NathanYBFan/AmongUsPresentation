using UnityEngine;
using UnityEngine.SceneManagement;
public class DefeatScreenButton : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    public void QuitClicked() 
    {
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
    }
}
