using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawZoneManager : MonoBehaviour
{
    [SerializeField] BrushInteractor leftBrush;
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("XROrigin"))
        {
            leftBrush.EnableBrush(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("XROrigin"))
        {
            leftBrush.EnableBrush(false);
        }
    }
}
