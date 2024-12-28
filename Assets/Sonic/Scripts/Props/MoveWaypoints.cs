using System.Collections.Generic;
using UnityEngine;

public class MoveWaypoints : MonoBehaviour {
    [SerializeField] private List<Transform> waypoints;
    [SerializeField] private float speed;
    private int currentIndex;
    private float precision = 1f;

    private void Update() {
        float distanceToPoint = Vec2Point().magnitude;

        if (distanceToPoint < precision) {
            currentIndex = (currentIndex + 1) % waypoints.Count; 
        }

        MoveToWaypoint();
    }

    private void MoveToWaypoint() {
        Vector3 toPoint = Vec2Point().normalized;

        transform.Translate(toPoint * speed * Time.deltaTime, Space.World);
        transform.LookAt(transform.position + toPoint);
    }

    private Vector3 Vec2Point() {
        Vector3 pointPos = waypoints[currentIndex].position;
        Vector3 currentPos = transform.position;
        
        pointPos = new Vector3(pointPos.x, 0, pointPos.z);
        currentPos = new Vector3(currentPos.x, 0, currentPos.z);

        return pointPos - currentPos;
    }
}