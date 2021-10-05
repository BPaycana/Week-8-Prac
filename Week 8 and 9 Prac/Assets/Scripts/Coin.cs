using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public LayerMask playerOne;
    public LayerMask playerTwo;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == 6)
        {
            Scorekeeper.instance.AddPoint();
            Destroy(gameObject);
        }

        if (col.gameObject.layer == 7)
        {
            Scorekeeper.instance.AddPoint2();
            Destroy(gameObject);
        }

        
    }
}
