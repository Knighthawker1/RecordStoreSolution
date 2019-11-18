CREATE TABLE Genres (
	GenreID 					INT  			NOT NULL  IDENTITY  PRIMARY KEY,
	GenreName					NVARCHAR (50)	NOT NULL 
);

CREATE TABLE Artists (
	ArtistID 					INT  			NOT NULL  IDENTITY  PRIMARY KEY,
	ArtistName					NVARCHAR (100)	NOT NULL 
);

CREATE TABLE Albums (
	AlbumID 					INT  			NOT NULL  IDENTITY  PRIMARY KEY,
	AlbumName					NVARCHAR (100)	NOT NULL,
	AlbumGenreID				INT				NOT NULL,
	AlbumPrice					DECIMAL			NULL,
	AlbumArtistID				INT				NOT NULL	
);

ALTER TABLE Albums ADD CONSTRAINT Albums_Genres_GenreID 
FOREIGN KEY (AlbumGenreID) REFERENCES Genres (GenreID);

ALTER TABLE Albums ADD CONSTRAINT Albums_Artists_ArtistID
FOREIGN KEY (AlbumArtistID) REFERENCES Artists (ArtistID);