use [Olympic-stats];

truncate table Sports_category;

--���������������: ����� + 0.34�

insert into Sports_category values

--������� ������� 3, � ��������� 2, ��������� 1 ���� ������

--=============================== �� ��������  =================================--

--����������� ��� F11-F13 ������ �� ������ ������������

-- F13 � ������� �����������
	('��', '0:0:7.0', null, 1, 1, 3), ('��', '0:0:11.2', null, 1, 2, 3),('��', '0:0:23.2', null, 1, 3, 3),('��', '0:0:52.5', null, 1, 4, 3),
	('��', '0:2:0.0', null, 1, 5, 3), ('��', '0:4:10.0', null, 1, 6, 3),('��', '0:16:0.0', null, 1, 7, 3),('��', '0:34:45.0', null, 1, 8, 3),
-- � ���������
	('��', '0:0:23.9', null, 1, 3, 2),('��', '0:0:53.5', null, 1, 4, 2),('��', '0:2:2.0', null, 1, 5, 2), ('��', '0:4:12.0', null, 1, 6, 2),
-- �� ������� ����������
	('��', null, 6.40, 1, 9, 1),  ('��', null, 1.85, 1, 10, 1),('��', null, 13.50, 1, 11, 1), --������
	('��', null, 39.50, 1, 15, 1),('��', null, 45.0, 1, 14, 1),('��', null, 50.0, 1, 19, 1), --����� (800 ��) ��� �����
	('��', null, 13.60, 1, 25, 1),--('��', null, 1.85, 1, 23, 1), --���� ��


-- F12 � ������� �����������
	('��', '0:0:7.1', null, 5, 1, 3), ('��', '0:0:11.4', null, 5, 2, 3),('��', '0:0:23.8', null, 5, 3, 3),('��', '0:0:53.4', null, 5, 4, 3),
	('��', '0:2:2.5', null, 5, 5, 3), ('��', '0:4:12.0', null, 5, 6, 3),('��', '0:16:10.0', null, 5, 7, 3),('��', '0:35:00.0', null, 5, 8, 3),
-- � ���������
	('��', '0:0:24.7', null, 5, 3, 2),('��', '0:0:54.4', null, 5, 4, 2),('��', '0:2:4.5', null, 5, 5, 2), ('��', '0:4:15.0', null, 5, 6, 2),
-- �� ������� ����������
	('��', null, 6.35, 5, 9, 1),  ('��', null, 1.80, 5, 10, 1),('��', null, 13.40, 5, 11, 1), --������
	('��', null, 38.50, 5, 15, 1),('��', null, 44.0, 5, 14, 1),('��', null, 49.0, 5, 19, 1), --����� (800 ��) ��� �����
	('��', null, 13.40, 5, 25, 1),--('��', null, 1.85, 5, 23, 1), --���� ��


-- F11 � ������� �����������
	('��', '0:0:7.6', null, 9, 1, 3), ('��', '0:0:12.4', null, 9, 2, 3),('��', '0:0:25.5', null, 9, 3, 3),('��', '0:0:56.8', null, 9, 4, 3),
	('��', '0:2:12.0', null, 9, 5, 3), ('��', '0:4:35.0', null, 9, 6, 3),('��', '0:17:35.0', null, 9, 7, 3),('��', '0:39:00.0', null, 9, 8, 3),
-- � ���������
	('��', '0:0:27.0', null, 9, 3, 2),('��', '0:0:58.8', null, 9, 4, 2),('��', '0:2:15.0', null, 9, 5, 2), ('��', '0:4:40.0', null, 9, 6, 2),
-- �� ������� ����������
	('��', null, 5.50, 9, 9, 1),  ('��', null, 1.40, 9, 10, 1),('��', null, 11.20, 9, 11, 1), --������
	('��', null, 31.0, 9, 15, 1),('��', null, 36.50, 9, 14, 1),('��', null, 34.0, 9, 19, 1), --����� (800 ��) ��� �����
	('��', null, 11.60, 9, 25, 1),--('��', null, 1.85, 9, 23, 1), --���� ��


--=============================== ����  ������� =================================--

-- F13 � ������� �����������
								  ('����', '0:0:11.24', null, 1, 2, 3),('����', '0:0:22.64', null, 1, 3, 3),('����', '0:0:50.84', null, 1, 4, 3),
	('����', '0:1:57.94', null, 1, 5, 3), ('����', '0:3:58.54', null, 1, 6, 3),('����', '0:15:30.24', null, 1, 7, 3),('����', '0:32:50.24', null, 1, 8, 3),
-- �� ������� ����������
	('����', null, 6.80, 1, 9, 1),  ('����', null, 1.90, 1, 10, 1),('����', null, 14.25, 1, 11, 1), --������
	('����', null, 42.0, 1, 15, 1),('����', null, 57.0, 1, 19, 1), --����� (800 ��) ��� �����
	('����', null, 14.70, 1, 25, 1),--('��', null, 1.85, 1, 23, 1), --���� ��


-- F12 � ������� �����������
								  ('����', '0:0:11.34', null, 5, 2, 3),('����', '0:0:22.84', null, 5, 3, 3),('����', '0:0:51.24', null, 5, 4, 3),
	('����', '0:1:58.84', null, 5, 5, 3), ('����', '0:3:59.74', null, 5, 6, 3),('����', '0:15:40.24', null, 5, 7, 3),('����', '0:33:5.24', null, 5, 8, 3),
-- �� ������� ����������
	('����', null, 6.75, 5, 9, 1),  ('����', null, 1.86, 5, 10, 1),('����', null, 14.15, 5, 11, 1), --������
	('����', null, 41.0, 5, 15, 1),('����', null, 56.0, 5, 19, 1), --����� (800 ��) ��� �����
	('����', null, 14.50, 5, 25, 1),--('��', null, 1.85, 5, 23, 1), --���� ��


-- F11 � ������� �����������
								   ('����', '0:0:12.24', null, 9, 2, 3),('����', '0:0:24.64', null, 9, 3, 3),('����', '0:0:54.24', null, 9, 4, 3),
	('����', '0:2:3.84', null, 9, 5, 3), ('����', '0:4:10.84', null, 9, 6, 3),('����', '0:16:10.24', null, 9, 7, 3),('����', '0:34:5.24', null, 9, 8, 3),
-- �� ������� ����������
	('����', null, 5.85, 9, 9, 1),  ('����', null, 1.50, 9, 10, 1),('����', null, 12.0, 9, 11, 1), --������
	('����', null, 34.50, 9, 15, 1),('����', null, 38.50, 9, 19, 1), --����� (800 ��) ��� �����
	('����', null, 12.50, 9, 25, 1),--('��', null, 1.85, 9, 23, 1), --���� ��


--=============================== �� �������  =================================--

-- F13 � ������� �����������
	('��', '0:0:7.9', null, 3, 1, 3), ('��', '0:0:13.0', null, 3, 2, 3),('��', '0:0:26.8', null, 3, 3, 3),('��', '0:1:2.0', null, 3, 4, 3),
	('��', '0:2:26.5', null, 3, 5, 3), ('��', '0:5:12.0', null, 3, 6, 3),('��', '0:20:0.0', null, 3, 7, 3),('��', '0:46:00.0', null, 3, 8, 3),
-- � ���������
	('��', '0:0:27.6', null, 3, 3, 2),('��', '0:1:3.0', null, 3, 4, 2),('��', '0:2:28.5', null, 3, 5, 2), ('��', '0:5:15.0', null, 3, 6, 2),
-- �� ������� ����������
	('��', null, 5.10, 3, 9, 1),  ('��', null, 1.45, 3, 10, 1), --������
	('��', null, 35.0, 3, 13, 1),('��', null, 34.0, 3, 17, 1),('��', null, 32.0, 3, 18, 1),
	('��', null, 11.50, 3, 21, 1),('��', null, 10.80, 3, 22, 1),


-- F12 � ������� �����������
	('��', '0:0:8.0', null, 7, 1, 3), ('��', '0:0:13.2', null, 7, 2, 3),('��', '0:0:27.2', null, 7, 3, 3),('��', '0:1:3.5', null, 7, 4, 3),
	('��', '0:2:28.0', null, 7, 5, 3), ('��', '0:5:15.0', null, 7, 6, 3),('��', '0:20:14.0', null, 7, 7, 3),('��', '0:46:30.0', null, 7, 8, 3),
-- � ���������
	('��', '0:0:28.2', null, 7, 3, 2),('��', '0:1:4.5', null, 7, 4, 2),('��', '0:2:31.0', null, 7, 5, 2), ('��', '0:5:18.0', null, 7, 6, 2),
-- �� ������� ����������
	('��', null, 5.0, 7, 9, 1),  ('��', null, 1.40, 7, 10, 1), --������
	('��', null, 33.50, 7, 13, 1),('��', null, 33.50, 7, 17, 1),('��', null, 31.0, 7, 18, 1),
	('��', null, 11.30, 7, 21, 1),('��', null, 10.60, 7, 22, 1),


-- F11 � ������� �����������
	('��', '0:0:8.9', null, 11, 1, 3), ('��', '0:0:14.1', null, 11, 2, 3),('��', '0:0:29.4', null, 11, 3, 3),('��', '0:1:9.0', null, 11, 4, 3),
	('��', '0:2:39.0', null, 11, 5, 3), ('��', '0:5:59.0', null, 11, 6, 3),('��', '0:29:50.0', null, 11, 7, 3),('��', '0:59:0.0', null, 11, 8, 3),
-- � ���������
	('��', '0:0:30.8', null, 11, 3, 2),('��', '0:1:11.0', null, 11, 4, 2),('��', '0:2:45.0', null, 11, 5, 2), ('��', '0:6:5.0', null, 11, 6, 2),
-- �� ������� ����������
	('��', null, 4.10, 11, 9, 1),  ('��', null, 1.25, 11, 10, 1), --������
	('��', null, 23.50, 11, 13, 1),('��', null, 23.0, 11, 17, 1),('��', null, 23.0, 11, 18, 1),
	('��', null, 10.0, 11, 21, 1),('��', null, 8.50, 11, 22, 1),	
	

--=============================== ���� �������  =================================--

-- F13 � ������� �����������
								   ('����', '0:0:12.84', null, 3, 2, 3),('����', '0:0:25.74', null, 3, 3, 3),('����', '0:0:59.24', null, 3, 4, 3),
	('����', '0:2:20.84', null, 3, 5, 3), ('����', '0:4:57.24', null, 3, 6, 3),('����', '0:18:30.0', null, 3, 7, 3),('����', '0:39:0.0', null, 3, 8, 3),
-- �� ������� ����������
	('����', null, 5.45, 3, 9, 1),  ('��', null, 1.50, 3, 10, 1), --������
	('����', null, 38.50, 3, 13, 1),('��', null, 38.0, 3, 18, 1),
	('����', null, 12.70, 3, 22, 1),


-- F12 � ������� �����������
								   ('����', '0:0:12.94', null, 7, 2, 3),('����', '0:0:25.94', null, 7, 3, 3),('����', '0:0:59.74', null, 7, 4, 3),
	('����', '0:2:21.84', null, 7, 5, 3), ('����', '0:4:59.24', null, 7, 6, 3),('����', '0:18:42.0', null, 7, 7, 3),('����', '0:39:25.0', null, 7, 8, 3),
-- �� ������� ����������
	('����', null, 5.35, 7, 9, 1),  ('����', null, 1.45, 7, 10, 1), --������
	('����', null, 37.50, 7, 13, 1),('����', null, 37.0, 7, 18, 1),
	('����', null, 12.50, 7, 22, 1),
	

-- F11 � ������� �����������
								   ('����', '0:0:13.44', null, 11, 2, 3),('����', '0:0:26.94', null, 11, 3, 3),('����', '0:1:3.24', null, 11, 4, 3),
	('����', '0:2:29.84', null, 11, 5, 3), ('����', '0:5:24.0', null, 11, 6, 3),('����', '0:23:0.0', null, 11, 7, 3),('����', '0:45:0.0', null, 11, 8, 3),
-- �� ������� ����������
	('����', null, 4.45, 11, 9, 1),  ('����', null, 1.30, 11, 10, 1), --������
	('����', null, 27.0, 11, 13, 1),('����', null, 30.0, 11, 18, 1),
	('����', null, 10.50, 11, 22, 1),





-- ----------------------------- T11-T13 

-- T13 � ������� �����������
	('��', '0:0:7.0', null, 2, 1, 3), ('��', '0:0:11.2', null, 2, 2, 3),('��', '0:0:23.2', null, 2, 3, 3),('��', '0:0:52.5', null, 2, 4, 3),
	('��', '0:2:0.0', null, 2, 5, 3), ('��', '0:4:10.0', null, 2, 6, 3),('��', '0:16:0.0', null, 2, 7, 3),('��', '0:34:45.0', null, 2, 8, 3),
-- � ���������
	('��', '0:0:23.9', null, 2, 3, 2),('��', '0:0:53.5', null, 2, 4, 2),('��', '0:2:2.0', null, 2, 5, 2), ('��', '0:4:12.0', null, 2, 6, 2),
-- �� ������� ����������
	('��', null, 6.40, 2, 9, 1),  ('��', null, 1.85, 2, 10, 1),('��', null, 13.50, 2, 11, 1), --������
	('��', null, 39.50, 2, 15, 1),('��', null, 45.0, 2, 14, 1),('��', null, 50.0, 2, 19, 1), --����� (800 ��) ��� �����
	('��', null, 13.60, 2, 25, 1),--('��', null, 1.85, 2, 23, 1), --���� ��


-- F12 � ������� �����������
	('��', '0:0:7.1', null, 6, 1, 3), ('��', '0:0:11.4', null, 6, 2, 3),('��', '0:0:23.8', null, 6, 3, 3),('��', '0:0:53.4', null, 6, 4, 3),
	('��', '0:2:2.5', null, 6, 5, 3), ('��', '0:4:12.0', null, 6, 6, 3),('��', '0:16:10.0', null, 6, 7, 3),('��', '0:35:00.0', null, 6, 8, 3),
-- � ���������
	('��', '0:0:24.7', null, 6, 3, 2),('��', '0:0:54.4', null, 6, 4, 2),('��', '0:2:4.5', null, 6, 5, 2), ('��', '0:4:15.0', null, 6, 6, 2),
-- �� ������� ����������
	('��', null, 6.35, 6, 9, 1),  ('��', null, 1.80, 6, 10, 1),('��', null, 13.40, 6, 11, 1), --������
	('��', null, 38.50, 6, 15, 1),('��', null, 44.0, 6, 14, 1),('��', null, 49.0, 6, 19, 1), --����� (800 ��) ��� �����
	('��', null, 13.40, 6, 25, 1),--('��', null, 1.85, 6, 23, 1), --���� ��


-- F11 � ������� �����������
	('��', '0:0:7.6', null, 10, 1, 3), ('��', '0:0:12.4', null, 10, 2, 3),('��', '0:0:25.5', null, 10, 3, 3),('��', '0:0:56.8', null, 10, 4, 3),
	('��', '0:2:12.0', null, 10, 5, 3), ('��', '0:4:35.0', null, 10, 6, 3),('��', '0:17:35.0', null, 10, 7, 3),('��', '0:39:00.0', null, 10, 8, 3),
-- � ���������
	('��', '0:0:27.0', null, 10, 3, 2),('��', '0:0:58.8', null, 10, 4, 2),('��', '0:2:15.0', null, 10, 5, 2), ('��', '0:4:40.0', null, 10, 6, 2),
-- �� ������� ����������
	('��', null, 5.50, 10, 9, 1),  ('��', null, 1.40, 10, 10, 1),('��', null, 11.20, 10, 11, 1), --������
	('��', null, 31.0, 10, 15, 1),('��', null, 36.50, 10, 14, 1),('��', null, 34.0, 10, 19, 1), --����� (800 ��) ��� �����
	('��', null, 11.60, 10, 25, 1),--('��', null, 1.85, 10, 23, 1), --���� ��


--=============================== ����  ������� =================================--

-- F13 � ������� �����������
								  ('����', '0:0:11.24', null, 2, 2, 3),('����', '0:0:22.64', null, 2, 3, 3),('����', '0:0:50.84', null, 2, 4, 3),
	('����', '0:1:57.94', null, 2, 5, 3), ('����', '0:3:58.54', null, 2, 6, 3),('����', '0:15:30.24', null, 2, 7, 3),('����', '0:32:50.24', null, 2, 8, 3),
-- �� ������� ����������
	('����', null, 6.80, 2, 9, 1),  ('����', null, 1.90, 2, 10, 1),('����', null, 14.25, 2, 11, 1), --������
	('����', null, 42.0, 2, 15, 1),('����', null, 57.0, 2, 19, 1), --����� (800 ��) ��� �����
	('����', null, 14.70, 2, 25, 1),--('��', null, 1.85, 1, 23, 1), --���� ��


-- F12 � ������� �����������
								  ('����', '0:0:11.34', null, 6, 2, 3),('����', '0:0:22.84', null, 6, 3, 3),('����', '0:0:51.24', null, 6, 4, 3),
	('����', '0:1:58.84', null, 6, 5, 3), ('����', '0:3:59.74', null, 6, 6, 3),('����', '0:15:40.24', null, 6, 7, 3),('����', '0:33:5.24', null, 6, 8, 3),
-- �� ������� ����������
	('����', null, 6.75, 6, 9, 1),  ('����', null, 1.86, 6, 10, 1),('����', null, 14.15, 6, 11, 1), --������
	('����', null, 41.0, 6, 15, 1),('����', null, 56.0, 6, 19, 1), --����� (800 ��) ��� �����
	('����', null, 14.50, 6, 25, 1),--('��', null, 1.85, 6, 23, 1), --���� ��


-- F11 � ������� �����������
								   ('����', '0:0:12.24', null, 10, 2, 3),('����', '0:0:24.64', null, 10, 3, 3),('����', '0:0:54.24', null, 10, 4, 3),
	('����', '0:2:3.84', null, 10, 5, 3), ('����', '0:4:10.84', null, 10, 6, 3),('����', '0:16:10.24', null, 10, 7, 3),('����', '0:34:5.24', null, 10, 8, 3),
-- �� ������� ����������
	('����', null, 5.85, 10, 9, 1),  ('����', null, 1.50, 10, 10, 1),('����', null, 12.0, 10, 11, 1), --������
	('����', null, 34.50, 10, 15, 1),('����', null, 38.50, 10, 19, 1), --����� (800 ��) ��� �����
	('����', null, 12.50, 10, 25, 1),--('��', null, 1.85, 10, 23, 1), --���� ��


--=============================== �� �������  =================================--

-- F13 � ������� �����������
	('��', '0:0:7.9', null, 4, 1, 3), ('��', '0:0:13.0', null, 4, 2, 3),('��', '0:0:26.8', null, 4, 3, 3),('��', '0:1:2.0', null, 4, 4, 3),
	('��', '0:2:26.5', null, 4, 5, 3), ('��', '0:5:12.0', null, 4, 6, 3),('��', '0:20:0.0', null, 4, 7, 3),('��', '0:46:00.0', null, 4, 8, 3),
-- � ���������
	('��', '0:0:27.6', null, 4, 3, 2),('��', '0:1:3.0', null, 4, 4, 2),('��', '0:2:28.5', null, 4, 5, 2), ('��', '0:5:15.0', null, 4, 6, 2),
-- �� ������� ����������
	('��', null, 5.10, 4, 9, 1),  ('��', null, 1.45, 4, 10, 1), --������
	('��', null, 35.0, 4, 13, 1),('��', null, 34.0, 4, 17, 1),('��', null, 32.0, 4, 18, 1),
	('��', null, 11.50, 4, 21, 1),('��', null, 10.80, 4, 22, 1),


-- F12 � ������� �����������
	('��', '0:0:8.0', null, 8, 1, 3), ('��', '0:0:13.2', null, 8, 2, 3),('��', '0:0:27.2', null, 8, 3, 3),('��', '0:1:3.5', null, 8, 4, 3),
	('��', '0:2:28.0', null, 8, 5, 3), ('��', '0:5:15.0', null, 8, 6, 3),('��', '0:20:14.0', null, 8, 7, 3),('��', '0:46:30.0', null, 8, 8, 3),
-- � ���������
	('��', '0:0:28.2', null, 8, 3, 2),('��', '0:1:4.5', null, 8, 4, 2),('��', '0:2:31.0', null, 8, 5, 2), ('��', '0:5:18.0', null, 8, 6, 2),
-- �� ������� ����������
	('��', null, 5.0, 8, 9, 1),  ('��', null, 1.40, 8, 10, 1), --������
	('��', null, 33.50, 8, 13, 1),('��', null, 33.50, 8, 17, 1),('��', null, 31.0, 8, 18, 1),
	('��', null, 11.30, 8, 21, 1),('��', null, 10.60, 8, 22, 1),


-- F11 � ������� �����������
	('��', '0:0:8.9', null, 12, 1, 3), ('��', '0:0:14.1', null, 12, 2, 3),('��', '0:0:29.4', null, 12, 3, 3),('��', '0:1:9.0', null, 12, 4, 3),
	('��', '0:2:39.0', null, 12, 5, 3), ('��', '0:5:59.0', null, 12, 6, 3),('��', '0:29:50.0', null, 12, 7, 3),('��', '0:59:0.0', null, 12, 8, 3),
-- � ���������
	('��', '0:0:30.8', null, 12, 3, 2),('��', '0:1:11.0', null, 12, 4, 2),('��', '0:2:45.0', null, 12, 5, 2), ('��', '0:6:5.0', null, 12, 6, 2),
-- �� ������� ����������
	('��', null, 4.10, 12, 9, 1),  ('��', null, 1.25, 12, 10, 1), --������
	('��', null, 23.50, 12, 13, 1),('��', null, 23.0, 12, 17, 1),('��', null, 23.0, 12, 18, 1),
	('��', null, 10.0, 12, 21, 1),('��', null, 8.50, 12, 22, 1),	
	

--=============================== ���� �������  =================================--

-- F13 � ������� �����������
								   ('����', '0:0:12.84', null, 4, 2, 3),('����', '0:0:25.74', null, 4, 3, 3),('����', '0:0:59.24', null, 4, 4, 3),
	('����', '0:2:20.84', null, 4, 5, 3), ('����', '0:4:57.24', null, 4, 6, 3),('����', '0:18:30.0', null, 4, 7, 3),('����', '0:39:0.0', null, 4, 8, 3),
-- �� ������� ����������
	('����', null, 5.45, 4, 9, 1),  ('����', null, 1.50, 4, 10, 1), --������
	('����', null, 38.50, 4, 13, 1),('����', null, 38.0, 4, 18, 1),
	('����', null, 12.70, 4, 22, 1),


-- F12 � ������� �����������
								   ('����', '0:0:12.94', null, 8, 2, 3),('����', '0:0:25.94', null, 8, 3, 3),('����', '0:0:59.74', null, 8, 4, 3),
	('����', '0:2:21.84', null, 8, 5, 3), ('����', '0:4:59.24', null, 8, 6, 3),('����', '0:18:42.0', null, 8, 7, 3),('����', '0:39:25.0', null, 8, 8, 3),
-- �� ������� ����������
	('����', null, 5.35, 8, 9, 1),  ('����', null, 1.45, 8, 10, 1), --������
	('����', null, 37.50, 8, 13, 1),('����', null, 37.0, 8, 18, 1),
	('����', null, 12.50, 8, 22, 1),
	

-- F11 � ������� �����������
								   ('����', '0:0:13.44', null, 12, 2, 3),('����', '0:0:26.94', null, 12, 3, 3),('����', '0:1:3.24', null, 12, 4, 3),
	('����', '0:2:29.84', null, 12, 5, 3), ('����', '0:5:24.0', null, 12, 6, 3),('����', '0:23:0.0', null, 12, 7, 3),('����', '0:45:0.0', null, 12, 8, 3),
-- �� ������� ����������
	('����', null, 4.45, 12, 9, 1),  ('����', null, 1.30, 12, 10, 1), --������
	('����', null, 27.0, 12, 13, 1),('����', null, 30.0, 12, 18, 1),
	('����', null, 10.50, 12, 22, 1)

	;


--	��������������� � �������� ��� � ��� � ���������

-- �������� ��������������� ��� �11-�13 ����

--������� ��������� ������� � �������� ���� ���������� T11-T13 ��� ������� ������������ ������� ����������
--������� update ��� ������� +0.34 � �������� ������� � ������� �� ���� � ������ ���������� (������ id-3, ���� id-4) (������ � ��������� id-2, ���� id-8)