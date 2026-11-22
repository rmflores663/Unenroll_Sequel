using UnityEngine;

public class Load_Next_Level : MonoBehaviour
{

    [SerializeField]
    GameObject Load_Level;
    [SerializeField]
    GameObject This_Level;

   public void Load_Next_Level_Invoke()
    {
        Load_Level.SetActive(true);
        This_Level.SetActive(false);
    }
}
