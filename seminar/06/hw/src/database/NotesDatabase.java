package database;

import notes.infrastructure.persistance.Database;

public class NotesDatabase implements Database {

    private NotesTable notesTable;

    public NotesTable getNotesTable() {
        if (notesTable == null)
            notesTable = new NotesTable();
        return notesTable;
    }

    public void removeNotesRecordById(int id) {
        this.notesTable.removeRecordById(id);
    }

}
