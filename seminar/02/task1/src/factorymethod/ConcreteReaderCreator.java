package factorymethod;

import templatemethod.LogReader;
import templatemethod.PoemReader;

public class ConcreteReaderCreator extends BaseLogReaderCreator {
    @Override
    protected LogReader createLogReaderInstance(LogType logType) {

        return switch(logType) {
            case Poem -> new PoemReader();
            case Text -> new TextFileReader();
            case Database -> new DatabaseReader();
            case System -> new OperationSystemLogEventReader();
        };
    }
}
