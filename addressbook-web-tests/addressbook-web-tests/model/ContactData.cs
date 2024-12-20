

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        public ContactData(string firstname)
        {
            Firstname = firstname;
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
            if (Lastname.CompareTo(other.Lastname) == 0)
            {
                return Firstname.CompareTo(other.Firstname);
            }
            else
            {
                return Lastname.CompareTo(other.Lastname);
            }
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Nickname { get; set; }

    }
}
