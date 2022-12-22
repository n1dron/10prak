class Program
{
    static void Main(string[] args)
    {
        var arrUsers = new Users[]
        {
            new Users("admin","newpass",2605),
            new Users("kassir","newpass",15),
            new Users("manager","newpass",32),
            new Users("sklad","newpass",32),
            new Users("bux","newpass",32)
        };

    Start:
        Console.WriteLine("Для входа в систему нажмите 1, для регистрации 2");
        var input = Console.ReadLine();
        bool successfull = false;
        while (!successfull)
        {
            if (input == "1")
            {
                Console.WriteLine("Введите свой логин:");
                var username = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                var password = Console.ReadLine();


                foreach (Users user in arrUsers)
                {
                    if (username == user.username && password == user.password)
                    {
                        Console.WriteLine("Вы успешно вошли в систему!");
                        Console.ReadLine();
                        successfull = true;
                        break;
                    }
                }

                if (!successfull)
                {
                    Console.WriteLine("Ваш логин или пароль неверны, попробуйте еще раз!");
                }

            }

            else if (input == "2")
            {

                Console.WriteLine("Введите свой логин:");
                var username = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                var password = Console.ReadLine();

                Console.WriteLine("Введите ваш ID:");
                int id = int.Parse(Console.ReadLine());


                Array.Resize(ref arrUsers, arrUsers.Length + 1);
                arrUsers[arrUsers.Length - 1] = new Users(username, password, id);
                successfull = true;
                goto Start;

            }
            else
            {
                Console.WriteLine("Попробуй снова!");
                break;
            }
        }

    }
}

public class Users
{
    public string username;
    public string password;
    private int id;

    public Users(string username, string password, int id)
    {
        this.username = username;
        this.password = password;
        this.id = id;
    }
}