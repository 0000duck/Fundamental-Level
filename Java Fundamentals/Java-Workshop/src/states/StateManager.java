package states;

/**
 * Created by ivailojordanov on 11/8/15.
 */
public class StateManager {
    private static State currentState = null;

    public static State getCurrentState() {
        return currentState;
    }

    public static void setCurrentState(State newState) {
        currentState = newState;
    }
}
