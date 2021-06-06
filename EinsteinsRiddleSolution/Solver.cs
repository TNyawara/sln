using System;
using EinsteinsRiddleSolution;


namespace EinsteinsRiddleSolution
{
    public class Solver
    {
        private void InitPossibilities()
        {
            
        } 
        private program.HouseColor[] houses;
        private int[][] five_possibilities;
    
    {
        this.InitPossibilities();

        // create five houses
        this.houses = new program.HouseColor[5];
        for (int i = 0; i < this.houses.Length; i++)
            this.houses[i] = new program.HouseColor()();

     
        this.houses[2].Drinks = program.Drinks.Water;

       
        this.houses[0].Nationalities = program.Nationalities.Norwegian;

       
        this.houses[1].HouseColor = program.HouseColor.Yellow;
    }

 

    public void Solution1()
    {
        // iterate colors
        for (int l = 0; l < this.five_possibilities.Length; l++)
        
            int[] poss1 = this.five_possibilities[l];
            this.houses[poss1[0]].HouseColor = program.HouseColor.Blue;
            this.houses[poss1[1]].HouseColor = program.HouseColor.Green;
            this.houses[poss1[2]].HouseColor = program.HouseColor.Red;
            this.houses[poss1[3]].HouseColor = program.HouseColor.White;
            this.houses[poss1[4]].HouseColor = program.HouseColor.Yellow;
        
        
        // iterate nations
        for (int m = 0; m < this.five_possibilities.Length; m++)
        {
            int[] poss2 = this.five_possibilities[m];
            this.houses[poss2[0]].Nationalities = program.Nationalities.Brit;
            this.houses[poss2[0]].Nationalities = program.Nationalities.Dane;
            this.houses[poss2[0]].Nationalities = program.Nationalities.German;
            this.houses[poss2[0]].Nationalities = program.Nationalities.Norwegian;
            this.houses[poss2[0]].Nationalities = program.Nationalities.Swede;
            
            // iterate drinks
            for (int k = 0; k < this.five_possibilities.Length; k++)
            {
                int[] poss3 = this.five_possibilities[k];
                this.houses[poss3[0]].Drinks = program.Drinks.Beer;
                this.houses[poss3[1]].Drinks = program.Drinks.Coffee;
                this.houses[poss3[2]].Drinks= program.Drinks.Milk;
                this.houses[poss3[3]].Drinks= program.Drinks.Tea;
                this.houses[poss3[4]].Drinks= program.Drinks.Water;
            
        // iterate cigarettes
        for (int i = 0; i < this.five_possibilities.Length; i++)
        {
            int[] poss4= this.five_possibilities[i];
            this.houses[poss4[0]].Cigarettes= program.Cigarettes.Blends;
            this.houses[poss4[1]].Cigarettes= program.Cigarettes.BlueMaster;
            this.houses[poss4[2]].Cigarettes= program.Cigarettes.Dunhill;
            this.houses[poss4[3]].Cigarettes = program.Cigarettes.PallMall;
            this.houses[poss4[4]].Cigarettes = program.Cigarettes.Prince;

            // iterate pets
            for (int j = 0; j < this.five_possibilities.Length; j++)
            {
                int[] poss5 = this.five_possibilities[j];
                this.houses[poss5[0]].Pets = program.Pets.Birds;
                this.houses[poss5[1]].Pets = program.Pets.Cats;
                this.houses[poss5[2]].Pets = program.Pets.Dogs;
                this.houses[poss5[3]].Pets = program.Pets.Horses;
                this.houses[poss5[4]].Pets= program.Pets.Fish;

                // The Brit Lives in the red house
                            if (!this.hint1_Verify())
                                continue;

                            //The Swede keeps Dogs as pets
                            if (!this.hint2_Verify())
                                continue;

                            // The Dane drinks Tea
                            if (!this.hint3_Verify())
                                continue;

                            // THe green house is exactly to the left of the white house
                            if (!this.hint4_Verify())
                                continue;

                           //The owner of the Green house drinks Coffee.
                            if (!this.hint5_Verify())
                                continue;

                            // The person who smokes Pall Mall rears Birds.
                            if (!this.hint6_Verify())
                                continue;

                            // The owner of the Yellow house smokes Dunhill."
                         

                            // The man living in the centre house drinks Milk.
                            if (!this.hint8_Verify())
                                continue;

                            // The Norwegian lives in the first house.
                       

                            // The man who smokes Blends lives next to the one who keeps Cats.
                            if (!this.hint10_Verify())
                                continue;

                            //The man who keeps Horses lives next to the man who smokes Dunhill.
                            if (!this.hint11_Verify())
                                continue;

                            // The man who smokes Blue Master drinks Beer.
                            if (!this.hint12_Verify())
                                continue;

                            // The German smokes Prince.

                            // The Norwegian lives next to the Blue house.
                            if (!this.hint14_Verify())
                                continue;

                            // The man who smokes Blends has a neighbour who drinks Water.
                            if (!this.hint15_Verify())
                                continue;

                            // print solution
                            this.PrintSolution();
                        }
                    }
                }
            }
        }
    }

   
    // The Brit Lives in the red house
    private bool hint1_Verify()
    {
        bool hint= false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Nationalities== program.Nationalities.Brit)
            {
                if (this.houses[i].HouseColor == program.HouseColor.Red)
                {
                    hint = true;
                }
                break;
            }
        }
        return hint;
    }

    //The Swede keeps Dogs as pets
    private bool hint2_Verify()
    {
        bool hint= false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Nationalities == program.Nationalities.Swede)
            {
                if (this.houses[i].Pets == program.Pets.Dogs)
                {
                    hint = true;
                } 
                break;
            }
        }
        return hint;
    }

    //The Dane drinks Tea.
    private bool hint3_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Nationalities == program.Nationalities.Dane)
            {
                if (this.houses[i].Drinks == program.Drinks.Tea)
                {
                    hint = true;
                }
                break;
            }
        }
        return hint;
    }

  //The Green house is exactly to the left of the White house
    private bool hint4_Verify()
    {
        if ((this.houses[2].HouseColor == program.HouseColor.Green &&
                this.houses[3].HouseColor == program.HouseColor.White) ||
                (this.houses[3].HouseColor == program.HouseColor.Green &&
                this.houses[4].HouseColor == program.HouseColor.White))
        {
            return true;
        }
        else
            return false;
    }

    //The owner of the Green house drinks Coffee.
    private bool hint5_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].HouseColor == program.HouseColor.Green)
            {
                if (this.houses[i].Drink == program.Drinks.Coffee)
                {
                    hint = true;
                }
                break;
            }
        }
        return hint;
    }

    //The person who smokes Pall Mall rears Birds.
    private bool hint6_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Cigarettes == program.Cigarettes.PallMall)
            {
                if (this.houses[i].Pets == program.Pets.Bird)
                {
                    hint = true;
                }
                break;
            }
        }

        return hint;
    }

  

    //he owner of the Yellow house smokes Dunhill.
    private bool hint8_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].HouseColor == program.HouseColor.Yellow)
            {
                if (this.houses[i].Cigarette == program.Cigarettes.Dunhill)
                {
                    hint = true;
                }
                break;
            }
        }
        return hint;
    }
    // The man who smokes Blends lives next to the one who keeps Cats.
    private bool hint10_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Cigarettes == program.Cigarettes.Blends)
            {
                if (i == 0)
                {
                    if (this.houses[1].Pets == program.Pets.Cats)
                        hint = true;
                }
                else if (i == 4)
                {
                    if (this.houses[3].Pets == program.Pets.Cats)
                        hint= true;
                }
                else if (this.houses[i - 1].Pets == program.Pets.Cats ||
                    this.houses[i + 1].Pets== program.Pets.Cats)
                    hint = true;

                break;
            }
        }

        return hint;
    }

    // The man who keeps Horses lives next to the man who smokes Dunhill.
    private bool hint11_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Pets == program.Pets.Horses)
            {
                if (i == 0)
                {
                    if (this.houses[1].Cigarettes == program.Cigarettes.Dunhill)
                        hint = true;
                }
                else if (i == 4)
                {
                    if (this.houses[3].Cigarettes == program.Cigarettes.Dunhill)
                        hint = true;
                }
                else if (this.houses[i - 1].Cigarettes == program.Cigarettes.Dunhill ||
                            this.houses[i + 1].Cigarettes == program.Cigarettes.Dunhill)
                        hint = true;
            
                break;
            }
        }
        return hint;
    }

    // The man who smokes Blue Master drinks Beer.
    private bool hint12_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Cigarettes == program.Cigarettes.BlueMaster)
            {
                if (this.houses[i].Drinks == program.Drinks.Beer)
                    hint= true;

                break;
            }
        }
        return hint;
    }


    // The German smokes Prince.
    private bool hint14_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Nationalities == program.Nationalities.German)
            {
                if (this.houses[i].Cigarettes == program.Cigarettes.Prince)
                    hint= true;

                break;
            }
        }
        return hint;
    }

//The man who smokes Blends has a neighbour who drinks Water.
    private bool hint15_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Cigarettes== program.Cigarettes.Blends)
            {
                if (i == 0)
                {
                    if (this.houses[1].Drinks == program.Drinks.Water)
                        hint = true;
                }
                else if (i == 4)
                {
                    if (this.houses[3].Drinks == program.Drinks.Water)
                        hint = true;
                }
                else if (this.houses[i - 1].Drinks == program.Drinks.Water ||
                    this.houses[i + 1].Drinks == program.Drinks.Water)
                        hint = true;

                break;
            }
        }
        return hint;
    }

    string PrintSolution(int result)
    {
        string print;
            if (result == 0)
            {
                print = "\nFailed";
            }
            else if (result == 14)
            {
                print = "\nPassed";
            }
            else
            {
                print = "\nFair";
            }
            return print;
        }
    }
    