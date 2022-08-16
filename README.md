# TDDMicroExercises
Test Driven Development - Micro Exercises
by José Alberto Araújo : zebeto-pt

Exercises for TDD Micro Exercises in C#
using NUnit

1. TirePressureMonitoringSystem exercise:
Write the unit tests for the Alarm class, refactor the code as much as you need to make the class testable.
The Alarm class is designed to monitor tire pressure and set an alarm if the pressure falls outside of the expected range. The Sensor class provided for the exercise simulates the behaviour of a real tire sensor, providing random but realistic values.

2. UnicodeFileToHtmlTextConverter exercise:
Write the unit tests for the UnicodeFileToHtmlTextConverter class, refactor the code as much as you need to make the class testable.
The UnicodeFileToHtmlTextConverter class is designed to reformat a plain text file for display in a browser.

3. TicketDispenser exercise:
Write the unit tests for the TicketDispenser, refactor the code as much as you need to make the class testable.
The TicketDispenser class is designed to be used to manage a queuing system in a shop. There may be more than one ticket dispenser but the same ticket should not be issued to two different customers.

4. TelemetrySystem exercise:
Write the unit tests for the TelemetryDiagnosticControls class, refactor the code as much as you need to make the class testable.
The responsibility of the TelemetryDiagnosticControls class is to establish a connection to the telemetry server (through the TelemetryClient), send a diagnostic request and successfully receive the response that contains the diagnostic info. The TelemetryClient class provided for the exercise simulates the behavior of the real TelemetryClient class, and can respond with either the diagnostic information or a random sequence. The real TelemetryClient class would connect and communicate with the telemetry server via tcp/ip.

5. Refactor the entire solution architecture:
Follow the SOLID principles and refactor the entire code base and change the architecture as you see fit without losing functionality.

