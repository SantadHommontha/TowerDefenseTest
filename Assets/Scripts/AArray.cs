using UnityEngine;

public class AArray : MonoBehaviour
{

    

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
