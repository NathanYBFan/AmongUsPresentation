using UnityEngine;
using UnityEngine.SceneManagement;

public class OverallVoting : MonoBehaviour
{
    [SerializeField]
    private Transform[] votingOptions;

    [SerializeField]
    private string sceneToLoad;

    public void DisableAllVotingOptions()
    {
        foreach(Transform votingOption in votingOptions)
        {
            votingOption.gameObject.SetActive(false);
        }
    }

    public void ChatPressed ()
    {
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Additive);
    }
}
