-- 1. which artists did not make any albums at all?
SELECT *
FROM Artist
	WHERE ArtistId NOT IN(
	SELECT ArtistId
	FROM Album);
-- 2. which artists did not record any tracks of the Latin genre?
select Artist.Name as Artist
from Track
	inner join Genre on Genre.GenreId = Track.GenreId
	left join Album on Album.AlbumId = Track.AlbumId
	left join Artist on Artist.ArtistId = Album.ArtistId
where Genre.Name != 'Latin'
group by Artist.Name;
-- 3. which video track has the longest length? (use media type table)
select top 1 Track.Name, Track.Milliseconds
from Track
	inner join MediaType on MediaType.MediaTypeId = Track.MediaTypeId
where MediaType.Name like '%video%'
order by Track.Milliseconds desc;
-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)
select * from Employee;
-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?
-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.