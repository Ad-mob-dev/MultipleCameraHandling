using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;
    public float damping = 1;
    Vector3 offset;

    void Start()
    {
       offset = target.transform.position - transform.position;
      
    }


    void LateUpdate()
    {
       float currentAngle = transform.eulerAngles.y;
       float desiredAngle = target.transform.eulerAngles.y;
       float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);
        //if Quaternion.Euler saved in Variable then Changing Reference 
       transform.position = target.transform.position - (Quaternion.Euler(0, angle, 0) * offset);
       transform.LookAt(target.transform);
    }

  
}
