# Personel Yönetim API

Bu proje, ASP.NET Core Web API kullanılarak geliştirilmiş basit bir Personel Yönetim Sistemi API'sidir.

## Kullanılan Teknolojiler

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- REST API
- Visual Studio

## Proje Özellikleri

API üzerinden temel CRUD işlemleri gerçekleştirilebilir:

- Personel ekleme
- Tüm personelleri listeleme
- ID'ye göre personel getirme
- Personel bilgilerini güncelleme
- Personel silme

## Personel Modeli

Personel bilgileri aşağıdaki alanlardan oluşmaktadır:

- Id
- Ad
- Soyad
- Departman
- Maaş

## API İşlemleri

| İşlem | HTTP Metodu | Açıklama |
|---|---|---|
| Personelleri Getir | GET | Tüm personelleri listeler |
| Personel Getir | GET | ID'ye göre personel getirir |
| Personel Ekle | POST | Yeni personel ekler |
| Personel Güncelle | PUT | Personel bilgilerini günceller |
| Personel Sil | DELETE | Personeli siler |

## Veritabanı

Projede Entity Framework Core Code First yaklaşımı kullanılmıştır.

Migration işlemleri ile SQL Server üzerinde veritabanı ve Personeller tablosu oluşturulmaktadır.

## Projenin Amacı

Bu proje ASP.NET Core Web API, Entity Framework Core, SQL Server ve CRUD işlemlerini uygulamalı olarak öğrenmek amacıyla geliştirilmiştir.
