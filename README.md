api developed using asp .net core

Testing the end points
--------------------------------------------
Postman would be a good choice to test the end points

To get all the records, select GET for the end point - api/course
To get the records by id, select GET for the end point - api/course/1

To add a record, select POST with the following json in body for the end point - api/course


{
    "id": 21,
    "title": "ASP .Net Advanced",
    "description": "ASP .Net Course for programmers",
    "reference": "ASPNETB0021",
    "duration": 6,
    "fees": 500,
    "status": "open",
    "location": "Net Hall 1",
    "totalplaces": 100,
    "availableplaces": 90
  }
  
  To update a record, select PUT  with the following json in body for the end point - api/course/1


{
    "id": 21,
    "title": "ASP .Net Advanced",
    "description": "ASP .Net Course for programmers",
    "reference": "ASPNETB0021",
    "duration": 6,
    "fees": 500,
    "status": "open",
    "location": "Net Hall 1",
    "totalplaces": 100,
    "availableplaces": 90
  }
  
    To delete a record, select DELETE for the end point - api/course/1

  
  

