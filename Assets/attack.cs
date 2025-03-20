using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public int damage = 5;
    private float attackRange = 5f;
    public LayerMask enemyLayer;
    public Camera cam;
    private Ray ray;
    RaycastHit hit;


    private float lastAttack = 0;
    private float attackTime = 1f;


   private void AttackSystem()
    {
        if(Physics.Raycast(ray, out hit, attackRange, enemyLayer))
        {
            hp enemyHp = hit.collider.GetComponent<hp>();
            Debug.Log("Attacl Enemy");
            enemyHp.Damage(damage);
        }
        lastAttack =Time.time;
    }



    // Start is called before the first frame update
   

    // Update is called once per frame
    private void Update()
    {
        if (Input .GetMouseButtonDown(0))
        {
            ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        }   if (Physics.Raycast(ray,out hit, attackRange, enemyLayer))
        {
            if (hit.collider.gameObject.CompareTag("Enemy"))
            {
                AttackSystem();
            }
        }
    }
}
