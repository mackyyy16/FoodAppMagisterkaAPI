CREATE TABLE "user" (id_user serial PRIMARY KEY,
			name VARCHAR (100) NOT NULL, 
			surname VARCHAR (100) NOT NULL,
			sex VARCHAR (100) NOT NULL,
			password VARCHAR (100) NOT NULL,
			login VARCHAR (100) NOT NULL,
			email VARCHAR (100) NOT NULL,
			dateofbirth VARCHAR (100) NOT NULL,
			phonenumber INT NOT NULL,
			role VARCHAR (100) NOT NULL,
			street VARCHAR (100) NOT NULL,
			postcode VARCHAR (100) NOT NULL,
			city VARCHAR (100) NOT NULL
			);

CREATE TABLE "food" (id_food serial PRIMARY KEY,
			name VARCHAR (100) NOT NULL, 
			price INT NOT NULL,
			description VARCHAR (200) NOT NULL, 
			amount VARCHAR (100) NOT NULL 
			);