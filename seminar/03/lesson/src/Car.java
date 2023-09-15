import java.awt.*;

public abstract class Car {

    //region Constructors

    public Car(String make, String model, Color color) {
        this.make = make;
        this.model = model;
        this.color = color;
    }


    //endregion

    //region Public Methods

    public abstract void movement();            // Движение
    public abstract void maintenance();         // Обслуживание
    public abstract boolean gearShifting();     // Переключение передач
    public abstract boolean switchHeadLights(); // Включение фар
    public abstract boolean switchWipers();     // Включение дворников
    //public abstract void sweeping();            // Подметать улицу

    public boolean switchFogLights() {
        fogLights = !fogLights;
        return fogLights;
    }

    protected void setWheelsCount(int wheelsCount) {
        this.wheelsCount = wheelsCount;
    }

    public int getWheelsCount() {
        return wheelsCount;
    }

    //endregion

    //region Private Fields

    private String make;                // Марка автомобиля
    private String model;               // Модель автомобиля
    private Color color;                // Цвет
    protected CarType type;             // Тип
    private int wheelsCount;            // Число колёс
    protected FuelType fuelType;        // Тип топлива
    private GearboxType gearboxType;    // Тип коробки передач
    private double engineCapacity;      // Объём двигателя
    private boolean fogLights = false;  // Состояние противотуманных фар

    //endregion



}
