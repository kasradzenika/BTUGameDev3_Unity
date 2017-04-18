using UnityEngine;

public class BTUGameDev5 : MonoBehaviour
{
    //public Vector3 moveSpeed;
    //public Vector3 scaleSpeed;
    //public Vector3 rotSpeed;

    public string newName;

    public Transform otherTransform;

    private void Start()
    {
        otherTransform.name = newName;
    }

    void Update ()
    {
        //otherTransform.position = otherTransform.position + moveSpeed;

        //otherTransform.localScale = otherTransform.localScale + scaleSpeed;

        //otherTransform.eulerAngles = otherTransform.eulerAngles + rotSpeed;
    }
}
