using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BounceBetweenPoints : MonoBehaviour
{
    [SerializeField]
    private List<Transform> listOfTargets;

    [SerializeField]
    private float minSpeed = 0.2f;

    [SerializeField]
    private float maxSpeed = 1f;

    [SerializeField]
    private float speed = 0.2f;

    private Transform currentTarget;

    private void Start()
    {
        PickNextTarget();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, currentTarget.position, speed);
    }

    public void PickNextTarget()
    {
        Transform tempPos = listOfTargets[Random.Range(0, listOfTargets.Count - 1)];
        while (currentTarget != null && currentTarget.position == tempPos.position)
            tempPos = listOfTargets[Random.Range(0, listOfTargets.Count - 1)];
        currentTarget = tempPos;

        speed = Random.Range(minSpeed, maxSpeed);
    }
}
