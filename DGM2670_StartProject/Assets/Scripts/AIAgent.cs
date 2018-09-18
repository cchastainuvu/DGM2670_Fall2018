using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIAgent : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform Player;
    public bool CanChase;
    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        
        
    }

    private void Update()
    {

        if (true)
        {
             agent.destination = Player.position;
        }
        else
        {
            agent.destination = transform.position;
            //Equal to self, essentially.
        }
       
    }
    
    //Uppercase Transform is the CLASS. Lowercase transform is a variable hidden in MonoBehaviour.
}
