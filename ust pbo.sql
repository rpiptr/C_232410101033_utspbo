toc.dat                                                                                             0000600 0004000 0002000 00000012235 14713362611 0014446 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP   1                
    |            uts_pbo    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false         �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false         �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false         �           1262    19061    uts_pbo    DATABASE     ~   CREATE DATABASE uts_pbo WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE uts_pbo;
                postgres    false         �            1259    19063    akun    TABLE     �   CREATE TABLE public.akun (
    id_akun integer NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL
);
    DROP TABLE public.akun;
       public         heap    postgres    false         �            1259    19062    akun_id_akun_seq    SEQUENCE     �   CREATE SEQUENCE public.akun_id_akun_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.akun_id_akun_seq;
       public          postgres    false    216         �           0    0    akun_id_akun_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.akun_id_akun_seq OWNED BY public.akun.id_akun;
          public          postgres    false    215         �            1259    19085    barang    TABLE     �   CREATE TABLE public.barang (
    id_barang integer NOT NULL,
    nama_barang character varying NOT NULL,
    kategori character varying NOT NULL,
    jumlah integer NOT NULL,
    harga integer NOT NULL
);
    DROP TABLE public.barang;
       public         heap    postgres    false         �            1259    19084    barang_id_barang_seq    SEQUENCE     �   CREATE SEQUENCE public.barang_id_barang_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.barang_id_barang_seq;
       public          postgres    false    218         �           0    0    barang_id_barang_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.barang_id_barang_seq OWNED BY public.barang.id_barang;
          public          postgres    false    217         U           2604    19066    akun id_akun    DEFAULT     l   ALTER TABLE ONLY public.akun ALTER COLUMN id_akun SET DEFAULT nextval('public.akun_id_akun_seq'::regclass);
 ;   ALTER TABLE public.akun ALTER COLUMN id_akun DROP DEFAULT;
       public          postgres    false    216    215    216         V           2604    19088    barang id_barang    DEFAULT     t   ALTER TABLE ONLY public.barang ALTER COLUMN id_barang SET DEFAULT nextval('public.barang_id_barang_seq'::regclass);
 ?   ALTER TABLE public.barang ALTER COLUMN id_barang DROP DEFAULT;
       public          postgres    false    218    217    218         �          0    19063    akun 
   TABLE DATA           ;   COPY public.akun (id_akun, username, password) FROM stdin;
    public          postgres    false    216       4847.dat �          0    19085    barang 
   TABLE DATA           Q   COPY public.barang (id_barang, nama_barang, kategori, jumlah, harga) FROM stdin;
    public          postgres    false    218       4849.dat �           0    0    akun_id_akun_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.akun_id_akun_seq', 1, true);
          public          postgres    false    215         �           0    0    barang_id_barang_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.barang_id_barang_seq', 1, true);
          public          postgres    false    217         X           2606    19070    akun akun_id_akun_key 
   CONSTRAINT     S   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_id_akun_key UNIQUE (id_akun);
 ?   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_id_akun_key;
       public            postgres    false    216         Z           2606    19074    akun akun_password_key 
   CONSTRAINT     U   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_password_key UNIQUE (password);
 @   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_password_key;
       public            postgres    false    216         \           2606    19072    akun akun_username_key 
   CONSTRAINT     U   ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_username_key UNIQUE (username);
 @   ALTER TABLE ONLY public.akun DROP CONSTRAINT akun_username_key;
       public            postgres    false    216         ^           2606    19092    barang barang_id_barang_key 
   CONSTRAINT     [   ALTER TABLE ONLY public.barang
    ADD CONSTRAINT barang_id_barang_key UNIQUE (id_barang);
 E   ALTER TABLE ONLY public.barang DROP CONSTRAINT barang_id_barang_key;
       public            postgres    false    218                                                                                                                                                                                                                                                                                                                                                                           4847.dat                                                                                            0000600 0004000 0002000 00000000024 14713362611 0014260 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	admin	admin1
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            4849.dat                                                                                            0000600 0004000 0002000 00000000042 14713362611 0014262 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	Fruit tea	Minuman	100	3000
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              restore.sql                                                                                         0000600 0004000 0002000 00000011146 14713362611 0015373 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 16.2
-- Dumped by pg_dump version 16.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE uts_pbo;
--
-- Name: uts_pbo; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE uts_pbo WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';


ALTER DATABASE uts_pbo OWNER TO postgres;

\connect uts_pbo

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: akun; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.akun (
    id_akun integer NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL
);


ALTER TABLE public.akun OWNER TO postgres;

--
-- Name: akun_id_akun_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.akun_id_akun_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.akun_id_akun_seq OWNER TO postgres;

--
-- Name: akun_id_akun_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.akun_id_akun_seq OWNED BY public.akun.id_akun;


--
-- Name: barang; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.barang (
    id_barang integer NOT NULL,
    nama_barang character varying NOT NULL,
    kategori character varying NOT NULL,
    jumlah integer NOT NULL,
    harga integer NOT NULL
);


ALTER TABLE public.barang OWNER TO postgres;

--
-- Name: barang_id_barang_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.barang_id_barang_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.barang_id_barang_seq OWNER TO postgres;

--
-- Name: barang_id_barang_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.barang_id_barang_seq OWNED BY public.barang.id_barang;


--
-- Name: akun id_akun; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.akun ALTER COLUMN id_akun SET DEFAULT nextval('public.akun_id_akun_seq'::regclass);


--
-- Name: barang id_barang; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.barang ALTER COLUMN id_barang SET DEFAULT nextval('public.barang_id_barang_seq'::regclass);


--
-- Data for Name: akun; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.akun (id_akun, username, password) FROM stdin;
\.
COPY public.akun (id_akun, username, password) FROM '$$PATH$$/4847.dat';

--
-- Data for Name: barang; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.barang (id_barang, nama_barang, kategori, jumlah, harga) FROM stdin;
\.
COPY public.barang (id_barang, nama_barang, kategori, jumlah, harga) FROM '$$PATH$$/4849.dat';

--
-- Name: akun_id_akun_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.akun_id_akun_seq', 1, true);


--
-- Name: barang_id_barang_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.barang_id_barang_seq', 1, true);


--
-- Name: akun akun_id_akun_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_id_akun_key UNIQUE (id_akun);


--
-- Name: akun akun_password_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_password_key UNIQUE (password);


--
-- Name: akun akun_username_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.akun
    ADD CONSTRAINT akun_username_key UNIQUE (username);


--
-- Name: barang barang_id_barang_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.barang
    ADD CONSTRAINT barang_id_barang_key UNIQUE (id_barang);


--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          