# 4. Use EntityFrameworkCore ORM

Date: 2026-06-27

## Status

Accepted

## Context

This project initially mantained by one developer, we need ORM to avoid using raw queries and to ensure type-safety using LINQ Expression

## Decision

We Installed Microsoft.EntityFrameworkCore.Design and Microsoft.EntityFrameworkCore.Sqlite

## Consequences

This decision would safe us a lot of time and Make Debugging Database related issue much easier.

The performance overhead it introduced is justifyable since this project is local-first application.
