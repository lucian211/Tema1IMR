using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public LayerMask CactusLayer;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Collider[] hits = Physics.OverlapSphere(transform.position, 0.25f, CactusLayer);
        if (hits.Length > 1) //se exclude pe sine, deoarece toti cactusii au acelasi Layer
        {
            animator.CrossFade("Attack", 0.01f);
        }
    }
}
