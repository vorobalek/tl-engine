# TL.Engine

Локальный запуск одной командой:

```bash
docker compose up --build
```

После старта:

- приложение: `http://localhost:5000`
- SQL Server: `localhost:14333`
- SQL login: `sa`
- SQL password: `TlEngine12345!`

Что важно:

- этот проект без правок кода работает только с SQL Server, не с PostgreSQL
- первый старт может занять 10-30 секунд: создаётся БД и применяются миграции
- `docker compose` собирает приложение через `Dockerfile`, который повторяет старую bat-схему запуска: `TL.Engine.dll` и `Extensions/` оказываются рядом в отдельном runtime-каталоге
- пароль пользователя `sa` внутри самого TL Engine в миграциях не задан; это не тот же `sa`, что у SQL Server

Остановить и удалить контейнеры:

```bash
docker compose down
```

Остановить и удалить контейнеры вместе с БД:

```bash
docker compose down -v
```
