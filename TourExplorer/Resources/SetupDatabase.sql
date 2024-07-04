-- TABELE
CREATE TABLE klienci (
    id_klienta SMALLINT NOT NULL,
    imie       VARCHAR2(30) NOT NULL,
    nazwisko   VARCHAR2(30) NOT NULL,
    login      VARCHAR2(10) NOT NULL,
    haslo      VARCHAR2(40) NOT NULL
);
ALTER TABLE klienci ADD CONSTRAINT klient_pk PRIMARY KEY ( id_klienta );

CREATE TABLE przewodnicy (
    id_przewodnika          SMALLINT NOT NULL,
    imie                    VARCHAR2(30) NOT NULL,
    nazwisko                VARCHAR2(30) NOT NULL,
    uprawnienia_przewodnika VARCHAR2(50),
    login                   VARCHAR2(10) NOT NULL,
    haslo                   VARCHAR2(40) NOT NULL
);
ALTER TABLE przewodnicy ADD CONSTRAINT przewodnik_pk PRIMARY KEY ( id_przewodnika );

CREATE TABLE wycieczki (
    id_katalogowe_wycieczki SMALLINT NOT NULL,
    nazwa_wycieczki         VARCHAR2(50) NOT NULL,
    cena_wycieczki          NUMBER NOT NULL
);
ALTER TABLE wycieczki ADD CONSTRAINT wycieczka_pk PRIMARY KEY ( id_katalogowe_wycieczki );

CREATE TABLE wycieczki_klientow (
    id_wycieczki_klienta    SMALLINT NOT NULL,
    data_rezerwacji         DATE NOT NULL,
    miejsce_odbioru         VARCHAR2(50),
    id_klienta              SMALLINT NOT NULL,
    id_katalogowe_wycieczki SMALLINT NOT NULL
);
ALTER TABLE wycieczki_klientow ADD CONSTRAINT wycieczka_klienta_pk PRIMARY KEY ( id_wycieczki_klienta );

ALTER TABLE wycieczki_klientow
    ADD CONSTRAINT wycieczka_klienta_klient_fk FOREIGN KEY ( id_klienta )
        REFERENCES klienci ( id_klienta );

ALTER TABLE wycieczki_klientow
    ADD CONSTRAINT wycieczka_klienta_wycieczka_fk FOREIGN KEY ( id_katalogowe_wycieczki )
        REFERENCES wycieczki ( id_katalogowe_wycieczki );


-- KLIENCI (UZYTKOWNICY)
INSERT INTO klienci VALUES (1, 'Julian', 'Zawadzki', 'julzaw', '26f1cbc03dcdbd2aa5795df9ff032f21');
INSERT INTO klienci VALUES (2, 'Amadeusz', 'Wozniak', 'amawoz', '30d1eaff93e555f1d28cc884b29266f6');
INSERT INTO klienci VALUES (3, 'Zuzanna', 'Wroblewska', 'zuzwro', 'f2e3f79b4cf4defaa96d51f1f4c91606');
INSERT INTO klienci VALUES (4, 'Emilia', 'Gorska', 'emigor', 'f125fcfe781fdaac4336a35ec3d81969');
INSERT INTO klienci VALUES (5, 'Sergiusz', 'Kaczmarczyk', 'serkac', '3d9b1f4781efdbfc8e1642621f51adb5');
INSERT INTO klienci VALUES (6, 'Denis', 'Duda', 'dendud', 'e30d79408ab67c31a531586cd566a571');
INSERT INTO klienci VALUES (7, 'Kordian', 'Czarnecki', 'korcza', '262960d7316a3bf14638f3d9fe59bf75');
INSERT INTO klienci VALUES (8, 'Ariel', 'Przybylski', 'ariprz', 'f2cc91d565ca4a264350ec45ffba3ab1');

-- WYCIECZKI
INSERT INTO wycieczki VALUES (1, 'Jarmark w Wiedniu', 450);
INSERT INTO wycieczki VALUES (2, 'Zwiedzanie Pragi', 380);
INSERT INTO wycieczki VALUES (3, 'Warszawa', 200);
INSERT INTO wycieczki VALUES (4, 'Zakopane + Oswiecim', 290);
INSERT INTO wycieczki VALUES (5, 'Ryga Tallinn Sztokholm Promem', 1080);
INSERT INTO wycieczki VALUES (6, 'Lodz zoo i orientarium', 100);
INSERT INTO wycieczki VALUES (7, 'Morawy', 850);
INSERT INTO wycieczki VALUES (8, 'Drezno + Szwajcaria Saksonska', 750);
INSERT INTO wycieczki VALUES (9, 'Splyw pontonowy po Dunajcu', 170);
INSERT INTO wycieczki VALUES (10, 'Litwa', 800);
INSERT INTO wycieczki VALUES (11, 'Tyrol', 600);
INSERT INTO wycieczki VALUES (12, 'Budapeszt', 680);

-- PRZEWODNICY (ADMINISTRATORZY)
INSERT INTO przewodnicy VALUES (1, 'Dominik', 'Szymanski', 'Polska, Ukraina', 'domszy', '94431cca18795eb2657298496d77e127');
INSERT INTO przewodnicy VALUES (2, 'Milosz', 'Marciniak', 'Austria, Alpy, Budapeszt, Wieden', 'milmar', '724c09fc11bd69e36d0df172be78f1df');
INSERT INTO przewodnicy VALUES (3, 'Rafal', 'Sobczak', 'Czechy, Slowacja', 'rafsob', '78fb9501ef8fae10eb4eed01b7212b4c');
INSERT INTO przewodnicy VALUES (4, 'Olaf', 'Borkowski', 'Litwa, Lotwa, Estonia, Szwecja, Finlandia', 'olabor', '0d9c7ae93090ca6e10c832a60ebf2382');
INSERT INTO przewodnicy VALUES (5, 'Ignacy', 'Zalewski', 'Niemcy', 'ignzal', 'de4446330b547b4c600ec8b0c8c804a3');


-- WYCIECZKI KLIENTA
INSERT INTO wycieczki_klientow VALUES (1, TO_DATE('2025-03-20', 'YYYY-MM-DD'), 'Parking M1 Czeladz', 4, 5);
INSERT INTO wycieczki_klientow VALUES (2, TO_DATE('2025-04-05', 'YYYY-MM-DD'), NULL, 6, 11);
INSERT INTO wycieczki_klientow VALUES (3, TO_DATE('2025-05-10', 'YYYY-MM-DD'), 'Centrum Przesiadkowe Katowice Sadowa', 8, 1);
INSERT INTO wycieczki_klientow VALUES (4, TO_DATE('2025-03-01', 'YYYY-MM-DD'), 'McDonald''s Stacja Shell Sosnowiec', 5, 5);
INSERT INTO wycieczki_klientow VALUES (5, TO_DATE('2025-04-22', 'YYYY-MM-DD'), 'Centrum Przesiadkowe Katowice Sadowa', 8, 8);
INSERT INTO wycieczki_klientow VALUES (6, TO_DATE('2025-04-15', 'YYYY-MM-DD'), 'Parking M1 Czeladz', 2, 5);
INSERT INTO wycieczki_klientow VALUES (7, TO_DATE('2025-03-28', 'YYYY-MM-DD'), 'Centrum Przesiadkowe Katowice Sadowa', 3, 1);
INSERT INTO wycieczki_klientow VALUES (8, TO_DATE('2025-04-12', 'YYYY-MM-DD'), 'Centrum Przesiadkowe Katowice Sadowa', 1, 10);

COMMIT;