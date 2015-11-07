using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float _rotationX = 0;

    private Camera mainCamera;

    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true;

        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float rotationY = mainCamera.transform.localEulerAngles.y;
            mainCamera.transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;        
            mainCamera.transform.localEulerAngles = new Vector3(_rotationX, 0, 0);
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
	
	}
}
