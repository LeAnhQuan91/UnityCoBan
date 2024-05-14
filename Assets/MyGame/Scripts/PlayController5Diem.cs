using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController5Diem : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    public Transform pointE;
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
            targetPositon = pointE.position;
        }
        else if (transform.position == pointE.position)
        {
            targetPositon = pointA.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPositon, speed * Time.deltaTime);
        transform.LookAt(targetPositon);
    }
}
