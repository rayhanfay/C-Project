using System;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rayhan Al Farassy's Adventure Game");
            Console.WriteLine("Siapa namamu?");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hai! "+player.Name+", apakah kamu siap bermain [y/n]");
            String Ready = Console.ReadLine();
            if(Ready=="y"){
                Console.WriteLine(player.Name+" memasuki permainan...");
                Enemy enemy1 = new Enemy("Karambit");
                Console.WriteLine(player.Name+ " is encountering "+enemy1.Name);
                Console.WriteLine(enemy1.Name+" attacking you...");
                Console.WriteLine("Pilih tindakanmu");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Skill Attack");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Run Away");

                while (!player.IsDead && !enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction){
                        case "1" :
                        Console.WriteLine(player.Name+" is doing Single Attack");
                        enemy1.GetHit(player.AttackPower);
                        player.Experience += 0.3f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.Write("Player Health : "+player.Health+"  | Enemy Health : "+enemy1.Health+"\n");
                        break;
                        case "2" :
                        player.Swing();
                        player.Experience += 0.9f;
                        enemy1.GetHit(player.AttackPower);
                        Console.Write("Player Health : "+player.Health+"  | Enemy Health : "+enemy1.Health+"\n");
                        break;
                        case "3" :
                        player.Rest();
                        Console.WriteLine("Energy is being restored...");
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        break;
                        case "4" :
                        Console.WriteLine(player.Name+" is running away...");
                        break;
                    }
                }
                Console.WriteLine(player.Name+" get "+player.Experience+" Experience point.");
            
            }else{
                Console.WriteLine("Permainan dibatalkan. Goodbye...");
                Console.ReadLine();
            }
        }
    }
    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();

        public Novice(){
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
        }

        public void Swing(){
            if(SkillSlot >0){
                Console.WriteLine("Skill Attack!!!!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SkillSlot--;
            }else{
                Console.WriteLine("Kamu tidak memiliki energy!");
            }
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Rest(){
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die(){
            Console.WriteLine("Kamu meninggal. Game Selesai...");
            IsDead = true;
        }
    }
    class Enemy
    {
        public string Name{ get; set; } 
        public int Health{ get; set; } 
        public int AttackPower{ get; set; } 
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name){
            Health = 50;
            Name = name;
        }

        public void Attack(int damage){
            AttackPower= rnd.Next(1,20);
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" Get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }
        
        public void Die(){
            Console.WriteLine(Name +" telah mati");
            IsDead = true;
        }
    }
}

