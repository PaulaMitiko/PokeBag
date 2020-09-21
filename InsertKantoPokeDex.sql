INSERT INTO PokeDex VALUES 
(1, 'Bulbasaur', 'Grass', 'Poison', 25, 3, NULL, 1115, 815),
(2, 'Ivysaur', 'Grass', 'Poison', 100, 3, NULL, 1699, 1303),
(3, 'Vanusaur','Grass','Poison', NULL, 3, NULL, 2720, 2176),
(4, 'Charmander', 'Fire', NULL, 25, 3, NULL, 980, 704),
(5, 'Charmeleon', 'Fire', NULL, 100, 3, NULL, 1653, 1263),
(6, 'Charizard', 'Fire', 'Flying', NULL, 3, NULL, 2889, 2320),
(7, 'Squirtle', 'Water', NULL, 25, 3, NULL, 946, 675),
(8, 'Wartortle', 'Water', NULL, 100, 3, NULL, 1488, 1125),
(9, 'Blastoise', 'Water', NULL, NULL, 3, NULL, 2466, 1956),
(10, 'Caterpie', 'Bug', NULL, 12, 1, NULL, 437, 267),
(11, 'Metapod', 'Bug', NULL, 50, 1, NULL, 450, 273),
(12, 'Butterfree', 'Bug', 'Flying', NULL, 1, NULL, 1827, 1411),
(13, 'Weedle', 'Bug', 'Poison', 12, 1, NULL, 456, 283),
(14, 'Kakuna', 'Bug', 'Poison', 50, 1, NULL, 432, 261),
(15, 'Beedrill', 'Bug', 'Poison', NULL, 1, NULL, 1846, 1426),
(16, 'Pidgey', 'Normal', 'Flying', 12, 1, NULL, 680, 461),
(17, 'Pidgeotto', 'Normal', 'Flying', 50, 1, NULL, 1194, 879),
(18, 'Pidgeot', 'Normal', 'Flying', NULL, 1, NULL, 2129, 1668),
(19, 'Rattata', 'Normal', NULL, 25, 1, NULL, 734, 504),
(20, 'Raticate', 'Normal', NULL, NULL, 1, NULL, 1730, 1330),
(21, 'Spearow', 'Normal', 'Flying', 50, 1, NULL, 798, 551),
(22, 'Fearow', 'Normal', 'Flying', NULL, 1, NULL, 1997, 1554),
(23, 'Ekans', 'Poison', NULL, 50, 3, NULL, 927, 661),
(24, 'Arbok', 'Poison', NULL, NULL, 3, NULL, 1920, 1491),
(25, 'Pikachu', 'Electric', NULL, 50, 1, NULL, 938, 670),
(26, 'Raichu', 'Electric', NULL, NULL, 1, NULL, 2182, 1712),
(27, 'Sandshrew', 'Ground', NULL, 50, 3, NULL, 1261, 936),
(28, 'Sandslash', 'Ground', NULL, NULL, 3, NULL, 2374, 1878),
(29, 'Nidoran(F)', 'Poison', NULL, 25, 3, NULL, 816, 568),
(30, 'Nidorina', 'Poison', NULL, 100, 3, NULL, 1309, 974),
(31, 'Nidoqueen', 'Poison', 'Ground', NULL, 3, NULL, 2488, 1975),
(32, 'Nidoran(M)', 'Poison', NULL, 25, 3, NULL, 860, 605),
(33, 'Nidorino', 'Poison', NULL, 100, 3, NULL, 1393, 1045),
(34, 'Nidoking', 'Poison', 'Ground', NULL, 3, NULL, 2567, 2042),
(35, 'Clefairy', 'Fairy', NULL, 50, 1, NULL, 1155, 845),
(36, 'Clefable', 'Fairy', NULL, NULL, 1, NULL, 2437, 1931),
(37, 'Vulpix', 'Fire', NULL, 50, 3, NULL, 883, 626),
(38, 'Ninetales', 'Fire', NULL, NULL, 3, NULL, 2279, 1797),
(39, 'Jigglypuff', 'Normal', 'Fairy', 50, 1, NULL, 724, 470),
(40, 'Wigglytuff', 'Normal', 'Fairy', NULL, 1, NULL, 1926, 1474),
(41, 'Zubat', 'Poison', 'Flying', 25, 1, NULL, 667, 450),
(42, 'Golbat', 'Poison', 'Flying', 100, 1, NULL, 1976, 1538),
(43, 'Oddish', 'Grass', 'Poison', 25, 3, NULL, 1228, 909),
(44, 'Gloom', 'Grass', 'Poison', 100, 3, NULL, 1681, 1288),
(45, 'Vileplume', 'Grass', 'Poison', NULL, 3, NULL, 2559, 2036);

INSERT INTO Cidade VALUES
('Maringá','Brasil',0),
('Bombinhas', 'Brasil',0),
('Curitiba','Brasil',0),
('Winter Garden', 'Estados Unidos',0);

select * from PokemonBag;
select * from PokeDex;
select * from cidade;

update PokeDex set QtdePokemon = 0;



