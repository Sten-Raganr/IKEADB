SELECT Series.SeriesName,Room.RoomName FROM Room
INNER JOIN Series ON Series.RoomId = Room.Id
WHERE Room.RoomName LIKE 'Kitchen'