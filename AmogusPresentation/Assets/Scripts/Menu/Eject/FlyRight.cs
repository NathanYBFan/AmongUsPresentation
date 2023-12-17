using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyRight : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, target.position, speed);
    }
}
