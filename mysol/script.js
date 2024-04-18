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
  const dropToken = (row, column, playertoken) => {};
  return{
    dropToken, 
    getBoard
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
    clearToken
  };
}

const gameController = (function (
  playerOneName = "Player 1",
  playerTwoName = "Player 2"
) {
  const board = gameboard;
  const players = [
    { name: playerOneName, token: "X" },
    { name: playerTwoName, token: "O" },
  ];

  return{
    
  }
})();
