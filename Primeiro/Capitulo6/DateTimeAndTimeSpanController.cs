using System;
using System.Globalization;
using Primeiro.Entities;

namespace Primeiro.Capitulo6
{
    class DateTimeAndTimeSpanController : LoadController
    {
        public override void Rodar()
        {
            // construtores
            {
                DateTime d1 = new DateTime(2000, 8, 15);
                DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
                DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                Console.WriteLine(d3);
            }

            // Demo - Now, UtcNow, Today
            {
                DateTime d1 = DateTime.Now;
                DateTime d2 = DateTime.UtcNow;
                DateTime d3 = DateTime.Today;
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                Console.WriteLine(d3);
            }

            // Demo - Parse
            {
                DateTime d1 = DateTime.Parse("2000-08-15");
                DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
                DateTime d3 = DateTime.Parse("15/08/2000");
                DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                Console.WriteLine(d3);
                Console.WriteLine(d4);
            }

            // Demo - ParseExact
            {
                DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
                CultureInfo.InvariantCulture);
                DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
                CultureInfo.InvariantCulture);
                Console.WriteLine(d1);
                Console.WriteLine(d2);
            }

            // Demo - construtores
            {
                TimeSpan t1 = new TimeSpan();
                TimeSpan t2 = new TimeSpan(900000000L);
                TimeSpan t3 = new TimeSpan(2, 11, 21);
                TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
                TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
                Console.WriteLine(t1);
                Console.WriteLine(t2);
                Console.WriteLine(t3);
                Console.WriteLine(t4);
                Console.WriteLine(t5);
            }

            // Demo - métodos From
            {
                TimeSpan t1 = TimeSpan.FromDays(1.5);
                TimeSpan t2 = TimeSpan.FromHours(1.5);
                TimeSpan t3 = TimeSpan.FromMinutes(1.5);
                TimeSpan t4 = TimeSpan.FromSeconds(1.5);
                TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
                TimeSpan t6 = TimeSpan.FromTicks(900000000L);
                Console.WriteLine(t1);
                Console.WriteLine(t2);
                Console.WriteLine(t3);
                Console.WriteLine(t4);
                Console.WriteLine(t5);
                Console.WriteLine(t6);
            }

            // Propriedades e Operações com DateTime
            // Propriedades
            {
                DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
                Console.WriteLine(d);
                Console.WriteLine("1) Date: " + d.Date);
                Console.WriteLine("2) Day: " + d.Day);
                Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
                Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
                Console.WriteLine("5) Hour: " + d.Hour);
                Console.WriteLine("6) Kind: " + d.Kind);
                Console.WriteLine("7) Millisecond: " + d.Millisecond);
                Console.WriteLine("8) Minute: " + d.Minute);
                Console.WriteLine("9) Month: " + d.Month);
                Console.WriteLine("10) Second: " + d.Second);
                Console.WriteLine("11) Ticks: " + d.Ticks);
                Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
                Console.WriteLine("13) Year: " + d.Year);
            }

            // Formatação
            {
                DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
                string s1 = d.ToLongDateString();
                string s2 = d.ToLongTimeString();
                string s3 = d.ToShortDateString();
                string s4 = d.ToShortTimeString();
                string s5 = d.ToString();
                string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
                string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                Console.WriteLine(s3);
                Console.WriteLine(s4);
                Console.WriteLine(s5);
                Console.WriteLine(s6);
                Console.WriteLine(s7);
            }

            /* Operacoes com Date time
            {
                DateTime x = ...
                DateTime y = x.Add(timeSpan);
                DateTime y = x.AddDays(double);
                DateTime y = x.AddHours(double);
                DateTime y = x.AddMilliseconds(double);
                DateTime y = x.AddMinutes(double);
                DateTime y = x.AddMonths(int);
                DateTime y = x.AddSeconds(double);
                DateTime y = x.AddTicks(long);
                DateTime y = x.AddYears(int);
                DateTime y = x.Subtract(timeSpan);
                TimeSpan t = x.Subtract(dateTime);
            } */

            // TimeSpan Property
            {
                TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
                Console.WriteLine(t);
                Console.WriteLine("Days: " + t.Days);
                Console.WriteLine("Hours: " + t.Hours);
                Console.WriteLine("Minutes: " + t.Minutes);
                Console.WriteLine("Milliseconds: " + t.Milliseconds);
                Console.WriteLine("Seconds: " + t.Seconds);
                Console.WriteLine("Ticks: " + t.Ticks);
                Console.WriteLine("TotalDays: " + t.TotalDays);
                Console.WriteLine("TotalHours: " + t.TotalHours);
                Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
                Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
                Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            }

            // TimeSpan Operacoes
            {
                TimeSpan t1 = new TimeSpan(1, 30, 10);
                TimeSpan t2 = new TimeSpan(0, 10, 5);
                TimeSpan sum = t1.Add(t2);
                TimeSpan dif = t1.Subtract(t2);
                TimeSpan mult = t2.Multiply(2.0);
                TimeSpan div = t2.Divide(2.0);
                Console.WriteLine(t1);
                Console.WriteLine(t2);
                Console.WriteLine(sum);
                Console.WriteLine(dif);
                Console.WriteLine(mult);
                Console.WriteLine(div);
            }

            // DateTimeKind
            {
                DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
                DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
                DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
                Console.WriteLine("d1: " + d1);
                Console.WriteLine("d1 Kind: " + d1.Kind);
                Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
                Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
                Console.WriteLine();
                Console.WriteLine("d2: " + d2);
                Console.WriteLine("d2 Kind: " + d2.Kind);
                Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
                Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
                Console.WriteLine();
                Console.WriteLine("d3: " + d3);
                Console.WriteLine("d3 Kind: " + d3.Kind);
                Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
                Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            }

            // DateTimeKind - ISO8601
            {
                DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
                DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
                Console.WriteLine("d1: " + d1);
                Console.WriteLine("d1 Kind: " + d1.Kind);
                Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
                Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
                Console.WriteLine();
                Console.WriteLine("d2: " + d2);
                Console.WriteLine("d2 Kind: " + d2.Kind);
                Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
                Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
                Console.WriteLine();
                // Perigoso converter uma data desta forma pois ela pode estar em formato local e a conversao não estará correta como neste exemplo
                Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
                // O Ideal é garantir que a data esteja no horário universal e ai sim converter, como no exemplo abaixo.
                Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // Quando tem o Z no final quer dizer que a data foi armazenada no formato UTC
            }

        }
    }
}
