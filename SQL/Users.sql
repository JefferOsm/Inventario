CREATE EXTENSION IF NOT EXISTS pgcrypto;


-- Comandos usuario de lectura
GRANT USAGE ON SCHEMA public to lectura;
GRANT SELECT ON ALL SEQUENCES IN SCHEMA public TO lectura;
GRANT SELECT ON ALL TABLES IN SCHEMA public TO lectura;


-- Comandos usuario admin (read and only)
GRANT USAGE ON SCHEMA public to administrador;
GRANT USAGE ON ALL SEQUENCES IN SCHEMA public TO administrador;
GRANT SELECT,INSERT,UPDATE,DELETE ON ALL TABLES IN SCHEMA public TO administrador;

SELECT auth_scram('administrador','admin',rolpassword) FROM pg_authid WHERE rolname = 'administrador';




SELECT *FROM pg_authid