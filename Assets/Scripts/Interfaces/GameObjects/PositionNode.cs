using UnityEngine;

public interface IPositionNode {

    public Vector3 Position
    {
        get; set;
    }

    public void SpawnPositionNode(bool hidden = false);
}