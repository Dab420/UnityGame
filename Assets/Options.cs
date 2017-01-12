using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {
    static public bool option1;
    void ChooseOption(string optionName)
    {
        switch(optionName)
        {
            case "option1":
                {
                    option1 = true;
                    Debug.Log("Yes");
                    break;
                }
        }
    }
}
