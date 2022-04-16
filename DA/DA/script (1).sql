create user super identified by pw;
grant create session to super;
grant select on dba_users to super;
grant select on dba_roles to super;
grant select on dba_tables to super;
grant select on dba_sys_privs to super;
grant select on dba_role_privs to super;
grant select on dba_tab_privs to super;

grant all privileges to super with admin option;

create or replace procedure sp_viewuser
as
    c sys_refcursor;
begin
    open c for
    select username, default_tablespace, created, last_login, account_status
    from dba_users;
    dbms_sql.return_result(c);
    close c;
end;
/
create or replace procedure sp_createuser(usr varchar2, pw varchar2)
as
    usr_exist number := 0;
begin
    select count(*) into usr_exist from dba_users where username = usr;
    if usr_exist > 0 then
    begin
        dbms_output.put_line('User already existed');
        return;
    end;
    else 
    begin
        execute immediate('create user '||usr||' identified by '||'pw');
        execute immediate('grant connect to '||usr);
        dbms_output.put_line('User created successfully');
    end;
    end if;
end;
/
create or replace procedure sp_createrole(role_name varchar2)
as
    role_exist number := 0;
begin
    select count(*) into role_exist from dba_roles where role = role_name;
    if role_exist > 0 then
    begin
        dbms_output.put_line('Role already existed');
        return;
    end;
    else 
    begin
        execute immediate ('create role '||role_name);
        dbms_output.put_line('User created successfully');
    end;
    end if;
end;
/
create or replace procedure sp_viewprivs_user(usr varchar2)
as
    c sys_refcursor;
begin
    open c for
    select grantee, grantor, privilege, table_name, grantable
    from dba_tab_privs
    where grantee = upper(usr);
    dbms_sql.return_result(c);
    close c;
end;
/
create or replace procedure sp_viewprivs_role(role_name varchar2)
as
    c sys_refcursor;
begin
    open c for
    select grantee, granted_role, admin_option, delegate_option
    from dba_role_privs
    where grantee = upper(role_name);
    dbms_sql.return_result(c);
    close c;
end;
/
create or replace procedure sp_dropuser(usr varchar2)
as
    usr_exist number := 0;
begin
    select count(*) into usr_exist from dba_users where username = usr;
    if usr_exist > 0 then
    begin
        dbms_output.put_line('User does not exist');
        return;
    end;
    else 
    begin
        execute immediate ('drop user '||usr);
        dbms_output.put_line('User dropped successfully');
    end;
    end if;
end;
/
create or replace procedure sp_droprole(role_name varchar2)
as
    role_exist number := 0;
begin
    select count(*) into role_exist from dba_roles where role = role_name;
    if role_exist > 0 then 
    begin
        dbms_output.put_line('Role does not exist');
        return;
    end;
    else 
    begin
        execute immediate ('drop role '||role_name);
        dbms_output.put_line('Role dropped successfully');
    end;
    end if;
end;
/
create or replace procedure sp_alteruser_lock(usr varchar2)
as
    usr_exist number := 0;
    usr_lock VARCHAR2(10) := 'OPEN';
begin
    select count(*) into usr_exist from dba_users where username = usr;
    if usr_exist > 0 then
    begin
        dbms_output.put_line('User does not exist');
        return;
    end;
    else 
    begin
        select account_status into usr_lock from dba_users where username = upper(usr);
        if usr_lock = 'OPEN' then usr_lock := 'lock';
        else usr_lock := 'unlock';
        end if;
        execute immediate ('alter user '||usr||' account '||usr_lock);
    end;
    end if;
end;
/
create or replace procedure sp_alteruser_password(usr varchar2, pw varchar2)
as
    usr_exist number := 0;
begin
    select count(*) into usr_exist from dba_users where username = usr;
    if usr_exist > 0 then 
    begin
        dbms_output.put_line('User does not exist');
        return;
    end;
    else 
    begin
        execute immediate ('alter user '||usr||' identified by '||pw);
        dbms_output.put_line('Password changed sucessfully');
    end;
    end if;
end;
/
create or replace procedure sp_alteruser_expire(usr varchar2)
as
    usr_exist number := 0;
begin
    select count(*) into usr_exist from dba_users where username = usr;
    if usr_exist > 0 then
    begin
        dbms_output.put_line('User does not exist');
        return;
    end;
    else 
    begin
        execute immediate ('alter user '||usr||' password expire');
        dbms_output.put_line('Alteration completed');
    end;
    end if;
end;
/
create or replace procedure sp_grantpriv_tab(grantee varchar2, tab_name varchar2, priv varchar2, opt boolean)
as
    usr_exist number := 0;
    tab_exist number := 0;
    with_opt varchar2(15) := '';
begin
    select count(*) into usr_exist from dba_users where username = grantee;
    select count(*) into tab_exist from dba_tables where table_name = tab_name;
    if opt = TRUE then with_opt := 'with grant option';
    end if;
    if usr_exist > 0 and tab_exist > 0 then
    begin
        dbms_output.put_line('User does not exist');
        return;
    end;
    else 
    begin
        execute immediate ('grant '||priv||' on '||tab_name||' to '||grantee||with_opt);
        dbms_output.put_line('Grant successfully');
    end;
    end if;
end;
/
create or replace procedure sp_revokepriv(usr varchar2, tab_name varchar2, priv varchar2)
as
    priv_exist number := 0;
begin
    select count(*) into priv_exist from dba_tab_privs 
    where grantee = usr and table_name = tab_name and privilege = priv;
    if priv_exist > 0 then
    begin
        dbms_output.put_line('User privilege not granted');
        return;
    end;
    else 
    begin
        execute immediate ('revoke '||priv||' on '||tab_name||' from '||usr);
        dbms_output.put_line('Revoke successfully');
    end;
    end if;
end;
