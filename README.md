# 🔍 Blazor Subtext Matcher

A simple full-stack web application built with **Blazor**, **.NET Web API**, and **xUnit** that allows users to input a `text` and a `subtext`, and returns the positions where the subtext occurs in the main text — case-insensitively and allowing multiple matches.

---

## ✨ Features

- ✅ Blazor WebAssembly front-end UI
- ✅ .NET Web API back-end with matching logic
- ✅ Case-insensitive substring match with multiple occurrences
- ✅ Unit test coverage using xUnit
- ✅ GitHub Actions CI/CD workflow for deployment
- ✅ Ready to deploy to Azure App Service

---

## 🖼️ User Interface

- Input field for `text`
- Input field for `subtext`
- Match button triggers the search
- Output shows all starting character positions of the matches (1-based)

---

## 🧪 Test Coverage

Unit tests located in `MatchApi.Tests` include:
- Basic matches
- Repeated/multiple matches
- Empty input handling
- No match edge case

Run tests with:

```bash
dotnet test
