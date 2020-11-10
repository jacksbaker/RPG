using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
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
        //if(false)
        {
            Destroy(other.gameObject);
        }
    }

    //private function OnCollisionEnter(col : Collision)
    //{
    //    if (col.gameObject.tag == "WeaponOrSomething")
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("Wow! ITS WORKS MAN OMG!!");

}
