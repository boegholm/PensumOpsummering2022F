namespace Eksamen
{
    class P
    {
        List<Figur> Figurs = new List<Figur>();
        void foo()
        {
            Figur t = new Trekant(1,2,5,5);
            Firkant f = new Firkant(3, 3, 4, 4);
            Figurs.Add(t);
            Figurs.Add(f);
        }

        void Draw()
        {
            foreach(Figur v in Figurs)
            {
                v.Draw();
            }
        }
    }





    public class User
    {
        private string name;
        private string email;

        public int Id { get; set; }
        public string Navn
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException($"{nameof(Navn)} cannot be null");
                if (value.Length == 0)
                    throw new ArgumentException(nameof(Navn)+ " cannot have length 0");
                if (!char.IsUpper(value[0]))
                    throw new ArgumentException(nameof(Navn) + " must start with capital letter");
                name = value;
            }
        }

        public string Email
        {
            get { 
                return email; 
            }
            set
            {
                if(value == null)
                    throw new EmailValidationException(nameof(Email));
                if (value.Length == 0)
                    throw new EmailValidationException(nameof(Email) + " cannot be zero length");

                string[] parts = value.Split('@');
                if (parts.Length != 2)
                    throw new EmailValidationException(nameof(Email));
                
                var local = parts[0];
                var domain = parts[1];
                if (!ValidatePart(local, '-', '.','_'))
                    throw new EmailValidationException();
                if (!ValidatePart(domain, '-', '.'))
                    throw new EmailValidationException();

                if (domain.Count(v => v == '.') < 1)
                    throw new EmailValidationException();

                if(new[] { '.', '-' }.Any(domain.Contains))
                    throw new EmailValidationException();
                email = value;
            }
        }

        private bool ValidatePart(string s, params char[] extra)
        {
            return s.All(v => char.IsLetterOrDigit(v) || extra.Contains(v));
        }

        public int Balance { get; set; }
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;
    }

}
