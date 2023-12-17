using UnityEngine;
using UnityEngine.SceneManagement;

public class VotingCharacterButton : MonoBehaviour
{
    [SerializeField]
    private OverallVoting overallVoting;

    [SerializeField]
    private Transform voteButtons;

    [SerializeField]
    private string checkMarkSceneToLoad;

    public void ClickedOnPFP()
    {
        if (voteButtons.gameObject.activeInHierarchy)
            voteButtons.gameObject.SetActive(false);    
        else
        {
            overallVoting.DisableAllVotingOptions();
            voteButtons.gameObject.SetActive(true);
        }
    }

    public void CheckButtonPressed()
    {
        SceneManager.LoadScene(checkMarkSceneToLoad, LoadSceneMode.Additive);
        overallVoting.DisableAllVotingOptions();
    }

    public void XButtonPressed()
    {
        voteButtons.gameObject.SetActive(false);
    }
}
