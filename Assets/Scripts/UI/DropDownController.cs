using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownController : MonoBehaviour
{
    GameObject target;
    MouseAimCamera mouseAimc;
    LookAtCamera lookAtc;
    FollowCamera followc;
    DungeonCamera dungeonc;

    private void Start()
    {
        target = GameObject.Find("Main Camera");
        mouseAimc = target.GetComponent<MouseAimCamera>();
        lookAtc = target.GetComponent<LookAtCamera>();
        followc = target.GetComponent<FollowCamera>();
        dungeonc = target.GetComponent<DungeonCamera>();
        Debug.Log(target.name);
    }

    public void HandleDropDown(int value)

    {
        if(value == 0)
        {
            mouseAimc.enabled = false;
            lookAtc.enabled = true;
            followc.enabled = false;
            dungeonc.enabled = false;
        }

        if (value == 1)
        {
            mouseAimc.enabled = false;
            lookAtc.enabled = false;
            followc.enabled = true;
            dungeonc.enabled = false;
        }

        if (value == 2)
        {
            mouseAimc.enabled = false;
            lookAtc.enabled = false;
            followc.enabled = false;
            dungeonc.enabled = true;

        }

        if (value == 3)
        {
            mouseAimc.enabled = true;
            lookAtc.enabled = false;
            followc.enabled = false;
            dungeonc.enabled = false;
        }

    }
}
