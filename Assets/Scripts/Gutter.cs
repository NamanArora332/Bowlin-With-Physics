using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        if (triggeredBody.CompareTag("Ball"))
        {

            
            Rigidbody ballRigidBody = triggeredBody.gameObject.GetComponent<Rigidbody>();

            
            float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

            
            ballRigidBody.linearVelocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;

            
            Vector3 newVelocity = Vector3.forward * velocityMagnitude;
            ballRigidBody.linearVelocity = newVelocity;
        }
    }
}