using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        //public Transform target;                                    // target to aim for
        public GameObject target;

        
        

        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();

	        agent.updateRotation = false;
	        agent.updatePosition = true;

            target = GameObject.FindGameObjectWithTag("Player");
            
        }


        private void Update()
        {
            if (target != null)
                agent.SetDestination(target.transform.position);

            if (agent.remainingDistance > agent.stoppingDistance)
                character.Move(agent.desiredVelocity, false, false);
            else
                character.Move(Vector3.zero, false, false);
        }


        /*public void SetTarget(Transform target)
        {
            this.target = target;
        }*/

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag.Equals("Player"))
            {
                Destroy(collision.gameObject);
                SceneManager.LoadScene("GameOver");                
            }
            
            if (collision.gameObject.tag.Equals("Bullet"))
            {
                Score.score++;
                Destroy(gameObject);
            }
        }
    }
}
