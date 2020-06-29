using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveSkills : MonoBehaviour
{
    // Start is called before the first frame update

   // [HideInInspector] public string[] passives;
    [HideInInspector] public int[] passivesNumber;

    private System.Action[] passivesFunctions = null;
    void Start()
    {
        passivesFunctions = new System.Action[9] { Passive_None, Passive_BonusRewardPoints, Passive_BonusRewardChance, Passive_SwordSpeed, Passive_DirectionalArrowLength, Passive_BladeLength, Passive_LowerGravity, Passive_CramblingWallsResistance, Passive_Magnet };

        //  passives = new string[9] { "", "BRP", "BRC", "SS", "DAL", "BL", "LG", "CWR", "M" };
        /*
         
         BRP = Bonus reward points :       Increases the value ammount of bonus rewards you catch
         More levels =                    More value ammount 
        
         BRC = Bonus reward chance :      Increases the chance of a bonus reward to come
         More levels =                    Increases the chance value

         SS = Sword speed:                Increases the speed that the sword is throw, making it reachs the other side of the screen faster
         More levels =                    Increases the speed value

         DAL = Directional arrow lenght:  Increases the directional arrow lenght, making it easier to aim
         More levels =                    Increases the arrow lenght

         BL = Blade lenght:               Increases the sword's blade lenght, making it more likely to hit a wall on it's edge
         More levels =                    Increases the blade lenght

         LG = Lower gravity:              Reduces the gavity, making the items and walls fall slower
         More levels =                    Reduces the gavtiy value

         CWR = Crambling wall resistance: Makes crambling walls last longer after being hit
         More levels =                    Lasts longer

         M = Magnet:                      Increases the gavity, making the items and walls fall faster, but you can still play, one more time, after throwing the sword off of a wall
         More levels =                    Reduces the gravity value
         
         
        */
        passivesNumber = new int[3] { 0, 0, 0 };



    }

    // Update is called once per frame
    void Update()
    {
        foreach (int x in passivesNumber)
        {
            for (int i = 0; i <= passivesFunctions.Length; i++)
            {
                if (x.Equals(i))
                {
                    passivesFunctions[i]();
                }

            }

        }


    }

    void Passive_BonusRewardPoints()
    {
    }
    void Passive_BonusRewardChance()
    {


    }
    void Passive_SwordSpeed()
    {


    }
    void Passive_DirectionalArrowLength()
    {

    }
    void Passive_BladeLength()
    {

    }
    void Passive_LowerGravity()
    {

    }
    void Passive_CramblingWallsResistance()
    {

    }
    void Passive_Magnet()
    {

    }
    void Passive_None()
    {

    }
}
