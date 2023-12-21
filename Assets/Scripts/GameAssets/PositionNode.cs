using UnityEngine;

public class PositionNode : IPositionNode
{
    private Vector3 position;
    public Vector3 Position { get; set; }

    public void SpawnPositionNode(bool hidden = false)
    {
    }
}