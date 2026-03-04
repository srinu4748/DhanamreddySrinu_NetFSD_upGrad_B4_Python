CREATE DATABASE EventDb;

USE EventDb;

CREATE TABLE UserInfo (
EmailId VARCHAR(100) PRIMARY KEY,
UserName VARCHAR(50) NOT NULL
CHECK (LEN(UserName) BETWEEN 1 AND 50),
Role VARCHAR(20) NOT NULL
CHECK (Role IN ('Admin','Participant')),
Password VARCHAR(20) NOT NULL
CHECK (LEN(Password) BETWEEN 6 AND 20)
);

CREATE TABLE EventDetails (
EventId INT PRIMARY KEY IDENTITY(1,1),
EventName VARCHAR(50) NOT NULL
CHECK (LEN(EventName) BETWEEN 1 AND 50),
EventCategory VARCHAR(50) NOT NULL
CHECK (LEN(EventCategory) BETWEEN 1 AND 50),
EventDate DATETIME NOT NULL,
Description VARCHAR(255) NULL,
Status VARCHAR(20) NOT NULL
CHECK (Status IN ('Active','In-Active'))
);

CREATE TABLE SpeakersDetails (
SpeakerId INT PRIMARY KEY IDENTITY(1,1),
SpeakerName VARCHAR(50) NOT NULL
CHECK (LEN(SpeakerName) BETWEEN 1 AND 50)
);

CREATE TABLE SessionInfo(
SessionId INT PRIMARY KEY IDENTITY(1,1),
EventId INT NOT NULL,
SessionTitle VARCHAR(50) NOT NULL
CHECK (LEN(SessionTitle) BETWEEN 1 AND 50),
SpeakerId INT NOT NULL,
Description VARCHAR(255) NULL,
SessionStart DATETIME NOT NULL,
SessionEnd DATETIME NOT NULL,
SessionUrl VARCHAR(255),
CONSTRAINT FK_Event
FOREIGN KEY (EventId)
REFERENCES EventDetails(EventId),
CONSTRAINT FK_Speaker
FOREIGN KEY (SpeakerId)
REFERENCES SpeakersDetails(SpeakerId)
);


CREATE TABLE ParticipantEventDetails
(
Id INT PRIMARY KEY IDENTITY(1,1),
ParticipantEmailId VARCHAR(100) NOT NULL,
EventId INT NOT NULL,
SessionId INT NOT NULL,
IsAttended BIT NOT NULL
CHECK (IsAttended IN (0,1)),
CONSTRAINT FK_Participant
FOREIGN KEY (ParticipantEmailId)
REFERENCES UserInfo(EmailId),
CONSTRAINT FK_EventDetails
FOREIGN KEY (EventId)
REFERENCES EventDetails(EventId),
CONSTRAINT FK_Session
FOREIGN KEY (SessionId)
REFERENCES SessionInfo(SessionId)
);

INSERT INTO UserInfo VALUES
('admin@gmail.com','AdminUser','Admin','admin123'),
('srinu@gmail.com','Srinu','Participant','srinu123');


INSERT INTO EventDetails(EventName,EventCategory,EventDate,Description,Status)
VALUES
('Tech Conference','Technology','2026-05-10','Technology Event','Active');


INSERT INTO SpeakersDetails(SpeakerName)
VALUES
('Ravi Kumar');


INSERT INTO SessionInfo
(EventId,SessionTitle,SpeakerId,Description,SessionStart,SessionEnd,SessionUrl)
VALUES
(1,'AI Future',1,'Discussion on AI',
'2026-05-10 10:00:00',
'2026-05-10 12:00:00',
'www.ai-session.com');


INSERT INTO ParticipantEventDetails
(ParticipantEmailId,EventId,SessionId,IsAttended)
VALUES
('srinu@gmail.com',1,1,1);

SELECT * FROM UserInfo;

SELECT * FROM EventDetails;

SELECT * FROM ParticipantEventDetails;

SELECT * FROM SessionInfo;

SELECT * FROM SpeakersDetails;

SELECT 
S.SessionTitle,
E.EventName,
SP.SpeakerName,
S.SessionStart,
S.SessionEnd
FROM SessionInfo S
JOIN EventDetails E
ON S.EventId = E.EventId
JOIN SpeakersDetails SP
ON S.SpeakerId = SP.SpeakerId;

SELECT 
U.UserName,
E.EventName,
S.SessionTitle,
P.IsAttended
FROM ParticipantEventDetails P
JOIN UserInfo U
ON P.ParticipantEmailId = U.EmailId
JOIN EventDetails E
ON P.EventId = E.EventId
JOIN SessionInfo S
ON P.SessionId = S.SessionId;