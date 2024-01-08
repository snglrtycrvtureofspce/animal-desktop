-- Просмотр информации о животных и связанных с ними пользователях
CREATE VIEW V1 AS
SELECT
    ae.Id AS AnimalId,
    ae.Name AS AnimalName,
    ae.Description AS AnimalDescription,
    ae.DateOfBirth AS AnimalDateOfBirth,
    ae.Status AS AnimalStatus,
    ae.Breed AS AnimalBreed,
    ae.PhotoUrl AS AnimalPhotoUrl,
    ue.Id AS UserId,
    ue.Username AS UserUsername,
    ue.Name AS UserName,
    ue.Age AS UserAge,
    ue.Email AS UserEmail
FROM Animals ae
LEFT JOIN AnimalUserEntity aue ON ae.Id = aue.AnimalId
LEFT JOIN Users ue ON aue.UserId = ue.Id;

-- Просмотр информации о маркерах животных
CREATE VIEW V2 AS
SELECT
    ae.Id AS AnimalId,
    ae.Name AS AnimalName,
    ae.Description AS AnimalDescription,
    me.Id AS MarkerId,
    me.Latitude AS MarkerLatitude,
    me.Longitude AS MarkerLongitude,
    me.LocationName AS MarkerLocationName
FROM Animals ae
LEFT JOIN AnimalMarkerEntity ame ON ae.Id = ame.AnimalId
LEFT JOIN Markers me ON ame.MarkerId = me.Id;

-- Просмотр маркеров с привязкой к животным и пользователям
CREATE VIEW V3 AS
SELECT
    me.Id AS MarkerId,
    me.Latitude AS MarkerLatitude,
    me.Longitude AS MarkerLongitude,
    me.LocationName AS MarkerLocationName,
    ae.Id AS AnimalId,
    ae.Name AS AnimalName,
    ae.Description AS AnimalDescription,
    ue.Id AS UserId,
    ue.Username AS UserUsername,
    ue.Name AS UserName
FROM Markers me
LEFT JOIN AnimalMarkerEntity ame ON me.Id = ame.MarkerId
LEFT JOIN Animals ae ON ame.AnimalId = ae.Id
LEFT JOIN AnimalUserEntity aue ON ae.Id = aue.AnimalId
LEFT JOIN Users ue ON aue.UserId = ue.Id;