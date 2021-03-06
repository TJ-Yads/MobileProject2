using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    public Collider2D myCollider;
    public bool noBlockZone;

    void Update()
    {
        if (CheckDetection())
        {
        }
    }

    public bool CheckDetection()
    {
        if (myCollider.IsTouchingLayers(LayerMask.GetMask("Blocks")))
        {
            if (noBlockZone)
            {
                return (false);
            }
            else
            {
                return (true);
            }
            
        }
        else
        {
            if (noBlockZone)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
