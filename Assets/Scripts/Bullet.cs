using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    public float LifeTime = 8f;
    private float lifeduration;
    //Rigidbody projectile;
    private void OnEnable()
    {
        lifeduration = LifeTime;
        //projectile = GetComponent<Rigidbody>();
    }
    private void Update()
    {

        this.transform.Translate(Vector3.forward * speed * Time.deltaTime); 
        lifeduration -= Time.deltaTime;
        if (lifeduration <= 0f)
        {
            gameObject.SetActive(false);
        }
    }
}
