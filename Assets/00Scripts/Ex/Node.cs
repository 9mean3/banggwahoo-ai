using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeState
{
    Running,
    Success,
    Failure,
}

public abstract class Node : MonoBehaviour
{
    public abstract NodeState Evaluate();
}
