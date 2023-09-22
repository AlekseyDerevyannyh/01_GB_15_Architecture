import models.TableModel;
import presenters.BookingPresenter;
import presenters.View;
import presenters.Model;
import views.BookingView;

import java.util.Date;
import java.util.Scanner;

public class Main {

    static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        View view = new BookingView();
        Model model = new TableModel();
        BookingPresenter presenter = new BookingPresenter(model, view);

        boolean f = true;
        while (f) {
            System.out.println();
            System.out.println("*** Приложение БРОНИРОВАНИЕ СТОЛИКОВ ***");
            System.out.println("========================================");
            System.out.println("1. Показать список всех столиков");
            System.out.println("2. Показать список доступных для бронирования столиков");
            System.out.println("3. Забронировать столик");
            System.out.println("4. Изменить бронь");
            System.out.println("0. ВЫХОД ИЗ ПРОГРАММЫ");
            System.out.print("Пожалуйста, выберите пункт меню: ");
            if (scanner.hasNextInt()){
                int no = scanner.nextInt();
                scanner.nextLine();
                try {
                    String name;
                    switch (no) {
                        case 0:
                            System.out.println("Завершение работы приложения");
                            f = false;
                            break;
                        case 1:
                            presenter.updateUIShowTables();
                            break;
                        case 2:
                            presenter.updateUIShowFreeTables();
                            break;
                        case 3:
                            System.out.println("Список доступных для бронирования столиков:");
                            presenter.updateUIShowFreeTables();
                            System.out.print("Укажите своё имя: ");
                            name = scanner.nextLine();
                            System.out.print("Укажите номер столика для бронирования: ");
                            if (scanner.hasNextInt()){
                                int tableNo = scanner.nextInt();
                                scanner.nextLine();
                                view.reservationTable(new Date(), tableNo, name);
                            } else {
                                System.out.println("Номер столика указан некорректно.");
                            }
                            break;
                        case 4:
                            System.out.println("Список доступных для бронирования столиков:");
                            presenter.updateUIShowFreeTables();
                            System.out.print("Укажите номер брони для изменения: ");
                            if (scanner.hasNextInt()){
                                int reservationNo = scanner.nextInt();
                                scanner.nextLine();
                                System.out.print("Укажите номер столика для бронирования: ");
                                if (scanner.hasNextInt()) {
                                    int tableNo = scanner.nextInt();
                                    scanner.nextLine();
                                    System.out.print("Укажите своё имя: ");
                                    name = scanner.nextLine();
                                    view.changeReservationTable(reservationNo, new Date(), tableNo, name);
                                } else {
                                    System.out.println("Номер столика указан некорректно.");
                                }
                            } else {
                                System.out.println("Номер брони указан некорректно.");
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
