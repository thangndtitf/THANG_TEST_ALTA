CREATE TABLE "Users" (
  "Id" int2 NOT NULL,
  "Name" varchar(255) NOT NULL,
  "Email" varchar(255) NOT NULL,
  "Phone" numeric(10) NOT NULL,
  "Birdday" timestamp(6) NOT NULL,
  "Gender" numeric(1) NOT NULL,
  "Password" varchar(255) NOT NULL,
  "Avata" varchar(255) NOT NULL,
  "CreatedAt" timestamp(6) NOT NULL,
  PRIMARY KEY ("Id")
);