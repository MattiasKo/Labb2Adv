using Labb2Adv.Models;
using System;
using System.Linq;

namespace Labb2Adv
{
    public class Program
    {
        static void Main(string[] args)
        {
            SkolaDbContext Context = new SkolaDbContext();
            Console.WriteLine("-----------Lärare som lär ut matte----------");
            var MatteLärare = Context.Lärare.
                Join(Context.Kurs,
                Lär => Lär.LärarId,
                Kur => Kur.LärId,
                (LäraNamn, KursNamn) => new
                {
                    LärNamn = LäraNamn.Name,
                    KurNamn = KursNamn.KursNamn
                }).Where(s=>s.KurNamn =="Matte").Distinct().ToList();

            foreach (var ML in MatteLärare)
            {
                Console.WriteLine("Lärare {0}, lär ut {1}", ML.LärNamn, ML.KurNamn);
            }
            Console.WriteLine("-----------Alla elever med sina lärare--------------");

            var ElevLärare = Context.Lärare.
                Join(Context.Kurs,
                Lär => Lär.LärarId,
                KurLär => KurLär.LärId,
                (Lär, KurLär) => new { Lär, KurLär }
                )
                .Join(Context.Student,
                StudKur => StudKur.KurLär.StudId,
                Stu => Stu.StudId,
                (StudKur, Stu) => new { StudKur, Stu }).Select(p => new
                {
                    LärNamn = p.StudKur.Lär.Name,
                    ElevNamn = p.Stu.StudName,
                }
                ).ToList();
            foreach (var item in ElevLärare)
            {
                Console.WriteLine("Lärare {0}, studerande {1}",item.LärNamn,item.ElevNamn);
            }

            Console.WriteLine("--------------contains programmering1-------------");

            var ContainPro = Context.Kurs.Select(k=>k.KursNamn).Contains("Programmering1");
            Console.WriteLine("Contains Programmering1 = "+ContainPro);



            Console.WriteLine("---Editera en kurs från programmering2 till OOP---");
            foreach(var NY in Context.Kurs.Where(k => k.KursNamn == "programmering2"))
            {
                NY.KursNamn = "OOP";
                
            }
            Context.SaveChanges();

            ContainPro = Context.Kurs.Select(k => k.KursNamn).Contains("programmering2");
            Console.WriteLine("Contains Programmering2 = " + ContainPro);



            Console.WriteLine("----------updatera en elevs lärare anas till reidar--------");


            foreach (var item in Context.Kurs.Where(a=>a.LärId==1).Where(b=>b.StudId==4))
            {
                item.LärId = 3;
                Console.WriteLine("Studerande = {0} har nu lärare {1}", item.StudId, item.LärId);
            }
            Context.SaveChanges();


            Console.ReadKey();
        }
    }
}
