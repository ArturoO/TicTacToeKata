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
            int expectedWidth = 3;
            int expectedHeight = 3;

            Assert.That(TicTacToe.Width, Is.EqualTo(expectedWidth));
            Assert.That(TicTacToe.Height, Is.EqualTo(expectedHeight));
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
            string expected = "Game continues.";
            Assert.That(game.Status(), Is.EqualTo(expected));
        }

        [Test]
        public void game_status_when_playerX_has_won()
        {
            TicTacToe game = new TicTacToe();
            string expected = "Game is over: Player X won!";

            game.PlaceXAt(0, 0);
            game.PlaceXAt(1, 0);
            game.PlaceXAt(2, 0);

            Assert.That(game.Status(), Is.EqualTo(expected));
        }


    }
}
