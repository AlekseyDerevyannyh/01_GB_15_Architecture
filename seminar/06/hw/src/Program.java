import database.NotesDatabase;
import notes.core.application.ConcreteNoteEditor;
import notes.infrastructure.persistance.NotesDbContext;
import notes.presentation.queries.controllers.NotesController;
import notes.presentation.queries.views.NotesConsolePresenter;

import java.util.Scanner;

public class Program {

    static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        NotesController controller = new NotesController(new ConcreteNoteEditor(
                new NotesDbContext(new NotesDatabase()), new NotesConsolePresenter()));

        boolean f = true;
        while (f) {
            System.out.println();
            System.out.println("*** Приложение ЗАМЕТКИ ***");
            System.out.println("=======================");
            System.out.println("1. Открыть список заметок");
            System.out.println("2. Удалить заметку по id");
            System.out.println("0. ЗАВЕРШЕНИЕ РАБОТЫ ПРИЛОЖЕНИЯ");
            System.out.print("Пожалуйста, выберите пункт меню: ");
            if (scanner.hasNextInt()){
                int no = scanner.nextInt();
                scanner.nextLine();
                try {
                    switch (no) {
                        case 0:
                            System.out.println("Завершение работы приложения");
                            f = false;
                            break;
                        case 1:
                            controller.routeGetAll();
                            break;
                        case 2:
                            System.out.print("Укажите номер заметки для удаления: ");
                            if (scanner.hasNextInt()){
                                int id = scanner.nextInt();
                                scanner.nextLine();
                                controller.routeRemoveNoteById(id);
                            } else {
                                System.out.println("Номер заметки указан некорректно.");
                            }
                            break;
                        default:
                            System.out.println("Укажите корректный пункт меню.");
                    }
                } catch (Exception e) {
                    System.out.println(e.getMessage());
                }
            } else {
                System.out.println("Укажите корректный пункт меню.");
                scanner.nextLine();
            }
        }
    }
}
