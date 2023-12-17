using System.Runtime.CompilerServices;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField]
    private float spinSpeed = 60f;

    [SerializeField]
    private bool spinClockWise = true;
    // Update is called once per frame
    void Update()
    {
        if (spinClockWise)
            transform.Rotate(0, 0, -spinSpeed * Time.deltaTime);
        else
            transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}
