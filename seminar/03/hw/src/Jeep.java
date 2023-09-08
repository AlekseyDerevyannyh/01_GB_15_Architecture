import java.awt.*;

/**
 * Джип
 */
public class Jeep extends Car implements Fueling, Wiping {

    private Refueling refueling;
    private Washing washing;

    public Jeep(String make, String model, Color color) {
        super(make, model, color);
        setWheelsCount(4);
        fuelType=FuelType.Diesel;
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
