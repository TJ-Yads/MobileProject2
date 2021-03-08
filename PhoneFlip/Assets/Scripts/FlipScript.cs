using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipScript : MonoBehaviour
{

    Quaternion phoneRotation;
    DetectorScript[] detectors;

    int inPlaceNumber = 0;

    void Start()
    {
        Input.gyro.enabled = true;


        detectors = FindObjectsOfType<DetectorScript>();

    }

    // Update is called once per frame
    void Update()
    {
        phoneRotation = Input.gyro.attitude;

        Debug.Log(phoneRotation);

        if((Mathf.Abs(phoneRotation.x)>0.3f) && (Mathf.Abs(phoneRotation.y) > 0.6f))
        {
            Debug.Log("Flipped");
            CheckDetectors();
        }
    }

    void CheckDetectors()
    {
        foreach (DetectorScript detector in detectors)
        {
            if (detector.CheckDetection())
            {
                inPlaceNumber += 1;
            }
        }

        if (inPlaceNumber == detectors.Length)
        {
            Win();
        }

        inPlaceNumber = 0;
    }

    void Win()
    {
        Debug.Log("You win!");
    }

}
