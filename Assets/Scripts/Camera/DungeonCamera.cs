using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCamera : MonoBehaviour
{

    public GameObject target;
    public float damping = 1;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 desiredPos = target.transform.position + offset;
        Vector3 pos = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * damping);
        transform.position = pos;
        transform.LookAt(target.transform.position);
    }
}
