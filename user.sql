create user super identified by pw;
grant create session to super;
grant select on dba_users to super;
grant select on dba_roles to super;
grant select on dba_tables to super;
grant select on dba_sys_privs to super;
grant select on dba_role_privs to super;
grant select on role_sys_privs to super;
grant select on dba_tab_privs to super;

grant all privileges to super with admin option;