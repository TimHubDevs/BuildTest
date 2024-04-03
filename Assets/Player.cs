using UnityEngine;

public class Player : MonoBehaviour
{
    private string _name;
    private SpriteRenderer _spriteRenderer;
    
    private void Start()
    {
        _name = gameObject.name;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ShowDeath()
    {
        _spriteRenderer.color = Color.red;
    }

    public string GetName()
    {
        return _name;
    }
}
