CREATE TABLE public.user (
	id serial NOT NULL,
	username varchar NOT NULL,
	email varchar NOT NULL,
	password varchar NOT NULL,
	created timestamp NOT NULL,
	updated timestamp NOT null,
	CONSTRAINT pk_user PRIMARY KEY (id)
);
