using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{

    public int damageToGive;
    public GameObject damageBurst;
    public Transform hitPoint;
    public GameObject damageNumber;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);
            var clone = (GameObject) Instantiate(damageNumber, hitPoint.position, Quaternion.Euler (Vector3.zero));

            var test1 = clone.GetComponent<FloatingNumbers>(); 
            test1.damageNumber = damageToGive;
            clone.transform.position = new Vector2(hitPoint.position.x, hitPoint.position.y);
        }
    }

    //private function OnCollisionEnter(col : Collision)
    //{
    //    if (col.gameObject.tag == "WeaponOrSomething")
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("Wow! ITS WORKS MAN OMG!!");

}
