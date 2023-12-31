package views;

import models.Table;
import presenters.View;
import presenters.ViewObserver;

import java.util.Collection;
import java.util.Date;

public class BookingView implements View {

    private ViewObserver observer;

    public void setObserver(ViewObserver observer) {
        this.observer = observer;
    }

    public void showTables(Collection<Table> tables) {
        for (Table table : tables) {
            System.out.println(table);
        }
    }

    @Override
    public void showReservationTableResult(int reservationNo) {
        if (reservationNo > 0) {
            System.out.printf("Столик успешно забронирован. Номер вашей брони: #%d\n", reservationNo);
        } else {
            System.out.println("Что-то пошло не так, попробуйте повторить попытку позже.");
        }
    }

    /**
     * Действие клиента (пользователь нажал на кнопку бронирования), бронирование столика
     * @param orderDate Дата бронирования
     * @param tableNo Номер столика
     * @param name Имя клиента
     */
    public void reservationTable(Date orderDate, int tableNo, String name) {
        if (observer != null) {
            observer.onReservationTable(orderDate, tableNo, name);
        }
    }

    /**
     * TODO: Доработать самостоятельно в рамках домашней работы
     * Действие клиента (пользователь нажал на кнопку изменения резерва)
     * @param oldReservation Идентификатор брони (старый)
     * @param reservationDate Дата бронирования
     * @param tableNo Номер столика
     * @param name Имя клиента
     */
    public void changeReservationTable(int oldReservation, Date reservationDate, int tableNo, String name) {

    }
}
