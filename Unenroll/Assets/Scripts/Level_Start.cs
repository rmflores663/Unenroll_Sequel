using UnityEngine;

public class Level_Start : MonoBehaviour
{


    [SerializeField]
    GameObject[] This_Level;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            if (This_Level[i].activeSelf)
            {
                if (i != 0)
                {
                    This_Level[i].SetActive(false);
                }
                else
                {
                    This_Level[i].SetActive(true);
                }
            }
            else
            {

                if (i == 0)
                {
                    This_Level[i].SetActive(true);
                }
            }
        }
    }
}
