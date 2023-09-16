package notes.presentation.queries.controllers;

import notes.core.application.interfaces.NoteEditor;
import notes.core.domain.Note;

import java.util.Optional;

public class NotesController extends Controller {
    private final NoteEditor noteEditor;

    public NotesController(NoteEditor noteEditor) {
        this.noteEditor = noteEditor;
    }

    public void routeAddNote(Note note) {
        this.noteEditor.add(note);
    }

    public void routeRemoveNote(Note note) {
        this.noteEditor.remove(note);
    }

    public void routeGetAll() {
        this.noteEditor.printAll();
    }

    public Optional<Note> getById(int id) {
        return this.noteEditor.getById(id);
    }

    public void routeRemoveNoteById(int id) {
        if (getById(id).isPresent()) {
            this.noteEditor.removeById(id);
            System.out.printf("Заметка с id=%d удалена.\n", id);
        } else {
            System.out.printf("Заметки с id=%d не существует!\n", id);
        }
    }

}
