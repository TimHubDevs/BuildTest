using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject skeletPrefab;
    
    [SerializeField]
    private Player player;

    private void Start()
    {
        GameObject skeletObj = Instantiate(skeletPrefab);
        skeletObj.GetComponent<Skelet>().SetPlayer(player);
    }
}
