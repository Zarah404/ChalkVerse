using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;
    public float detectionDistance = 3f;
   
 
    

    private void Update()
    {
        if (player != null)
        {
            float distance = Vector2.Distance(transform.position, player.position);

            if (distance < detectionDistance)
            {
                float minXLimit = player.position.x - detectionDistance;
                float maxXLimit = player.position.x + detectionDistance;
                
                

                float targetX = Mathf.Clamp(player.position.x, minXLimit, maxXLimit);
                Vector2 targetPosition = new Vector2(targetX, transform.position.y);
                Vector2 direction = (targetPosition - (Vector2)transform.position).normalized;
                transform.Translate(direction * speed * Time.deltaTime);

                if (direction.x < 0)
                {
                    // Move left
                    transform.localScale = new Vector3(-1f, 1f, 1f);
                }
                else if (direction.x > 0)
                {
                    // Move right
                    transform.localScale = new Vector3(1f, 1f, 1f);
                }
            }
        }
    }
}
