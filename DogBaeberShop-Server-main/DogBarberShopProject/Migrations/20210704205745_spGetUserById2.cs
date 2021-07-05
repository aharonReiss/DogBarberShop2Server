using Microsoft.EntityFrameworkCore.Migrations;

namespace DogBarberShopProject.Migrations
{
    public partial class spGetUserById2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create procedure spGetUserById
                                    @id int
                                    as
                                    begin
                                    select * from users where Id = @id
                                    end";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
