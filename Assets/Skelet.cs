using UnityEngine;

public class Skelet : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    private Player player;
    private bool richGoal = false;

    public void SetPlayer(Player player)
    {
        this.player = player;
    }
    
    void Update()
    {
        if (player == null)
        {
            return;
        }

        if (!richGoal)
        {
            Vector2 direction = player.transform.position - transform.position;
            transform.Translate(direction * Time.deltaTime * speed);

            if ((transform.position - player.transform.position).magnitude < 0.5f)
            {
                richGoal = true;
                Death death = new Death(player);
            }
        }
    }
}
