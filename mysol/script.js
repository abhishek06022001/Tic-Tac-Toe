const gameboard = (function gameboard() {
  const rows = 3;
  const columns = 3;
  const board = [];
  for (let i = 0; i < rows; i++) {
    board[i] = [];
   
    for (let j = 0; j < columns; j++) {
      board[i].push(cell());
    }
  }
  const getBoard = () => board;
  const dropToken = (row, column, p) => {
    // drop token inside that cell bro
   
   
    let newcell = cell();
    newcell.setToken(p.token);
    board[row][column] = newcell;

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
function player(){
  return {
    token:"X",
  };
}
/**
 * basic gameboard operations
 * playRound
 * clearboard
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
    clearBoard();
    switchPlayer();

     
   
  };

  const clearBoard = () => {
  board.forEach(row => {
      row.forEach(cell => {
        cell.clearToken();
      });
  });
  }
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
