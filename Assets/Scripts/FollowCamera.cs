using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    private void Update()
    {
        transform.position = target.position - transform.forward * 10;
    }
}