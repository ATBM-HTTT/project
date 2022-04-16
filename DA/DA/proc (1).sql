create or replace procedure sp_viewuser
as
    c sys_refcursor;
begin
    open c for
    select username, default_tablespace, created, last_login, account_status
    from dba_users;
    dbms_sql.return_result(c);
end;
/
create or replace procedure sp_viewrole
as
 c sys_refcursor;
 begin
    open c for
    select role, password_required, authentication_type, common 
    from dba_roles
    dbms_sql.return_result(c);
end;
/
create or replace procedure sp_createuser(usr varchar2, pw varchar2)
as
    usr_exist number := 0;
begin
    select count(*) into usr_exist from dba_users where username = upper(usr);
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
    select count(*) into role_exist from dba_roles where role = upper(role_name);
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
end;
/
create or replace procedure sp_viewprivs_role(role_name varchar2)
as
    c sys_refcursor;
begin
    open c for
    select role, privilege, admin_option
    from role_sys_privs
    where role = upper(role_name);
    dbms_sql.return_result(c);
end;
/
create or replace procedure sp_dropuser(usr varchar2)
as
    usr_exist number := 0;
begin
    select count(*) into usr_exist from dba_users where username = upper(usr);
    if usr_exist = 0 then
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
    select count(*) into role_exist from dba_roles where role = upper(role_name);
    if role_exist = 0 then 
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
    usr_lock VARCHAR2(10) := 'lock';
begin
    select count(*) into usr_exist from dba_users where username = upper(usr);
    if usr_exist = 0 then
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
    select count(*) into usr_exist from dba_users where username = upper(usr);
    if usr_exist = 0 then 
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
    select count(*) into usr_exist from dba_users where username = upper(usr);
    if usr_exist = 0 then
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
    with_opt varchar2(20) := ' ';
begin
    select count(*) into usr_exist from dba_users where username = upper(grantee);
    select count(*) into tab_exist from dba_tables where table_name = upper(tab_name);
    if opt = TRUE then with_opt := ' with grant option';
    end if;
    if usr_exist = 0 and tab_exist = 0 then
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
create or replace procedure sp_revokepriv_tab(usr varchar2, tab_name varchar2, priv varchar2)
as
    priv_exist number := 0;
begin
    select count(*) into priv_exist from dba_tab_privs 
    where grantee = upper(usr) and table_name = upper(tab_name) and privilege = upper(priv);
    if priv_exist = 0 then
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
/
create or replace procedure sp_alteruser_expire(usr varchar2)
as
    usr_exist number := 0;
begin
    select count(*) into usr_exist from dba_users where username = upper(usr);
    if usr_exist = 0 then
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
create or replace procedure sp_grantpriv_column(grantee varchar2, tab_name varchar2, col_name varchar2, priv varchar2, opt boolean)
as
    usr_exist number := 0;
    tab_exist number := 0;
    view_name varchar2(50);
    with_opt varchar2(20) := '';
begin
    select count(*) into usr_exist from dba_users where username = upper(grantee);
    select count(*) into tab_exist from dba_tables where table_name = upper(tab_name);
    if opt = TRUE then with_opt := ' with grant option';
    end if;
    if usr_exist = 0 and tab_exist = 0 then
    begin
        dbms_output.put_line('User does not exist');
        return;
    end;
    else 
    begin
        view_name := priv||'_'||col_name;
        execute immediate ('create or replace view '||view_name||' as select '||col_name||' from '||tab_name);
        execute immediate ('grant '||priv||' on '||view_name||' to '||grantee||with_opt);
        dbms_output.put_line('Grant successfully');
    end;
    end if;
end;

create or replace procedure sp_revokepriv_column(usr varchar2, col_name varchar2, priv varchar2)
as
    priv_exist number := 0;
    view_name varchar2(50) := priv||'_'||col_name;
begin
    select count(*) into priv_exist from dba_tab_privs 
    where grantee = upper(usr) and table_name = upper(view_name);
    if priv_exist = 0 then
    begin
        dbms_output.put_line('User privilege not granted');
        return;
    end;
    else 
    begin
        execute immediate ('revoke '||priv||' on '||view_name||' from '||usr);
        dbms_output.put_line('Revoke successfully');
    end;
    end if;
end;

create or replace procedure sp_revokerole(usr varchar2, role_name varchar2)
as
    priv_exist number := 0;
begin
    select count(*) into priv_exist from dba_role_privs 
    where grantee = upper(usr) and granted_role = upper(role_name);
    if priv_exist = 0 then
    begin
        dbms_output.put_line('Role not granted');
        return;
    end;
    else 
    begin
        execute immediate ('revoke '||role_name||' from '||usr);
        dbms_output.put_line('Revoke successfully');
    end;
    end if;
end;

create or replace procedure sp_grantrole(usr varchar2, role_name varchar2, opt boolean)
as
    role_exist number := 0;
    with_opt varchar(20) := 0;
begin
    select count(*) into role_exist from dba_roles
    where role = upper(role_name);
    if opt = TRUE then with_opt := ' with admin option';
    end if;
    if role_exist = 0 then
    begin
        dbms_output.put_line('Role does not exist');
        return;
    end;
    else 
    begin
        execute immediate ('grant '||role_name||' to '||usr||with_opt);
        dbms_output.put_line('Revoke successfully');
    end;
    end if;
end;
/
create or replace procedure sp_finduser(usr varchar2)
as
    c sys_refcursor;
begin
    open c for
    select * from dba_users where username = upper(usr);
    dbms_sql.return_result(c);
end;
/
create or replace procedure sp_findrole(role_name varchar2)
as
    c sys_refcursor;
begin
    open c for
    select * from dba_roles where role = upper(role_name);
    dbms_sql.return_result(c);
end;
