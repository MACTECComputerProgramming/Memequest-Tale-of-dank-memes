using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stuffDie : MonoBehaviour {

    public int BHP = 100;
    public int CHP;

    int DMG= 100;


   public void on_Click()
    {
        BHP -=DMG;
        print("health =" + BHP);

        

    }

    void Update()
    {
        if(BHP <= 0)
        {
            print ("Enemy dead");
        }
    }
}
