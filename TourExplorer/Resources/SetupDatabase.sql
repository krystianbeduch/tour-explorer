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
INSERT INTO klient VALUES (1, 'Julian', 'Zawadzki');
INSERT INTO klient VALUES (2, 'Amadeusz', 'Wozniak');
INSERT INTO klient VALUES (3, 'Zuzanna', 'Wroblewska');
INSERT INTO klient VALUES (4, 'Emilia', 'Gorska');
INSERT INTO klient VALUES (5, 'Sergiusz', 'Kaczmarczyk');
INSERT INTO klient VALUES (6, 'Denis', 'Duda');
INSERT INTO klient VALUES (7, 'Kordian', 'Czarnecki');
INSERT INTO klient VALUES (8, 'Ariel', 'Przybylski');

-- WYCIECZKI
INSERT INTO wycieczka VALUES (1, 'Jarmark w Wiedniu', 450);
INSERT INTO wycieczka VALUES (2, 'Zwiedzanie Pragi', 380);
INSERT INTO wycieczka VALUES (3, 'Warszawa', 200);
INSERT INTO wycieczka VALUES (4, 'Zakopane + Oswiecim', 290);
INSERT INTO wycieczka VALUES (5, 'Ryga Tallinn Sztokholm Promem', 1080);
INSERT INTO wycieczka VALUES (6, 'Lodz zoo i orientarium', 100);
INSERT INTO wycieczka VALUES (7, 'Morawy', 850);
INSERT INTO wycieczka VALUES (8, 'Drezno + Szwajcaria Saksonska', 750);
INSERT INTO wycieczka VALUES (9, 'Splyw pontonowy po Dunajcu', 170);
INSERT INTO wycieczka VALUES (10, 'Litwa', 800);
INSERT INTO wycieczka VALUES (11, 'Tyrol', 600);
INSERT INTO wycieczka VALUES (12, 'Budapeszt', 680);

-- PRZEWODNICY (ADMINISTRATORZY)
INSERT INTO przewodnik VALUES (1, 'Dominik', 'Szymanski', 'Polska, Ukraina');
INSERT INTO przewodnik VALUES (2, 'Milosz', 'Marciniak', 'Austria, Alpy, Budapeszt, Wieden');
INSERT INTO przewodnik VALUES (3, 'Rafal', 'Sobczak', 'Czechy, Slowacja');
INSERT INTO przewodnik VALUES (4, 'Olaf', 'Borkowski', 'Litwa, Lotwa, Estonia, Szwecja, Finlandia');
INSERT INTO przewodnik VALUES (5, 'Ignacy', 'Zalewski', 'Niemcy');


-- WYCIECZKI KLIENTA
INSERT INTO wycieczka_klienta VALUES (1, TO_DATE('2025-03-20', 'YYYY-MM-DD'), 'Parking M1 Czeladz', 4, 5);
INSERT INTO wycieczka_klienta VALUES (2, TO_DATE('2025-04-05', 'YYYY-MM-DD'), NULL, 6, 11);
INSERT INTO wycieczka_klienta VALUES (3, TO_DATE('2025-05-10', 'YYYY-MM-DD'), 'Centrum Przesiadkowe Katowice Sadowa', 8, 1);
INSERT INTO wycieczka_klienta VALUES (4, TO_DATE('2025-03-01', 'YYYY-MM-DD'), 'McDonald''s Stacja Shell Sosnowiec', 5, 5);
INSERT INTO wycieczka_klienta VALUES (5, TO_DATE('2025-04-22', 'YYYY-MM-DD'), 'Centrum Przesiadkowe Katowice Sadowa', 8, 8);
INSERT INTO wycieczka_klienta VALUES (6, TO_DATE('2025-04-15', 'YYYY-MM-DD'), 'Parking M1 Czeladz', 2, 5);
INSERT INTO wycieczka_klienta VALUES (7, TO_DATE('2025-03-28', 'YYYY-MM-DD'), 'Centrum Przesiadkowe Katowice Sadowa', 3, 1);
INSERT INTO wycieczka_klienta VALUES (8, TO_DATE('2025-04-12', 'YYYY-MM-DD'), 'Centrum Przesiadkowe Katowice Sadowa', 1, 10);

COMMIT;