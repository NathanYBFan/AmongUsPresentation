using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerMovement playerMovement;

    private Vector2 playerInputs;

    // Update is called once per frame
    void Update()
    {
        playerInputs = Vector2.zero;

        if (Input.GetAxis("Horizontal") != 0)
        {
            playerInputs.x = Input.GetAxis("Horizontal");
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            playerInputs.y = Input.GetAxis("Vertical");
        }

        playerInputs.Normalize();
        
        playerMovement.Move(playerInputs);
    }
}
