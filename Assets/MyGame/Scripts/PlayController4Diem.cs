using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    private Vector3 targetPositon;
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = pointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pointA.position)
        {
            targetPositon = pointB.position;
        }
        else if (transform.position == pointB.position)
        {
            targetPositon = pointC.position;
        }
        else if (transform.position == pointC.position)
        {
            targetPositon = pointD.position;
        }
        else if (transform.position == pointD.position)
        {
            targetPositon = pointA.position;
        }
        transform.position = Vector3.MoveTowards(transform.position,targetPositon, speed * Time.deltaTime);
        transform.LookAt(targetPositon);
    }
}
