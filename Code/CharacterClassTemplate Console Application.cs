using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classesforgame
{
    class Program
    {
        static int Main(string[] args)
        {
            //Testing the functions that will be used for the game template
            Character npc = new Character(); //Create instance of object
            npc.CharacterEnterStore();
            Console.In.Read();
            npc.CharacterClicked();
            Console.In.Read();
            npc.CharacterMakeAnOpinion();
            Console.In.Read();
            npc.CharacterDisplayAnOpinion();
            Console.In.Read();
            npc.CharacterLeaveStore();
            Console.In.Read();

            return 0;
        }
    }
    class Character
    {
        //These will have getters and setters
        private int CharacterId;

        private bool CharacterIsMale;
        private string CharacterName;
        private int CharacterAge;
        private int CharacterWealth;
        private int CharacterIQ;
        private int CharacterHumour;
        private string CharacterEmotionalState;



        //Graphics?
        //Partical effects? 
        //Position and Scale



        public Character()
        {
            CharacterId = 1; //This will be Generated by the factory class
            CharacterIsMale = true;
            CharacterName = "Harry"; //Will be selected from an array of names based on gender of charactrer
            CharacterWealth = 100; //Generated by a random algorithm the higher the number the more they pay you for your products
            CharacterIQ = 100; //Generated by a random algorithm the higher the number the more Inteligent they are
            CharacterHumour = 100;
            CharacterEmotionalState = "Happy";

            Console.Out.WriteLine("ID is: " + CharacterId + " Name is: " + CharacterName); Console.Read();
        }

        public void CharacterEnterStore()
        {
            try
            {
                Console.Out.WriteLine("I am now in the store being displayed");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.StackTrace);
            }
        }

        public void CharacterClicked()
        {
            try
            {
                Console.Out.WriteLine("This is me Responding to a click");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.StackTrace);
            }
        }

        public void CharacterMakeAnOpinion()
        {
            try
            {
                Console.Out.WriteLine("Ive made an Opinion but I wont say it yet");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.StackTrace);
            }
        }

        public void CharacterDisplayAnOpinion()
        {
            try
            {
                Console.Out.WriteLine("Here is my Opinion for testing purposes I am happy");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.StackTrace);
            }
        }

        public void CharacterLeaveStore()
        {
            try
            {
                Console.Out.WriteLine("Goodbye I am leaving now. In the real game at this point if my Rating of store falls to 0 I don't come back");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.StackTrace);
            }
        }

        //When Character is destoryed run this
        ~Character()
        {
            Console.Out.Write(CharacterName + " had bad expirences at your shop and is not coming back..."); // say this when the character has despawned and there don't like the shop support varrible is 0 or less
            Console.In.Read();
        }
    };
}
