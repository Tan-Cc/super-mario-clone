
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public Transform target;
    public float smoothing = 5f;
    Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;
        offset.x = target.position.x + 1;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = targetCamPos;

    }

    //要跟随的人物
    /*public Transform follow;

    //相机距人物距离
    public float distanceAway = 5f;

    //相机距人物高度
    public float distanceUp = 5f;

    //相机跟随速度
    public float smooth = 5f;

    //目标位置
    private Vector3 targetPosition;

    private void LateUpdate()
    {
        //得到目标位置
        targetPosition = follow.position; //+ Vector3.up * distanceUp - follow.forward * distanceAway;
     
        //相机位置
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);

        //相机时刻看着人物
        transform.LookAt(follow);
    }*/
}
