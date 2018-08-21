using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeKata;

namespace TicTacToeKataTests
{
    public class TicTacToeTests
    {

        [Test]
        public void board_size_is_3x3()
        {
            TicTacToe game = new TicTacToe();
            int expectedWIDTH = 3;
            int expectedHEIGHT = 3;

            Assert.That(TicTacToe.WIDTH, Is.EqualTo(expectedWIDTH));
            Assert.That(TicTacToe.HEIGHT, Is.EqualTo(expectedHEIGHT));
        }

        [Test]
        public void on_start_all_fields_contain_spaces()
        {
            TicTacToe game = new TicTacToe();
            char expected = ' ';
            
            Assert.That(game.Field(0, 0), Is.EqualTo(expected));
            Assert.That(game.Field(1, 0), Is.EqualTo(expected));
            Assert.That(game.Field(2, 0), Is.EqualTo(expected));

            Assert.That(game.Field(0, 1), Is.EqualTo(expected));
            Assert.That(game.Field(1, 1), Is.EqualTo(expected));
            Assert.That(game.Field(2, 1), Is.EqualTo(expected));

            Assert.That(game.Field(0, 2), Is.EqualTo(expected));
            Assert.That(game.Field(1, 2), Is.EqualTo(expected));
            Assert.That(game.Field(2, 2), Is.EqualTo(expected));
        }

        [Test]
        public void player_X_can_place_X_character_on_board()
        {
            TicTacToe game = new TicTacToe();
            char expected = 'X';

            game.PlaceXAt(0, 0);
            Assert.That(game.Field(0, 0), Is.EqualTo(expected));

            game.PlaceXAt(2, 2);
            Assert.That(game.Field(2, 2), Is.EqualTo(expected));
        }

        [Test]
        public void player_O_can_place_O_character_on_board()
        {
            TicTacToe game = new TicTacToe();
            char expected = 'O';

            game.PlaceOAt(0, 0);
            Assert.That(game.Field(0, 0), Is.EqualTo(expected));

            game.PlaceOAt(2, 2);
            Assert.That(game.Field(2, 2), Is.EqualTo(expected));
        }

        [Test]
        public void player_cant_use_field_that_was_taken()
        {
            TicTacToe game = new TicTacToe();
            char expected = 'O';

            game.PlaceOAt(0, 0);
            Assert.That(game.Field(0, 0), Is.EqualTo(expected));

            game.PlaceXAt(0, 0);
            Assert.That(game.Field(0, 0), Is.EqualTo(expected));
        }

        [Test]
        public void check_game_status_on_start()
        {
            TicTacToe game = new TicTacToe();
            int expected = 0;
            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_after_2_rounds()
        {
            TicTacToe game = new TicTacToe();
            int expected = 0;
            
            //round 1
            game.PlaceXAt(0, 0);
            game.PlaceOAt(2, 1);
            //round 2
            game.PlaceXAt(2, 2);
            game.PlaceOAt(1, 1);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_after_filling_all_fields()
        {
            TicTacToe game = new TicTacToe();
            int expected = 3;

            //round 1
            game.PlaceXAt(0, 0);
            game.PlaceOAt(2, 1);
            //round 2
            game.PlaceXAt(2, 2);
            game.PlaceOAt(1, 1);
            //round 3
            game.PlaceXAt(0, 1);
            game.PlaceOAt(0, 2);
            //round 4
            game.PlaceXAt(1, 2);
            game.PlaceOAt(1, 0);
            //round 5
            game.PlaceXAt(2, 0);
            
            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }


        [Test]
        public void game_status_code_when_playerX_won_row_1()
        {
            TicTacToe game = new TicTacToe();
            int expected = 1;

            game.PlaceXAt(0, 0);
            game.PlaceXAt(1, 0);
            game.PlaceXAt(2, 0);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerX_won_row_2()
        {
            TicTacToe game = new TicTacToe();
            int expected = 1;

            game.PlaceXAt(0, 1);
            game.PlaceXAt(1, 1);
            game.PlaceXAt(2, 1);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerO_won_row_2()
        {
            TicTacToe game = new TicTacToe();
            int expected = 2;

            game.PlaceOAt(0, 1);
            game.PlaceOAt(1, 1);
            game.PlaceOAt(2, 1);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerX_won_row_3()
        {
            TicTacToe game = new TicTacToe();
            int expected = 1;
            
            game.PlaceXAt(0, 2);
            game.PlaceXAt(1, 2);
            game.PlaceXAt(2, 2);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerX_won_col_1()
        {
            TicTacToe game = new TicTacToe();
            int expected = 1;

            game.PlaceXAt(0, 0);
            game.PlaceXAt(0, 1);
            game.PlaceXAt(0, 2);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerX_won_col_2()
        {
            TicTacToe game = new TicTacToe();
            int expected = 1;

            game.PlaceXAt(1, 0);
            game.PlaceXAt(1, 1);
            game.PlaceXAt(1, 2);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerO_won_col_2()
        {
            TicTacToe game = new TicTacToe();
            int expected = 2;

            game.PlaceOAt(1, 0);
            game.PlaceOAt(1, 1);
            game.PlaceOAt(1, 2);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerX_won_col_3()
        {
            TicTacToe game = new TicTacToe();
            int expected = 1;

            game.PlaceXAt(2, 0);
            game.PlaceXAt(2, 1);
            game.PlaceXAt(2, 2);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerX_won_diagonal_1()
        {
            TicTacToe game = new TicTacToe();
            int expected = 1;

            game.PlaceXAt(0, 0);
            game.PlaceXAt(1, 1);
            game.PlaceXAt(2, 2);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerO_won_diagonal_1()
        {
            TicTacToe game = new TicTacToe();
            int expected = 2;

            game.PlaceOAt(0, 0);
            game.PlaceOAt(1, 1);
            game.PlaceOAt(2, 2);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_code_when_playerX_won_diagonal_2()
        {
            TicTacToe game = new TicTacToe();
            int expected = 1;

            game.PlaceXAt(2, 0);
            game.PlaceXAt(1, 1);
            game.PlaceXAt(0, 2);

            Assert.That(game.StatusCode(), Is.EqualTo(expected));
        }


    }
}
