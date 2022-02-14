using Microsoft.EntityFrameworkCore.Migrations;

namespace MathexGaming.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiabloAchievements",
                columns: table => new
                {
                    D3AchievementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AchievementName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AchievementText = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Group = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SubGroup = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SeasonRoll = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabloAchievements", x => x.D3AchievementId);
                });

            migrationBuilder.CreateTable(
                name: "EAsFCxps",
                columns: table => new
                {
                    EAsFCxpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NextLevel = table.Column<int>(type: "int", nullable: false),
                    XPThreshold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EAsFCxps", x => x.EAsFCxpID);
                });

            migrationBuilder.CreateTable(
                name: "FUTGames",
                columns: table => new
                {
                    FUTgame = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUTGames", x => x.FUTgame);
                });

            migrationBuilder.CreateTable(
                name: "GameMaps",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RWLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameMaps", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Gamers",
                columns: table => new
                {
                    GamerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PSUser = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PSEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamers", x => x.GamerId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JourneyObjectiveGroups",
                columns: table => new
                {
                    JourneyObjectiveGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JourneyObjectiveGroupName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JourneyObjectiveGroups", x => x.JourneyObjectiveGroupID);
                });

            migrationBuilder.CreateTable(
                name: "JourneyObjectives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectiveName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Chapter = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Season = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JourneyObjectives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    GameMapID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Challenges_GameMaps_GameMapID",
                        column: x => x.GameMapID,
                        principalTable: "GameMaps",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D3UserCompletion",
                columns: table => new
                {
                    D3UserCompletionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompletedColor = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    GamerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D3UserCompletion", x => x.D3UserCompletionID);
                    table.ForeignKey(
                        name: "FK_D3UserCompletion_Gamers_GamerID",
                        column: x => x.GamerID,
                        principalTable: "Gamers",
                        principalColumn: "GamerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserCoins",
                columns: table => new
                {
                    CoinID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coins = table.Column<int>(type: "int", nullable: false),
                    DraftsBought = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    GamerId = table.Column<int>(type: "int", nullable: true),
                    FUTgameID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCoins", x => x.CoinID);
                    table.ForeignKey(
                        name: "FK_UserCoins_FUTGames_FUTgameID",
                        column: x => x.FUTgameID,
                        principalTable: "FUTGames",
                        principalColumn: "FUTgame",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCoins_Gamers_GamerId",
                        column: x => x.GamerId,
                        principalTable: "Gamers",
                        principalColumn: "GamerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DiabloAchievements",
                columns: new[] { "D3AchievementId", "AchievementName", "AchievementText", "Group", "SeasonRoll", "SubGroup" },
                values: new object[] { 1, "Boss Mode", "Kill all bosses (except Vidian) in 20 mins", "ScConquests", 24, "ScConquests" });

            migrationBuilder.InsertData(
                table: "FUTGames",
                column: "FUTgame",
                values: new object[]
                {
                    17,
                    18,
                    19
                });

            migrationBuilder.InsertData(
                table: "Gamers",
                columns: new[] { "GamerId", "PSEmail", "PSUser", "RealName" },
                values: new object[] { 1, "mn83gamer@gmail.com", "mn83gamer", "Martin Nørholm" });

            migrationBuilder.InsertData(
                table: "JourneyObjectiveGroups",
                columns: new[] { "JourneyObjectiveGroupID", "JourneyObjectiveGroupName" },
                values: new object[,]
                {
                    { 1, "Bosses" },
                    { 2, "Kanai's Cube" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_GameMapID",
                table: "Challenges",
                column: "GameMapID");

            migrationBuilder.CreateIndex(
                name: "IX_D3UserCompletion_GamerID",
                table: "D3UserCompletion",
                column: "GamerID");

            migrationBuilder.CreateIndex(
                name: "IX_UserCoins_FUTgameID",
                table: "UserCoins",
                column: "FUTgameID");

            migrationBuilder.CreateIndex(
                name: "IX_UserCoins_GamerId",
                table: "UserCoins",
                column: "GamerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "D3UserCompletion");

            migrationBuilder.DropTable(
                name: "DiabloAchievements");

            migrationBuilder.DropTable(
                name: "EAsFCxps");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "JourneyObjectiveGroups");

            migrationBuilder.DropTable(
                name: "JourneyObjectives");

            migrationBuilder.DropTable(
                name: "UserCoins");

            migrationBuilder.DropTable(
                name: "GameMaps");

            migrationBuilder.DropTable(
                name: "FUTGames");

            migrationBuilder.DropTable(
                name: "Gamers");
        }
    }
}
