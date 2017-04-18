using UnityEngine;

public class FrameLogger : MonoBehaviour
{
    int frameCounter = 0;
    int countDirection = 1;

    void Update ()
    {
        if(frameCounter == 100)
        {
            countDirection = -1;
        }

        if (frameCounter == 0)
        {
            countDirection = 1;
        }

        frameCounter = frameCounter + countDirection;

        Debug.Log(frameCounter);
	}
}
