using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game2D
{
    class Save
    {
        public static void SaveTxtLines()
        {                       
            int[] saveToFile = { Character.Dmg, Character.Exp, Character.Hp, Character.MaxHp, Character.Money, Character.NextLvl };
            
            string fileName = @"C:\SavedGame\Save1.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(Menu.name);
                    for(int i=0; i<saveToFile.Length; i++)
                    {
                        writer.WriteLine(saveToFile[i]);
                    }
                    Console.WriteLine("Game saved");
                    
                }
            }
            catch(Exception exp)
            {
                Console.Write(exp.Message);
            }
        }
        public static void LoadTxt()
        {
            string fileName = @"C:\SavedGame\Save1.txt";
            try
            {
                using (StreamReader read = new StreamReader(fileName))
                {
                    Menu.name=read.ReadLine();
                    Character.Dmg = Convert.ToInt32(read.ReadLine());
                    Character.Exp= Convert.ToInt32(read.ReadLine());
                    Character.Hp= Convert.ToInt32(read.ReadLine());
                    Character.MaxHp = Convert.ToInt32(read.ReadLine());
                    Character.Money = Convert.ToInt32(read.ReadLine());
                    Character.NextLvl = Convert.ToInt32(read.ReadLine());
                    Console.WriteLine("Game loaded");

                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }        
        
    }
}
