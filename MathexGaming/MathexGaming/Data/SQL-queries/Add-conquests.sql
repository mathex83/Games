USE MathexGaming
GO
CREATE PROCEDURE spConquests1 
@SeasonRoll int
AS
INSERT INTO DiabloAchievements
(AchievementName,AchievementText,[Group],SeasonRoll)
VALUES
('Boss Mode',
'Kill all bosses (except Vidian) in 20 mins',
'Conquests',@SeasonRoll),
('Worlds Apart',
'Hardcore: Kill all bosses (except Vidian) in 20 mins',
'Conquests',@SeasonRoll),
('On A Good Day',
'3x Legendary Gem 65',
'Conquests',@SeasonRoll),
('I Cant Stop',
'Hardcore: 3x Legendary Gem 65',
'Conquests',@SeasonRoll),
('Curses!',
'350 kills Cursed Peat (Act 5/Paths Of The Drowned)',
'Conquests',@SeasonRoll),
('Stars Align',
'Hardcore: 350 kills Cursed Peat (Act 5/Paths Of The Drowned)',
'Conquests',@SeasonRoll),
('The Thrill',
'GR45 No Set Items',
'Conquests',@SeasonRoll),
('Super Human',
'Hardcore: GR45 No Set Items',
'Conquests',@SeasonRoll),
('Years Of War',
'GR55 6 different 6-piece set bonuses',
'Conquests',@SeasonRoll),
('Dynasty',
'Hardcore: GR55 6 different 6-piece set bonuses',
'Conquests',@SeasonRoll)
GO

--EXEC spConquests1 @SeasonRoll=24