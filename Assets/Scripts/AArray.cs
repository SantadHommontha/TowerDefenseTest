using UnityEngine;

public class AArray : MonoBehaviour
{
    public string message1;
    public string message2;
    public string message3;
    public string message4;
    public string message5;


    public string[] messages;

    public float timer = 0;
    public int index = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1)
        {
            timer = 0;
            Debug.Log(messages[index]);
            index++;
        }


    }
}
