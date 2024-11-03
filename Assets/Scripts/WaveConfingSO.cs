using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "WaveConfig", fileName = "New Wave Config")]
public class WaveConfingSO : ScriptableObject
{
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 5f;

    public Transform GetStartingWaypoint()
    {
        return pathPrefab.GetChild(0);
    }
    public List<Transform> GetWaypoints()
    {
        List<Transform> waypoints = bew List<Tranform>();
        foreach(Transform child in pathPrefab);
        {
            waypoints.Add(child);
        }
        return waypoints;
    }
    public float GetMoveSpeed()
    {
        return moveSpeed;
    }
    
}
