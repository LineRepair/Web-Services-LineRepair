Feature: ApplianceModelServiceTests
	As a Developer
	I want to add new ApplianceModel through API
	so that it becomes available for applications.
	
Background: 
    	Given the Endpoint https://localhost:44346/api/v1/applianceModel is available 
    	And A ApplianceBrand is already stored 
    	     | Name    | ImgPath |
             | Samsung | img1    |

@applianceModel.adding
Scenario: Add ApplianceModel
	When A Post Request is sent to ApplianceModel
	| Name  | Model | ImgPath  | PurchaseDate | ApplianceBrandId |
	| T-800 | 1.0.1 | img1.jpg | 23/12/20     | 2                |
	Then A Response with Status 200 is received in ApplianceModel
	And A applianceModel Resource is included in Response Body
    | Name  | Model | ImgPath  | PurchaseDate | ApplianceBrandId |
    | T-800 | 1.0.1 | img1.jpg | 23/12/20     | 2                |

@applianceModel-adding-Invalid
Scenario: Add ApplianceModel with Invalid ApplianceBrand
	When A Post Request is sent to ApplianceModel
	| Name  | Model | ImgPath  | PurchaseDate | ApplianceBrandId |
    | T-800 | 1.0.1 | img1.jpg | 23/12/20     | -2               |
    Then A Response with Status 400 is received in ApplianceModel
    And A message of "Invalid ApplianceBrand" is included in Response Body