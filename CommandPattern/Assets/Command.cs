using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : MonoBehaviour
{

    public abstract void Execute();

}

// we use abstract to make sure that all our methods have a execute function