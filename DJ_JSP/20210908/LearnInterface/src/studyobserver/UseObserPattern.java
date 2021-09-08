package studyobserver;

public interface UseObserPattern {
	void subscribe(EmergencyStopable r);
	void unsubscribe(EmergencyStopable r);
	void notifyParts();
}
