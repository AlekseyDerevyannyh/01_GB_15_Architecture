import java.util.ArrayList;
import java.util.Collection;

/**
 * 3D модель
 */
class Model3D implements Entity {

    private static int counter = 10000;
    private final int id;
    private Collection<Texture> textures = new ArrayList<>();

    {
        id = ++counter;
    }

    @Override
    public int getId() {
        return id;
    }

    public Model3D() {

    }

    public Model3D(Collection<Texture> textures) {
        this.textures = textures;
    }

    public Collection<Texture> getTextures() {
        return textures;
    }

    @Override
    public String toString() {
        return String.format("3DModel #%s", id);
    }

    public void removeTexture(Texture texture) {
        textures.remove(texture);
    }
}