public class CarWash implements Washing {

    @Override
    public void wipMirrors() {
        System.out.println("Мойка зеркал");
    }

    @Override
    public void wipWindshield() {
        System.out.println("Мойка лобового стекла");
    }

    @Override
    public void wipHeadlights() {
        System.out.println("Мойка фар");

    }
}
