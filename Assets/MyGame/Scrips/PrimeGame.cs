using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrimeGame : MonoBehaviour
{

    int number;
    public InputField input;
    bool isprime;
    bool rightbutton;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        numberchanger(Random.Range(1, 100));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonpressed(int a)
    {
        int.TryParse(input.text, out int result);

        number = result;

        isprime = CalcIsPrime(number);

        if(a == 1 && isprime)
        {
            rightbutton = true; 
        }

        else if(a == 2 && !isprime)
        {
            rightbutton = true;
        }

        else
        {
            rightbutton = false;
        }

        changetext();

    }


    void changetext()
    {
        if(rightbutton)
        {
            text.text = "richtig";
        }

        else
        {
            text.text = "falsch";
        }

        numberchanger(Random.Range(1,100));

    }

    public bool CalcIsPrime(int number)
    {

        if (number == 1) return false;
        if (number == 2) return true;

        if (number % 2 == 0) return false; // Even number     

        for (int i = 2; i < number; i++)
        { // Advance from two to include correct calculation for '4'
            if (number % i == 0) return false;
        }

        return true;

    }

    void numberchanger(int a)
    {
        int b;


        b = Mathf.RoundToInt(a);
        input.text = b.ToString();
    }
}
