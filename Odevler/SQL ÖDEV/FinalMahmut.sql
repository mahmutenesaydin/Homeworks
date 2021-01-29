Create Database TarimUretim
Go
Use TarimUretim
Go
Create Table Bolgeler
(
	BolgeNo Int Identity Primary Key,
	BolgeAdi Varchar(100) Unique,
	Aktif Bit Default 1
)
Go
Create Table Iller
(
	PlakaKodu Int Primary Key,
	BolgeNo Int,
	IlAdi Varchar(50) Unique,
	TelefonKodu Varchar(5) Unique,
	Aktif Bit Default 1
	Constraint FK_Il_Bolge Foreign Key(BolgeNo) References Bolgeler(BolgeNo)
)
Go
Create Table Urunler
(
	UrunNo Int Identity Primary Key,
	UrunAdi Varchar(100) Unique
)
Go
Create Table UrunDonemleri
(
	DonemNo Int Identity Primary Key,
	DonemTanimi Varchar(50) Unique,
	Aktif Bit Default 1
)
Go
Create Table IlUrunleri
(
	PlakaKodu Int,
	DonemNo Int,
	UrunNo Int,
	Miktar Int,
	Constraint FK_IlUrun_PlakaKodu Foreign Key(PlakaKodu)References Iller(PlakaKodu),
	Constraint FK_IlUrun_DonemNo Foreign Key(DonemNo)References UrunDonemleri(DonemNo),
	Constraint FK_IlUrun_UrunNo Foreign Key(UrunNo)References Urunler(UrunNo)
)
Go
Create Proc SP_BolgeEkle
(
	@BolgeAdi Varchar(100),
	@Aktif Bit
)
As
Begin 
	Insert Into Bolgeler(BolgeAdi,Aktif) Values(@BolgeAdi, @Aktif)
End
Go
Exec SP_BolgeEkle 'Marmara Bölgesi',1
Go
Exec SP_BolgeEkle 'Ege Bölgesi',1
Go
Exec SP_BolgeEkle 'Akdeniz Bölgesi',1
Go
Exec SP_BolgeEkle 'Ýç Anadolu Bölgesi',1
Go
Exec SP_BolgeEkle 'Karadeniz Bölgesi',1
Go
Exec SP_BolgeEkle 'Doðu Anadolu Bölgesi',1
Go
Exec SP_BolgeEkle 'Güneydoðu Anadolu Bölgesi',1
go

Create Proc SP_IlEkle
(
	@PlakaKodu Int,
	@IlAdi Varchar(50),
	@TelefonKodu Varchar(5),
	@Aktif Bit,
	@BolgeNo int,
	@SatirSayisi Int Output
)
As
Begin
	Insert Into Iller(PlakaKodu,IlAdi,TelefonKodu,Aktif,BolgeNo)
	Values(@PlakaKodu,@IlAdi,@TelefonKodu,@Aktif,@BolgeNo)
	Select @SatirSayisi = @@ROWCOUNT
End
Go

Declare @ss Int;
Exec SP_IlEkle 17,'Çanakkale','286',1,1,@ss output
Exec SP_IlEkle 35,'Ýzmir','232',1,2,@ss output
Exec SP_IlEkle 7,'Antalya','242',1,3,@ss output
Exec SP_IlEkle 42,'Konya','332',1,4,@ss output
Exec SP_IlEkle 52,'Ordu','452',1,5,@ss output
Exec SP_IlEkle 25,'Erzurum','442',1,6,@ss output
Exec SP_IlEkle 63,'Þanlýurfa','414',1,7,@ss output
go

select * from Iller

Create proc SP_DonemEkle
(
	@DonemTanimi varchar(50),
	@Aktif bit
)
as
Begin
	Declare @i int
	Begin Try
		Insert into UrunDonemleri(DonemTanimi,Aktif)
		values (@DonemTanimi,@Aktif)
		select @i = @@ROWCOUNT
	End Try
	Begin Catch
		select @i = ERROR_NUMBER()
	End Catch
	return @i
End
go

Exec SP_DonemEkle '2010 Yýlý',1
Go
Exec SP_DonemEkle '2011 Yýlý',1
Go
Exec SP_DonemEkle '2012 Yýlý',1
Go
Exec SP_DonemEkle '2013 Yýlý',1
Go
Exec SP_DonemEkle '2014 Yýlý',1
Go
Exec SP_DonemEkle '2015 Yýlý',1
Go
Exec SP_DonemEkle '2016 Yýlý',1

go

Create Proc SP_UrunEkle
(
	@UrunAdi varchar(100)
)
as
Begin
	Declare @i int
	Begin Try
		if exists (Select * from Urunler where UrunAdi=@UrunAdi)
			select @i = 0
		else
		Begin
		Insert into Urunler(UrunAdi)values(@UrunAdi)
			select @i = 1
		End 
	End Try
	Begin Catch 
		Select @i = -1
	End Catch
	Return @i
End
go

Exec SP_UrunEkle 'Domates'
Go
Exec SP_UrunEkle 'Ýncir'
Go
Exec SP_UrunEkle 'Portakal'
Go
Exec SP_UrunEkle 'Buðday'
Go
Exec SP_UrunEkle 'Fýndýk'
Go
Exec SP_UrunEkle 'Arpa'
Go
Exec SP_UrunEkle 'Mercimek'

go

create Proc SP_IlUrunleriEkle
(
	@PlakaKodu int,
	@UrunNo int,
	@DonemNo int,
	@Miktar int,
	@Mesaj varchar(100) output
)
as
Begin
	Begin Try 
		Insert into IlUrunleri(PlakaKodu,UrunNo,DonemNo,Miktar)
		values (@PlakaKodu,@UrunNo,@DonemNo,@Miktar)
		set @Mesaj = 'Ürün baþarýyla kaydedildi'
	End Try
	Begin Catch
		set @Mesaj = 'Eklemeye çalýþtýðýnýz verilerden biri ya da bir kaçý tanýmlý deðil!'
	End Catch
End
go

Declare @m varchar(150)
Exec SP_IlUrunleriEkle 17,1,1,500000,@m output;
Exec SP_IlUrunleriEkle 35,2,2,250000,@m output;
Exec SP_IlUrunleriEkle 7,3,3,125000, @m output;
Exec SP_IlUrunleriEkle 42,4,4,354235, @m output;
Exec SP_IlUrunleriEkle 52,5,5,225000, @m output;
Exec SP_IlUrunleriEkle 25,6,6,154200,@m output;
Exec SP_IlUrunleriEkle 63,7,7,25000,@m output;

go-------------------------


Create view VW_ViewFinal
with encryption
as
Select 
	B.BolgeAdi,
	I.IlAdi,
	U.UrunAdi,
	UD.DonemTanimi,
	IU.Miktar
from Bolgeler B
join Iller I on I.BolgeNo=B.BolgeNo
join IlUrunleri IU on IU.PlakaKodu=I.PlakaKodu
join Urunler U on U.UrunNo=IU.UrunNo
join UrunDonemleri UD on UD.DonemNo=IU.DonemNo

go ----------------------- 

Create Function FN_BolgeUretimHesapla
(
	@BolgeNo int
)
returns int
as
Begin
	Declare @Miktar int
	Select @Miktar = SUM(IU.Miktar)
	from Bolgeler B
	join Iller I on I.BolgeNo=B.BolgeNo
	join IlUrunleri IU on IU.PlakaKodu=I.PlakaKodu
	where B.BolgeNo=@BolgeNo
	return @Miktar
End

go

Create Function Fn_BolgeyeGoreUretim
(
	@BolgeNo int
)
Returns table
as
	Return Select 
	B.BolgeAdi,
	I.IlAdi,
	U.UrunAdi,
	UD.DonemTanimi,
	IU.Miktar
	from Bolgeler B
	join Iller I on I.BolgeNo=B.BolgeNo
	join IlUrunleri IU on IU.PlakaKodu=I.PlakaKodu
	join Urunler U on U.UrunNo=IU.UrunNo
	join UrunDonemleri UD on UD.DonemNo=IU.DonemNo
	where B.BolgeNo=@BolgeNo
go

create function FN_DonemeGoreUretim
(
	@DonemNo int
)
Returns table
as
	Return Select
	B.BolgeAdi,
	I.IlAdi,
	U.UrunAdi,
	UD.DonemTanimi,
	IU.Miktar
	from Bolgeler B
	join Iller I on I.BolgeNo=B.BolgeNo
	join IlUrunleri IU on IU.PlakaKodu=I.PlakaKodu
	join Urunler U on U.UrunNo=IU.UrunNo
	join UrunDonemleri UD on UD.DonemNo=IU.DonemNo
	where UD.DonemNo=@DonemNo


go---------------------------------------


Create Trigger TR_BolgeSil
on Bolgeler
Instead of Delete
as
	declare @BolgeNo int
	select @BolgeNo = BolgeNo From Deleted
	update Bolgeler set Aktif = 0 where BolgeNo=@BolgeNo
go

Create Trigger TR_IlSil
on Iller
Instead Of Delete
as
	Declare @PlakaKodu int
	select @PlakaKodu = PlakaKodu from deleted
	update Iller set Aktif = 0 where PlakaKodu = @PlakaKodu
go

Create Trigger TR_UrunDonemiSil
on UrunDonemleri
Instead of Delete
as
	Declare @DonemNo int
	select @DonemNo = DonemNo from Deleted
	update UrunDonemleri set Aktif = 0 where DonemNo=@DonemNo


go--------------------------


Create Table DonemUretim
(
	DonemID int,
	ToplamUretim int
)

