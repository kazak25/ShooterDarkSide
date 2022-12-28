using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefsManager
{
    private const string PLAYER_KEY = "Weapon";
    // Start is called before the first frame update
    public static void Save(string player)
    {
        PlayerPrefs.SetString(PLAYER_KEY,player);
        PlayerPrefs.Save();
    }

    public static string Load()
    {
        return PlayerPrefs.GetString(PLAYER_KEY);
    }
    
}
