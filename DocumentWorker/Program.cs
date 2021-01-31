using System;

namespace DocumentWorker
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт!");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про!");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про!");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован!");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string key;
            int start;
            int comand;
            Console.WriteLine("Выберете действие: "); 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 ---> Ввести ключ");
            Console.WriteLine("2 ---> Войти без ключа");
            Console.ForegroundColor =  ConsoleColor.White;
            Console.Write("--->"); int.TryParse(Console.ReadLine(), out start);
            if (start == 1)
            {
                Console.WriteLine("Введите ключ: "); key = Console.ReadLine();
                if (key == "pro")
                {
                    ProDocumentWorker document = new ProDocumentWorker();
                    Console.WriteLine("Пожалуйста введите команду для работы с документом: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1 ---> Открыть документ");
                    Console.WriteLine("2 ---> Редактировать документ");
                    Console.WriteLine("3 ---> Сохранить документ");
                    Console.ForegroundColor =  ConsoleColor.White;
                    Console.Write("--->"); int.TryParse(Console.ReadLine(), out comand);
                    if (comand == 1)
                    {
                        document.OpenDocument();
                        Console.WriteLine("Для продолжения введите команду: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("2 ---> Редактировать документ");
                        Console.WriteLine("3 ---> Сохранить документ");
                        Console.ForegroundColor =  ConsoleColor.White;
                        Console.Write("--->"); int.TryParse(Console.ReadLine(), out comand);
                    }
                    if (comand == 2)
                    {
                        document.EditDocument();
                        Console.WriteLine("Для продолжения введите команду: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("3 ---> Сохранить документ");
                        Console.ForegroundColor =  ConsoleColor.White;
                        Console.Write("--->"); int.TryParse(Console.ReadLine(), out comand);
                    }
                    if (comand == 3)
                    {
                        document.SaveDocument();
                    }
                }
                else if (key == "exp")
                {
                    ExpertDocumentWorker document = new ExpertDocumentWorker();
                    Console.WriteLine("Пожалуйста введите команду для работы с документом: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1 ---> Открыть документ");
                    Console.WriteLine("2 ---> Редактировать документ");
                    Console.WriteLine("3 ---> Сохранить документ");
                    Console.ForegroundColor =  ConsoleColor.White;
                    Console.Write("--->"); int.TryParse(Console.ReadLine(), out comand);
                    if (comand == 1)
                    {
                        document.OpenDocument();
                        Console.WriteLine("Для продолжения введите команду: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("2 ---> Редактировать документ");
                        Console.WriteLine("3 ---> Сохранить документ");
                        Console.ForegroundColor =  ConsoleColor.White;
                        Console.Write("--->"); int.TryParse(Console.ReadLine(), out comand);
                    }
                    if (comand == 2)
                    {
                        document.EditDocument();
                        Console.WriteLine("Для продолжения введите команду: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("3 ---> Сохранить документ");
                        Console.ForegroundColor =  ConsoleColor.White;
                        Console.Write("--->"); int.TryParse(Console.ReadLine(), out comand);
                    }
                    if (comand == 3)
                    {
                    document.SaveDocument();
                    }
                }  
            }
            else 
            {
                DocumentWorker document = new DocumentWorker();
                Console.WriteLine("Пожалуйста введите команду для работы с документом: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1 ---> Открыть документ");
                Console.WriteLine("2 ---> Редактировать документ");
                Console.WriteLine("3 ---> Сохранить документ");
                Console.ForegroundColor =  ConsoleColor.White;
                Console.Write("--->"); int.TryParse(Console.ReadLine(), out comand);
                if (comand == 1)
                {
                    document.OpenDocument();
                    Console.WriteLine("Для продолжения введите команду: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("2 ---> Редактировать документ");
                    Console.WriteLine("3 ---> Сохранить документ");
                    Console.ForegroundColor =  ConsoleColor.White;
                    Console.Write("--->"); int.TryParse(Console.ReadLine(), out comand);
                }
                if (comand == 2)
                {
                    document.EditDocument();
                    Console.WriteLine("Для продолжения введите команду: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("3 ---> Сохранить документ");
                    Console.ForegroundColor =  ConsoleColor.White;
                    Console.Write("--->"); int.TryParse(Console.ReadLine(), out comand);
                }
                if (comand == 3)
                {
                    document.SaveDocument();
                }
            }
        }
    }
}
