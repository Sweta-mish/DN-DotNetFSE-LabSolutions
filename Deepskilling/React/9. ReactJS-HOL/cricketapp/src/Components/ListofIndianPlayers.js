import React from "react";

const T20Players = [
    "First Player",
    "Second Player",
    "Third Player"
];

const RanjiTrophyPlayers = [
    "Fourth Player",
    "Fifth Player",
    "Sixth Player"
];

export const IndianPlayers = [
    ...T20Players,
    ...RanjiTrophyPlayers
];

function ListofIndianPlayers(props) {
    return (
        <div>
            <ul>
                {
                    props.IndianPlayers.map((player, index) => (
                        <li key={index}>
                            Mr. {player}
                        </li>
                    ))
                }
            </ul>
        </div>
    );
}

export default ListofIndianPlayers;