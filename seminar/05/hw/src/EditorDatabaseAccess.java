import java.util.ArrayList;
import java.util.Collection;

/**
 * Реализация DAC
 */
class EditorDatabaseAccess implements DatabaseAccess {

    private final Database editorDatabase;

    public EditorDatabaseAccess(Database editorDatabase) {
        this.editorDatabase = editorDatabase;
    }

    @Override
    public Collection<Model3D> getAllModels() {
        Collection<Model3D> models = new ArrayList<>();
        for (Entity entity : editorDatabase.getAll()) {
            if (entity instanceof Model3D) {
                models.add((Model3D) entity);
            }
        }
        return models;
    }

    @Override
    public Collection<Texture> getAllTextures() {
        Collection<Texture> textures = new ArrayList<>();
        for (Entity entity : editorDatabase.getAll()) {
            if (entity instanceof Texture) {
                textures.add((Texture) entity);
            }
        }
        return textures;
    }

    @Override
    public void addEntity(Entity entity) {
        editorDatabase.getAll().add(entity);

    }

    @Override
    public void removeEntity(Entity entity) {
        editorDatabase.getAll().remove(entity);
    }

    @Override
    public void removeTexture(int id) {
        for (Entity entity : editorDatabase.getAll()) {
            if (entity instanceof Texture) {
                if (entity.getId() == id) {
                    removeEntity(entity);
                    removeTextureFromModel((Texture) entity);
                    System.out.printf("Текстура #%d удалена\n", id);
                    return;
                }
            }
        }
        throw new RuntimeException("Текстура с указанным id не найдена.");
    }

    private void removeTextureFromModel(Texture texture) {
        for (Entity entity : editorDatabase.getAll()) {
            if (entity instanceof Model3D) {
                ((Model3D) entity).removeTexture(texture);
            }
        }
    }
    @Override
    public void removeModel(int id) {
        for (Entity entity : editorDatabase.getAll()) {
            if (entity instanceof Model3D) {
                if (entity.getId() == id) {
                    removeEntity(entity);
                    System.out.printf("Модель #%d удалена\n", id);
                    return;
                }
            }
        }
        throw new RuntimeException("3D модель с указанным id не найдена.");
    }
}
