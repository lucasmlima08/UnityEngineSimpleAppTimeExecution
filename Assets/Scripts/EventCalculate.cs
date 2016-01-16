using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EventCalculate : MonoBehaviour {

    public InputField inputValue;
    public Text result;

	public void eventCalculate()
    {
        try
        {
            int valueCount = int.Parse(inputValue.text);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < valueCount; i++);
            long elapsedMs = watch.ElapsedMilliseconds;
            //watch.Stop();
            
            result.text = "Resultado: "+elapsedMs;
        }
        catch (ExitGUIException e) { }
    }
}
