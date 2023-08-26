package store;

public abstract class User {
    private static counter = 1000;
    protected int id;

    {
        id = ++counter;
    }
}
