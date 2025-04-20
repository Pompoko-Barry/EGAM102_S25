using UnityEngine;

public class CleanedGrapplr : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer _lineRenderer;
    public DistanceJoint2D _distanceJoint;


    // Start is called before the first frame update
    void Start()
    {
        _distanceJoint.enabled = false;
        _lineRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {


            Vector2 mouseWorldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mouseWorldPos - (Vector2)transform.position;

            //ignore "Player" layer
            int layerMask = ~LayerMask.GetMask("Player");

            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction.normalized, Mathf.Infinity, layerMask);

            if (hit.collider == null && hit.collider.attachedRigidbody == null) return;
            {
                Vector2 hitPoint = hit.point;

                _lineRenderer.SetPosition(0, hitPoint);
                _lineRenderer.SetPosition(1, transform.position);

                _distanceJoint.connectedAnchor = hitPoint;
                _distanceJoint.distance = Vector2.Distance(transform.position, hitPoint);
                _distanceJoint.enabled = true;
                _lineRenderer.enabled = true;
            }

        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _distanceJoint.enabled = false;
            _lineRenderer.enabled = false;
        }
        if (_distanceJoint.enabled)
        {
            _lineRenderer.SetPosition(1, transform.position);

            //pull effect to gradually reduce joint distance
            float pullSpeed = 2.5f;
            _distanceJoint.distance = Mathf.Max(0.1f, _distanceJoint.distance - pullSpeed * Time.deltaTime);
        }
    }

}