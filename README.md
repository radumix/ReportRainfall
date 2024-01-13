# ReportRainfall

Display paramters in swaqger basically is stationID and count.

to dispaly the negative expection response:

add invalid string value to stationid paramter.

{
  "message": "Invalid stationId",
  "detail": [
    {
      "propertyName": "stationId",
      "message": "Invalid stationId value"
    }
  ]
}

____________________________________________________________________

To display Positive expectied response:
add int value to count Prameter.

{
  "readings": [
    {
      "dateMeasured": "2024-01-10T15:23:45.2013172+08:00",
      "amountMeasured": 0
    },
    {
      "dateMeasured": "2024-01-10T15:23:45.2022832+08:00",
      "amountMeasured": 10.5
    },
    {
      "dateMeasured": "2024-01-10T15:23:45.2022847+08:00",
      "amountMeasured": 21
    }
  ]
}
