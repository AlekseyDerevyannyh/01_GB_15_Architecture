public class Singleton {
    private static Singleton uniqueInstance;    // статическая переменная для хранения единственного экземпляра

    private Singleton() {   // приватный конструктор; только Singleton может создавать экземпляры этого класса
    }

    public static Singleton getInstance() {     // метод создаёт и возвращает экземпляр
        if (uniqueInstance == null) {           // если uniqueInstance содержит null, значит экземпляр ещё не создан
            uniqueInstance = new Singleton();   // создаём новый экземпляр Singleton приватным конструктором и присваиваем его uniqueInstance
            System.out.println("creating new Singleton");   // делаем вывод для наглядности
        }
        return uniqueInstance;      // к моменту выполнения этой команды экземпляр уже создан - возвращаем его
    }

    public void printSingleton() {  // вспомогательный метод вывода для наглядности работы паттерна
        System.out.println("print inside Singleton");
    }
}
