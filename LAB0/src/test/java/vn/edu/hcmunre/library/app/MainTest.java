package vn.edu.hcmunre.library.app;

import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.assertEquals;

public class MainTest {
    @Test
    @DisplayName("Check status message readiness")
    void testStatusMessage() {
        assertEquals("Library OOAD starter project is ready.", Main.getStatusMessage());
    }
}
