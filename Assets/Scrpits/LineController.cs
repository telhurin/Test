using UnityEngine;
using System.Collections;

public class LineController : MonoBehaviour
{

    #region Privates
    private LineRenderer lineRenderer;

    private float distance = 0;
    private float counter = 0;

    #endregion

    public float drawingSpeed = 1;
    public Transform origin;
    public Transform destination;


	// Use this for initialization
	void Start () {

        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetPosition(1, origin.position + (destination.position - origin.position) * 0);
        distance = Vector3.Distance(origin.position, destination.position);
	}
	
	// Update is called once per frame
	void Update () {

        if (counter < 1)
        {
            counter += 0.001f * drawingSpeed;
            lineRenderer.SetPosition(1, origin.position + (destination.position - origin.position) * counter);
        }
	
	}
}
