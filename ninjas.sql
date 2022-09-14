CREATE TABLE ninjas(
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name TEXT NOT NULL,
    weapon VARCHAR(255) NOT NULL DEFAULT "silence",
    confirmedKills INT NOT NULL DEFAULT 0,
    certified BOOLEAN NOT NULL DEFAULT false,
    color VARCHAR(50)
    )default charset utf8;

    DROP TABLE ninjas;

DELETE FROM ninjas;



-- NOTE
    INSERT INTO ninjas
    (name, weapon, certified, color)
    VALUES 
    ("Jackie Chan", "Nun-chucks", true, "white robe");
    INSERT INTO ninjas
    (name, weapon, certified, color)
    VALUES 
    ("Scorpion", "spear", true, "yellow robe");
    INSERT INTO ninjas
    (name, weapon, certified, color)
    VALUES 
    ("Snake Eyes", "hands", true, "Black robe");
    INSERT INTO ninjas
    (name, weapon, certified, color)
    VALUES 
    ("Donnatello", "Staff", false, "purple robe");
    INSERT INTO ninjas
    (name, weapon, certified, color)
    VALUES 
    ("Reptile", "claws", false, "green robe");
    INSERT INTO ninjas
    (name, weapon, certified, color)
    VALUES 
    ("Chris Farley", "Ignorance", false, "blonde");


-- NOTE get all
    SELECT * FROM ninjas;

    -- NOTE search 
SELECT * FROM ninjas WHERE name LIKE "%s%";

    -- NOTE get one by id
    SELECT * FROM ninjas WHERE id = 3;

    -- NOTE update by id
UPDATE ninjas  
SET confirmedKills = 200
WHERE id = 3;

-- NOTE DELETE
DELETE FROM ninjas WHERE id = 6;

-- NOTE certify(BOOL)
UPDATE ninjas 
SET certified = true
WHERE confirmedKills > 0;