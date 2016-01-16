using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EventReset : MonoBehaviour {

    public InputField inputValue;
    public Text result;

	public void eventReset()
    {
        inputValue.text = "";
        result.text = "| Resultado |";
    }
}
