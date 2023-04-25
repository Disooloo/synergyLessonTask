using System;

namespace synergyLessonTask2.Task4
{
    internal class InvalideDamageException : ArgumentException
    {
        public override string Message => _message;

        public int Damage { get; }
        private string _message = "Урон не может быть отрецательным";
        public InvalideDamageException(){}
        // ctor => TAB
        public InvalideDamageException(int damage) => Damage = damage;
        public InvalideDamageException(string message, int damabe)
        {
            _message = message;
            Damage = damabe;
        }
    }
}
