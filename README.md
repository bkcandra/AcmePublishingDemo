# AcmePublishingDemo

db diagram is available on  https://github.com/bkcandra/AcmePublishingDemo/blob/master/AcmePublishingDemo.API/diagram.png

One solution to create a recurrent task is to use azure function with timer trigger, we can also create a windows task scheduler, azure logic etc.

The process is as follows :
1. Create  Azure Function with a Timer Trigger is created to run on a specific schedule, in this case daily or monthly.
2. this function is designed to check the active customer subscriptions. It retrieves subscription details and associated publication.
3. Based on the subscription and publication, the function determines the delivery day. For example, if the delivery is scheduled for the 15th of each month, the function calculates the current date and checks if it's 3 days before the delivery day.
4. If it's 3 days before the delivery day, the function generates a print request. The print request includes the publication details and the customer's delivery address. The function sends the print request to the appropriate print distribution company based on the country ID associated with the customer's delivery address.
5. The print distribution company receives the print request and processes it. They initiate the printing of the publication and prepare it for delivery to the customer.
6. the function also creates a delivery request. The delivery request includes the necessary information for delivering the printed publication to the customer. The function sends the delivery request to the print distribution company.
7. The print distribution company receives the delivery request and carries out the delivery process. They ensure that the printed publication is sent to the correct customer's delivery address on the specified delivery day.\

In case the function cannot find a distribution company for a specific delivery country, 

it creates an error record. The error record captures the relevant details, such as the country ID and the inability to find a suitable distribution company.


Note: 

- The distribution API on this solution can be implemented using various database systems such as MongoDB, SQL Server, or PostgreSQL. 
- Additionally, based on the specific requirements, it is possible to have a single API that connects to multiple distribution databases located in different regions or countries.
- This approach allows for compliance with individual country requirements on PII 
- The choice of database system and the architecture for connecting to multiple databases should be determined based on the specific needs and scalability requirements.
