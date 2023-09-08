import java.awt.*;

/**
 * Машина уборщик
 */
public class Harvester extends Car implements Fueling, Wiping {

    private Refueling refueling;
    private Washing washing;

    public Harvester(String make, String model, Color color) {
        super(make, model, color);
        setWheelsCount(6);
    }

    public void setRefuelingStation(Refueling refueling) {
        this.refueling = refueling;
    }

    public void setCarWash(Washing washing) {
        this.washing = washing;
    }

    /**
     * Заправить автомобиль
     */
    @Override
    public void fuel() {
        if (refueling != null) {
            refueling.fuel(fuelType);
        }
    }

    @Override
    public void movement() {

    }

    @Override
    public void maintenance() {

    }

    @Override
    public boolean gearShifting() {
        return false;
    }

    @Override
    public boolean switchHeadLights() {
        return false;
    }

    @Override
    public boolean switchWipers() {
        return false;
    }

    public void sweeping() {
        System.out.println("Автомобиль метёт улицу.");
    }

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
