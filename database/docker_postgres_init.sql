CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

create table recipes
(
    recipe_id uuid DEFAULT uuid_generate_v4() primary key,
    title     varchar not null
);

insert into recipes (title) values
('korv');