using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public const int AMMO_IN_BOX = 50;
    
    public static void AddAmmo()
    {
        CharacterStats.CurrentAmmo += AMMO_IN_BOX;
        CharacterStats.OnAmmoChanged.Invoke();
    }
}
