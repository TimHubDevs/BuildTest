using UnityEngine;

public class Death
{
    private Player _player;

    public Death(Player player)
    {
        _player = player;
        Test();
    }

    private void Test()
    {
        Debug.Log($"Death was on player {_player.GetName()}");
        _player.ShowDeath();
    }
}
