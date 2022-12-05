namespace final_project.src.main.online_shop
{
    public class User
    {
        public string userName;
        public string password;
        public int currentBalance;
        public User(string userName, string password, int currentBalance)
        {
            this.userName = userName;
            this.password = password;
            this.currentBalance = currentBalance;
        }
        public void setUserName(string userName)
        {
            this.userName = userName;
        }
        public void increaseCurrentBalance(int newBalance)
        {
            currentBalance += newBalance;
        }
        public int decreaseCurrentBalance(int newBalance)
        {
            if (currentBalance - newBalance >= 0)
            {
                currentBalance -= newBalance;
            }
            else
            {
                Console.WriteLine("Oh...Your Balance will be negative!!!");
                return 1;
            }
            return 0;
        }
        public int getCurrentBalance()
        {
            return currentBalance;
        }
    }
}