using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Composite : BT_Node
{
    public List<BT_Node> children { get; set; }

    public Composite(BehaviorTree t, BT_Node[] nodes) : base(t)
    {
        children = new List<BT_Node>(nodes);
    }
}
