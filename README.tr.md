<img src="icon.png" width="100" height="100" alt="Levge.Exceptions logo" />

# Levge.Exceptions

[![Build Status](https://github.com/levge-projects/Levge.Exceptions/actions/workflows/main.yml/badge.svg)](https://github.com/levge-projects/Levge.Exceptions/actions/workflows/main.yml)
[![NuGet](https://img.shields.io/nuget/v/Levge.Exceptions.svg)](https://www.nuget.org/packages/Levge.Exceptions)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

[English](README.md) | Türkçe

## Açýklama

Levge.Exceptions, Levge .NET ekosistemi genelinde kullanýlmak üzere merkezi bir istisna kütüphanesi sunar. Daha sürdürülebilir ve tutarlý hata yönetimi oluþturmaya yardýmcý olan yapýlandýrýlmýþ, anlamsal istisna türleri sunar.

### Özellikler

- Tüm Levge istisnalarý için temel istisna sýnýfý
- Yaygýn senaryolar için özelleþtirilmiþ istisnalar (bulunamadý, doðrulama, çakýþma, yetkisiz)
- HTTP durum kodlarýyla temiz entegrasyon
- Tutarlý hata mesajlaþmasý
- .NET 8.0 için geliþtirilmiþtir

## Kurulum

NuGet Paket Yöneticisi ile kurulum:
```
dotnet add package Levge.Exceptions
```

## Kullaným

### Temel Kullaným

```csharp
using Levge.Exceptions;

// Temel istisna
throw new LevgeException("Levge bileþeninde bir hata oluþtu.");

// Bulunamadý istisnasý
throw new LevgeNotFoundException("Kullanýcý", 42);
```

### Doðrulama Ýstisnalarý

```csharp
// Tek alan doðrulama
throw new LevgeValidationException("Email", "Geçersiz e-posta biçimi.");

// Çoklu alan doðrulamalarý
throw new LevgeValidationException(new Dictionary<string, string[]>
{
    ["Email"] = new[] { "Zorunlu" },
    ["Þifre"] = new[] { "Çok kýsa", "Bir sayý içermeli" }
});
```

### Yetkilendirme ve Çakýþma Ýstisnalarý

```csharp
// Yetkisiz istisnasý
throw new LevgeUnauthorizedException();

// Çakýþma istisnasý
throw new LevgeConflictException("Kaynak zaten mevcut.");

// Alana özgü çakýþma
throw LevgeConflictException.ForField("Email", "test@example.com");
```

## API Dokümantasyonu

### LevgeException

Tüm özel Levge istisnalarý için temel istisna sýnýfý.

#### Yapýcýlar

- `LevgeException()`: Varsayýlan ayarlarla yeni bir örnek oluþturur.
- `LevgeException(string message)`: Belirtilen mesajla yeni bir örnek oluþturur.
- `LevgeException(string message, Exception innerException)`: Belirtilen mesaj ve iç istisna ile yeni bir örnek oluþturur.

### LevgeNotFoundException

Ýstenen bir kaynak bulunamadýðýnda fýrlatýlan istisna.

#### Yapýcýlar

- `LevgeNotFoundException(string resource, object? key = null)`: Belirtilen kaynak adý ve isteðe baðlý anahtarla yeni bir örnek oluþturur.

### LevgeValidationException

Doðrulama hatalarý oluþtuðunda fýrlatýlan istisna.

#### Özellikler

- `IReadOnlyDictionary<string, string[]> Errors`: Alan adlarýný ve bunlarla iliþkili doðrulama hata mesajlarýný içeren bir sözlük alýr.

#### Yapýcýlar

- `LevgeValidationException(Dictionary<string, string[]> errors)`: Birden çok doðrulama hatasý ile yeni bir örnek oluþturur.
- `LevgeValidationException(string field, string message)`: Tek bir doðrulama hatasý ile yeni bir örnek oluþturur.

### LevgeUnauthorizedException

Bir kullanýcý bir eylemi gerçekleþtirme veya bir kaynaða eriþme yetkisine sahip olmadýðýnda fýrlatýlan istisna.

#### Yapýcýlar

- `LevgeUnauthorizedException()`: Varsayýlan bir mesajla yeni bir örnek oluþturur.
- `LevgeUnauthorizedException(string message)`: Belirtilen bir mesajla yeni bir örnek oluþturur.
- `LevgeUnauthorizedException(string message, Exception innerException)`: Belirtilen bir mesaj ve iç istisna ile yeni bir örnek oluþturur.

### LevgeConflictException

Genellikle zaten var olan bir kaynak oluþturmaya çalýþýrken bir kaynak çakýþmasý oluþtuðunda fýrlatýlan istisna.

#### Yapýcýlar

- `LevgeConflictException(string message = "Resource already exists.")`: Ýsteðe baðlý özel bir mesajla yeni bir örnek oluþturur.

#### Metodlar

- `ForField(string field, object? value = null)`: Zaten kullanýmda olan belirli bir alan için yeni bir örnek oluþturur.

## Baðýmlýlýklar

- .NET 8.0

## Lisans

MIT © [Levge](https://github.com/levge-projects)