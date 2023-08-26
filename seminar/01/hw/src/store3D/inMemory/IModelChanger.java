package store3D.inMemory;

public interface IModelChanger {

    /**
     * Произошло изменение в хранилище моделей
     */
    void notifyChange();

    void registerModelChanger(IModelChangedObserver o);

    void removeModelChanger(IModelChangedObserver o);
}
