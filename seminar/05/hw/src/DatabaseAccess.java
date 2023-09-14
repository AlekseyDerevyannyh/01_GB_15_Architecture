import java.util.Collection;

/**
 * Интерфейс Data Access Layer (DAC)
 */
interface DatabaseAccess {

    void addEntity(Entity entity);
    void removeEntity(Entity entity);
    Collection<Texture> getAllTextures();
    Collection<Model3D> getAllModels();
    void removeTexture(int id);
    void removeModel(int id);
}