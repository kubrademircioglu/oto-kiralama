--create table arac(
--arac_id int identity(1,1),
--ucret_id int,
--marka varchar(20),
--model varchar(30),
--yýl int,
--yakýt varchar(30),
--vites varchar(30),
--km varchar(max),
--renk varchar(30),
--kasa_tipi varchar(30),

--)
--USE [veritabani]
--GO
--/****** Object:  Trigger [dbo].[tr_silinmis]    
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE trigger [dbo].[tr_ekle] on [dbo].[ekleKullanici]
--after insert
--as
--begin

--declare @kullaniciNo int
--declare @kullaniciAd varchar(50)
--declare @kullaniciSifre varchar(50)
--declare @yetkiTuru varchar(15)
--select @kullaniciNo=kullaniciNo from inserted
--select @kullaniciAd=kullaniciAd from inserted
--select @kullaniciSifre=kullaniciSifre from inserted
--select @yetkiTuru=yetkiTuru from inserted
--insert into ekle_kullanici values(@kullaniciNo,@kullaniciAd,@kullaniciSifre,@yetkiTuru)

--end


--USE [veritabani]
--GO
--/****** Object:  Trigger [dbo].[tr_silinmis]    
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE trigger [dbo].[tr_sil] on [dbo].[ekleKullanici]
--after delete
--as
--begin

--declare @kullaniciNo int
--declare @kullaniciAd varchar(50)
--declare @kullaniciSifre varchar(50)
--declare @yetkiTuru varchar(15)
--select @kullaniciNo=kullaniciNo from deleted
--select @kullaniciAd=kullaniciAd from deleted
--select @kullaniciSifre=kullaniciSifre from deleted
--select @yetkiTuru=yetkiTuru from inserted
--insert into silinmis_kullanici values(@kullaniciNo,@kullaniciAd,@kullaniciSifre,@yetkiTuru)

--end

--create table ucret(
--arac_id int,
--ucret_id int identity(1,1),
--ucret money,
--gun_bilgisi varchar(50)
--)


--create table ekle_müsteri(
--musteri_id int identity,
--ad varchar(20) not null,
--soyad varchar(20) not null,
--tc varchar(11) not null,
--tel_no varchar(11) not null,
--yas  int,
--kan_grubu varchar(20) not null,
--adres nvarchar(max) not null,

--)

--USE [veritabani]
--GO
--/****** Object:  Trigger [dbo].[tr_silinmis]    
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE trigger [dbo].[tr_ekle_mus] on [dbo].[müsteri]
--after insert
--as
--begin

--declare @ad varchar(50)
--declare @soyad varchar(50)
--declare @tc varchar(15)
--declare @tel_no int
--declare @yas int
--declare @kan_grubu varchar(50)
--declare @adres varchar(max)
--select @ad=ad from inserted
--select @soyad=soyad from inserted
--select @tc=tc from inserted
--select @tel_no=tel_no from inserted
--select @yas=yas from inserted
--select @kan_grubu=kan_grubu from inserted
--select @adres=adres from inserted
--insert into ekle_müsteri values(@ad,@soyad,@tc,@tel_no,@yas,@kan_grubu,@adres)

--end