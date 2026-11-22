using UnityEngine;
using TMPro;

public class Load_Win : MonoBehaviour 
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] GameObject Win_Level;
    [SerializeField] GameObject Lose_Level;
    [SerializeField] GameObject This_Level;


    public void ValidateInput()
    {
        string input = inputField.text;
        input = input.ToUpper();
        input = input.Replace(" ", string.Empty);
        input = input.Replace(",", string.Empty);

        if (input == "RRRRLLLRL")
        {
            Win_Level.SetActive(true);
            This_Level.SetActive(false);
        }
        else
        {

            Lose_Level.SetActive(true);
            This_Level.SetActive(false);
        }
    }

}
