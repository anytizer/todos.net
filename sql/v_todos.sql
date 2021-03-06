-- SHOW CREATE VIEW v_todos;
DROP VIEW IF EXISTS v_todos;
CREATE VIEW v_todos AS
-- EXPLAIN
SELECT
	-- *
	-- ts.todo_status_id,
	u.user_id, u.user_username, u.user_fullname,
	t.todo_id,
	p.project_id, p.project_name,
	s.status_id, s.status_shortname status_name,
	ts.added_on, t.issue_number, t.todo_text
FROM todo_todos t
INNER JOIN todo_todos_statuses ts ON ts.todo_id = t.todo_id
INNER JOIN todo_statuses s ON s.status_id = ts.status_id
INNER JOIN todo_projects_todos pd ON pd.todo_id = t.todo_id
INNER JOIN todo_projects p ON p.project_id = pd.project_id
INNER JOIN todo_users_projects up ON p.project_id = up.project_id
INNER JOIN todo_users u ON u.user_id = up.user_id
WHERE
	t.is_active='Y'
	AND s.is_active='Y'
	AND s.in_list='Y'
	AND ts.is_latest='Y'
ORDER BY
	s.status_priority,
	ts.added_on DESC
;