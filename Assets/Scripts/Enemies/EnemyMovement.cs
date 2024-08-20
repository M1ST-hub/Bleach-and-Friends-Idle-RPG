using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class EnemyMovement : MonoBehaviour
{

    public GameObject Enemy;
    public float speed;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if(transform.position.x < -3.5 )
        {
            speed = 0;
        }
    }
}
