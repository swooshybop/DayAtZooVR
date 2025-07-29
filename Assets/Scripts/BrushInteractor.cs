using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BrushInteractor : MonoBehaviour
{
    [SerializeField] InputActionReference drawAction;
    [SerializeField] float minDistance = 0.01f;
    [SerializeField] Material strokeMat;
    [SerializeField] float strokeWidth = 0.01f;

    LineRenderer currentStroke;
    List<Vector3> points = new();

    public void EnableBrush(bool state)
    {
        gameObject.SetActive(state);
    }

    void OnEnable()
    {
        drawAction.action.started += StartStroke;
        drawAction.action.canceled += EndStroke;
    }

    void OnDisable()
    {
        drawAction.action.started -= StartStroke;
        drawAction.action.canceled -= EndStroke;
    }

    void Update()
    {
        if (currentStroke == null)
        {
            return;
        }

        Vector3 pos = transform.position;

        if (points.Count == 0 || Vector3.Distance(points[^1], pos) > minDistance)
        {
            points.Add(pos);
            currentStroke.positionCount = points.Count;
            currentStroke.SetPositions(points.ToArray());
        }
    }

    void StartStroke(InputAction.CallbackContext ctx)
    {
        currentStroke = new GameObject("Stroke").AddComponent<LineRenderer>();
        currentStroke.material = strokeMat;
        currentStroke.widthMultiplier = strokeWidth;
        points.Clear();
    }
    void EndStroke(InputAction.CallbackContext ctx)
    {
        currentStroke = null;
    }
}
