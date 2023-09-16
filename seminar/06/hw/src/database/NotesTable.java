package database;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Random;

public class NotesTable {

    private Random random = new Random();

    private Collection<NotesRecord> records;

    public Collection<NotesRecord> getRecords() {
        if (records == null) {
            records = new ArrayList<>();
            int recordCount = 5 + random.nextInt(10);
            for (int i = 0; i < recordCount; i++) {
                records.add(new NotesRecord("title #" + i, "details #" + i));
            }
        }
        return records;
    }

    public void removeRecordById(int id) {
        Collection<NotesRecord> result = new ArrayList<>();
        for (NotesRecord record : this.records) {
            if (record.getId() != id) {
                result.add(record);
            }
        }
        this.records = result;
    }
}
