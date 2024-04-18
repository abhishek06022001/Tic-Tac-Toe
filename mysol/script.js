const gameboard = (function gameboard() {
  const rows = 3;
  const columns = 3;
  const board = [];
  for (let i = 0; i < rows.length; i++) {
    board[i] = [];
    for (let j = 0; j < columns.length; j++) {
      board[i].push(cell());
    }
  }
  const getBoard = () => board;
  const dropToken = (row, column, playertoken) => {
    // drop token inside that cell bro
  };
  return {
    dropToken,
    getBoard,
  };
})(); //IIFE
function cell() {
  let val = "-";
  const getValue = () => val;
  const setToken = (playerToken) => {
    val = playerToken;
  };
  const clearToken = () => {
    val = "-";
  };
  return {
    getValue,
    setToken,
    clearToken,
  };
}
/**
 * basic gameboard operations
 *  playRound
 * Clearboard
 * checkwin
 * checkTie
 * newGame
 */
const gameController = (function (
  playerOneName = "Player 1",
  playerTwoName = "Player 2"
) {
  const board = gameboard;
  const players = [
    { name: playerOneName, token: "X" },
    { name: playerTwoName, token: "O" },
  ];
  const newGame = () => {
    //clear all cells
   
  };
  const switchPlayer = () => {
  
  };
  const playRound = (row, col, player) => {
    //drop the token into the cell at that row and column
    board.dropToken(row, column, player.token);
    checkWinner();
    checkTie();
  };
  return {
    getBoard: board.getBoard,
    newGame,
    playRound,
  };
})();
