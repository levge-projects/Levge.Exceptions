<img src="icon.png" width="100" height="100" alt="Levge.Exceptions logo" />

# Levge.Exceptions

[![Build Status](https://github.com/levge-projects/Levge.Exceptions/actions/workflows/main.yml/badge.svg)](https://github.com/levge-projects/Levge.Exceptions/actions/workflows/main.yml)
[![NuGet](https://img.shields.io/nuget/v/Levge.Exceptions.svg)](https://www.nuget.org/packages/Levge.Exceptions)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

[English](README.md) | T�rk�e

## A��klama

Levge.Exceptions, Levge .NET ekosistemi genelinde kullan�lmak �zere merkezi bir istisna k�t�phanesi sunar. Daha s�rd�r�lebilir ve tutarl� hata y�netimi olu�turmaya yard�mc� olan yap�land�r�lm��, anlamsal istisna t�rleri sunar.

### �zellikler

- T�m Levge istisnalar� i�in temel istisna s�n�f�
- Yayg�n senaryolar i�in �zelle�tirilmi� istisnalar (bulunamad�, do�rulama, �ak��ma, yetkisiz)
- HTTP durum kodlar�yla temiz entegrasyon
- Tutarl� hata mesajla�mas�
- .NET 8.0 i�in geli�tirilmi�tir

## Kurulum

NuGet Paket Y�neticisi ile kurulum:
```
dotnet add package Levge.Exceptions
```

## Kullan�m

### Temel Kullan�m

```csharp
using Levge.Exceptions;

// Temel istisna
throw new LevgeException("Levge bile�eninde bir hata olu�tu.");

// Bulunamad� istisnas�
throw new LevgeNotFoundException("Kullan�c�", 42);
```

### Do�rulama �stisnalar�

```csharp
// Tek alan do�rulama
throw new LevgeValidationException("Email", "Ge�ersiz e-posta bi�imi.");

// �oklu alan do�rulamalar�
throw new LevgeValidationException(new Dictionary<string, string[]>
{
    ["Email"] = new[] { "Zorunlu" },
    ["�ifre"] = new[] { "�ok k�sa", "Bir say� i�ermeli" }
});
```

### Yetkilendirme ve �ak��ma �stisnalar�

```csharp
// Yetkisiz istisnas�
throw new LevgeUnauthorizedException();

// �ak��ma istisnas�
throw new LevgeConflictException("Kaynak zaten mevcut.");

// Alana �zg� �ak��ma
throw LevgeConflictException.ForField("Email", "test@example.com");
```

## API Dok�mantasyonu

### LevgeException

T�m �zel Levge istisnalar� i�in temel istisna s�n�f�.

#### Yap�c�lar

- `LevgeException()`: Varsay�lan ayarlarla yeni bir �rnek olu�turur.
- `LevgeException(string message)`: Belirtilen mesajla yeni bir �rnek olu�turur.
- `LevgeException(string message, Exception innerException)`: Belirtilen mesaj ve i� istisna ile yeni bir �rnek olu�turur.

### LevgeNotFoundException

�stenen bir kaynak bulunamad���nda f�rlat�lan istisna.

#### Yap�c�lar

- `LevgeNotFoundException(string resource, object? key = null)`: Belirtilen kaynak ad� ve iste�e ba�l� anahtarla yeni bir �rnek olu�turur.

### LevgeValidationException

Do�rulama hatalar� olu�tu�unda f�rlat�lan istisna.

#### �zellikler

- `IReadOnlyDictionary<string, string[]> Errors`: Alan adlar�n� ve bunlarla ili�kili do�rulama hata mesajlar�n� i�eren bir s�zl�k al�r.

#### Yap�c�lar

- `LevgeValidationException(Dictionary<string, string[]> errors)`: Birden �ok do�rulama hatas� ile yeni bir �rnek olu�turur.
- `LevgeValidationException(string field, string message)`: Tek bir do�rulama hatas� ile yeni bir �rnek olu�turur.

### LevgeUnauthorizedException

Bir kullan�c� bir eylemi ger�ekle�tirme veya bir kayna�a eri�me yetkisine sahip olmad���nda f�rlat�lan istisna.

#### Yap�c�lar

- `LevgeUnauthorizedException()`: Varsay�lan bir mesajla yeni bir �rnek olu�turur.
- `LevgeUnauthorizedException(string message)`: Belirtilen bir mesajla yeni bir �rnek olu�turur.
- `LevgeUnauthorizedException(string message, Exception innerException)`: Belirtilen bir mesaj ve i� istisna ile yeni bir �rnek olu�turur.

### LevgeConflictException

Genellikle zaten var olan bir kaynak olu�turmaya �al���rken bir kaynak �ak��mas� olu�tu�unda f�rlat�lan istisna.

#### Yap�c�lar

- `LevgeConflictException(string message = "Resource already exists.")`: �ste�e ba�l� �zel bir mesajla yeni bir �rnek olu�turur.

#### Metodlar

- `ForField(string field, object? value = null)`: Zaten kullan�mda olan belirli bir alan i�in yeni bir �rnek olu�turur.

## Ba��ml�l�klar

- .NET 8.0

## Lisans

MIT � [Levge](https://github.com/levge-projects)