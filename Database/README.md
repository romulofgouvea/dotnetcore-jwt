### Erros
Caso o ip do conainter pgadmin4 nao funcione automatico no localhost execute:

```bash
docker inspect <id-container> | grep 0.0.0.0
```