using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int damage = 10;
    private float attackRange = 5f;
    public LayerMask enemyLayer;
    public Camera cam;
    private Ray ray;
    RaycastHit hit;

    private float lastAttack = 0;
    private float attackCooltime = 1f;

    private void AttackSystem()
    {
        if (Time.time - lastAttack >= attackCooltime)
        {


            if (Physics.Raycast(ray, out hit , attackRange, enemyLayer))
            {
                Hp enemyHp = hit.collider.GetComponent<Hp>();
                Debug.Log("Attack Enemy");
                enemyHp.Damge(damage);
            }
            lastAttack = Time.time; 
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            if (Physics.Raycast(ray, out hit , attackRange, enemyLayer))
            {
                if (hit.collider.gameObject.CompareTag("Enemy"))
                {
                    AttackSystem();
                }
               
            }
        }
    }
}
