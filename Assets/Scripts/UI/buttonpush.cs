using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class buttonpush : MonoBehaviour {
    //public GameObject text;
    public GameObject player;
    private Rigidbody rb;
    public Text test;
    public Text movementfunc;
    public InputField inputfeild;
    public bool canmove;
    public string[] inputarray = new string[2];
    
    //public List
    public List<string> function = new List<string>();
    public List<Vector3> nodes = new List<Vector3>();


    Vector3 playerpos;
    Vector3 newpos;

    float time;
    float distance;


    string temp_dir;
    string temp_dis;
    public bool state;

    public float speed = 1.0f;

    int nodepos;
    public bool first;
    void Start()
    {
        first = true;
        movementfunc.text = "";
        rb = player.GetComponent<Rigidbody>();
        canmove = false;
        nodepos = 0;

       
       
        
    }
    void Update()
        
    {

        
        if (canmove == true)
        {

            float distcov = (Time.time - time) * speed;
            float journeyfracure = distcov / distance;

            player.transform.position = Vector3.Lerp(playerpos, newpos, journeyfracure);

            if (journeyfracure >= 1f && nodepos + 1 < nodes.Count)
            {
                if (first == true)
                {
                    nodepos = 0;
                    first = false;
                }
                else
                {
                    nodepos++;
                }
             
               Move();
            }
            if (player.transform.position == nodes[nodes.Count - 1])
            {
                canmove = false;
            }

          
        }
    }
   public void number_edit()
   {
       test.text = inputarray[0] + " for " + inputarray[1];
   }
    public void number_0()
    {

        inputarray[1] = inputarray[1] + "0";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void number_1()
    {

        inputarray[1] = inputarray[1] + "1";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void number_2()
    {

        inputarray[1] = inputarray[1] + "2";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void number_3()
    {

        inputarray[1] = inputarray[1] + "3";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void number_4()
    {

        inputarray[1] = inputarray[1] + "4";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void number_5()
    {

        inputarray[1] = inputarray[1] + "5";
        test.text = inputarray[0] + " for " + inputarray[1];
    }
    public void number_6()
    {

        inputarray[1] = inputarray[1] + "6";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void number_7()
    {

        inputarray[1] = inputarray[1] + "7";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void number_8()
    {

        inputarray[1] = inputarray[1] + "8";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void number_9()
    {

        inputarray[1] = inputarray[1] + "9";
        test.text = inputarray[0] + " for " + inputarray[1];

    }

    public void Button_Left()
    {
        inputarray[0] = "Left";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void Button_Right()
    {

        inputarray[0] = "Right";
        test.text = inputarray[0] + " for " + inputarray[1];
    }
    public void Button_Foward()
    {
        inputarray[0] = "Foward";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
    public void Button_Back()
    {

        inputarray[0] = "Back";
        test.text = inputarray[0] + " for " + inputarray[1];

    }
  
    //changes the text of the text displayed in the game
    public void Button_Confrim()
    {
        movementfunc.text = "";
        test.text = "";
        function.Add(inputarray[0]);
        function.Add(inputarray[1]);
        int size;
        size = function.Count;
        inputarray[0] = null;
        inputarray[1] = null;
        //Debug.Log("this is size" + size);
        //Debug.Log("here");
        //Debug.Log(function[0]);
       // Debug.Log(function[1]);
        
        for (int i = 0; i < size; i++)
        {
            
            //Debug.Log("Test");
            //movementfunc.text +=  "\n" + function[i] + "\n";
            Debug.Log(function[i]);
            if(i%2 == 0)
            {

                movementfunc.text += function[i] + " " + function[i+1] + "\n";
            }
            if(i%2 !=0)
            {
                
            }
           
        }


    }

    public void Button_Run()
    {
        playerpos = player.transform.position;
        Vector3 ogpos = player.transform.position;
        int size;
        size = function.Count;

        canmove = true;
        Debug.Log(playerpos);
        for (int i = 0; i < size; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Here");
                if (function[i] == "Right")
                {

                    float number = System.Convert.ToSingle(function[i + 1]);

                    playerpos += player.transform.right * Time.deltaTime * number;

                    nodes.Add(playerpos);
                    //player.transform.position += playerpos;
                    //playerpos = ogpos;
                }
                if (function[i] == "Foward")
                {
                    float number = System.Convert.ToSingle(function[i + 1]);

                    playerpos += player.transform.forward * Time.deltaTime * number;

                    nodes.Add(playerpos);
                    //playerpos = ogpos;
                }
                if (function[i] == "Back")
                {
                    float number = System.Convert.ToSingle(function[i + 1]);

                    playerpos += -player.transform.forward * Time.deltaTime * number;

                    nodes.Add(playerpos);
                    //playerpos = ogpos;
                }
                if (function[i] == "Left")
                {
                    float number = System.Convert.ToSingle(function[i + 1]);

                    playerpos += -player.transform.right * Time.deltaTime * number;

                    nodes.Add(playerpos);
                   // playerpos = ogpos;
                }
            }

        }
        Move(); 
    }

    /*
     public void Button_Run()
    {
        int size;
        size = function.Count;
        canmove = true;

            for (int i = 0; i < size; i++)
            {
            
                if(i%2 == 0)
                {
                    canmove = true;
                    temp_dir = function[i];
                    temp_dis = function[i + 1];
                 }
        }
        
     }

    void Move(string dir, string dis)
    {
       
        float curtime = Time.time - starttime;
        float number = System.Convert.ToSingle(dis);

        playerpos = player.transform.position;

        if (dir == "Right")
        {
            newpos = player.transform.position * number * Time.deltaTime + transform.right;
            distance = Vector3.Distance(playerpos, newpos);
            float journeyfracure = curtime / distance;
            player.transform.position = Vector3.Lerp(playerpos, newpos, journeyfracure);
        }

        if (player.transform.position == newpos)
        {
            canmove = false;
        }
    }
     * */
    void Move()
    {
        if (first == true)
        {
            playerpos = player.transform.position;
            newpos = nodes[nodepos];
        }
        else
        {
            playerpos = nodes[nodepos];
            newpos = nodes[nodepos + 1];
        }
        time = Time.time;
        distance = Vector3.Distance(playerpos, newpos);

    }
}
