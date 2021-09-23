using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform currentObject;
    public Transform goalObject;
    private Animator _animator;
    private float speed = 0.5f;
    private float closeEnoughDistance = 2f;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        
            float distanceToGoal = Vector3.Distance(currentObject.position, goalObject.position);
            Vector3 goalDirection = (goalObject.position - currentObject.position).normalized;
            Vector3 lookatGoal = new Vector3(goalObject.position.x, transform.position.y, goalObject.position.z);
            transform.LookAt(lookatGoal);
            float normalizedAnimationSpeed = ((Mathf.Clamp(distanceToGoal, closeEnoughDistance, 10f + closeEnoughDistance)) - closeEnoughDistance) / 10;
            _animator.SetFloat("Speed", normalizedAnimationSpeed);
            if (Mathf.Abs(distanceToGoal) > closeEnoughDistance)
            {
                currentObject.Translate(0, 0, speed * normalizedAnimationSpeed * Time.deltaTime);
            }
       
    }
}
