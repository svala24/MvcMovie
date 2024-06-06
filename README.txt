2024-05-16
Suryarajsinh Vala
1700 UTC

1720 
added MVC controller-empty

1733 
edited the content of controllers/helloworldcontroller.cs

changed welcome string, added name and ID.
Defined vala as a name by default.


https://localhost:7087/helloworld/welcome?name=vala&ID=3

1810 
Defined name "vala"

1815 
Created "HelloWordld" folder
Added item, named "Index.cshtml"

1822 
Sucess.





2024-05-23
Suryarjsinh Vala
1700 UTC

1706
added img library
created .png file in paint.

1710
linked img in wwwroot folder, initially it wasnt getting linked to img folder so I use "~" to solved

<img src="~/img/smile.png" />

also added "marquee" for better view

1735
added one more statement in header

1740
made font adjustment in title and message /h1, h2

1747
changed name in views > MvcMovie to MvcMovie web page.

1752
created Welcome.cshtml file in view > shared folder

faced some error in syntax (return value), commented old string

fixed.

https://localhost:7087/HelloWorld/Welcome?name=surya&numtimes=4




1755
Added New Scaffolded Item in Controllers.
Model class Movie(MvcMovie.Models)

1757
Migration initiated and timestamp
20240523183338_InitialCreate

1780
Movie Index wasn't working, giving database error.
Solved it by verifying dbo.Movie design in SQL database  and clearing browser cachce and 

https://localhost:7087/Movies

1800
In order to add content in Movie Index, I defined syntax int (Id), string (title) and data type, genre and price (datetime releasedata)

Done!!




2024-05-30
Suryarajsinh Vala
1700 UTC

1710
Part 7 Started!!
updated search string in Controllers/Moviecontroller.cs

1711
checked it/run it! 

https://localhost:7087/Movies?MovieGenre=&SearchString=iboy

Finished :D

Part 8 Started!!
1712
Added Rating Property in Models/Movie.cs

public string? Rating {  get; set; }

Faced an error (Rating error in /movies) :|
Fixed it by updating database again!!

1725

Now I will add 'rating filed' in :-

Added Rating Views/Movies/Create.cshtml
Added Rating Views/Movies/Delete.cshtml
Added Rating Views/Movies/Details.cshtml
Added Rating Views/Movies/Edit.cshtml
Added Rating Views/Movies/Index.cshtml


https://localhost:7087/Movies


1740
Migration started for Rating

Add-Migration Rating
Update-Database

20240530163133_Rating.cs


Suucessfully updated database!!

Edited MoviesController.cs
Added 'rating' in public string
Bind("Id,Title,ReleaseDate,Genre,Price,Rating")




