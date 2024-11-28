using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InspectorLib
{
    public class FunctionInsp
    {
        // Название автоинспекции
        private const string name = "Автоинспекция г. Чита";
        // Главный инспектор
        private string Inspector = "Васильев Василий Иванович";
        // Список сотрудников
        private readonly List<string> workers;

        // Конструктор класса
        public FunctionInsp()
        {
            workers = new List<string>
            {
                "Иванов И.И.",
                "Зиронов Т.А.",
                "Миронов А.В.",
                "Васильев В.И."
            };
        }

        // Возвращает ФИО главного инспектора
        public string GetInspector() => Inspector;

        // Возвращает название автоинспекции
        public string GetCarInspection() => name;

        // Устанавливает новое ФИО главного инспектора
        public bool SetInspector(string fullname)
        {
            if (IsWorker(fullname))
            {
                Inspector = fullname;
                return true;
            }
            return false; // ФИО не найдено в списке сотрудников
        }

        // Генерирует госномер
        public (bool Success, string Number) GenerateNumber(string number, char symbol, string code)
        {
            if (!ValidateSymbol(symbol))
            {
                return (false, "Символ должен быть в верхнем регистре.");
            }
            return (true, $"{symbol}{number}_{code}");
        }

        // Возвращает список сотрудников
        public List<string> GetWorkers() => new List<string>(workers);

        // Добавляет нового сотрудника
        public bool AddWorker(string fullname)
        {
            if (!IsWorker(fullname))
            {
                workers.Add(fullname);
                return true;
            }
            return false; // Сотрудник уже существует
        }

        // Проверяет, является ли ФИО сотрудником
        private bool IsWorker(string fullname) => workers.Contains(fullname);

        // Проверяет, является ли символ заглавным
        private bool ValidateSymbol(char symbol) => char.IsUpper(symbol);
    }
}
