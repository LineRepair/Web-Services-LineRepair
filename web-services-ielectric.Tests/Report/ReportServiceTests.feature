Feature: ReportServiceTests
	As a Developer
	I want to add new Report through the API
	So that it becomes available for applications

Background: 
    	Given the Endpoint https://localhost:44346/api/v1/reports is available 
    	And A Technician is already stored 
    	| Names | LastNames | CellphoneNumber | Address    | Email           | Password   |
        | Pedro | Jimenez   | 978675641       | San Isidro | pedro@gmail.com | Pedro12345 |

@technician.selectAppointment
Scenario: Select Appointment
    When A Technician Request is create to Report
    | Names | LastNames | CellphoneNumber | Address    | Email           | Password   |
    | Pedro | Jimenez   | 978675641       | San Isidro | pedro@gmail.com | Pedro12345 |
    Then A Response with Status 200 is received in Appointment
    And Appointment Resource is included in Response Body
     | DateReserve   | DateAttention     | Hour     | Done       | ClientId     | TechnicianId |
     | 1/06/2022     | 4/06/2022         | 15:00    |  true      |      1       |    2         | 
      
@technician.selectAppointment    
Scenario: Select Appointment unfinished
    When A Technician Request is create to Report
    | Names | LastNames | CellphoneNumber | Address    | Email           | Password   |
    | Pedro | Jimenez   | 978675641       | San Isidro | pedro@gmail.com | Pedro12345 |
    Then A Response with Status 200 is received in Appointment
    And Appointment Resource is included in Response Body
     | DateReserve   | DateAttention     | Hour     | Done       | ClientId     | TechnicianId |
     | 1/06/2022     | 4/06/2022         | 15:00    |  false      |      1       |    2         |  
     
@report.adding
Scenario: Add Report
	When A Post Request is sent to Report
	| Observation             | Diagnosis             | RepairDescription                      | ImagePath                 | Date     | TechnicianId | AppointmentId |
    | The microwave smell bad | A component is burned |  I replaced the microchip successfully | https://google.com/images | 10-12-24 | 2            |       1       |
	Then A Response with Status 200 is received in Report
	And A Report Resource is included in Response Body
    | Observation             | Diagnosis             | RepairDescription                      | ImagePath                 | Date     | TechnicianId |AppointmentId  |
    | The microwave smell bad | A component is burned |  I replaced the microchip successfully | https://google.com/images | 10-12-24 | 2            |      1        |

@report-adding-Invalid
Scenario: Add Report with Invalid Technician
	When A Post Request is sent to Report
	| Observation             | Diagnosis             | RepairDescription                      | ImagePath                 | Date     | TechnicianId |AppointmentId  |
    | The microwave smell bad | A component is burned |  I replaced the microchip successfully | https://google.com/images | 10-12-24 | -2           |       1       |
    Then A Response with Status 400 is received in Report
    And A message of "Invalid Technician" is included in Response Body

