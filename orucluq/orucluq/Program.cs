using System;
using orucluq.Models;
namespace orucluq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Status stat1 = new Status("Qablar", "Qab-qacaq — məişətdə, əsasən də mətbəxdə yemək hazırlığı, ərzağın saxlanmsı və emalı üçün işlədilən əşyaların ümumi adı. Qab-qacaq aşağıdakı kateqoriyalara bölünür:");
            //Status stat2 = new Status("Telefon", "Telefonun ikinci dəfə  isə XX əsrin 80-ci illərində simsiz rabitə sisteminin tətbiqi nəticəsində baş verdi. Mobil telefonun ixtirası mühəndis Martin Kuperin adı ilə bağlıdır.");
            //Status stat3 = new Status("Masin", "wdefefeeeeeeeeeeeeeeefffffffffffffffffffffffeeeeeeeeeeeeeeeeeeeeeeeee");
            User user = new User("ferid");
            int Choice;
            do
            {
                Console.WriteLine("===========Menu===========");
                Console.WriteLine("1. Share status\n2. Get all statuses\n3. Get status by id\n4. Filter status by date\n0. Quit");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Basliq yazin:");
                            string title = Console.ReadLine();
                            Console.WriteLine("Content yazin:");
                            string content = Console.ReadLine();
                            Status stat = new Status(title, content);
                            user.ShareStatus(stat);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:

                        try
                        {
                            foreach (var item in user.GetAllStatuses())
                            {
                                item.GetStatusInfo();
                                Console.WriteLine("=======================");
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("id Gonderin");
                            int id = Convert.ToInt32(Console.ReadLine());
                            user.GetStatusById(id).GetStatusInfo();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("id girin");
                            int id0 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("il yazin:");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ay yazin");
                            int month = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("gun yazin");
                            int day = Convert.ToInt32(Console.ReadLine());

                            DateTime date = new DateTime(year, month, day, 00, 00, 00);
                            foreach (var item in user.FilterStatusByDate(id0, date))
                            {
                                item.GetStatusInfo();
                                Console.WriteLine("===========");
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        break;

                    default:
                        break;
                }

            } while (Choice!=0);

        }
    }
}
