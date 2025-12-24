namespace oop
{
    public abstract class Person
    {
        public int Id { get; set; }
        private string _FullName { get; set; }
        public string FullName 
        { 
            get
            {
                return _FullName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _FullName = "No Name";
                }
                else
                {
                    _FullName = value;
                }
            }
        }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual string DisplayPersonInfo()
        {
            return $"Id : {Id} , FullName : {FullName} , Email : {Email} , PhoneNumber : {PhoneNumber}";
        }
    }
}
