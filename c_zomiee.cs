using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_Zomieeee : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent g_Navemeash;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_zombieMove();
    }

    void m_zombieMove()
    {
        g_Navemeash.destination = target.position;
    }
}
