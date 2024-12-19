

using NUnit.Framework;
using System.Xml.Linq;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstname;
        private string middlename = "";
        private string lastname = "";
        private string nickname = "";


        public ContactData(string firstname)
        {
            this.firstname = firstname;
        }

        public bool Equals(ContactData other) //метод сравнения для объектов типа ContactData
        {
            if (object.ReferenceEquals(other, null))
            {
                return false; //текущий объект с которым сравниваем не мб равен null
            }
            if (object.ReferenceEquals(other, this))
            {
                return true; //текущий объект равен другому, две ссылки указывают на один и тот же объект
            }
            return (Lastname == other.Lastname) & (Firstname == other.Firstname); //сравнение геттеров, а не полей напрямую
        }

        public override int GetHashCode() //функция вычисляющая хэш-код для оптимизации сравнения списков
        {
            var ln = Lastname.GetHashCode();
            var fn = Firstname.GetHashCode();
            var sum = ln + fn;
            return sum;
        }

        public override string ToString() //метод возвращает строковое представление объектов типа ContactData
        {
            return "firstname =" + Firstname + " lastname =" + Lastname;
        }

        public int CompareTo(ContactData other) //метод сравнения элементов списка типа ContactData для сортировки
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1; //возвращает 1 - если текущий элемент больше, 0 - равны, -1 - текущий меньше другого
            }
            return Lastname.CompareTo(other.Lastname); //сравнение имен
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public string Middlename
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }
        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }
    }
}
