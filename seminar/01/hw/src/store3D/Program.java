package store3D;

import store3D.inMemory.ModelStore;
import store3D.inMemory.Observer1;
import store3D.models.*;

import java.awt.*;
import java.util.ArrayList;
import java.util.List;

public class Program {
    public static void main(String[] args) {

        Observer1 observer1 = new Observer1();

        Poligon p1 = new Poligon();
        List<Poligon> poligons1 = new ArrayList<>();
        poligons1.add(p1);
        PoligonalModel poligonalModel1 = new PoligonalModel(poligons1);


        Point3D location1 = new Point3D(0 , 0, 0);
        Angle3D angle1 = new Angle3D(0, 0, 0);
        Flash flash = new Flash(location1, angle1, new Color(0, 0,0), 10);

        Point3D location2 = new Point3D(10 , 10, 0);
        Angle3D angle2 = new Angle3D(20, 20, 0);

        Camera camera = new Camera(location2, angle2);
        List<Camera> cameras = new ArrayList<>();
        cameras.add(camera);

        List<PoligonalModel> poligonalModels = new ArrayList<>();
        poligonalModels.add(poligonalModel1);
        List<Flash> flashes = new ArrayList<>();
        flashes.add(flash);

        Scene scene = new Scene(poligonalModels, flashes, cameras);
        List<Scene> scenes = new ArrayList<>();
        scenes.add(scene);

        ModelStore store = new ModelStore(poligonalModels, flashes, scenes, cameras);
        store.registerModelChanger(observer1);

        Poligon p2 = new Poligon();
        List<Poligon> poligons2 = new ArrayList<>();
        poligons2.add(p2);
        PoligonalModel poligonalModel2 = new PoligonalModel(poligons2);

        store.add(poligonalModel2);
    }
}
