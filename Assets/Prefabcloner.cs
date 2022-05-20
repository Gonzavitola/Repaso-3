using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prefabcloner : MonoBehaviour
{
    public GameObject prefab;
    public Text InputCloneAmount;
    public int counter;
    public Text displayClonesLeft;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        displayClonesLeft.text = "?";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ClonePrefab()
    {
        if (InputCloneAmount.text != "")
        {
            int cloneAmount = int.Parse(InputCloneAmount.text);

            if (counter < cloneAmount)
            {
                Instantiate(prefab);
                counter++;
                displayClonesLeft.text = (cloneAmount - counter).ToString();
            }
            else
            {
                displayClonesLeft.text = "ERROR,ingrese un valor";
            }
        }
    }
}
