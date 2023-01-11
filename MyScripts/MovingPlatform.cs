using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] Waypoints;

    private int CurrentWaypointIndex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(Waypoints[CurrentWaypointIndex].transform.position, transform.position) < .1f)
        {
            CurrentWaypointIndex++;
            if (CurrentWaypointIndex >= Waypoints.Length)
            {
                CurrentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[CurrentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
