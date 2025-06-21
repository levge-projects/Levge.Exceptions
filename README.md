<img src="icon.png" width="100" height="100" alt="Levge.Exceptions logo" />

# Levge.Exceptions

[![Build Status](https://github.com/levge-projects/Levge.Exceptions/actions/workflows/main.yml/badge.svg)](https://github.com/levge-projects/Levge.Exceptions/actions/workflows/main.yml)
[![NuGet](https://img.shields.io/nuget/v/Levge.Exceptions.svg)](https://www.nuget.org/packages/Levge.Exceptions)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

English | [Türkçe](README.tr.md)

## Description

Levge.Exceptions provides a centralized exception library for use across the Levge .NET ecosystem. It offers structured, semantic exception types that help create more maintainable and consistent error handling.

### Features

- Base exception class for all Levge exceptions
- Specialized exceptions for common scenarios (not found, validation, conflict, unauthorized)
- Clean integration with HTTP status codes
- Consistent error messaging
- Built for .NET 8.0

## Installation

Install via NuGet Package Manager:dotnet add package Levge.Exceptions
## Usage

### Basic Usage
using Levge.Exceptions;

// Basic exception
throw new LevgeException("An error occurred in a Levge component.");

// Not found exception
throw new LevgeNotFoundException("User", 42);
### Validation Exceptions
// Single field validation
throw new LevgeValidationException("Email", "Invalid email format.");

// Multiple field validations
throw new LevgeValidationException(new Dictionary<string, string[]>
{
    ["Email"] = new[] { "Required" },
    ["Password"] = new[] { "Too short", "Must contain a number" }
});
### Authorization and Conflict Exceptions
// Unauthorized exception
throw new LevgeUnauthorizedException();

// Conflict exception
throw new LevgeConflictException("Resource already exists.");

// Field-specific conflict
throw LevgeConflictException.ForField("Email", "test@example.com");
## API Documentation

### LevgeException

Base exception class for all custom Levge exceptions.

#### Constructors

- `LevgeException()`: Initializes a new instance with default settings.
- `LevgeException(string message)`: Initializes a new instance with the specified message.
- `LevgeException(string message, Exception innerException)`: Initializes a new instance with the specified message and inner exception.

### LevgeNotFoundException

Exception thrown when a requested resource cannot be found.

#### Constructors

- `LevgeNotFoundException(string resource, object? key = null)`: Initializes a new instance with the specified resource name and optional key.

### LevgeValidationException

Exception thrown when validation errors occur.

#### Properties

- `IReadOnlyDictionary<string, string[]> Errors`: Gets a dictionary of field names and their associated validation error messages.

#### Constructors

- `LevgeValidationException(Dictionary<string, string[]> errors)`: Initializes a new instance with multiple validation errors.
- `LevgeValidationException(string field, string message)`: Initializes a new instance with a single validation error.

### LevgeUnauthorizedException

Exception thrown when a user is not authorized to perform an action or access a resource.

#### Constructors

- `LevgeUnauthorizedException()`: Initializes a new instance with a default message.
- `LevgeUnauthorizedException(string message)`: Initializes a new instance with a specified message.
- `LevgeUnauthorizedException(string message, Exception innerException)`: Initializes a new instance with a specified message and inner exception.

### LevgeConflictException

Exception thrown when a resource conflict occurs, typically when trying to create a resource that already exists.

#### Constructors

- `LevgeConflictException(string message = "Resource already exists.")`: Initializes a new instance with an optional custom message.

#### Methods

- `ForField(string field, object? value = null)`: Creates a new instance for a specific field that is already in use.

## Dependencies

- .NET 8.0

## License

MIT © [Levge](https://github.com/levge-projects)
