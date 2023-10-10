function getAll(){
    const tableEl = document.querySelector('thead');
    tableEl.insertAdjacentHTML('beforeend',"<tr><th>Season</th><th>Number</th><th>Name</th><th>Batting Avg</th><th>On Base Plus Slugging</th>" +
                                "<th>Games Played</th><th>Games Started</th><th>At Bats</th><th>Runs</th><th>Hits</th><th>Doubles</th>" +
                                "<th>Triples</th><th>Homeruns</th><th>Runs Batted In</th><th>Total Bases</th><th>Slugging Percentage</th>" +
                                "<th>Base On Balls</th><th>Hit By Pitch</th><th>Strikeout</th><th>Ground Into Double Play</th><th>On Base Percentage</th>" +
                                "<th>Sacrifice Fly</th><th>Sacrifice Bunt</th><th>Stolen Bases</th><th>Stolen Base Attempts</th></tr>");

    const listEl = document.querySelector('tbody');
    fetch('https://localhost:7147/BaseballStats/')
        .then(res => res.json())
        .then(data =>{
            var i = 0;
            data.forEach(post => {
                console.log(data);
                listEl.insertAdjacentHTML('beforeend',
                 `<td>${post.season}</td><td> ${post.number}</td><td> ${post.name}</td><td> ${post.battingAvg}</td>
                 <td> ${post.onBasePlusSlugging}</td><td> ${post.gamesPlayed}</td><td> ${post.gamesStarted}</td><td> ${post.atBats}</td>
                 <td> ${post.runs}</td><td> ${post.hits}</td><td> ${post.doubles}</td><td> ${post.triples}</td>
                 <td> ${post.homeruns}</td><td> ${post.runsBattedIn}</td><td> ${post.totalBases}</td><td> ${post.sluggingPercentage}</td>
                 <td> ${post.baseOnBalls}</td><td> ${post.hitByPitch}</td><td> ${post.strikeout}</td><td> ${post.groundIntoDoublePlay}</td>
                 <td> ${post.onBasePercentage}</td><td> ${post.sacrificeFly}</td><td> ${post.sacrificeBunt}</td><td> ${post.stolenBases}</td>
                 <td> ${post.stolenBaseAttempts}</td>`);
            });
            // var colName = res[0];
            //var colName2 = data[0];
            //console.log(colName);
            //console.log(colName2);
        })
}

function getPlayersBySeason(){
    let year = prompt("Please enter the season:");

    const tableEl = document.querySelector('thead');
    tableEl.insertAdjacentHTML('beforeend',"<tr><th>Season</th><th>Number</th><th>Name</th><th>Batting Avg</th><th>On Base Plus Slugging</th>" +
                                "<th>Games Played</th><th>Games Started</th><th>At Bats</th><th>Runs</th><th>Hits</th><th>Doubles</th>" +
                                "<th>Triples</th><th>Homeruns</th><th>Runs Batted In</th><th>Total Bases</th><th>Slugging Percentage</th>" +
                                "<th>Base On Balls</th><th>Hit By Pitch</th><th>Strikeout</th><th>Ground Into Double Play</th><th>On Base Percentage</th>" +
                                "<th>Sacrifice Fly</th><th>Sacrifice Bunt</th><th>Stolen Bases</th><th>Stolen Base Attempts</th></tr>");
    const searchYear = year;
    const url = new URL("https://localhost:7147/BaseballStats/season/");
    const new_url = new URL(url + searchYear);

    console.log(searchYear);
    console.log(url);
    console.log(new_url);

    const listEl = document.querySelector('tbody');
    fetch(new_url)
        .then(res => res.json())
        .then(data =>{
            var i = 0;
            data.forEach(post => {
                console.log(data);
                listEl.insertAdjacentHTML('beforeend',
                 `<td>${post.season}</td><td> ${post.number}</td><td> ${post.name}</td><td> ${post.battingAvg}</td>
                 <td> ${post.onBasePlusSlugging}</td><td> ${post.gamesPlayed}</td><td> ${post.gamesStarted}</td><td> ${post.atBats}</td>
                 <td> ${post.runs}</td><td> ${post.hits}</td><td> ${post.doubles}</td><td> ${post.triples}</td>
                 <td> ${post.homeruns}</td><td> ${post.runsBattedIn}</td><td> ${post.totalBases}</td><td> ${post.sluggingPercentage}</td>
                 <td> ${post.baseOnBalls}</td><td> ${post.hitByPitch}</td><td> ${post.strikeout}</td><td> ${post.groundIntoDoublePlay}</td>
                 <td> ${post.onBasePercentage}</td><td> ${post.sacrificeFly}</td><td> ${post.sacrificeBunt}</td><td> ${post.stolenBases}</td>
                 <td> ${post.stolenBaseAttempts}</td>`);
            });
        })
}

function GetPlayersByName(){
    let name = prompt("Please enter the players name (Last, First):");

    const tableEl = document.querySelector('thead');
    tableEl.insertAdjacentHTML('beforeend',"<tr><th>Season</th><th>Number</th><th>Name</th><th>Batting Avg</th><th>On Base Plus Slugging</th>" +
                                "<th>Games Played</th><th>Games Started</th><th>At Bats</th><th>Runs</th><th>Hits</th><th>Doubles</th>" +
                                "<th>Triples</th><th>Homeruns</th><th>Runs Batted In</th><th>Total Bases</th><th>Slugging Percentage</th>" +
                                "<th>Base On Balls</th><th>Hit By Pitch</th><th>Strikeout</th><th>Ground Into Double Play</th><th>On Base Percentage</th>" +
                                "<th>Sacrifice Fly</th><th>Sacrifice Bunt</th><th>Stolen Bases</th><th>Stolen Base Attempts</th></tr>");

    const url = new URL("https://localhost:7147/BaseballStats/name/");
    const new_url = new URL(url + name);
    //console.log(year);
    console.log(new_url);

    const listEl = document.querySelector('tbody');
    fetch(new_url)
        .then(res => res.json())
        .then(data =>{
            var i = 0;
            data.forEach(post => {
                console.log(data);
                listEl.insertAdjacentHTML('beforeend',
                 `<td>${post.season}</td><td> ${post.number}</td><td> ${post.name}</td><td> ${post.battingAvg}</td>
                 <td> ${post.onBasePlusSlugging}</td><td> ${post.gamesPlayed}</td><td> ${post.gamesStarted}</td><td> ${post.atBats}</td>
                 <td> ${post.runs}</td><td> ${post.hits}</td><td> ${post.doubles}</td><td> ${post.triples}</td>
                 <td> ${post.homeruns}</td><td> ${post.runsBattedIn}</td><td> ${post.totalBases}</td><td> ${post.sluggingPercentage}</td>
                 <td> ${post.baseOnBalls}</td><td> ${post.hitByPitch}</td><td> ${post.strikeout}</td><td> ${post.groundIntoDoublePlay}</td>
                 <td> ${post.onBasePercentage}</td><td> ${post.sacrificeFly}</td><td> ${post.sacrificeBunt}</td><td> ${post.stolenBases}</td>
                 <td> ${post.stolenBaseAttempts}</td>`);
            });
        })
}

function GetPlayersByNumber(){
    let number = prompt("Please enter the players number:");

    const tableEl = document.querySelector('thead');
    tableEl.insertAdjacentHTML('beforeend',"<tr><th>Season</th><th>Number</th><th>Name</th><th>Batting Avg</th><th>On Base Plus Slugging</th>" +
                                "<th>Games Played</th><th>Games Started</th><th>At Bats</th><th>Runs</th><th>Hits</th><th>Doubles</th>" +
                                "<th>Triples</th><th>Homeruns</th><th>Runs Batted In</th><th>Total Bases</th><th>Slugging Percentage</th>" +
                                "<th>Base On Balls</th><th>Hit By Pitch</th><th>Strikeout</th><th>Ground Into Double Play</th><th>On Base Percentage</th>" +
                                "<th>Sacrifice Fly</th><th>Sacrifice Bunt</th><th>Stolen Bases</th><th>Stolen Base Attempts</th></tr>");

    const url = new URL("https://localhost:7147/BaseballStats/player/");
    const new_url = new URL(url + number);
    //console.log(year);
    console.log(new_url);

    const listEl = document.querySelector('tbody');
    fetch(new_url)
        .then(res => res.json())
        .then(data =>{
            var i = 0;
            data.forEach(post => {
                console.log(data);
                listEl.insertAdjacentHTML('beforeend',
                 `<td>${post.season}</td><td> ${post.number}</td><td> ${post.name}</td><td> ${post.battingAvg}</td>
                 <td> ${post.onBasePlusSlugging}</td><td> ${post.gamesPlayed}</td><td> ${post.gamesStarted}</td><td> ${post.atBats}</td>
                 <td> ${post.runs}</td><td> ${post.hits}</td><td> ${post.doubles}</td><td> ${post.triples}</td>
                 <td> ${post.homeruns}</td><td> ${post.runsBattedIn}</td><td> ${post.totalBases}</td><td> ${post.sluggingPercentage}</td>
                 <td> ${post.baseOnBalls}</td><td> ${post.hitByPitch}</td><td> ${post.strikeout}</td><td> ${post.groundIntoDoublePlay}</td>
                 <td> ${post.onBasePercentage}</td><td> ${post.sacrificeFly}</td><td> ${post.sacrificeBunt}</td><td> ${post.stolenBases}</td>
                 <td> ${post.stolenBaseAttempts}</td>`);
            });
        })
}

function getPercentage(){
    const tableEl = document.querySelector('thead');
    tableEl.insertAdjacentHTML('beforeend',`<h3>The following is the percentage of games started out of games played for each player for each season:</h3>`);

    const listEl = document.querySelector('tbody');
    fetch('https://localhost:7147/BaseballStats/percentage')
        .then(res => res.json())
        .then(data =>{
            var i = 0;
            data.forEach(element => {
                console.log(data);
                listEl.insertAdjacentHTML('beforeend',`<td>${element}</td>`);
            });
        })
}

function getTeamBattingAvg(){
    const tableEl = document.querySelector('thead');
    tableEl.insertAdjacentHTML('beforeend',`<h3>The following is the average team batting average by year:</h3>`);

    const url = new URL("https://localhost:7147/BaseballStats/teamAvg/");
    console.log(url);

    const listEl = document.querySelector('tbody');
    fetch(url)
        .then(res => res.json())
        .then(data =>{
            var i = 0;
            data.forEach(element => {
                console.log(data);
                listEl.insertAdjacentHTML('beforeend',`<td>${element}</td>`);
            });
        })
}









