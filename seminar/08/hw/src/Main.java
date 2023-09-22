import models.TableModel;
import presenters.BookingPresenter;
import presenters.View;
import presenters.Model;
import views.BookingView;

import java.util.Date;

public class Main {

    public static void main(String[] args) {
        View view = new BookingView();
        Model model = new TableModel();
        BookingPresenter presenter = new BookingPresenter(model, view);

        presenter.updateUIShowTables();

        view.reservationTable(new Date(), 2, "Алексей");

        presenter.updateUIShowFreeTables();

        view.changeReservationTable(1001, new Date(), 3, "Алексей");

        presenter.updateUIShowFreeTables();
    }
}
