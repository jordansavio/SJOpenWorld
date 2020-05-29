using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public Animator Enemy;
    public int Life;
    public bool Patrol;
    public bool Attack;
    public Transform Target;
    public float speed;
    public float speedTurn;

    private void Start()
    {
        Patrol = true;
    }

    private void FixedUpdate()
    {
        if (Patrol && !Attack)
        {
            Enemy.SetBool("isWalk",true);

            Vector3 player = Target.position;
            transform.position = Vector3.MoveTowards(transform.position, player , speed * Time.deltaTime);

            Vector3 distancce = Target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(distancce);

           transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * (speedTurn / 360.0f));
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !Attack)
        {
            Enemy.SetBool("isWalk", false);

            Attack = true;
            InvokeRepeating("OnAttack", 0, 1);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player" && Attack)
        {
            Patrol = true;
            Attack = false;
            CancelInvoke("OnAttack");
        }
    }

    void OnAttack()
    {
        Enemy.SetTrigger("isAttack");
        Debug.Log("Attaack");
    }

    public void SetDamage()
    {
        Life -= 1;
        if(Life <= 0)
        {
            EnemyDie();
        }
    }

    public void EnemyDie()
    {
        Enemy.SetTrigger("isDie");
    }

}
