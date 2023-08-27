package store3D.inMemory;

import store3D.models.Camera;
import store3D.models.Flash;
import store3D.models.PoligonalModel;
import store3D.models.Scene;

import java.util.ArrayList;
import java.util.List;

public class ModelStore implements IModelChanger {
    private List<IModelChangedObserver> observers = new ArrayList<>();

    private List<PoligonalModel> models = new ArrayList<>();
    private List<Flash> flashes = new ArrayList<>();
    private List<Scene> scenes = new ArrayList<>();
    private List<Camera> cameras = new ArrayList<>();

    public ModelStore(List<PoligonalModel> models, List<Flash> flashes, List<Scene> scenes, List<Camera> cameras) {
        this.models = models;
        this.flashes = flashes;
        this.scenes = scenes;
        this.cameras = cameras;
    }

    public void add(PoligonalModel model) {
        models.add(model);
        notifyChange();
    }

    public Scene getScene(int id) {
        for (Scene scene : this.scenes) {
            if (scene.getId() == id) {
                return scene;
            }
        }
        return null;
    }

    @Override
    public void notifyChange() {
        for (IModelChangedObserver observer : observers) {
            observer.applyUpdateModel();
        }
    }

    @Override
    public void registerModelChanger(IModelChangedObserver o) {
        observers.add(o);
    }

    @Override
    public void removeModelChanger(IModelChangedObserver o) {
        observers.remove(o);
    }
}
