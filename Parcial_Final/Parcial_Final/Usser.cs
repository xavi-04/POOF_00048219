namespace Parcial_Final
{
    public class Usser
    {
        private int idUser;
        private string fullName;
        private string userName;
        private string password;
        private bool userType;
        
        public Usser()
        {
            fullName = "";
            userName = "";
            password = "";
            userType = false;
        }

        public Usser(Usser use)
        {
            idUser = -1;
            fullName = "";
            userName = "";
            password = "";
            userType = false;
        }

        public int IdUser
        {
            get => idUser;
            set => idUser = value;
        }
        

        public string FullName
        {
            get => fullName;
            set => fullName = value;
        }

        public string UserName
        {
            get => userName;
            set => userName = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public bool UserType
        {
            get => userType;
            set => userType = value;
        }
    }
}