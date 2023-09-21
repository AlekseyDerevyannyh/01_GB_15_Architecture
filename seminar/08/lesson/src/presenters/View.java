package presenters;

import models.Table;

import java.util.Collection;
import java.util.Date;

public interface View {
    /**
     * Отображение списка столиков в приложении
     * @param tables список столиков
     */
    void showTables(Collection<Table> tables);

    /**
     * Отобразить результат бронирования столика
     * @param reservationNo Номер брони
     */
    void showReservationTableResult(int reservationNo);

    /**
     * Установить наблюдателя для представления
     * @param observer наблюдатель
     */
    void setObserver(ViewObserver observer);

    /**
     * Событие: Клиент нажал на кнопку резерва столика
     * @param orderDate Дата резерва
     * @param tableNo Номер столика
     * @param name Имя клиента
     */
    void reservationTable(Date orderDate, int tableNo, String name);
}
